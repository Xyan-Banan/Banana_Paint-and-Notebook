using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace FilesForms
{
    public partial class Form1 : Form
    {
        string imageName;
        Pen pen;                //ручка, которой мы рисуем
        PictureBox curColor;    //текущий цвет
        List<Point> points;     //точки для отрисовки линии
        //--------------
        string textFile;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Brushes.Black, 1);
            curColor = colorBlack;
            points = new List<Point>();
            pb.Image = new Bitmap(pb.Width, pb.Height);
        }
        

        private void openImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif; *.bmp",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pb.Image = Image.FromFile(dialog.FileName);
                    imageName = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка! Невозможно прочитать файл с диска! " +
                        "Сообщение об ошибке: " + ex.Message);
                }
            }
        }

        private void saveImageBtn_Click(object sender, EventArgs e)
        {
            if (pb.Image == null) return;

            if (imageName == null)
                imageName = "untitled.bmp";

            SaveFileDialog saveImage = new SaveFileDialog
            {
                FileName = Path.GetFileNameWithoutExtension(imageName),
                DefaultExt = Path.GetExtension(imageName).Trim(new char[] { ' ', '.' }),
                ValidateNames = true,
                Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpg)|*.jpg|Png Image (.png)|*.png"
            };

            if(saveImage.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pb.Image);
                bmp.Save(saveImage.FileName);
            }
        }

        private Point transform(Point original)
        {
            float wRatio = (float)pb.Image.Width / pb.Width;
            float hRatio = (float)pb.Image.Height / pb.Height;
            return new Point
            {
                X = (int)(original.X * wRatio),
                Y = (int)(original.Y * hRatio)
            };
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"{e.X} {e.Y} {e.Button} {points.Count}");
            Console.WriteLine($"pb: {pb.Size}; Image: {pb.Image.Size}");
            Console.WriteLine($"original: {e.Location}; \ttransformed: {transform(e.Location)}");
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics canvas = Graphics.FromImage(pb.Image))
                {
                    points.Add(transform(e.Location));
                    canvas.SmoothingMode = SmoothingMode.AntiAlias;
                    canvas.DrawCurve(pen, points.ToArray(), 0.1f);
                }
                pb.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                points.Add(transform(e.Location));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                points.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float width = (float)Convert.ToDouble(textBox1.Text);
                if (width < 1)
                    width = 1;
                else if (width > 20)
                    width = 20;

                pen.Width = width;
                textBox1.Text = width.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = pen.Width.ToString();
            }
        }

        void setPen(PictureBox color)
        {
            pen.Color = color.BackColor;
            curColor.BorderStyle = BorderStyle.None;
            curColor = color;
            curColor.BorderStyle = BorderStyle.Fixed3D;
        }

        private void setPen(object sender, EventArgs e)
        {
            setPen((PictureBox)sender);
        }

        private void openTextBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Text files (*.txt, *.json) | *.txt; *.json | All files (*.*) | *.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.Text = File.ReadAllText(dialog.FileName);
                    textFile = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка! Невозможно прочитать файл с диска! Сообщение об ошибке: " + ex.Message);
                }

            }

        }

        private void saveTextBtn_Click(object sender, EventArgs e)
        {
            if (textFile == null)
            {
                SaveFileDialog saveText = new SaveFileDialog();
                saveText.FileName = "untitled";
                saveText.DefaultExt = ".txt";
                saveText.ValidateNames = true;
                saveText.Filter = "Text files (*.txt, *.json) | *.txt; *.json | All files (*.*) | *.*";

                if (saveText.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveText.FileName, richTextBox1.Text);
                    textFile = saveText.FileName;
                }
            }
            else
            {
                File.WriteAllText(textFile, richTextBox1.Text);
            }
        }

        private void saveTextAsBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveText = new SaveFileDialog();
            saveText.FileName = "untitled";
            saveText.DefaultExt = ".txt";
            saveText.ValidateNames = true;
            saveText.Filter = "Text files (*.txt, *.json) | *.txt; *.json | All files (*.*) | *.*";

            if (saveText.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveText.FileName, richTextBox1.Text);
                textFile = saveText.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

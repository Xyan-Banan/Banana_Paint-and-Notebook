
namespace FilesForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openImageBtn = new System.Windows.Forms.Button();
            this.saveImageBtn = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openTextBtn = new System.Windows.Forms.Button();
            this.saveTextBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorBlack = new System.Windows.Forms.PictureBox();
            this.colorRed = new System.Windows.Forms.PictureBox();
            this.colorBlue = new System.Windows.Forms.PictureBox();
            this.colorGreen = new System.Windows.Forms.PictureBox();
            this.saveTextAsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(152, 303);
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(128, 23);
            this.openImageBtn.TabIndex = 0;
            this.openImageBtn.Text = "Открыть картинку";
            this.openImageBtn.UseVisualStyleBackColor = true;
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click);
            // 
            // saveImageBtn
            // 
            this.saveImageBtn.Location = new System.Drawing.Point(152, 346);
            this.saveImageBtn.Name = "saveImageBtn";
            this.saveImageBtn.Size = new System.Drawing.Size(128, 23);
            this.saveImageBtn.TabIndex = 1;
            this.saveImageBtn.Text = "Сохранить картинку";
            this.saveImageBtn.UseVisualStyleBackColor = true;
            this.saveImageBtn.Click += new System.EventHandler(this.saveImageBtn_Click);
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb.Location = new System.Drawing.Point(85, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(262, 247);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            this.pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(353, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 247);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // openTextBtn
            // 
            this.openTextBtn.Location = new System.Drawing.Point(409, 303);
            this.openTextBtn.Name = "openTextBtn";
            this.openTextBtn.Size = new System.Drawing.Size(128, 23);
            this.openTextBtn.TabIndex = 0;
            this.openTextBtn.Text = "Открыть текст";
            this.openTextBtn.UseVisualStyleBackColor = true;
            this.openTextBtn.Click += new System.EventHandler(this.openTextBtn_Click);
            // 
            // saveTextBtn
            // 
            this.saveTextBtn.Location = new System.Drawing.Point(409, 346);
            this.saveTextBtn.Name = "saveTextBtn";
            this.saveTextBtn.Size = new System.Drawing.Size(128, 23);
            this.saveTextBtn.TabIndex = 1;
            this.saveTextBtn.Text = "Сохранить текст";
            this.saveTextBtn.UseVisualStyleBackColor = true;
            this.saveTextBtn.Click += new System.EventHandler(this.saveTextBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.Black;
            this.colorBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorBlack.Location = new System.Drawing.Point(12, 60);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(66, 20);
            this.colorBlack.TabIndex = 5;
            this.colorBlack.TabStop = false;
            this.colorBlack.Click += new System.EventHandler(this.setPen);
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.Red;
            this.colorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorRed.Location = new System.Drawing.Point(12, 86);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(66, 20);
            this.colorRed.TabIndex = 5;
            this.colorRed.TabStop = false;
            this.colorRed.Click += new System.EventHandler(this.setPen);
            // 
            // colorBlue
            // 
            this.colorBlue.BackColor = System.Drawing.Color.Blue;
            this.colorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBlue.Location = new System.Drawing.Point(13, 112);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(66, 20);
            this.colorBlue.TabIndex = 5;
            this.colorBlue.TabStop = false;
            this.colorBlue.Click += new System.EventHandler(this.setPen);
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.Lime;
            this.colorGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorGreen.Location = new System.Drawing.Point(13, 138);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(66, 20);
            this.colorGreen.TabIndex = 5;
            this.colorGreen.TabStop = false;
            this.colorGreen.Click += new System.EventHandler(this.setPen);
            // 
            // saveTextAsBtn
            // 
            this.saveTextAsBtn.Location = new System.Drawing.Point(392, 386);
            this.saveTextAsBtn.Name = "saveTextAsBtn";
            this.saveTextAsBtn.Size = new System.Drawing.Size(160, 23);
            this.saveTextAsBtn.TabIndex = 6;
            this.saveTextAsBtn.Text = "Сохранить текст как...";
            this.saveTextAsBtn.UseVisualStyleBackColor = true;
            this.saveTextAsBtn.Click += new System.EventHandler(this.saveTextAsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.saveTextAsBtn);
            this.Controls.Add(this.colorGreen);
            this.Controls.Add(this.colorBlue);
            this.Controls.Add(this.colorRed);
            this.Controls.Add(this.colorBlack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.saveTextBtn);
            this.Controls.Add(this.openTextBtn);
            this.Controls.Add(this.saveImageBtn);
            this.Controls.Add(this.openImageBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImageBtn;
        private System.Windows.Forms.Button saveImageBtn;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button openTextBtn;
        private System.Windows.Forms.Button saveTextBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox colorBlack;
        private System.Windows.Forms.PictureBox colorRed;
        private System.Windows.Forms.PictureBox colorBlue;
        private System.Windows.Forms.PictureBox colorGreen;
        private System.Windows.Forms.Button saveTextAsBtn;
    }
}


﻿namespace ImageGallery
{
     partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

    
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
           
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 349);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
          
            button1.Location = new Point(293, 451);
            button1.Name = "button1";
            button1.Size = new Size(179, 23);
            button1.TabIndex = 1;
            button1.Text = "Загрузить изображение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            
            button2.Location = new Point(48, 396);
            button2.Name = "button2";
            button2.Size = new Size(75, 42);
            button2.TabIndex = 2;
            button2.Text = "<---";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
           
            button3.Location = new Point(679, 396);
            button3.Name = "button3";
            button3.Size = new Size(75, 42);
            button3.TabIndex = 3;
            button3.Text = "--->";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
             
            button4.Location = new Point(293, 422);
            button4.Name = "button4";
            button4.Size = new Size(179, 23);
            button4.TabIndex = 4;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
             
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Image";
            Text = "Image";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
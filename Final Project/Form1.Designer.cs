namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 143);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(62, 332);
            button1.Name = "button1";
            button1.Size = new Size(196, 38);
            button1.TabIndex = 1;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.LightPink;
            label2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(62, 104);
            label2.Name = "label2";
            label2.Size = new Size(196, 39);
            label2.TabIndex = 5;
            label2.Text = "USER LOG IN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 262);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(28, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(28, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Pink;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(62, 188);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 30);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Pink;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.InfoText;
            textBox3.Location = new Point(62, 262);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 30);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox2_TextChanged_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(308, 506);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(62, 393);
            button2.Name = "button2";
            button2.Size = new Size(196, 38);
            button2.TabIndex = 14;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Pink;
            ClientSize = new Size(308, 504);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Black;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private Button button2;
    }
}

namespace TurnTableDemo
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
            progressBar1 = new ProgressBar();
            BtnStart = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            BtnReady = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(82, 56);
            progressBar1.MarqueeAnimationSpeed = 200;
            progressBar1.Maximum = 80;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1680, 118);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 4;
            // 
            // BtnStart
            // 
            BtnStart.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtnStart.Location = new Point(1770, 56);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(201, 118);
            BtnStart.TabIndex = 5;
            BtnStart.Text = "开始";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.MouseDown += BtnStart_MouseDown;
            BtnStart.MouseUp += BtnStart_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(731, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1400, 1395);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(82, 211);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(454, 1227);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "黄焖鸡\n钵钵鸡\n百香鸡\n掉渣饼\n滑蛋饭\n牛肉汤\n自选餐\n便当饭";
            richTextBox1.Validated += richTextBox1_Validated;
            // 
            // BtnReady
            // 
            BtnReady.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtnReady.Location = new Point(571, 653);
            BtnReady.Name = "BtnReady";
            BtnReady.Size = new Size(129, 118);
            BtnReady.TabIndex = 7;
            BtnReady.Text = "准备";
            BtnReady.UseVisualStyleBackColor = true;
            BtnReady.Click += BtnReady_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2234, 1635);
            Controls.Add(BtnReady);
            Controls.Add(richTextBox1);
            Controls.Add(BtnStart);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "美食大转盘";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar progressBar1;
        private Button BtnStart;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button BtnReady;
    }
}
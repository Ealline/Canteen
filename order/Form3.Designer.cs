namespace TurnTableDemo
{
    partial class Form3
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(226, 398);
            button3.Name = "button3";
            button3.Size = new Size(229, 101);
            button3.TabIndex = 0;
            button3.Text = "登录";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(658, 398);
            button4.Name = "button4";
            button4.Size = new Size(229, 101);
            button4.TabIndex = 1;
            button4.Text = "退出";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(304, 39);
            label4.Name = "label4";
            label4.Size = new Size(547, 64);
            label4.TabIndex = 2;
            label4.Text = "学生食堂点餐系统";
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("宋体", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(158, 149);
            label5.Name = "label5";
            label5.Size = new Size(216, 48);
            label5.TabIndex = 3;
            label5.Text = "用户名：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("宋体", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(158, 239);
            label6.Name = "label6";
            label6.Size = new Size(217, 48);
            label6.TabIndex = 4;
            label6.Text = "密  码：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(595, 38);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(355, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(595, 38);
            textBox2.TabIndex = 6;
            // 
            // Form3
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1181, 583);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "Form3";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnTableDemo
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();//退出
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // 检查用户名和密码文本框是否都有内容    
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // 假设这里需要验证用户名和密码，但当前代码没有实现验证逻辑  
                // 如果需要验证，请在这里添加逻辑  

                // 显示Form2并关闭Form3  
                using (Form2 form2 = new Form2())
                {
                    if (form2.ShowDialog() == DialogResult.OK)
                    {
                        // 如果Form2正常关闭，则这里可以执行后续操作  
                        // 例如：更新UI或加载数据等  
                    }
                }

                this.Close(); // 在Form2关闭后关闭Form3  
            }
            else
            {
                // 提示用户输入用户名和密码    
                MessageBox.Show("Please enter both username and password.");
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

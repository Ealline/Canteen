using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnTableDemo
{
    public partial class Form5 : Form
    {
        public Form5(List<(string Name, decimal Price)> items)// 修改构造函数以接收数据
        {
            InitializeComponent();
            this.items = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 success = new Form6();
            success.Show();
        }


        private List<(string Name, decimal Price)> items;


        private void Form5_Load(object sender, EventArgs e)
        {
            // 清空TextBox
            textBox1.Clear();
            decimal totalPrice = 0;
            foreach (var (Name, Price) in items)
            {
                textBox1.AppendText($"{Name} {Price}元{Environment.NewLine}");
                totalPrice += Price;
            }

            label3.Text = $"总价: {totalPrice}元";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // 关闭当前窗体
        }
    }
}

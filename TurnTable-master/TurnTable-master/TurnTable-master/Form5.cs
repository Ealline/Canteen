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
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 success = new Form6();
            success.Show();
        }


        private List<(string Name, decimal Price)> items;

        public Form5(List<(string Name, decimal Price)> items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            decimal total = 0;
            // 清空TextBox
            textBox1.Clear();

            foreach (var item in items)
            {
                // 构建显示的字符串，包括菜品名称和价格
                string displayText = $"{item.Name} {item.Price}\r\n";
                // 追加到TextBox中
                textBox1.AppendText(displayText);

                // 累计总价
                total += item.Price;
            }
            
            label3.Text = $"总价: {total}";
        }
            
    }
}

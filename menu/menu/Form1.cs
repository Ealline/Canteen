using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace menu
{
    public partial class Form1 : Form
    {
       
        private readonly Color defaultColor = SystemColors.WindowText;
        private readonly Color selectedColor = Color.Yellow;
        public Form1()
        {
            InitializeComponent();

            // 设置ListBox的DrawMode
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;

            // 添加一些项
            listBox1.Items.AddRange(new string[] {  });

            // 注册DrawItem事件
            listBox1.DrawItem += ListBox1_DrawItem;
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // 获取当前被绘制的项索引
            int index = e.Index;

            // 如果索引有效（不是-1，即不是空白区域）
            if (index != -1)
            {
                // 取消默认绘制样式
                e.DrawBackground();

                // 获取当前项的文本
                string itemText = listBox1.Items[index].ToString();

                // 根据是否选中来设置字体颜色
                Brush foreColorBrush = (e.State & DrawItemState.Selected) == DrawItemState.Selected ?
                    new SolidBrush(selectedColor) :
                    new SolidBrush(defaultColor);

                // 绘制项的文字
                e.Graphics.DrawString(itemText, e.Font, foreColorBrush, e.Bounds);

                // 结束绘制，不需要画边框
                e.DrawFocusRectangle();
            }
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new object[] {  });
        }

       

        


        private void button2_Click(object sender, EventArgs e)//提交
        {

        }

        private void button3_Click(object sender, EventArgs e)//显示
        {
           
           

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
       

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)//快餐
        {
            listBox1.Items.Clear(); // 清空ListBox现有的选项
            listBox1.Items.AddRange(new object[] { "1.经典拌饭   9元",
                                                   "2.韩式烤肉拌饭  12元",
                                                    "3.韩式肥牛拌饭   14元",
                                                    "4.韩式金枪鱼拌饭  15元",
                                                    "5.韩香泡菜炒饭   9元",       
                                                    "6.韩香酱油炒饭   9元",
                                                    "7.甜辣泡菜炒年糕  10元",
                                                    "8.鱼饼炒年糕    13元",
                                                    "9.咸蛋紫菜包饭  10元",
                                                    "10.韩式炸酱面  12元" }); // 添加新的选项列表
         
        }

        private void button1_Click_2(object sender, EventArgs e)//麻辣香锅
        {
            listBox1.Items.Clear(); // 清空ListBox现有的选项
            listBox1.Items.AddRange(new object[] { "1.套餐一：素食   13元", "2.套餐二：荤素搭配  14元", "3.套餐三：无肉不欢  16元" });
            StringBuilder sb = new StringBuilder();
            foreach (var item in listBox1.SelectedItems)
            {
                sb.AppendLine(item.ToString());
            }
           
           
        }

        

        private void button4_Click(object sender, EventArgs e)//烤鸭
        {
            listBox1.Items.Clear(); // 清空ListBox现有的选项
            listBox1.Items.AddRange(new object[] { "1.烤鸭半只   18元", "2.烤鸭整只   36元", "3.土豆丝     2元", "4.包菜       2元" , "5.米饭       2元" }); // 添加新的选项列表
         
        }

       private void button5_Click(object sender, EventArgs e)//煲仔饭
        {
            listBox1.Items.Clear(); // 清空ListBox现有的选项
            listBox1.Items.AddRange(new object[] { "1.叉烧煲仔饭   12元",
           "2.鱼香肉丝煲仔饭    12元",
           "3.辣椒炒肉煲仔饭    13元",
           "4.番茄炒蛋煲仔饭    12元",
           "5.红烧肉煲仔饭      13元" }); // 添加新的选项列表
        
        }

        private void button7_Click(object sender, EventArgs e)//牛肉板面
        {
            listBox1.Items.Clear(); // 清空ListBox现有的选项
            listBox1.Items.AddRange(new object[] { "1.牛肉板面  12元",
                                                   "2.青菜板面  7元",
                                                    "3.鸡丁板面  11元",
                                                    "4.三鲜板面  12元",
                                                    "5.肥牛板面  12元",
                                                    "6.豆腐片板面 9元",
                                                    "7.鸡柳板面  11元"}); // 添加新的选项列表
        
        }

        private void button6_Click(object sender, EventArgs e)//生煎
        {
            listBox1.Items.Clear(); // 清空ListBox现有的选项
            listBox1.Items.AddRange(new object[] { "1.生煎（4只） 6元",
                                                   "2.锅贴（4只）6元",
                                                    "3.小笼汤包（8只）8元",
                                                    "4.皮蛋瘦肉粥 4元",
                                                    "5.香菇鸡丝粥 4元",
                                                    "6.南瓜小米粥 3元",
                                                    "7.红枣银耳粥 3元"}); // 添加新的选项列表
           
        }

        private void button8_Click_1(object sender, EventArgs e)//汉堡
        {
            listBox1.Items.Clear(); // 清空ListBox现有的选项
            listBox1.Items.AddRange(new object[] { "1..套餐A  12元",
                                                   "2.套餐B  12元",
                                                    "3.套餐C  12元",
                                                    "4.套餐 D  12元"}); // 添加新的选项列表
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}

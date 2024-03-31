namespace TurnTableDemo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 偏移量
        /// </summary>
        private float roffset = 20;

        /// <summary>
        /// 大转盘旋转计时器
        /// </summary>
        private System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        /// <summary>
        /// 设置旋转力度时用到的计时器
        /// </summary>
        private System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

        private readonly TurnTable Turn;

        public Form1()
        {
            InitializeComponent();
            t.Tick += T_Tick;
            t1.Tick += T1_Tick;
            Turn = new(pictureBox1.Handle, new List<string>() { });
            Turn.Diameter = 800;
            richTextBox1_Validated(new object(), new EventArgs());

        }

        private int step = 1;
        private void T1_Tick(object? sender, EventArgs e)
        {
            if (progressBar1.Value <= progressBar1.Minimum) step = 1;
            if (progressBar1.Value >= progressBar1.Maximum) step = -1;
            progressBar1.Value += step;
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            Turn.Draw();
            Turn.OffsetAngle = Turn.OffsetAngle >= 360 ? 0 : Turn.OffsetAngle + roffset; //如果旋转角度大于360就置0实现

            if (roffset > 0.1)  //当旋转角度小于0.1时就停止
            {
                roffset = roffset - roffset / 100;  //减速的幅度逐渐减小
            }
            else
            {
                roffset = 0;
                t.Stop();
                System.Media.SystemSounds.Beep.Play(); //转盘停止提示音
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_MouseDown(object sender, MouseEventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            t1.Interval = 30; //定时器t1的间隔设置为30毫秒
            t1.Start();
        }

        private void BtnStart_MouseUp(object sender, MouseEventArgs e)
        {
            t1.Stop();
            roffset = progressBar1.Value;  //进程条的进度赋给偏移量
            t.Interval = 1;  //定时器t的间隔设置为1毫秒
            t.Start();
        }

        private void richTextBox1_Validated(object sender, EventArgs e)
        {
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {
            string[] strings = richTextBox1.Text.Split('\n'); //将richTextBox1的文本内容以回车键为切割点 赋值给strings
            List<string> list = new();
            foreach (var name in strings)
            {
                list.Add(name);
            }
            Turn.Items = list; //将strings中的字符串赋给转盘中的文字提示
            Turn.Draw();


            //绘制一个指针三角
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);//窗口句柄
            Brush brush = new SolidBrush(Color.Black);
            g.FillPolygon(brush, new Point[] { new Point(Turn.Diameter, Turn.Radius), new Point(Turn.Diameter + 60, Turn.Radius + 20), new Point(Turn.Diameter + 60, Turn.Radius - 20) });

        }

   

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
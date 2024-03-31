using System.Drawing.Drawing2D;

namespace TurnTableDemo
{
    public class TurnTable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="FromHwnd">容器句柄</param>
        /// <param name="Items">转盘项目，抽奖项列表，必须大于1</param>
        public TurnTable(nint FromHwnd, List<string> Items)
        {
            this.FromHwnd = FromHwnd;
            this.Items = Items;
        }

        /// <summary>
        /// 转盘项目，抽奖项列表
        /// </summary>
        public List<string> Items { get; set; }

        /// <summary>
        /// 容器句柄
        /// </summary>
        public nint FromHwnd { get; set; }
        /// <summary>
        /// 颜色列表
        /// </summary>
        public List<SolidBrush> Brushs { get; set; } = new()
            {
                new SolidBrush(Color.DarkRed),
                new SolidBrush(Color.Blue),
                new SolidBrush(Color.Indigo),
                new SolidBrush(Color.Green),
                new SolidBrush(Color.Brown),
                new SolidBrush(Color.Teal),
                new SolidBrush(Color.DarkOrange),
                new SolidBrush(Color.SteelBlue),
                new SolidBrush(Color.DarkGoldenrod),
                new SolidBrush(Color.DarkSlateBlue),
                new SolidBrush(Color.Firebrick),
                new SolidBrush(Color.Sienna),
                new SolidBrush(Color.DodgerBlue)
            };
        /// <summary>
        /// 左上角位置，Y轴
        /// </summary>
        public int Top { get; set; } = 0;
        /// <summary>
        /// 左上角位置，X轴
        /// </summary>
        public int Left { get; set; } = 0;
        /// <summary>
        /// 直径
        /// </summary>
        public int Diameter { get; set; } = 500;
        /// <summary>
        /// 半径
        /// </summary>
        public int Radius { get => Diameter / 2; }
        /// <summary>
        /// 高度
        /// </summary>
        public int Height { get => Diameter; }
        /// <summary>
        /// 宽度
        /// </summary>
        public int Weight { get => Diameter; }
        /// <summary>
        /// 前景颜色
        /// </summary>
        public Color ForeColor { get; set; } = Color.White;
        /// <summary>
        /// 背景颜色
        /// </summary>
        public Color BackColor { get; set; } = Color.Transparent;
        /// <summary>
        /// 说明的字体
        /// </summary>
        public Font CaptionFont { get; set; } = new("黑体", 18, FontStyle.Bold);

        /// <summary>
        /// 旋转角度
        /// </summary>
        public float OffsetAngle { get; set; }

        /// <summary>
        /// 绘图
        /// </summary>
        public void Draw()
        {
            Graphics g = Graphics.FromHwnd(FromHwnd);
            Rectangle rect = new(Left, Top, Diameter, Diameter);    //绘图的位置
            int length = Items.Count;   //分成几份
            Brush fore = new SolidBrush(ForeColor);  
            Matrix matrix = new();     //Matrix是一个二维变换的类，用于进行图形的变换操作，如旋转、缩放、平移等。
            matrix.RotateAt(OffsetAngle, new Point(Radius, Radius));  //RotateAt是matrix中的旋转   OffsetAngle:旋转角度  new Point(Radius, Radius):旋转中心点
            for (int i = 0; i < length; i++)
            {
                float angle = 360 / length;   //每个扇形角度
                var brush = Brushs[i % Brushs.Count];
                g.Transform = matrix; 

                g.FillPie(brush, rect, angle * i, angle); //FillPie:画扇形 brush:画刷 rect:扇形所在的矩形区域 angle*i:当作扇形的起始角度 i作为第几个扇形 angle:每个扇形的角度

                Matrix matrixCaption = new(); //扇形标签旋转
                matrixCaption.RotateAt(OffsetAngle + angle * i + angle / 2, new Point(Radius, Radius));
                g.Transform = matrixCaption;
                Rectangle rectCaption = new(Radius + Radius / 2, Radius - Convert.ToInt32(CaptionFont.Size / 2)-5, Radius, Radius); //文字说明的位置
                g.DrawString(Items[i], CaptionFont, fore, rectCaption);  //画扇形中的文本 Items[i]:文本内容 CaptionFont:文本字体 fore:画刷 rectCaption：指定矩阵区间
            }
        }

    }
}

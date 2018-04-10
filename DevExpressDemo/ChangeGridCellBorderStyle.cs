using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;
using System.Reflection;
using DevExpress.Utils.Paint;

namespace DevExpressDemo
{
    //改变表格中被选中单元格的边框
    public partial class ChangeGridCellBorderStyle : DevExpress.XtraEditors.XtraForm
    {
        public ChangeGridCellBorderStyle()
        {
            InitializeComponent();
        }

        private void ChangeGridCellBorderStyle_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_userinfo”中。您可以根据需要移动或删除它。
            this.tb_userinfoTableAdapter.Fill(this.jWDBDataSet1.tb_userinfo);

            FieldInfo fi = typeof(XPaint).GetField("graphics", BindingFlags.Static | BindingFlags.NonPublic);
            fi.SetValue(null, new MyXPaint());
        }
    }

    public class MyXPaint : XPaint
    {
        public override void DrawFocusRectangle(Graphics g, Rectangle r, Color foreColor, Color backColor)
        {
            if (!CanDraw(r)) return;
            //定义用于填充图形形状的颜色
            Brush hb = Brushes.Red;
            //定义一个宽度为2，高为r.Height-2,起始坐标为r.x和r.y的矩形,并且填充进图形对象
            g.FillRectangle(hb, new Rectangle(r.X, r.Y, 2,r.Height - 2));
            //定义一个宽度为r.Width，高为2,起始坐标为r.x和r.y的矩形,并且填充进图形对象
            g.FillRectangle(hb, new Rectangle(r.X, r.Y, r.Width - 2,2));
            //定义一个宽度为2，高为r.Height-2,起始坐标为r.Right-2和r.y的矩形,并且填充进图形对象
            g.FillRectangle(hb, new Rectangle(r.Right - 2, r.Y, 2, r.Height - 2));
            //定义一个宽度为r.Width，高为2,起始坐标为r.x和r.Bottom-2的矩形,并且填充进图形对象
            g.FillRectangle(hb, new Rectangle(r.X, r.Bottom - 2, r.Width, 2));
            //最后在表格单元格中拼凑出一个红色的边框
        }
    }
}
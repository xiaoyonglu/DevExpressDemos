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
using DevExpress.Utils.Drawing;

namespace DevExpressDemo
{
    //为GridView的表头设置筛选按钮
    public partial class XtraGridCustomDrawSortFilterButtonsDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomDrawSortFilterButtonsDemo()
        {
            InitializeComponent();

            List<Cars> CarList = new List<Cars>();
            Cars data1 = new Cars();
            data1.Make = "Audi";
            data1.Model = "A6";
            data1.Automatic = true;
            CarList.Add(data1);

            Cars data2 = new Cars();
            data2.Make = "Audi";
            data2.Model = "RS4";
            data2.Automatic = false;
            CarList.Add(data2);

            Cars data3 = new Cars();
            data3.Make = "Benz";
            data3.Model = "G63";
            data3.Automatic = true;
            CarList.Add(data3);

            gridControl1.DataSource = CarList;
        }

        private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;

            Rectangle rect = e.Bounds;
            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            Brush brush = e.Cache.GetGradientBrush(rect, Color.White, Color.LightCyan,
                e.Column.AppearanceHeader.GradientMode);
            rect.Inflate(-1, -1);
            e.Graphics.FillRectangle(brush, rect);
            e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect);

            //为表头的每一列添加筛选按钮
            foreach (DrawElementInfo info in e.Info.InnerElements)
            {
                ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
            }
            e.Handled = true;
        }
    }

    public class Cars
    {

        public string Make { get; set; }

        public string Model { get; set; }

        public bool Automatic { get; set; }
    }
}
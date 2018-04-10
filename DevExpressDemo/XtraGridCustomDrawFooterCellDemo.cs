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

namespace DevExpressDemo
{
    //自定义表格底部统计单元格
    public partial class XtraGridCustomDrawFooterCellDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomDrawFooterCellDemo()
        {
            InitializeComponent();
        }

        private void XtraGridCustomDrawFooterCellDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter1.Fill(this.jWDBDataSet.tb_order);
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);

        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            int dx = e.Bounds.Height;
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.Wheat, Color.FloralWhite, LinearGradientMode.Vertical);
            Rectangle r = e.Bounds;
            ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
            r.Inflate(-1, -1);
            e.Graphics.FillRectangle(brush, r);
            r.Inflate(-2, 0);
            e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r);
            e.Handled = true;
        }
    }
}
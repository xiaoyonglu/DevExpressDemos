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
    public partial class XtraGridCustomPaintCardFieldsDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomPaintCardFieldsDemo()
        {
            InitializeComponent();
        }

        private void XtraGridCustomPaintCardFieldsDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet4.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet4.tb_order);
        }

        private void cardView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            if (e.Column.FieldName == "TotalAmount" && e.IsGetData)
            {
                DataRow dataRow = jWDBDataSet4.Tables["tb_order"].Rows[e.ListSourceRowIndex];
                decimal orderPrice = dataRow["orderPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(dataRow["orderPrice"]);
                int orderCount = dataRow["orderCount"] == DBNull.Value ? 0 : Convert.ToInt32(dataRow["orderCount"]);
                e.Value = orderPrice * orderCount;
            }
        }

        private void cardView1_CustomDrawCardFieldValue(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.Aquamarine, Color.DarkSeaGreen, LinearGradientMode.Horizontal);
            if (e.Column.FieldName == "TotalAmount")
            {
                brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.SkyBlue, LinearGradientMode.Horizontal);
                e.Appearance.ForeColor = Color.Indigo;
                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold);
            }
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds);
            e.Handled = true;
        }
    }
}
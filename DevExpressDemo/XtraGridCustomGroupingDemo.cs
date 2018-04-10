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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DevExpressDemo
{
    //GridView自定义分组
    public partial class XtraGridCustomGroupingDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomGroupingDemo()
        {
            InitializeComponent();
        }

        private void XtraGridCustomGroupingDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet3.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet3.tb_order);

        }

        private void gridView1_CustomColumnGroup(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            //orderPrice是GridView的FieldName
            if (e.Column != null && e.Column.FieldName == "orderPrice")
            {
                double x = Math.Floor(Convert.ToDouble(e.Value1) / 10);
                double y = Math.Floor(Convert.ToDouble(e.Value2) / 10);
                int res = System.Collections.Comparer.Default.Compare(x, y);
                if (x > 9 && y > 9) res = 0;
                e.Result = res;
                e.Handled = true;
            }
        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            if (info == null) return;
            if (info.Column.FieldName == "orderPrice") {
                string interval = IntervalByValue(gridView1.GetGroupRowValue(info.RowHandle));
                string sumText = gridView1.GetGroupSummaryText(info.RowHandle);
                info.GroupText = string.Format("order Price:{0}{1}", interval, sumText);
            }
        }

        private static string IntervalByValue(object val)
        {
            double d = Math.Floor(Convert.ToDouble(val) / 10);
            string ret;
            if (d > 9)
                ret = string.Format(">={0:c}", 100);
            else
                ret=string.Format("{0:c}-{1:c}",d*10,(d+1)*10);
            return ret;

        }
    }
}
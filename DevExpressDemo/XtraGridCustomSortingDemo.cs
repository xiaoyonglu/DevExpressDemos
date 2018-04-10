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

namespace DevExpressDemo
{
    public partial class XtraGridCustomSortingDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomSortingDemo()
        {
            InitializeComponent();
        }

        private void XtraGridCustomSortingDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet4.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet4.tb_order);

        }

        private void gridView1_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            if (e.Column.FieldName == "orderName")
            {
                e.Handled = true;
                string s1 = e.Value1.ToString(), s2 = e.Value2.ToString();
                if (s1.Length > s2.Length)
                {
                    e.Result = 1;
                }
                else
                    if (s1.Length == s2.Length)
                    {
                        e.Result = System.Collections.Comparer.Default.Compare(s1, s2);
                    }
                    else
                        e.Result = -1;
            }
        }
    }
}
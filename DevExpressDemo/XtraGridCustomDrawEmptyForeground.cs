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
using DevExpress.XtraGrid.Views.Base;

namespace DevExpressDemo
{
    //Grid筛选没有数据的时候显示自定义的提示语
    public partial class XtraGridCustomDrawEmptyForeground : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomDrawEmptyForeground()
        {
            InitializeComponent();
        }

        private void XtraGridCustomDrawEmptyForeground_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet.tb_order);
        }

        private void gridView1_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            string s = string.Empty;
            ColumnView view = sender as ColumnView;
            BindingSource dataSource = view.DataSource as BindingSource;
            if (dataSource.Count == 0)
            {
                s = "没有数据";
            }
            else
            {
                s = "没有符合条件的数据";
            }
            Font font = new Font("Tahoma", 10, FontStyle.Bold);
            Rectangle r = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Width - 5, e.Bounds.Height - 5);
            e.Graphics.DrawString(s, font, Brushes.Black, r);
        }
    }
}
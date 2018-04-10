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
    public partial class XtraGridCustomKeyEventDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomKeyEventDemo()
        {
            InitializeComponent();
        }

        private void XtraGridCustomKeyEventDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet3.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet3.tb_order);

        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                if (gridView1.FocusedRowHandle < gridView1.DataRowCount - 1) {
                    gridView1.FocusedRowHandle += 1;
                    e.Handled=true;
                }
            }
            if (e.KeyCode.ToString().Contains(Keys.Back.ToString()))
            {
                if (gridView1.FocusedRowHandle > 0)
                {
                    gridView1.FocusedRowHandle -= 1;
                    e.Handled = true;
                }
            }
        }
    }
}
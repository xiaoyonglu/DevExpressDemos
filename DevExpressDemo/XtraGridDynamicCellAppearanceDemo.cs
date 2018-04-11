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
    public partial class XtraGridDynamicCellAppearanceDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridDynamicCellAppearanceDemo()
        {
            InitializeComponent();
        }

        private void XtraGridDynamicCellAppearanceDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet4.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet4.tb_order);

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.RowHandle != gridView1.FocusedRowHandle &&
            //    ((e.RowHandle % 2 == 0 && e.Column.VisibleIndex % 2 == 1) ||
            //     (e.Column.VisibleIndex % 2 == 0 && e.RowHandle % 2 == 1)))
            //    e.Appearance.BackColor = Color.AliceBlue;

            if (e.RowHandle % 2 == 0)
            {
                e.Appearance.BackColor = Color.AliceBlue;
            }
        }
    }
}
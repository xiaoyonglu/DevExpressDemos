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
    public partial class XtraGridDeleteSelectedRowsDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridDeleteSelectedRowsDemo()
        {
            InitializeComponent();
        }

        private void XtraGridDeleteSelectedRowsDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet4.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet4.tb_order);

        }

        private void btnDeleteSelectedRow_Click(object sender, EventArgs e)
        {
            if (gridView1 == null || gridView1.SelectedRowsCount <= 0) return;

            DataRow[] dataRows = new DataRow[gridView1.SelectedRowsCount];
            for (var i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                dataRows[i] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i]);
            }
            gridView1.BeginSort();
            try
            {
                foreach (DataRow row in dataRows)
                {
                    row.Delete();
                }
            }
            catch { }
            finally
            {
                gridView1.EndSort();
            }
        }
    }
}
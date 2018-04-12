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
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpressDemo
{
    public partial class XtraGridInitCellsNewRowDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridInitCellsNewRowDemo()
        {
            InitializeComponent();
        }

        private void XtraGridInitCellsNewRowDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet4.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet4.tb_order);

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            //设置orderPrice字段的初始值为10
            view.SetRowCellValue(e.RowHandle, view.Columns["orderPrice"], 10);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //新增一行
            gridView1.AddNewRow();
        }
    }
}
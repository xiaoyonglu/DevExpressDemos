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
    //自定义合并单元格
    public partial class CustomMergeCellDemo : DevExpress.XtraEditors.XtraForm
    {
        public CustomMergeCellDemo()
        {
            InitializeComponent();
        }

        private void CustomMergeCellDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet3.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet3.tb_order);

        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column.FieldName == "orderPrice")
            {
                GridView gridView = sender as GridView;
                if (gridView != null)
                {
                    Decimal value1 = (Decimal)gridView1.GetRowCellValue(e.RowHandle1, e.Column);
                    Decimal value2 = (Decimal)gridView1.GetRowCellValue(e.RowHandle2, e.Column);
                      e.Merge = value1 == value2;
                    e.Handled = true;
                }
            }
        }
    }
}
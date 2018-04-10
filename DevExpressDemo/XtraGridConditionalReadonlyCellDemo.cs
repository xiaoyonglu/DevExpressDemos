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
using DevExpress.XtraGrid.Columns;

namespace DevExpressDemo
{
    //根据情况对表格中的某些单元格禁止编辑
    public partial class XtraGridConditionalReadonlyCellDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridConditionalReadonlyCellDemo()
        {
            InitializeComponent();
        }

        private void XtraGridConditionalReadonlyCellDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);
        }

        private bool DisabledConditional(GridView view, int row) {
            //获取userId列
            GridColumn col = view.Columns["userId"];
            //选中单元格的数据
            string val = Convert.ToString(view.GetRowCellValue(row, col));
            //是否等于1或者2
            return (val == "1" || val == "2");
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            //如果列名是"userId"且值不等于1或者2，则不可以编辑
            if (view.FocusedColumn.FieldName == "userId" && !DisabledConditional(view, view.FocusedRowHandle))
            {
                e.Cancel = true;
            }
        }
    }
}
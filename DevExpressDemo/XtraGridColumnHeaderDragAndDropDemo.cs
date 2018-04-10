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
using DevExpress.XtraGrid.Columns;

namespace DevExpressDemo
{
    //禁止表格中通过拖拽自定义表头字段
    public partial class XtraGridColumnHeaderDragAndDropDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridColumnHeaderDragAndDropDemo()
        {
            InitializeComponent();
        }

        private void XtraGridColumnHeaderDragAndDropDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);

        }

        private void gridView1_DragObjectOver(object sender, DevExpress.XtraGrid.Views.Base.DragObjectOverEventArgs e)
        {
            GridColumn column = e.DragObject as GridColumn;
            if (column != null)
            {
                if (e.DropInfo.Index == -101)
                {
                    e.DropInfo.Valid = false;
                }
            }
        }
    }
}
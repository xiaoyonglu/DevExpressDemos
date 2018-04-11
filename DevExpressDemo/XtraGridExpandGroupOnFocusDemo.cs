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
    //单击行数据时展开分组
    //将orderPrice拖拽到表头上面一行
    public partial class XtraGridExpandGroupOnFocusDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridExpandGroupOnFocusDemo()
        {
            InitializeComponent();
        }

        private void XtraGridExpandGroupOnFocusDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet4.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet4.tb_order);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //单击行数据时展开分组
            //没有这段代码的话 需要双击行才能展开分组信息
            if (gridView1.IsGroupRow(e.FocusedRowHandle))
            {
                //选中行是否展开
                bool expanded = gridView1.GetRowExpanded(e.FocusedRowHandle);
                //设置选中行是否展开或者收起来
                gridView1.SetRowExpanded(e.FocusedRowHandle, !expanded);
            }
        }
    }
}
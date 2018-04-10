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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpressDemo
{

    //GridView设置下拉列表格式的过滤器
    public partial class XtraGridCustomizeCheckedFilterMenuDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomizeCheckedFilterMenuDemo()
        {
            InitializeComponent();
         
        }

        private void XtraGridCustomizeCheckedFilterMenuDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet3.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet3.tb_order);
            colorderPrice.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;

            gridView1.ShowFilterPopupCheckedListBox += new FilterPopupCheckedListBoxEventHandler(gridView1_ShowFilterPopupCheckedListBox);
        }

        private void gridView1_ShowFilterPopupCheckedListBox(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupCheckedListBoxEventArgs e)
        {
            if (e.Column.FieldName != "orderPrice") return;

            e.CheckedComboBox.SelectAllItemVisible = false;

            for (int i = 0; i < e.CheckedComboBox.Items.Count; i++) {

                CheckedListBoxItem item = e.CheckedComboBox.Items[i];
                Decimal itemValue = (decimal)(item.Value as FilterItem).Value;
                if (itemValue == 8 || itemValue == 10) {
                    e.CheckedComboBox.Items[i].Enabled = false;
                }
            }

        }
    }
}
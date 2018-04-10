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
using DevExpress.XtraEditors;

namespace DevExpressDemo
{
    //为表格添加嵌入式的导航栏 添加属性：EmbeddedNavigator 
    //当执行导航栏的"删除"操作时候,需要弹出自定义的确认对话框
    
    public partial class XtraGridConfirmRowDeletionDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridConfirmRowDeletionDemo()
        {
            InitializeComponent();
        }

        private void XtraGridConfirmRowDeletionDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);

        }

        //GridControl的EmbeddedNavigator下的ButtonClick事件
        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //如果是删除操作
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                //弹出自定义的确认对话框
                if (MessageBox.Show("Do you want to delete the current row？", "confirm deletion",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
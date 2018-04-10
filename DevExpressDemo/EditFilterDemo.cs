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
    public partial class EditFilterDemo : DevExpress.XtraEditors.XtraForm
    {
        public EditFilterDemo()
        {
            InitializeComponent();
        }

        private void EditFilterDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet.tb_order);

        }
    }
}
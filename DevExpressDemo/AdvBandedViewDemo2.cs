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
    public partial class AdvBandedViewDemo2 : DevExpress.XtraEditors.XtraForm
    {
        public AdvBandedViewDemo2()
        {
            InitializeComponent();
        }

        private void AdvBandedViewDemo2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_userinfo”中。您可以根据需要移动或删除它。
            this.tb_userinfoTableAdapter.Fill(this.jWDBDataSet1.tb_userinfo);
           
            this.tb_orderTableAdapter1.Fill(this.jWDBDataSet1.tb_order);
        }
    }
}
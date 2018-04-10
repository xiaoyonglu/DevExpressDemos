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
using System.Data.SqlClient;
using DevExpressDemo.Const;

namespace DevExpressDemo
{
    public partial class DataSourceBinding : DevExpress.XtraEditors.XtraForm
    {
        public DataSourceBinding()
        {
            InitializeComponent();
        }

        private DataTable GetDataSource() {
            string sql = "select userid,username,roleid,userstate from tb_userinfo";
            SqlDataAdapter da = new SqlDataAdapter(sql, DBConst.DBConnectionString);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            return dt;
        }

        private void DataSourceBinding_Load(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = GetDataSource();
            this.gridView1.OptionsEditForm.CustomEditFormLayout = new EditGridItem();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var rowData = e.Row;
            //TODO update  DB
        }
    }
}
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
using DevExpress.Data.Filtering;
using DevExpress.Data.Filtering.Helpers;

namespace DevExpressDemo
{
    public partial class ExpressionEditorDemo : DevExpress.XtraEditors.XtraForm
    {
        static string strCon = "Data Source=.;Initial Catalog=JWDB;User ID=sa;Password=111111";
        public ExpressionEditorDemo()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var strValidation = string.Empty;
            string sql = "select context from [tb_validationrule] where name='userinfo'";
            SqlDataAdapter da = new SqlDataAdapter(sql, strCon);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                strValidation = dt.Rows[0][0].ToString();
                //创建实例
                var expressionEditor = new UnboundColumnExpressionEditorFormEx(
                    PropertyColumnInfo.FromProperties(typeof(UserInfoEntity)), null);
                //验证的表达式
                expressionEditor.Expression = "Iif([userid] = 1 And IsNullOrEmpty([username]), '用户id为1的用户,用户名不能为空', '')";
                //在验证的页面上点击了OK之后的回调
                if (expressionEditor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //更新表达式到数据库
                    string updatesql = string.Format("update [tb_validationrule] set context='{0}' where name='userinfo'", expressionEditor.Expression.Replace("'", "''"));
                    SqlConnection conn = new SqlConnection(strCon);
                    conn.Open();
                    SqlCommand command = new SqlCommand(updatesql, conn);
                    command.ExecuteNonQuery();
                }

            }
        }

        private void ExpressionEditorDemo_Load(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = GetDataSource();
        }

        private DataTable GetDataSource()
        {
            
            string sql = "select userid,username,roleid,userstate from tb_userinfo";
            SqlDataAdapter da = new SqlDataAdapter(sql, strCon);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            return dt;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var items = new BindingList<UserInfoEntity>();
                for (var i = 0; i < ((System.Data.DataTable)(gridControl1.DataSource)).Rows.Count; i++) { 
                  UserInfoEntity entity = new UserInfoEntity();
                  entity.userid =Convert.ToInt32( ((System.Data.DataTable)(gridControl1.DataSource)).Rows[i].ItemArray[0]);
                  entity.username = Convert.ToString(((System.Data.DataTable)(gridControl1.DataSource)).Rows[i].ItemArray[1]);
                  entity.roleid = Convert.ToString(((System.Data.DataTable)(gridControl1.DataSource)).Rows[i].ItemArray[2]);
                  entity.userstate = Convert.ToBoolean(((System.Data.DataTable)(gridControl1.DataSource)).Rows[i].ItemArray[2]);
                    items.Add(entity);
                }

                if (items == null) return;

                ExpressionEvaluator evaluator = null;
                string strValidation = "Iif([userid] = 1 And IsNullOrEmpty([username]), '用户id为1的用户,用户名不能为空', '')";
                if (!string.IsNullOrEmpty(strValidation))
                {
                    CriteriaOperator op = CriteriaOperator.Parse(strValidation);
                    evaluator = new ExpressionEvaluator(new EvaluatorContextDescriptorDefault(typeof(UserInfoEntity)), op);
                }
                foreach (var item in items) {
                    var ev = evaluator.Evaluate(item);
                    if (!string.IsNullOrEmpty(ev as string)) {
                        MessageBox.Show(ev as string);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
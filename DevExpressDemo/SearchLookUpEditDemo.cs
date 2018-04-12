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
using System.Text.RegularExpressions;

namespace DevExpressDemo
{
    public partial class SearchLookUpEditDemo : DevExpress.XtraEditors.XtraForm
    {
        public SearchLookUpEditDemo()
        {
            InitializeComponent();


            string Resume = "DQ005050018_10A_1of2_1_1.1.pdf";
            var RegexStr = @"^(?<DrawingNumber>[^.]*)[^_]*_(?<DrawingRevision>[^_]*).*.pdf$";
            Match matc = Regex.Match(Resume, RegexStr);
            Console.WriteLine("姓名：{0},手机号：{1}", matc.Groups["DrawingNumber"].ToString(), matc.Groups["DrawingRevision"].ToString());
        }

        DataTable dt = new DataTable();

        private void SearchLookUpEditDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet4.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet4.tb_order);

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            for (int i = 0; i < 100; i++)
            {
                DataRow row = dt.NewRow();
                row["ID"] = i.ToString();
                row["Name"] = (new Random()).NextDouble().ToString();
                dt.Rows.Add(row);
                System.Threading.Thread.Sleep(1);
            }

            this.repositoryItemSearchLookUpEdit1.DataSource = dt;
            this.gridControl1.DataSource = dt.Clone();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "ID")
            {
                string id = e.Value.ToString();
                DataRow[] dr = dt.Select(string.Format("ID = '{0}'", id));
                if (dr != null && dr.Length > 0)
                {
                    DataRow row = dr[0];
                    string name = row["Name"].ToString();
                    gridView1.SetRowCellValue(e.RowHandle, "Name", name);
                }
            }
        }
    }
}
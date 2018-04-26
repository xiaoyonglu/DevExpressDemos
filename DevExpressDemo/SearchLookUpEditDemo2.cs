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
    public partial class SearchLookUpEditDemo2 : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();

        public SearchLookUpEditDemo2()
        {
            InitializeComponent();

            var result = ((Int32)129 == (Int32)129);
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
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
            //this.reso .DataSource = dt;
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
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
    public partial class XtraGridDisableEditorOpeningDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridDisableEditorOpeningDemo()
        {
            InitializeComponent();

            List<Data> list = new List<Data>();
            list.AddRange(new Data[]{
            new Data("one"),
            new Data("two"),
            new Data("three"),
            });
            gridControl1.DataSource = list;
        }

        DevExpress.XtraGrid.Columns.GridColumn preColumn = null;
        int preRow = -1;

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            //DevExpress.XtraGrid.Views.Grid.GridView view;
            //view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //if (preColumn != view.FocusedColumn || preRow != view.FocusedRowHandle) ;
            //e.Cancel = true;

            //preColumn = view.FocusedColumn;
            //preRow = view.FocusedRowHandle;
        }
    }

    public class Data
    {
        public Data(string text)
        {
            this.text = text;
        }
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
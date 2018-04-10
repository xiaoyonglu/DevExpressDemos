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
    //表格中的单元格设置自定义的菜单
    public partial class XtraGridCustomMenuDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridCustomMenuDemo()
        {
            InitializeComponent();
        }

        private void XtraGridCustomMenuDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);

        }

        System.Windows.Forms.ContextMenu cm;

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            if (cm == null) {
                InitializeCustomContextMenu();
            }
            this.gridView1.ActiveEditor.ContextMenu = cm;
        }

        private void InitializeCustomContextMenu()
        {
            cm = new System.Windows.Forms.ContextMenu();
            cm.MenuItems.Add(new MenuItem("Cut", new EventHandler(OnCut)));
            cm.MenuItems.Add(new MenuItem("Copy", new EventHandler(OnCopy)));
            cm.MenuItems.Add(new MenuItem("Paste", new EventHandler(onPaste)));
            cm.MenuItems.Add("-");
            cm.MenuItems.Add(new MenuItem("Select All", new EventHandler(onSelectAll)));
        }

        private void OnCut(object sender, EventArgs e)
        {
            TextEdit textEdit = this.gridView1.ActiveEditor as TextEdit;
            if (textEdit != null)
            {
                textEdit.Cut();
            }
        }

        private void OnCopy(object sender, EventArgs e)
        {
            TextEdit textEdit = this.gridView1.ActiveEditor as TextEdit;
            if (textEdit != null)
            {
                textEdit.Copy();
            }
        }

        private void onPaste(object sender, EventArgs e)
        {
            TextEdit textEdit = this.gridView1.ActiveEditor as TextEdit;
            if (textEdit != null)
            {
                textEdit.Paste();
            }
        }

        private void onSelectAll(object sender, EventArgs e)
        {
            TextEdit textEdit = this.gridView1.ActiveEditor as TextEdit;
            if (textEdit != null)
            {
                textEdit.SelectAll();
            }
        }
    }
}
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
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.Collections;
using DevExpress.XtraTreeList.Columns;

namespace DevExpressDemo
{
    public partial class TreeListDemo : DevExpress.XtraEditors.XtraForm
    {
        public TreeListDemo()
        {
            InitializeComponent();
        }

        private TreeListNode GetDragNode(IDataObject data)
        {
            return (TreeListNode)data.GetData(typeof(TreeListNode));
        }

        private void treeList1_DragDrop(object sender, DragEventArgs e)
        {
            TreeListNode node = GetDragNode(e.Data);
            if (node == null) return;
            TreeList list = (TreeList)sender;
            if (list == node.TreeList) return;
            TreeListHitInfo info = list.CalcHitInfo(list.PointToClient(new Point(e.X, e.Y)));
            InsertBrush(list, node, info.Node == null ? -1 : info.Node.Id);
                
        }

        private void treeList1_DragEnter(object sender, DragEventArgs e)
        {
            TreeList list = (TreeList)sender;
            TreeListNode node = GetDragNode(e.Data);
            if (node != null && node.TreeList != list)
                e.Effect = DragDropEffects.Copy;

        }


        private void InsertBrush(TreeList list, TreeListNode node, int parent)
        {
            ArrayList data = new ArrayList();
            foreach (TreeListColumn column in node.TreeList.Columns)
            {
                data.Add(node[column]);
            }
            parent = list.AppendNode(data.ToArray(), parent).Id;

            if (node.HasChildren)
                foreach (TreeListNode n in node.Nodes)
                    InsertBrush(list, n, parent);
        }

        private void treeList2_DragDrop(object sender, DragEventArgs e)
        {
            TreeListNode node = GetDragNode(e.Data);
            if (node == null) return;
            TreeList list = (TreeList)sender;
            if (list == node.TreeList) return;
            TreeListHitInfo info = list.CalcHitInfo(list.PointToClient(new Point(e.X, e.Y)));
            InsertBrush(list, node, info.Node == null ? -1 : info.Node.Id);

        }

        private void treeList2_DragEnter(object sender, DragEventArgs e)
        {
            TreeList list = (TreeList)sender;
            TreeListNode node = GetDragNode(e.Data);
            if (node != null && node.TreeList != list)
                e.Effect = DragDropEffects.Copy;
        }


    }
}
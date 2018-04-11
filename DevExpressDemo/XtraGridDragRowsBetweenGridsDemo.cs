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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using System.Data.SqlClient;
using DevExpressDemo.Const;

namespace DevExpressDemo
{
    public partial class DragDemo : DevExpress.XtraEditors.XtraForm
    {

        GridHitInfo downHitInfo = null;

        public DragDemo()
        {
            InitializeComponent();
        }

        private void DragDemo_Load(object sender, EventArgs e)
        {
            FillData();
        }

        //鼠标拖拽过程事件
        private void gridControl_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            GridControl grid = sender as GridControl;
            if (grid == null) return;
            GridView view = grid.FocusedView as GridView;
            //GridView如果有分组，则展开所有分组数据
            if (view.GroupCount != 0)
                view.ExpandAllGroups();
        }

        //鼠标按下事件
        private void gridView_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));//鼠标左键按下去时在GridView中的坐标
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
                downHitInfo = hitInfo;
        }

        //鼠标移动事件
        private void gridView_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)//不是左键则无效且鼠标左键按下去时需要在gridview区域中
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    object row = view.GetRow(downHitInfo.RowHandle);
                    if (row == null) return;
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }
         
        //拖拽完成后事件
        private void gridControl_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            //获取选中行的数据
            DataRow row = ((DataRowView)e.Data.GetData(typeof(DataRowView))).Row;
            if (row != null && table != null && row.Table != table)
            {
                table.ImportRow(row);
                row.Delete();
            }
        }

        private void FillData()
        {
            //左边的网格默认查出tb_order表中的所有数据
            string gridView1sql1 = "select orderName from tb_order";
            //右边的网格默认不显示数据
            string gridView1sql2 = "select orderName from tb_order where 1=2";
            gridControl1.DataSource = GetDataSource(gridView1sql1);
            gridControl2.DataSource = GetDataSource(gridView1sql2);
        }

        private DataTable GetDataSource(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, DBConst.DBConnectionString);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    //public class Entity
    //{
    //    public Entity()
    //    {
    //    }

    //    public int id { get; set; }
    //    public int userId { get; set; }
    //    public string orderSerialId { get; set; }
    //    public string OrderName { get; set; }
    //    public string orderPrice { get; set; }
    //    public string orderCount { get; set; }
        
    //}
}
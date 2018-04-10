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
using System.Net;
using System.IO;
using System.Diagnostics;

namespace DevExpressDemo
{
    //修改鼠标滑过的行的背景色
    public partial class HotTrackingRows : DevExpress.XtraEditors.XtraForm
    {

        private int hotTrackRow = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
       
        public HotTrackingRows()
        {
            InitializeComponent();
        }

        private void HotTrackingRows_Load(object sender, EventArgs e)
        {
          

            this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);
        }

        private int HotTrackRow
        {
            get
            {
                return hotTrackRow;
            }
            set
            {
                if (hotTrackRow != value)
                {
                    int prevHotTrackRow = hotTrackRow;
                    hotTrackRow = value;

                    gridView1.RefreshRow(prevHotTrackRow);
                    gridView1.RefreshRow(hotTrackRow);

                    if (hotTrackRow >= 0)
                    {
                        gridControl1.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        gridControl1.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(new Point(e.X, e.Y));

            if (info.InRowCell)
            {
                HotTrackRow = info.RowHandle;
            }
            else
            {
                HotTrackRow = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
            }
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle == HotTrackRow) {
                e.Appearance.BackColor = Color.PaleGoldenrod;
            }
        }

    }
}
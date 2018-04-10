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
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors.Repository;

namespace DevExpressDemo
{
    //在Grid中设置一个下拉计算器
    public partial class XtraGridColumnEditorDemo : DevExpress.XtraEditors.XtraForm
    {
        public XtraGridColumnEditorDemo()
        {
            InitializeComponent();

            BandedGridColumn newColumn = bandedGridView1.Columns.Add() as BandedGridColumn;
            newColumn.Caption = "Country";
            bandedGridView1.Bands[0].Columns.Add(newColumn);
            newColumn.Visible = true;

            RepositoryItemCalcEdit columnsEditor = new RepositoryItemCalcEdit();
            gridControl1.RepositoryItems.Add(columnsEditor);
            newColumn.ColumnEdit = columnsEditor;
        }
    }
}
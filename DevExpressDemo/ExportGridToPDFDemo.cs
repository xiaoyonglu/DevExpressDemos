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
using System.Diagnostics;

namespace DevExpressDemo
{
    //将Grid导出到PDF
    public partial class ExportGridToPDFDemo : DevExpress.XtraEditors.XtraForm
    {
        public ExportGridToPDFDemo()
        {
            InitializeComponent();
        }

        private void ExportGridToPDFDemo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_order”中。您可以根据需要移动或删除它。
            this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);
            // TODO: 这行代码将数据加载到表“jWDBDataSet1.tb_order”中。您可以根据需要移动或删除它。
           // this.tb_orderTableAdapter.Fill(this.jWDBDataSet1.tb_order);
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view =  gridControl1.MainView as  DevExpress.XtraGrid.Views.Grid.GridView;
            if(view !=null){
                //设置字体 如果不加中文可能会出现乱码
                DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("宋体", 9); 
                //PDF的名称
                view.ExportToPdf("MainViewData.pdf");

                Process pdfExport = new Process();
                pdfExport.StartInfo.FileName="AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "MainViewData.pdf";
                pdfExport.Start();
            }
        }
    }
}
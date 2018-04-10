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
using DevExpress.XtraGrid.EditForm.Helpers;

namespace DevExpressDemo
{
    public partial class EditGridItem : EditFormUserControl
    {
        public EditGridItem()
        {
            InitializeComponent();

            this.SetBoundFieldName(txtuserid, "userid");
            this.SetBoundFieldName(txtusername, "username");           
           
        }
    }
}
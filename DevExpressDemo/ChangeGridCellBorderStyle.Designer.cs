namespace DevExpressDemo
{
    partial class ChangeGridCellBorderStyle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbuserinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jWDBDataSet1 = new DevExpressDemo.JWDBDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluserid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserpwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colroleid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tb_userinfoTableAdapter = new DevExpressDemo.JWDBDataSet1TableAdapters.tb_userinfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuserinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jWDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbuserinfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(752, 427);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbuserinfoBindingSource
            // 
            this.tbuserinfoBindingSource.DataMember = "tb_userinfo";
            this.tbuserinfoBindingSource.DataSource = this.jWDBDataSet1;
            // 
            // jWDBDataSet1
            // 
            this.jWDBDataSet1.DataSetName = "JWDBDataSet1";
            this.jWDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluserid,
            this.colusername,
            this.coluserpwd,
            this.colroleid,
            this.coluserstate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // coluserid
            // 
            this.coluserid.FieldName = "userid";
            this.coluserid.Name = "coluserid";
            this.coluserid.Visible = true;
            this.coluserid.VisibleIndex = 0;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 1;
            // 
            // coluserpwd
            // 
            this.coluserpwd.FieldName = "userpwd";
            this.coluserpwd.Name = "coluserpwd";
            this.coluserpwd.Visible = true;
            this.coluserpwd.VisibleIndex = 2;
            // 
            // colroleid
            // 
            this.colroleid.FieldName = "roleid";
            this.colroleid.Name = "colroleid";
            this.colroleid.Visible = true;
            this.colroleid.VisibleIndex = 3;
            // 
            // coluserstate
            // 
            this.coluserstate.FieldName = "userstate";
            this.coluserstate.Name = "coluserstate";
            this.coluserstate.Visible = true;
            this.coluserstate.VisibleIndex = 4;
            // 
            // tb_userinfoTableAdapter
            // 
            this.tb_userinfoTableAdapter.ClearBeforeFill = true;
            // 
            // ChangeGridCellBorderStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 427);
            this.Controls.Add(this.gridControl1);
            this.Name = "ChangeGridCellBorderStyle";
            this.Text = "ChangeGridCellBorderStyle";
            this.Load += new System.EventHandler(this.ChangeGridCellBorderStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuserinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jWDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private JWDBDataSet1 jWDBDataSet1;
        private System.Windows.Forms.BindingSource tbuserinfoBindingSource;
        private JWDBDataSet1TableAdapters.tb_userinfoTableAdapter tb_userinfoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coluserid;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn coluserpwd;
        private DevExpress.XtraGrid.Columns.GridColumn colroleid;
        private DevExpress.XtraGrid.Columns.GridColumn coluserstate;
    }
}
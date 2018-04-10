namespace DevExpressDemo
{
    partial class EditFilterDemo
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.jWDBDataSet = new DevExpressDemo.JWDBDataSet();
            this.tborderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_orderTableAdapter = new DevExpressDemo.JWDBDataSetTableAdapters.tb_orderTableAdapter();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderSerialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jWDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tborderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tborderBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(733, 592);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coluserId,
            this.colorderSerialId,
            this.colorderName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // jWDBDataSet
            // 
            this.jWDBDataSet.DataSetName = "JWDBDataSet";
            this.jWDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tborderBindingSource
            // 
            this.tborderBindingSource.DataMember = "tb_order";
            this.tborderBindingSource.DataSource = this.jWDBDataSet;
            // 
            // tb_orderTableAdapter
            // 
            this.tb_orderTableAdapter.ClearBeforeFill = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // coluserId
            // 
            this.coluserId.FieldName = "userId";
            this.coluserId.Name = "coluserId";
            this.coluserId.Visible = true;
            this.coluserId.VisibleIndex = 1;
            // 
            // colorderSerialId
            // 
            this.colorderSerialId.FieldName = "orderSerialId";
            this.colorderSerialId.Name = "colorderSerialId";
            this.colorderSerialId.Visible = true;
            this.colorderSerialId.VisibleIndex = 2;
            // 
            // colorderName
            // 
            this.colorderName.FieldName = "orderName";
            this.colorderName.Name = "colorderName";
            this.colorderName.Visible = true;
            this.colorderName.VisibleIndex = 3;
            // 
            // EditFilterDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 592);
            this.Controls.Add(this.gridControl1);
            this.Name = "EditFilterDemo";
            this.Text = "EditFilterDemo";
            this.Load += new System.EventHandler(this.EditFilterDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jWDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tborderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private JWDBDataSet jWDBDataSet;
        private System.Windows.Forms.BindingSource tborderBindingSource;
        private JWDBDataSetTableAdapters.tb_orderTableAdapter tb_orderTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coluserId;
        private DevExpress.XtraGrid.Columns.GridColumn colorderSerialId;
        private DevExpress.XtraGrid.Columns.GridColumn colorderName;
    }
}
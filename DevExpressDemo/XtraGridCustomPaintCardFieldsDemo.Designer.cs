namespace DevExpressDemo
{
    partial class XtraGridCustomPaintCardFieldsDemo
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
            this.tborderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jWDBDataSet4 = new DevExpressDemo.JWDBDataSet4();
            this.tborderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_orderTableAdapter = new DevExpressDemo.JWDBDataSet4TableAdapters.tb_orderTableAdapter();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderSerialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tborderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jWDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tborderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tborderBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(617, 567);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // tborderBindingSource
            // 
            this.tborderBindingSource.DataMember = "tb_order";
            // 
            // jWDBDataSet4
            // 
            this.jWDBDataSet4.DataSetName = "JWDBDataSet4";
            this.jWDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tborderBindingSource1
            // 
            this.tborderBindingSource1.DataMember = "tb_order";
            this.tborderBindingSource1.DataSource = this.jWDBDataSet4;
            // 
            // tb_orderTableAdapter
            // 
            this.tb_orderTableAdapter.ClearBeforeFill = true;
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coluserId,
            this.colorderSerialId,
            this.colorderName,
            this.colorderPrice,
            this.colorderCount,
            this.TotalAmount});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView1.CustomDrawCardFieldValue += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.cardView1_CustomDrawCardFieldValue);
            this.cardView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.cardView1_CustomUnboundColumnData);
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
            // colorderPrice
            // 
            this.colorderPrice.FieldName = "orderPrice";
            this.colorderPrice.Name = "colorderPrice";
            this.colorderPrice.Visible = true;
            this.colorderPrice.VisibleIndex = 4;
            // 
            // colorderCount
            // 
            this.colorderCount.FieldName = "orderCount";
            this.colorderCount.Name = "colorderCount";
            this.colorderCount.Visible = true;
            this.colorderCount.VisibleIndex = 5;
            // 
            // TotalAmount
            // 
            this.TotalAmount.Caption = "TotalAmount";
            this.TotalAmount.DisplayFormat.FormatString = "c2";
            this.TotalAmount.FieldName = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TotalAmount.Visible = true;
            this.TotalAmount.VisibleIndex = 6;
            // 
            // XtraGridCustomPaintCardFieldsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 567);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraGridCustomPaintCardFieldsDemo";
            this.Text = "XtraGridCustomPaintCardFieldsDemo";
            this.Load += new System.EventHandler(this.XtraGridCustomPaintCardFieldsDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tborderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jWDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tborderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tborderBindingSource;
        private JWDBDataSet4 jWDBDataSet4;
        private System.Windows.Forms.BindingSource tborderBindingSource1;
        private JWDBDataSet4TableAdapters.tb_orderTableAdapter tb_orderTableAdapter;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coluserId;
        private DevExpress.XtraGrid.Columns.GridColumn colorderSerialId;
        private DevExpress.XtraGrid.Columns.GridColumn colorderName;
        private DevExpress.XtraGrid.Columns.GridColumn colorderPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colorderCount;
        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
    }
}
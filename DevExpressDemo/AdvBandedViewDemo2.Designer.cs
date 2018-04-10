namespace DevExpressDemo
{
    partial class AdvBandedViewDemo2
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbuserinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jWDBDataSet1 = new DevExpressDemo.JWDBDataSet1();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.coluserid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colusername = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colroleid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coluserstate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.coluserpwd = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tb_userinfoTableAdapter = new DevExpressDemo.JWDBDataSet1TableAdapters.tb_userinfoTableAdapter();
            this.tb_orderTableAdapter1 = new DevExpressDemo.JWDBDataSet1TableAdapters.tb_orderTableAdapter();
            this.tb_orderTableAdapter2 = new DevExpressDemo.JWDBDataSet1TableAdapters.tb_orderTableAdapter();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuserinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jWDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbuserinfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.cardView1;
            gridLevelNode1.RelationName = "FK_tb_order_tb_userinfo";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(624, 543);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.cardView1,
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
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.coluserid,
            this.colusername,
            this.coluserpwd,
            this.colroleid,
            this.coluserstate});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "public";
            this.gridBand1.Columns.Add(this.coluserid);
            this.gridBand1.Columns.Add(this.colusername);
            this.gridBand1.Columns.Add(this.colroleid);
            this.gridBand1.Columns.Add(this.coluserstate);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 204;
            // 
            // coluserid
            // 
            this.coluserid.FieldName = "userid";
            this.coluserid.Name = "coluserid";
            this.coluserid.Visible = true;
            this.coluserid.Width = 100;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.Width = 100;
            // 
            // colroleid
            // 
            this.colroleid.FieldName = "roleid";
            this.colroleid.Name = "colroleid";
            this.colroleid.RowIndex = 1;
            this.colroleid.Visible = true;
            this.colroleid.Width = 100;
            // 
            // coluserstate
            // 
            this.coluserstate.FieldName = "userstate";
            this.coluserstate.Name = "coluserstate";
            this.coluserstate.RowIndex = 1;
            this.coluserstate.Visible = true;
            this.coluserstate.Width = 104;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "private";
            this.gridBand2.Columns.Add(this.coluserpwd);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 100;
            // 
            // coluserpwd
            // 
            this.coluserpwd.FieldName = "userpwd";
            this.coluserpwd.Name = "coluserpwd";
            this.coluserpwd.Visible = true;
            this.coluserpwd.Width = 100;
            // 
            // tb_userinfoTableAdapter
            // 
            this.tb_userinfoTableAdapter.ClearBeforeFill = true;
            // 
            // tb_orderTableAdapter1
            // 
            this.tb_orderTableAdapter1.ClearBeforeFill = true;
            // 
            // tb_orderTableAdapter2
            // 
            this.tb_orderTableAdapter2.ClearBeforeFill = true;
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // AdvBandedViewDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 543);
            this.Controls.Add(this.gridControl1);
            this.Name = "AdvBandedViewDemo2";
            this.Text = "AdvBandedViewDemo2";
            this.Load += new System.EventHandler(this.AdvBandedViewDemo2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuserinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jWDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private JWDBDataSet1 jWDBDataSet1;
        private System.Windows.Forms.BindingSource tbuserinfoBindingSource;
        private JWDBDataSet1TableAdapters.tb_userinfoTableAdapter tb_userinfoTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coluserid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colusername;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colroleid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coluserstate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coluserpwd;

        private DevExpressDemo.JWDBDataSet1TableAdapters.tb_orderTableAdapter tb_orderTableAdapter1;
        private JWDBDataSet1TableAdapters.tb_orderTableAdapter tb_orderTableAdapter2;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
       
    }
}
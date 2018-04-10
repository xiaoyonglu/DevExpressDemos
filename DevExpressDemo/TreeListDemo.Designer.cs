namespace DevExpressDemo
{
    partial class TreeListDemo
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Location = new System.Drawing.Point(-6, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "HeaderQuarters",
            "1000000",
            "2018/01/20"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Engineering",
            "100000",
            "2018/01/20"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Eletronic Products",
            "10000",
            "2018/01/20"}, 1);
            this.treeList1.AppendNode(new object[] {
            "Phone",
            "4000",
            "2018/01/20"}, 2);
            this.treeList1.AppendNode(new object[] {
            "Software Products",
            "10000",
            "2018/01/20"}, 1);
            this.treeList1.AppendNode(new object[] {
            "IOS",
            "4000",
            "2018/01/20"}, 4);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(873, 236);
            this.treeList1.TabIndex = 0;
            this.treeList1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeList1_DragDrop);
            this.treeList1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeList1_DragEnter);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Department";
            this.treeListColumn1.FieldName = "Department";
            this.treeListColumn1.MinWidth = 88;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 88;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Budget";
            this.treeListColumn2.FieldName = "Budget";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "LastOrder";
            this.treeListColumn3.FieldName = "LastOrder";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn4,
            this.treeListColumn5});
            this.treeList2.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList2.Location = new System.Drawing.Point(-6, 327);
            this.treeList2.Name = "treeList2";
            this.treeList2.Size = new System.Drawing.Size(873, 236);
            this.treeList2.TabIndex = 1;
            this.treeList2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeList2_DragDrop);
            this.treeList2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeList2_DragEnter);
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Department";
            this.treeListColumn4.FieldName = "Department";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 0;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Budget";
            this.treeListColumn5.FieldName = "Budget";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 1;
            // 
            // TreeListDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 639);
            this.Controls.Add(this.treeList2);
            this.Controls.Add(this.treeList1);
            this.Name = "TreeListDemo";
            this.Text = "TreeList";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
    }
}
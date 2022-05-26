namespace WinFormsPivotGridCustomServerModeSort
{
    partial class Form1
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.entityServerModeSource = new DevExpress.Data.Linq.EntityServerModeSource();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.entityServerModeSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldPrice,
            this.fieldOrderYear,
            this.fieldOrderMonth});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(802, 279);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomServerModeSort += new System.EventHandler<DevExpress.XtraPivotGrid.CustomServerModeSortEventArgs>(this.pivotGridControl1_CustomServerModeSort);
            // 
            // entityServerModeSource
            // 
            this.entityServerModeSource.ElementType = typeof(WinFormsPivotGridCustomServerModeSort.SalesPerson);
            this.entityServerModeSource.KeyExpression = "OrderID";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category";
            dataSourceColumnBinding1.ColumnName = "CategoryName";
            this.fieldCategoryName.DataBinding = dataSourceColumnBinding1;
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldPrice
            // 
            this.fieldPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPrice.AreaIndex = 0;
            this.fieldPrice.Caption = "Price";
            dataSourceColumnBinding2.ColumnName = "Extended_Price";
            this.fieldPrice.DataBinding = dataSourceColumnBinding2;
            this.fieldPrice.Name = "fieldPrice";
            // 
            // fieldOrderYear
            // 
            this.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Year";
            dataSourceColumnBinding3.ColumnName = "OrderDate";
            dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.DataBinding = dataSourceColumnBinding3;
            this.fieldOrderYear.Name = "fieldOrderYear";
            this.fieldOrderYear.UnboundFieldName = "fieldOrderYear";
            // 
            // fieldOrderMonth
            // 
            this.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderMonth.AreaIndex = 1;
            this.fieldOrderMonth.Caption = "Month";
            dataSourceColumnBinding4.ColumnName = "OrderDate";
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderMonth.DataBinding = dataSourceColumnBinding4;
            this.fieldOrderMonth.Name = "fieldOrderMonth";
            this.fieldOrderMonth.UnboundFieldName = "fieldOrderMonth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 279);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Custom Server Mode Sorting";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderMonth;
    }
}


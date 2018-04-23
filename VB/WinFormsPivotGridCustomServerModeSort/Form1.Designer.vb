Namespace WinFormsPivotGridCustomServerModeSort
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.entityServerModeSource = New DevExpress.Data.Linq.EntityServerModeSource()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.entityServerModeSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.entityServerModeSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldPrice, Me.fieldOrderYear, Me.fieldOrderMonth})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(802, 279)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' entityServerModeSource
            ' 
            Me.entityServerModeSource.ElementType = GetType(WinFormsPivotGridCustomServerModeSort.SalesPerson)
            Me.entityServerModeSource.KeyExpression = "OrderID"
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            ' 
            ' fieldPrice
            ' 
            Me.fieldPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldPrice.AreaIndex = 0
            Me.fieldPrice.Caption = "Price"
            Me.fieldPrice.FieldName = "Extended_Price"
            Me.fieldPrice.Name = "fieldPrice"
            ' 
            ' fieldOrderYear
            ' 
            Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderYear.AreaIndex = 0
            Me.fieldOrderYear.Caption = "Year"
            Me.fieldOrderYear.FieldName = "OrderDate"
            Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderYear.Name = "fieldOrderYear"
            Me.fieldOrderYear.UnboundFieldName = "fieldOrderYear"
            ' 
            ' fieldOrderMonth
            ' 
            Me.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderMonth.AreaIndex = 1
            Me.fieldOrderMonth.Caption = "Month"
            Me.fieldOrderMonth.FieldName = "OrderDate"
            Me.fieldOrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderMonth.Name = "fieldOrderMonth"
            Me.fieldOrderMonth.UnboundFieldName = "fieldOrderMonth"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(802, 279)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Custom Server Mode Sorting"
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.entityServerModeSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private entityServerModeSource As DevExpress.Data.Linq.EntityServerModeSource
        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldPrice As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldOrderMonth As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace


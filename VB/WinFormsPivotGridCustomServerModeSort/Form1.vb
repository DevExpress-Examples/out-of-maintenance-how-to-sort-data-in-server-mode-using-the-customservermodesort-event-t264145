Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports System.Collections

Namespace WinFormsPivotGridCustomServerModeSort
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            entityServerModeSource.QueryableSource =
                (New WinFormsPivotGridCustomServerModeSort.NWindEntities1()).SalesPersons

            Dim field As PivotGridField = fieldOrderYear
            pivotGridControl1.BeginUpdate()
            Try
                field.FilterValues.Clear()
                field.FilterValues.Add(1996)
                field.FilterValues.FilterType = PivotFilterType.Included
            Finally
                pivotGridControl1.EndUpdate()
            End Try

            ' Sets fields' sort mode to Custom to raise the CustomServerModeSort event.
            fieldCategoryName.SortMode = PivotSortMode.Custom
            fieldOrderMonth.SortMode = PivotSortMode.Custom

        End Sub

        Private Sub pivotGridControl1_CustomServerModeSort(ByVal sender As Object, 
			ByVal e As CustomServerModeSortEventArgs) Handles pivotGridControl1.CustomServerModeSort
            ' Sorting using a cross area object.
            If e.Field Is fieldOrderMonth Then
                ' Sets the cross area key, by which the "Month" field will be sorted. 
                ' In this example, it's one of the "Category" cross area field values.
                Dim sorting As CrossAreaKey = e.GetCrossAreaKey(New Object() { "Produce" })

                ' Sets the result of the "Month" field's values comparison 
                ' by the cross area key object and the "Price" field.
                e.Result = Comparer.Default.Compare(
					e.GetCellValue1(sorting, fieldPrice), 
					e.GetCellValue2(sorting, fieldPrice))
            End If

            ' Direct sorting without using a cross area object. 
            If e.Field Is fieldCategoryName Then
                ' Sets the result of "Category" field's values comparison by the Year and Price fields.
                e.Result = Comparer.Default.Compare(
					e.GetCellValue1(New Object() { 1996 }, fieldPrice), 
					e.GetCellValue2(New Object() { 1996 }, fieldPrice))
            End If
        End Sub
    End Class
End Namespace

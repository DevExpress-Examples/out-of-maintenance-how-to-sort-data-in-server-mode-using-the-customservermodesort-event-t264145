using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using System.Collections;

namespace WinFormsPivotGridCustomServerModeSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            entityServerModeSource.QueryableSource = new 
                WinFormsPivotGridCustomServerModeSort.NWindEntities1().SalesPersons;
            
            PivotGridField field = fieldOrderYear;
            pivotGridControl1.BeginUpdate();
            try
            {
                field.FilterValues.Clear();
                field.FilterValues.Add(1996);
                field.FilterValues.FilterType = PivotFilterType.Included;
            }
            finally
            {
                pivotGridControl1.EndUpdate();
            }

            // Sets fields' sort mode to Custom to raise the CustomServerModeSort event.
            fieldCategoryName.SortMode = PivotSortMode.Custom;
            fieldOrderMonth.SortMode = PivotSortMode.Custom;

        }

        private void pivotGridControl1_CustomServerModeSort(object sender, 
            CustomServerModeSortEventArgs e)
        {
            // Sorting using a cross area object.
            if (e.Field == fieldOrderMonth)
            {
                // Sets the cross area key, by which the "Month" field will be sorted. 
                // In this example, it's one of the "Category" cross area field values.
                CrossAreaKey sorting = e.GetCrossAreaKey(new object[] { "Produce" });

                // Sets the result of the "Month" field's values comparison 
                // by the cross area key object and the "Price" field.
                e.Result = Comparer.Default.Compare(
                    e.GetCellValue1(sorting, fieldPrice),
                    e.GetCellValue2(sorting, fieldPrice)
                );
            }

            // Direct sorting without using a cross area object. 
            if (e.Field == fieldCategoryName)
            {
                // Sets the result of "Category" field's values comparison by the Year and Price fields.
                e.Result = Comparer.Default.Compare(
                    e.GetCellValue1(new object[] { 1996 }, fieldPrice),
                    e.GetCellValue2(new object[] { 1996 }, fieldPrice)
                );
            }
        }
    }
}

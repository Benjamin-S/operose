using System.Windows.Forms;

namespace Operose
{
    internal class ResetBatchDGV : DataGridView
    {
        //private SelectableColumn selectedColumn = new SelectableColumn
        //{
        //    HeaderText = "Selected",
        //    Name = "SelectedCol"
        //};

        public ResetBatchDGV()
        {
            DoubleBuffered = true;
        }

        //protected override void OnDataSourceChanged(EventArgs e)
        //{
        //    base.OnDataSourceChanged(e);
        //    if (!Columns.Contains(selectedColumn))
        //    {
        //        Columns.Add(selectedColumn);
        //    }
        //}
    }

    //public class SelectableColumn : DataGridViewCheckBoxColumn
    //{
    //    public SelectableColumn()
    //    {
    //    }
    //}
}
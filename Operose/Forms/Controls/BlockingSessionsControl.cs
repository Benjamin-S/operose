using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Operose
{
    public partial class BlockingSessionsControl : UserControl
    {
        private string controlName;
        private DataTable dataTable = new DataTable();
        public BlockingSessionsControl()
        {
            InitializeComponent();
        }

        public BlockingSessionsControl(string ControlName)
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            controlName = ControlName;
            //GetBlockingSessions();
        }


        private void GetBlockingSessions()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                using (var command = new SqlCommand("sp_WhoIsActive", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    connection.ChangeDatabase("master");
                    command.ExecuteNonQuery();

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }

            }

        }

    }
}

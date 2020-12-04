using Operose.HelpersLib;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Operose.ServicesLib
{
    public class DatabaseService
    {
        public DataTable GetBlockingSessions(
            string connectionString,
            string Filter = "",
            string Filter_type = "session",
            string Not_filter = "",
            string Not_filter_type = "session",
            int Show_own_spid = 0,
            int Show_system_spids = 0,
            int Show_sleeping_spids = 1,
            int Get_full_inner_text = 0,
            int Get_plans = 0,
            int Get_outer_command = 0,
            int Get_transaction_info = 0,
            int Get_task_info = 1,
            int Get_locks = 0,
            int Get_avg_time = 0,
            int Get_additional_info = 0,
            int Find_block_leaders = 0,
            int Delta_interval = 0,
            string Output_column_list = "[dd%][session_id][sql_text][sql_command][login_name][wait_info][tasks][tran_log%][cpu%][temp%][block%][reads%][writes%][context%][physical%][query_plan][locks][%]",
            string Sort_order = "[start_time] ASC",
            int Format_output = 0,
            string Destination_table = "",
            int Return_schema = 0,
            string Schema = null,
            int Help = 0)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("sp_WhoIsActive", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    connection.ChangeDatabase("master");

                    // Setting a vast list of parameters for this stored procedure

                    command.Parameters.Add(new SqlParameter("@filter", Filter));
                    command.Parameters.Add(new SqlParameter("@filter_type", Filter_type));
                    command.Parameters.Add(new SqlParameter("@not_filter", Not_filter));
                    command.Parameters.Add(new SqlParameter("@not_filter_type", Not_filter_type));
                    command.Parameters.Add(new SqlParameter("@show_own_spid", Show_own_spid));
                    command.Parameters.Add(new SqlParameter("@show_system_spids", Show_system_spids));
                    command.Parameters.Add(new SqlParameter("@show_sleeping_spids", Show_sleeping_spids));
                    command.Parameters.Add(new SqlParameter("@get_full_inner_text", Get_full_inner_text));
                    command.Parameters.Add(new SqlParameter("@get_plans", Get_plans));
                    command.Parameters.Add(new SqlParameter("@get_outer_command", Get_outer_command));
                    command.Parameters.Add(new SqlParameter("@get_transaction_info", Get_transaction_info));
                    command.Parameters.Add(new SqlParameter("@get_task_info", Get_task_info));
                    command.Parameters.Add(new SqlParameter("@get_locks", Get_locks));
                    command.Parameters.Add(new SqlParameter("@get_avg_time", Get_avg_time));
                    command.Parameters.Add(new SqlParameter("@get_additional_info", Get_additional_info));
                    command.Parameters.Add(new SqlParameter("@find_block_leaders", Find_block_leaders));
                    command.Parameters.Add(new SqlParameter("@delta_interval", Delta_interval));
                    command.Parameters.Add(new SqlParameter("@output_column_list", Output_column_list));
                    command.Parameters.Add(new SqlParameter("@sort_order", Sort_order));
                    command.Parameters.Add(new SqlParameter("@format_output", Format_output));
                    command.Parameters.Add(new SqlParameter("@destination_table", Destination_table));
                    command.Parameters.Add(new SqlParameter("@return_schema", Return_schema));
                    command.Parameters.Add(new SqlParameter("@schema", Schema));
                    command.Parameters.Add(new SqlParameter("@help", Help));

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        DebugHelper.WriteException(e);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        var count = da.Fill(dataTable);
                        DebugHelper.WriteLine("Database Context: " + connection.DataSource);
                        DebugHelper.WriteLine("Number of rows returned: " + count);
                        return dataTable;
                    }
                }
            }
        }

        public bool ClearInactiveUsers(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("ClearInactiveUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    connection.ChangeDatabase("master");
                    try
                    {
                        command.ExecuteNonQuery();
                        DebugHelper.WriteLine("Database Context: " + connection.DataSource);
                        DebugHelper.WriteLine("ClearInactiveUsers ran successfully");
                        return true;
                    }
                    catch (Exception e)
                    {
                        DebugHelper.WriteException(e);
                        return false;
                    }
                }
            }

        }
    }
}

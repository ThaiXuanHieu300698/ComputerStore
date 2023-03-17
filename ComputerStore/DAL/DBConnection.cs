using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class DBConnection
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        public DBConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        public SqlConnection openConnection()
        {
            try
            {
                if(connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Thông báo");
            }

            return connection;
        }

        public DataTable ExecuteSelectQuery(string query)
        {
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            command = new SqlCommand();
            try
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            command = new SqlCommand();
            try
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public void ExecuteInsertQuery(string query, SqlParameter[] parameters)
        {
            command = new SqlCommand();

            try
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
                adapter.InsertCommand = command;
            }
            catch(Exception)
            {
                MessageBox.Show("Đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExecuteUpdateQuery(string query, SqlParameter[] parameters)
        {
            command = new SqlCommand();
            try
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
                adapter.UpdateCommand = command;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void ExecuteDeleteQuery(string query, SqlParameter[] parameters)
        {
            command = new SqlCommand();
            try
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
                adapter.DeleteCommand = command;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

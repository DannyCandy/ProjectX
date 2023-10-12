using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSuApp
{
    public class DataAccess
    {
        private Connect connector = new Connect();

        public DataAccess()
        {

        }

        public DataTable GetData(string query)
        {
            MySqlConnection connection = connector.GetConnection();
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                Console.WriteLine("Connection opened!");

                // Lấy dữ liệu
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);
                Console.WriteLine("Data retrieved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to retrieve data. Error message: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed!");
            }

            return dataTable;
        }

        public void InsertData(string query)
        {
            MySqlConnection connection = connector.GetConnection();

            try
            {
                connection.Open();
                Console.WriteLine("Connection opened!");

                // Thêm dữ liệu
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to insert data. Error message: " + ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed!");
            }
        }

        public void UpdateData(string query)
        {
            MySqlConnection connection = connector.GetConnection();

            try
            {
                connection.Open();
                Console.WriteLine("Connection opened!");

                // Sửa dữ liệu
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Data updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to update data. Error message: " + ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed!");
            }
        }

        public void DeleteData(string query)
        {
            MySqlConnection connection = connector.GetConnection();

            try
            {
                connection.Open();
                Console.WriteLine("Connection opened!");

                // Xóa dữ liệu
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Data deleted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to delete data. Error message: " + ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed!");
            }
        }

        public static DataSet GetDataToDTS(string query,string tableName)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=employeems;Uid=root;Pwd=123;");
            DataSet dataSet = new DataSet();

            try
            {
                connection.Open();
                Console.WriteLine("Connection opened!");

                // Lấy dữ liệu
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                
                DataTable dataTable = new DataTable(tableName);
                dataSet.Tables.Add(dataTable);
                adapter.Fill(dataSet,tableName);
                Console.WriteLine("Data retrieved successfully!");
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        Console.WriteLine($"{column.ColumnName}: {row[column]}");
                    }
                    Console.WriteLine();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to retrieve data. Error message: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed!");
            }

            return dataSet;
        }

    }
}

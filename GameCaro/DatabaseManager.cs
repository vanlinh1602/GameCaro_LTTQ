using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GameCaro
{
    class DatabaseManager
    {
        string ConnectionString = @"Data Source=DESKTOP-OQUHPJ9\LINHSQL;Initial Catalog=GameCaro;Integrated Security=True";
        public DatabaseManager()
        {

        }
        public DataTable GetData(string name)
        {
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = @"SELECT * FROM dbo.HistoryGacha where name = @name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            SqlDataReader sqlData = command.ExecuteReader();
            data.Load(sqlData);
            connection.Close();
            return data;
        }
        public void AddItems(string name, string vatpham)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = @"INSERT HistoryGacha VALUES(@Player,@Ngay,@VatPham)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Player", name);
            command.Parameters.AddWithValue("@Ngay", DateTime.Now);
            command.Parameters.AddWithValue("@VatPham", vatpham);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddPlayer(string name)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = @"INSERT PLayer VALUES(@name)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            try
            {
                command.ExecuteNonQuery();
            }
            catch { }
            connection.Close();
        }
    }
}

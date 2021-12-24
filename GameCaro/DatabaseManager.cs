using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GameCaro
{
    class DatabaseManager
    {
        //string ConnectionString = @"Data Source=DESKTOP-OQUHPJ9\LINHSQL;Initial Catalog=GameCaro;Integrated Security=True";
        string ConnectionString = @"Data Source=MSI;Initial Catalog=GameCaro;Integrated Security=True";
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

        public DataTable GetHistory(string name)
        {
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = @"SELECT * FROM dbo.History where player1 = @name or player2 = @name";
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

        public void AddHistory(string player1, string player2)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = @"INSERT History VALUES(@Date, @Player1, @Point1, @Point2, @Player2)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Date", GameManager.time);
            command.Parameters.AddWithValue("@Player1", player1);
            command.Parameters.AddWithValue("@Point1", 0);
            command.Parameters.AddWithValue("@Point2", 0);
            command.Parameters.AddWithValue("@Player2", player2);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateHistory(string player1, string player2, int winner, int point)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query1 = @"UPDATE History
                             SET point1 = @point
                             WHERE player1 = @Player1 AND player2 = @Player2";
            string query2 = @"UPDATE History
                             SET point2 = @point
                             WHERE player1 = @Player1 AND player2 = @Player2";
            string query;
            if (winner == 1)
                query = query1;
            else
                query = query2;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@point", point);
            command.Parameters.AddWithValue("@Player1", player1);
            command.Parameters.AddWithValue("@Player2", player2);
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

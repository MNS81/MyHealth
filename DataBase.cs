using MySql.Data.MySqlClient;

namespace MyHealth
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=sql11.freesqldatabase.com; port=3306; username=sql11672722; password=SNI8RMCUH9; database=sql11672722");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection() => connection;
    }
}

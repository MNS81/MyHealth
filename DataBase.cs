using MySql.Data.MySqlClient;

namespace MyHealth
{
    public class DataBase
    {
        MySqlConnection connection = new MySqlConnection($"server={Key.SERVER};port={Key.PORT};username={Key.USER};password={Key.PASS};database={Key.BASE}");
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

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MyHealth
{
    public partial class Login : Form
    {
        public Login() => InitializeComponent();

        private void CancelButton_Click(object sender, EventArgs e) => this.Close();

        private void OKButton_Click(object sender, EventArgs e)
        {
            string userLogin = LoginInput.Text;
            string userPassWord = PassWordInput.Text;
            DataBase DB = new DataBase();
            DataTable DT = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("select * from `users` where `username` = @ul and `password` = @up", DB.GetConnection());
            cmd.Parameters.Add("@ul", MySqlDbType.VarChar).Value = userLogin;
            cmd.Parameters.Add("@up", MySqlDbType.VarChar).Value = userPassWord;
            adapter.SelectCommand = cmd;
            adapter.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                MessageBox.Show($"Привет {userLogin}!");
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["USER"].Value = userLogin;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else
                MessageBox.Show($"Пользователь {userLogin} не найден!");
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            string userLogin = LoginInput.Text;
            string userPassWord = PassWordInput.Text;
            DataBase DB = new DataBase();
            MySqlCommand cmd = new MySqlCommand("insert into `users` (`username`, `password`) values (@ul, @up)", DB.GetConnection());
            cmd.Parameters.Add("@ul", MySqlDbType.VarChar).Value = userLogin;
            cmd.Parameters.Add("@up", MySqlDbType.VarChar).Value = userPassWord;
            DB.OpenConnection();
            MessageBox.Show(cmd.ExecuteNonQuery() == 1 ? $"Новый пользователь {userLogin} создан" : "Ошибка создания пользователя!");
            DB.CloseConnection();
        }
    }
}
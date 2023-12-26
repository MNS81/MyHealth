using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MyHealth
{
    public partial class Login : Form
    {
        public Login() => InitializeComponent();

        private void CancelButton_Click(object sender, EventArgs e) => this.Close();

        private bool CheckValues() => LoginInput.Text != "" && PassWordInput.Text != "";

        private async void OKButton_Click(object sender, EventArgs e)
        {
            LoginStatusLabel.Text = "";
            if (CheckValues() == true)
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
                    LoginStatusLabel.Text = $"Привет {userLogin}!";
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["USER"].Value = userLogin;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    await Task.Delay(2000);
                    this.Close();
                }
                else
                    LoginStatusLabel.Text = $"Пользователь {userLogin} не найден!";
            }
            else
                LoginStatusLabel.Text = "Проверьте введённые данные!";
            await Task.Delay(2000);
            LoginStatusLabel.Text = "";

        }

        private async void NewUserButton_Click(object sender, EventArgs e)
        {
            LoginStatusLabel.Text = "";
            DialogResult = MessageBox.Show("Зарегистрироваться?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                if (CheckValues() == true)
                {
                    string userLogin = LoginInput.Text;
                    string userPassWord = PassWordInput.Text;
                    DataBase DB = new DataBase();
                    MySqlCommand cmd = new MySqlCommand("insert into `users` (`username`, `password`) values (@ul, @up)", DB.GetConnection());
                    cmd.Parameters.Add("@ul", MySqlDbType.VarChar).Value = userLogin;
                    cmd.Parameters.Add("@up", MySqlDbType.VarChar).Value = userPassWord;
                    DB.OpenConnection();
                    LoginStatusLabel.Text = cmd.ExecuteNonQuery() == 1 ? $"Новый пользователь {userLogin} создан" : "Ошибка создания пользователя!";
                    DB.CloseConnection();
                }
                else
                    LoginStatusLabel.Text = "Проверьте введённые данные!";
            }
            else
                LoginStatusLabel.Text = "Отмена регистрации";
            await Task.Delay(2000);
            LoginStatusLabel.Text = "";
        }
    }
}
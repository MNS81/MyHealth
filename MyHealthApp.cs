using MySql.Data.MySqlClient;
using System.Configuration;

namespace MyHealth
{
    public partial class MyHealthApp : Form
    {
        public MyHealthApp()
        {
            InitializeComponent();
            ClearInputFields();
        }

        private void ChangeUserButton_Click(object sender, EventArgs e)
        {
            Login User = new Login();
            User.Show();
        }

        private void WriteValuesButton_Click(object sender, EventArgs e)
        {
            string upPressure = UpPressureValueInput.Text;
            string lowPressure = LowPressureValueInput.Text;
            string heartRate = HeartRateValueInput.Text;
            string health = "";
            string[] dateTime = DateTime.Now.ToString().Split();
            List<string> healthState = new List<string>();
            if (checkBox1.Checked) { healthState.Add("forehead"); }
            if (checkBox2.Checked) { healthState.Add("backhead"); }
            if (checkBox3.Checked) { healthState.Add("temples"); }
            if (checkBox4.Checked) { healthState.Add("neck"); }
            if (checkBox5.Checked) { healthState.Add("mud"); }
            if (healthState.Count > 0)
                health = String.Join(", ", healthState);
            else
                health = "All OK!";
            if (upPressure == "0" || lowPressure == "0" || heartRate == "0" || upPressure == "" || lowPressure == "" || heartRate == "")
                toolStripStatusLabel1.Text = "Проверьте введённые данные!!!";
            else
            {
                DataBase DB = new DataBase();
                MySqlCommand cmd = new MySqlCommand("insert into `healthstate` (`username`, `date`, `time`, `up_pressure`, `low_pressure`, `heartrate`, `healthstate`) values (@un, @ud, @ut, @uu, @ul, @uh, @us)", DB.GetConnection());
                cmd.Parameters.Add("@un", MySqlDbType.VarChar).Value = ConfigurationManager.AppSettings["USER"];
                cmd.Parameters.Add("@ud", MySqlDbType.VarChar).Value = dateTime[0];
                cmd.Parameters.Add("@ut", MySqlDbType.VarChar).Value = dateTime[1];
                cmd.Parameters.Add("@uu", MySqlDbType.Int32).Value = upPressure;
                cmd.Parameters.Add("@ul", MySqlDbType.Int32).Value = lowPressure;
                cmd.Parameters.Add("@uh", MySqlDbType.Int32).Value = heartRate;
                cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = health;
                DB.OpenConnection();
                toolStripStatusLabel1.Text = cmd.ExecuteNonQuery() == 1 ? "Данные записаны" : "Ошибка записи данных!";
                DB.CloseConnection();
            }
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            UpPressureValueInput.Text = "";
            LowPressureValueInput.Text = "";
            HeartRateValueInput.Text = "";
        }

        private void ViewHealthBookButton_Click(object sender, EventArgs e)
        {
            ViewTable table = new ViewTable();
            table.Show();
        }
    }
}

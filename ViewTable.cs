using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MyHealth
{
    public partial class ViewTable : Form
    {
        public ViewTable() => InitializeComponent();

        private void ViewTable_Load(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DataTable DT = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("select * from `healthstate` where username = @ul order by id desc", DB.GetConnection());
            cmd.Parameters.Add("@ul", MySqlDbType.VarChar).Value = ConfigurationManager.AppSettings["USER"];
            adapter.SelectCommand = cmd;
            adapter.Fill(DT);
            dataGridView1.DataSource = DT;
        }
    }
}
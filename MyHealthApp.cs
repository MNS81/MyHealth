namespace MyHealth
{
    public partial class MyHealthApp : Form
    {
        public MyHealthApp()
        {
            InitializeComponent();
            UpPressureValueInput.Text = "";
            LowPressureValueInput.Text = "";
            HeartRateValueInput.Text = "";
        }
        public void ChangeUserButton_Click(object sender, EventArgs e)
        {
            Login User = new Login();
            User.Show();
        }
    }
}

using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace TicketSystem.Desktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44345/")
            };

            var response = await client.PostAsJsonAsync("api/auth/login", new
            {
                email = txtEmail.Text,
                password = txtPassword.Text
            });

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Login Successful");

                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
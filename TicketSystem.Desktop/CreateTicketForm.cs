using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace TicketSystem.Desktop
{
    public partial class CreateTicketForm : Form
    {
        public CreateTicketForm()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44345/")
            };

            var ticket = new
            {
                title = txtTitle.Text,
                description = txtDescription.Text,
                priority = cmbPriority.Text
            };

            var response = await client.PostAsJsonAsync("api/ticket?userId=1", ticket);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket Created Successfully");
                txtTitle.Clear();
                txtDescription.Clear();
                cmbPriority.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Error creating ticket");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem.Desktop
{
    public partial class TicketListForm : Form
    {
        public TicketListForm()
        {
            InitializeComponent();

            // ✅ Better row selection
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TicketListForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Open");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Closed");
        }

        // ✅ LOAD BUTTON (CLEAN)
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadTickets();
        }

        // ✅ MAIN LOAD METHOD (SINGLE SOURCE)
        private async Task LoadTickets()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44345/");

                var response = await client.GetStringAsync("api/ticket?userId=1&role=Admin");

                var tickets = JsonSerializer.Deserialize<List<TicketModel>>(response, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                // ✅ Clear + reload grid
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = tickets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tickets: " + ex.Message);
            }
        }

        //  ASSIGN TICKET
        private async void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Check selection
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a ticket first");
                    return;
                }

                // 2. Get Ticket ID
                int ticketId = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["Id"].Value
                );

                // 3. Validate User ID
                if (string.IsNullOrEmpty(txtAssignUserId.Text))
                {
                    MessageBox.Show("Enter User ID");
                    return;
                }

                int userId = Convert.ToInt32(txtAssignUserId.Text);

                // 4. Call API
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44345/");

                var response = await client.PutAsync(
                    $"api/ticket/assign?ticketId={ticketId}&userId={userId}",
                    null
                );

                // 5. Response handling
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(" Ticket Assigned Successfully");

                    //  Refresh grid
                    await LoadTickets();
                }
                else
                {
                    MessageBox.Show("❌ Failed to assign ticket");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a ticket first");
                    return;
                }

                int ticketId = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["Id"].Value
                );

                string status = cmbStatus.SelectedItem?.ToString(); 

                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Select status");
                    return;
                }

                
                MessageBox.Show($"TicketId: {ticketId}, Status: {status}");

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44345/");

                var response = await client.PutAsync(
                    $"api/ticket/status?ticketId={ticketId}&status={status}",
                    null
                );

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(" Status Updated");
                    await LoadTickets(); // refresh grid
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(" Failed: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
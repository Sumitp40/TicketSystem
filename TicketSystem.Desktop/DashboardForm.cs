using System;
using System.Windows.Forms;

namespace TicketSystem.Desktop
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateTicketForm().Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new TicketListForm().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
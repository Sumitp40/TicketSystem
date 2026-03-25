namespace TicketSystem.Desktop
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnCreate
            this.btnCreate.Location = new System.Drawing.Point(120, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 30);
            this.btnCreate.Text = "Create Ticket";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            // btnView
            this.btnView.Location = new System.Drawing.Point(120, 150);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(150, 30);
            this.btnView.Text = "View Tickets";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(120, 200);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 30);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnLogout);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnLogout;
    }
}
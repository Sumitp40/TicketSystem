namespace TicketSystem.Desktop
{
    partial class CreateTicketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1 - Title
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Text = "Title";

            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(180, 60);
            this.txtTitle.Size = new System.Drawing.Size(200, 23);

            // label2 - Description
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 110);
            this.label2.Text = "Description";

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(180, 110);
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.Multiline = true;

            // label3 - Priority
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 190);
            this.label3.Text = "Priority";

            // cmbPriority
            this.cmbPriority.Location = new System.Drawing.Point(180, 190);
            this.cmbPriority.Size = new System.Drawing.Size(200, 23);
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Items.AddRange(new object[] {
                "Low",
                "Medium",
                "High"
            });

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(200, 240);
            this.btnSubmit.Size = new System.Drawing.Size(120, 35);
            this.btnSubmit.Text = "Create Ticket";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.btnSubmit);
            this.Text = "Create Ticket";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Button btnSubmit;
    }
}
namespace TicketSystem.Desktop
{
    partial class TicketListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            txtAssignUserId = new TextBox();
            btnAssign = new Button();
            cmbStatus = new ComboBox();
            btnUpdateStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 392);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(120, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Tickets";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(943, 355);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtAssignUserId
            // 
            txtAssignUserId.Location = new Point(432, 393);
            txtAssignUserId.Name = "txtAssignUserId";
            txtAssignUserId.Size = new Size(120, 23);
            txtAssignUserId.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(446, 422);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(97, 23);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Ticket";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(785, 392);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 5;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(802, 421);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(93, 23);
            btnUpdateStatus.TabIndex = 6;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // TicketListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 551);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnAssign);
            Controls.Add(txtAssignUserId);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Name = "TicketListForm";
            Text = "TicketListForm";
            Load += TicketListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLoad;
        private DataGridView dataGridView1;
        private TextBox txtAssignUserId;
        private Button btnAssign;
        private ComboBox cmbStatus;
        private Button button1;
        private Button btnUpdateStatus;
    }
}
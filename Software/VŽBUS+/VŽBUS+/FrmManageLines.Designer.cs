namespace VŽBUS_
{
    partial class FrmManageLines
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvLines;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtDepartureTime;
        private System.Windows.Forms.TextBox txtArrivalTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblArrivalTime;

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
            this.dgvLines = new System.Windows.Forms.DataGridView();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtDepartureTime = new System.Windows.Forms.TextBox();
            this.txtArrivalTime = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLines
            // 
            this.dgvLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLines.Location = new System.Drawing.Point(12, 12);
            this.dgvLines.Name = "dgvLines";
            this.dgvLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLines.Size = new System.Drawing.Size(760, 200);
            this.dgvLines.TabIndex = 0;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(12, 250);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(118, 250);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(100, 20);
            this.txtDestination.TabIndex = 2;
            // 
            // txtDepartureTime
            // 
            this.txtDepartureTime.Location = new System.Drawing.Point(224, 250);
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(100, 20);
            this.txtDepartureTime.TabIndex = 3;
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(330, 250);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(100, 20);
            this.txtArrivalTime.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(448, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(529, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(610, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 234);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(52, 13);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "Polazište:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(118, 234);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(55, 13);
            this.lblDestination.TabIndex = 9;
            this.lblDestination.Text = "Odredište:";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(224, 234);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(84, 13);
            this.lblDepartureTime.TabIndex = 10;
            this.lblDepartureTime.Text = "Vrijeme polaska:";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Location = new System.Drawing.Point(330, 234);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(84, 13);
            this.lblArrivalTime.TabIndex = 11;
            this.lblArrivalTime.Text = "Vrijeme dolaska:";
            // 
            // FrmManageLines
            // 
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(784, 300);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtArrivalTime);
            this.Controls.Add(this.txtDepartureTime);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.dgvLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageLines";
            this.Text = "Upravljanje linijama";
            this.Load += new System.EventHandler(this.FrmManageLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

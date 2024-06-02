namespace VŽBUS_
{
    partial class FrmManageBuses
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvBuses;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRegistrationNumber;
        private System.Windows.Forms.Label lblCapacity;

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
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuses
            // 
            this.dgvBuses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuses.Location = new System.Drawing.Point(12, 12);
            this.dgvBuses.Name = "dgvBuses";
            this.dgvBuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuses.Size = new System.Drawing.Size(500, 150);
            this.dgvBuses.TabIndex = 0;
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(123, 172);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(126, 20);
            this.txtRegistrationNumber.TabIndex = 2;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(123, 198);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(126, 20);
            this.txtCapacity.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 224);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Location = new System.Drawing.Point(12, 175);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(92, 13);
            this.lblRegistrationNumber.TabIndex = 1;
            this.lblRegistrationNumber.Text = "Registracijski broj:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(12, 201);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(55, 13);
            this.lblCapacity.TabIndex = 3;
            this.lblCapacity.Text = "Kapacitet:";
            // 
            // FrmManageBuses
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtRegistrationNumber);
            this.Controls.Add(this.lblRegistrationNumber);
            this.Controls.Add(this.dgvBuses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageBuses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje autobusima";
            this.Load += new System.EventHandler(this.FrmManageBuses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

namespace VŽBUS_
{
    partial class FrmManageStations
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvStations;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;

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
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStations
            // 
            this.dgvStations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStations.Location = new System.Drawing.Point(12, 12);
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStations.Size = new System.Drawing.Size(500, 150);
            this.dgvStations.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 172);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(69, 198);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(241, 20);
            this.txtLocation.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 224);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 175);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naziv:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 201);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(50, 13);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Lokacija:";
            // 
            // FrmManageStations
            // 
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvStations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageStations";
            this.Text = "Upravljanje stanicama";
            this.Load += new System.EventHandler(this.FrmManageStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

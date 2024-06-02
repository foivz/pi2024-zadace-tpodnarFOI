namespace VŽBUS_
{
    partial class FrmManageTickets
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
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblLineId = new System.Windows.Forms.Label();
            this.txtLineId = new System.Windows.Forms.TextBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.lblIssueTime = new System.Windows.Forms.Label();
            this.txtIssueTime = new System.Windows.Forms.TextBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(12, 12);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(760, 200);
            this.dgvTickets.TabIndex = 0;
            this.dgvTickets.SelectionChanged += new System.EventHandler(this.dgvTickets_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 261);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(67, 13);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "ID Korisnika:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(87, 258);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 5;
            // 
            // lblLineId
            // 
            this.lblLineId.AutoSize = true;
            this.lblLineId.Location = new System.Drawing.Point(193, 261);
            this.lblLineId.Name = "lblLineId";
            this.lblLineId.Size = new System.Drawing.Size(48, 13);
            this.lblLineId.TabIndex = 6;
            this.lblLineId.Text = "ID Linije:";
            // 
            // txtLineId
            // 
            this.txtLineId.Location = new System.Drawing.Point(245, 258);
            this.txtLineId.Name = "txtLineId";
            this.txtLineId.Size = new System.Drawing.Size(100, 20);
            this.txtLineId.TabIndex = 7;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(351, 261);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(89, 13);
            this.lblIssueDate.TabIndex = 8;
            this.lblIssueDate.Text = "Datum izdavanja:";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(437, 258);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(100, 20);
            this.txtIssueDate.TabIndex = 9;
            // 
            // lblIssueTime
            // 
            this.lblIssueTime.AutoSize = true;
            this.lblIssueTime.Location = new System.Drawing.Point(543, 261);
            this.lblIssueTime.Name = "lblIssueTime";
            this.lblIssueTime.Size = new System.Drawing.Size(92, 13);
            this.lblIssueTime.TabIndex = 10;
            this.lblIssueTime.Text = "Vrijeme izdavanja:";
            // 
            // txtIssueTime
            // 
            this.txtIssueTime.Location = new System.Drawing.Point(641, 258);
            this.txtIssueTime.Name = "txtIssueTime";
            this.txtIssueTime.Size = new System.Drawing.Size(100, 20);
            this.txtIssueTime.TabIndex = 11;
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(12, 297);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(45, 13);
            this.lblSeat.TabIndex = 12;
            this.lblSeat.Text = "Sjedalo:";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(62, 294);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(100, 20);
            this.txtSeat.TabIndex = 13;
            // 
            // FrmManageTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 332);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.txtIssueTime);
            this.Controls.Add(this.lblIssueTime);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.txtLineId);
            this.Controls.Add(this.lblLineId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageTickets";
            this.Text = "Upravljanje kartama";
            this.Load += new System.EventHandler(this.FrmManageTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblLineId;
        private System.Windows.Forms.TextBox txtLineId;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.Label lblIssueTime;
        private System.Windows.Forms.TextBox txtIssueTime;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.TextBox txtSeat;
    }
}

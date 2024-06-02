namespace VŽBUS_
{
    partial class FrmManageReservations
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblLineId = new System.Windows.Forms.Label();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.lblReservationTime = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtLineId = new System.Windows.Forms.TextBox();
            this.txtReservationDate = new System.Windows.Forms.TextBox();
            this.txtReservationTime = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(12, 12);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(760, 150);
            this.dgvReservations.TabIndex = 0;
            this.dgvReservations.SelectionChanged += new System.EventHandler(this.dgvReservations_SelectionChanged);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 181);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(66, 13);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "ID korisnika:";
            // 
            // lblLineId
            // 
            this.lblLineId.AutoSize = true;
            this.lblLineId.Location = new System.Drawing.Point(12, 207);
            this.lblLineId.Name = "lblLineId";
            this.lblLineId.Size = new System.Drawing.Size(44, 13);
            this.lblLineId.TabIndex = 2;
            this.lblLineId.Text = "ID linije:";
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.Location = new System.Drawing.Point(12, 233);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(95, 13);
            this.lblReservationDate.TabIndex = 3;
            this.lblReservationDate.Text = "Datum rezervacije:";
            // 
            // lblReservationTime
            // 
            this.lblReservationTime.AutoSize = true;
            this.lblReservationTime.Location = new System.Drawing.Point(12, 259);
            this.lblReservationTime.Name = "lblReservationTime";
            this.lblReservationTime.Size = new System.Drawing.Size(98, 13);
            this.lblReservationTime.TabIndex = 4;
            this.lblReservationTime.Text = "Vrijeme rezervacije:";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(12, 285);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(45, 13);
            this.lblSeat.TabIndex = 5;
            this.lblSeat.Text = "Sjedalo:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(113, 178);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 6;
            // 
            // txtLineId
            // 
            this.txtLineId.Location = new System.Drawing.Point(113, 204);
            this.txtLineId.Name = "txtLineId";
            this.txtLineId.Size = new System.Drawing.Size(100, 20);
            this.txtLineId.TabIndex = 7;
            // 
            // txtReservationDate
            // 
            this.txtReservationDate.Location = new System.Drawing.Point(113, 230);
            this.txtReservationDate.Name = "txtReservationDate";
            this.txtReservationDate.Size = new System.Drawing.Size(100, 20);
            this.txtReservationDate.TabIndex = 8;
            // 
            // txtReservationTime
            // 
            this.txtReservationTime.Location = new System.Drawing.Point(113, 256);
            this.txtReservationTime.Name = "txtReservationTime";
            this.txtReservationTime.Size = new System.Drawing.Size(100, 20);
            this.txtReservationTime.TabIndex = 9;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(113, 282);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(100, 20);
            this.txtSeat.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.txtReservationTime);
            this.Controls.Add(this.txtReservationDate);
            this.Controls.Add(this.txtLineId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.lblReservationTime);
            this.Controls.Add(this.lblReservationDate);
            this.Controls.Add(this.lblLineId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.dgvReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageReservations";
            this.Text = "Upravljanje rezervacijama";
            this.Load += new System.EventHandler(this.FrmManageReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblLineId;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.Label lblReservationTime;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtLineId;
        private System.Windows.Forms.TextBox txtReservationDate;
        private System.Windows.Forms.TextBox txtReservationTime;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
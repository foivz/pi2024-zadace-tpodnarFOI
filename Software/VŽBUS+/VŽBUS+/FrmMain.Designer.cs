namespace VŽBUS_
{
    partial class FrmMain
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
            this.btnManageBuses = new System.Windows.Forms.Button();
            this.btnManagePassengers = new System.Windows.Forms.Button();
            this.btnManageLines = new System.Windows.Forms.Button();
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.btnManageStations = new System.Windows.Forms.Button();
            this.btnManageTickets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageBuses
            // 
            this.btnManageBuses.Location = new System.Drawing.Point(274, 43);
            this.btnManageBuses.Name = "btnManageBuses";
            this.btnManageBuses.Size = new System.Drawing.Size(150, 30);
            this.btnManageBuses.TabIndex = 5;
            this.btnManageBuses.Text = "Upravljanje autobusima";
            this.btnManageBuses.UseVisualStyleBackColor = true;
            this.btnManageBuses.Click += new System.EventHandler(this.btnManageBuses_Click);
            // 
            // btnManagePassengers
            // 
            this.btnManagePassengers.Location = new System.Drawing.Point(274, 93);
            this.btnManagePassengers.Name = "btnManagePassengers";
            this.btnManagePassengers.Size = new System.Drawing.Size(150, 30);
            this.btnManagePassengers.TabIndex = 4;
            this.btnManagePassengers.Text = "Popis registriranih putnika";
            this.btnManagePassengers.UseVisualStyleBackColor = true;
            this.btnManagePassengers.Click += new System.EventHandler(this.btnManagePassengers_Click);
            // 
            // btnManageLines
            // 
            this.btnManageLines.Location = new System.Drawing.Point(274, 143);
            this.btnManageLines.Name = "btnManageLines";
            this.btnManageLines.Size = new System.Drawing.Size(150, 30);
            this.btnManageLines.TabIndex = 3;
            this.btnManageLines.Text = "Upravljanje linijama";
            this.btnManageLines.UseVisualStyleBackColor = true;
            this.btnManageLines.Click += new System.EventHandler(this.btnManageLines_Click);
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.Location = new System.Drawing.Point(274, 193);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(150, 30);
            this.btnManageReservations.TabIndex = 2;
            this.btnManageReservations.Text = "Upravljanje rezervacijama";
            this.btnManageReservations.UseVisualStyleBackColor = true;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // btnManageStations
            // 
            this.btnManageStations.Location = new System.Drawing.Point(274, 243);
            this.btnManageStations.Name = "btnManageStations";
            this.btnManageStations.Size = new System.Drawing.Size(150, 30);
            this.btnManageStations.TabIndex = 1;
            this.btnManageStations.Text = "Upravljanje stanicama";
            this.btnManageStations.UseVisualStyleBackColor = true;
            this.btnManageStations.Click += new System.EventHandler(this.btnManageStations_Click);
            // 
            // btnManageTickets
            // 
            this.btnManageTickets.Location = new System.Drawing.Point(274, 293);
            this.btnManageTickets.Name = "btnManageTickets";
            this.btnManageTickets.Size = new System.Drawing.Size(150, 30);
            this.btnManageTickets.TabIndex = 0;
            this.btnManageTickets.Text = "Upravljanje kartama";
            this.btnManageTickets.UseVisualStyleBackColor = true;
            this.btnManageTickets.Click += new System.EventHandler(this.btnManageTickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dobrodošli natrag, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(72, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Korisniče!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gdje cesta vodi, mi slijedimo.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(62, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vaš VŽBUS+";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManageTickets);
            this.Controls.Add(this.btnManageStations);
            this.Controls.Add(this.btnManageReservations);
            this.Controls.Add(this.btnManageLines);
            this.Controls.Add(this.btnManagePassengers);
            this.Controls.Add(this.btnManageBuses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VŽBUS+ | Početna";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnManageBuses;
        private System.Windows.Forms.Button btnManagePassengers;
        private System.Windows.Forms.Button btnManageLines;
        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Button btnManageStations;
        private System.Windows.Forms.Button btnManageTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

namespace CarParkC_.Forms
{
    partial class Spots
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
            this.dgvSpots = new System.Windows.Forms.DataGridView();
            this.SpotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpots)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpots
            // 
            this.dgvSpots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpotNumber,
            this.VehicleID,
            this.StatusFree});
            this.dgvSpots.Location = new System.Drawing.Point(331, 12);
            this.dgvSpots.Name = "dgvSpots";
            this.dgvSpots.Size = new System.Drawing.Size(457, 426);
            this.dgvSpots.TabIndex = 0;
            // 
            // SpotNumber
            // 
            this.SpotNumber.HeaderText = "Номер места";
            this.SpotNumber.Name = "SpotNumber";
            // 
            // VehicleID
            // 
            this.VehicleID.HeaderText = "ID автомобиля";
            this.VehicleID.Name = "VehicleID";
            // 
            // StatusFree
            // 
            this.StatusFree.HeaderText = "Занято ли место?";
            this.StatusFree.Name = "StatusFree";
            // 
            // Spots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSpots);
            this.Name = "Spots";
            this.Text = "ParkSpots";
            this.Load += new System.EventHandler(this.ParkSpots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpots;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusFree;
    }
}
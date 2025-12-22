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
            this.bExit = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDrop = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
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
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(12, 289);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(135, 45);
            this.bExit.TabIndex = 17;
            this.bExit.Text = "Выйти";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(12, 197);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(135, 45);
            this.bUpdate.TabIndex = 16;
            this.bUpdate.Text = "Изменить";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bDrop
            // 
            this.bDrop.Location = new System.Drawing.Point(12, 106);
            this.bDrop.Name = "bDrop";
            this.bDrop.Size = new System.Drawing.Size(135, 45);
            this.bDrop.TabIndex = 15;
            this.bDrop.Text = "Удалить";
            this.bDrop.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(12, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(135, 45);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // Spots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDrop);
            this.Controls.Add(this.bAdd);
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
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDrop;
        private System.Windows.Forms.Button bAdd;
    }
}
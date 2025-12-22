namespace CarParkC_.Forms
{
    partial class Vehicles
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bExit = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDrop = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleID,
            this.ClientID,
            this.Brand,
            this.VehicleType,
            this.CarLicense});
            this.dgvVehicles.Location = new System.Drawing.Point(331, 12);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.Size = new System.Drawing.Size(457, 426);
            this.dgvVehicles.TabIndex = 1;
            // 
            // VehicleID
            // 
            this.VehicleID.HeaderText = "ID автомобиля";
            this.VehicleID.Name = "VehicleID";
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "ID клиента";
            this.ClientID.Name = "ClientID";
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Бренд автомобиля";
            this.Brand.Name = "Brand";
            // 
            // VehicleType
            // 
            this.VehicleType.HeaderText = "Тип автомобиля";
            this.VehicleType.Name = "VehicleType";
            // 
            // CarLicense
            // 
            this.CarLicense.HeaderText = "Номер автомобиля";
            this.CarLicense.Name = "CarLicense";
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(12, 289);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(135, 45);
            this.bExit.TabIndex = 13;
            this.bExit.Text = "Выйти";
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(12, 197);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(135, 45);
            this.bUpdate.TabIndex = 12;
            this.bUpdate.Text = "Изменить";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bDrop
            // 
            this.bDrop.Location = new System.Drawing.Point(12, 106);
            this.bDrop.Name = "bDrop";
            this.bDrop.Size = new System.Drawing.Size(135, 45);
            this.bDrop.TabIndex = 11;
            this.bDrop.Text = "Удалить";
            this.bDrop.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(12, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(135, 45);
            this.bAdd.TabIndex = 10;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDrop);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarLicense;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDrop;
        private System.Windows.Forms.Button bAdd;
    }
}
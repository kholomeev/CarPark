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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Spots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
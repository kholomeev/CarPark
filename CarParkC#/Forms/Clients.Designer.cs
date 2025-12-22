namespace CarParkC_.Forms
{
    partial class Clients
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bExit = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDrop = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.Phone});
            this.dgvUsers.Location = new System.Drawing.Point(331, 12);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(457, 426);
            this.dgvUsers.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID клиента";
            this.ID.Name = "ID";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "ФИО клиента";
            this.UserName.Name = "UserName";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Номер телефона";
            this.Phone.Name = "Phone";
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(12, 289);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(135, 45);
            this.bExit.TabIndex = 17;
            this.bExit.Text = "Выйти";
            this.bExit.UseVisualStyleBackColor = true;
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
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDrop);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgvUsers);
            this.Name = "Clients";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDrop;
        private System.Windows.Forms.Button bAdd;
    }
}
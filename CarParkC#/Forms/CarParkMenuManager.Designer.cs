namespace CarParkC_
{
    partial class CarParkMenuManager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bUsersTable = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.bSpotsTable = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bVehiclesTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bHelp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bUsersTable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bSpotsTable, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bExit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bVehiclesTable, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 373);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вас приветствует программа \"Автостоянка\"";
            // 
            // bUsersTable
            // 
            this.bUsersTable.Location = new System.Drawing.Point(3, 189);
            this.bUsersTable.Name = "bUsersTable";
            this.bUsersTable.Size = new System.Drawing.Size(260, 45);
            this.bUsersTable.TabIndex = 4;
            this.bUsersTable.Text = "Пользователи";
            this.bUsersTable.UseVisualStyleBackColor = true;
            this.bUsersTable.Click += new System.EventHandler(this.bUsersTable_Click);
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(3, 282);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(260, 45);
            this.bHelp.TabIndex = 1;
            this.bHelp.Text = "Справка";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // bSpotsTable
            // 
            this.bSpotsTable.Location = new System.Drawing.Point(269, 189);
            this.bSpotsTable.Name = "bSpotsTable";
            this.bSpotsTable.Size = new System.Drawing.Size(260, 45);
            this.bSpotsTable.TabIndex = 6;
            this.bSpotsTable.Text = "Места";
            this.bSpotsTable.UseVisualStyleBackColor = true;
            this.bSpotsTable.Click += new System.EventHandler(this.bSpotsTable_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(535, 282);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(262, 45);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bVehiclesTable
            // 
            this.bVehiclesTable.Location = new System.Drawing.Point(535, 189);
            this.bVehiclesTable.Name = "bVehiclesTable";
            this.bVehiclesTable.Size = new System.Drawing.Size(262, 45);
            this.bVehiclesTable.TabIndex = 5;
            this.bVehiclesTable.Text = "Автомобили";
            this.bVehiclesTable.UseVisualStyleBackColor = true;
            this.bVehiclesTable.Click += new System.EventHandler(this.bVehiclesTable_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(284, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Здравствуйте, менеджер БД";
            // 
            // CarParkMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CarParkMenuManager";
            this.Text = "Главное меню";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bUsersTable;
        private System.Windows.Forms.Button bVehiclesTable;
        private System.Windows.Forms.Button bSpotsTable;
        private System.Windows.Forms.Label label2;
    }
}
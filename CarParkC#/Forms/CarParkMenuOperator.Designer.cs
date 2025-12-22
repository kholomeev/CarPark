namespace CarParkC_.Forms
{
    partial class CarParkMenuOperator
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
            this.bHelp = new System.Windows.Forms.Button();
            this.bTickets = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bNotification = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bHelp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bExit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bNotification, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bTickets, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вас приветствует программа \"Автостоянка\"";
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(3, 282);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(393, 43);
            this.bHelp.TabIndex = 1;
            this.bHelp.Text = "Справка";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // bTickets
            // 
            this.bTickets.Location = new System.Drawing.Point(3, 189);
            this.bTickets.Name = "bTickets";
            this.bTickets.Size = new System.Drawing.Size(393, 43);
            this.bTickets.TabIndex = 3;
            this.bTickets.Text = "Выдача билета";
            this.bTickets.UseVisualStyleBackColor = true;
            this.bTickets.Click += new System.EventHandler(this.bTickets_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(402, 282);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(395, 43);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bNotification
            // 
            this.bNotification.Location = new System.Drawing.Point(402, 189);
            this.bNotification.Name = "bNotification";
            this.bNotification.Size = new System.Drawing.Size(395, 43);
            this.bNotification.TabIndex = 4;
            this.bNotification.Text = "Уведомить пользователя";
            this.bNotification.UseVisualStyleBackColor = true;
            this.bNotification.Click += new System.EventHandler(this.bNotification_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(301, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Здравствуйте, оператор";
            // 
            // CarParkMenuOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CarParkMenuOperator";
            this.Text = "Главное меню";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bTickets;
        private System.Windows.Forms.Button bNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
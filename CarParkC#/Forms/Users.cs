using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkC_.Forms
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "DataSource=carpark.db";
                var connection = new SqliteConnection(connectionString);
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT INTO USERS(name, phone)
                     VALUES('Турмалинов Е.Р.', '+7 989 325 88 33');

                    SELECT * FROM USERS;
                ";

                var reader = command.ExecuteReader();

                dgvUsers.Rows.Clear();

                while (reader.Read())
                {
                    dgvUsers.Rows.Add(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2)
                    );
                }

                command.ExecuteNonQuery();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}

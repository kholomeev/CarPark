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
    public partial class Spots : Form
    {
        public Spots()
        {
            InitializeComponent();
        }

        private void ParkSpots_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "DataSource=carpark.db";
                var connection = new SqliteConnection(connectionString);
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT INTO PARKSPOTS(vehicle_id, statusFree)
                     VALUES(1, true);

                    SELECT * FROM PARKSPOTS;
                ";

                var reader = command.ExecuteReader();

                dgvSpots.Rows.Clear();

                while (reader.Read())
                {
                    dgvSpots.Rows.Add(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetBoolean(2)
                    );
                }

                reader.Close();
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

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}

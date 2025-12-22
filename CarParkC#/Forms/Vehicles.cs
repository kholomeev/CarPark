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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "DataSource=carpark.db";
                var connection = new SqliteConnection(connectionString);
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT INTO VEHICLES(client_id, brand, vehicleType, carLicense)
                     VALUES(1, 'Nissan', 'Легковой автомобиль', 'А111ТВ 78RUS');

                    SELECT * FROM VEHICLES;
                ";

                var reader = command.ExecuteReader();

                dgvVehicles.Rows.Clear();

                while (reader.Read())
                {
                    dgvVehicles.Rows.Add(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
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
    }
}

using CarParkC_.Classes;
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
using System.Xml.Linq;

namespace CarParkC_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) ||
                string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            try
            {
                var db = new DatabaseService();

                if (db.CheckUser(tbUsername.Text, tbPassword.Text))
                {
                    Hide();
                    new CarParkMenuManager().Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин и пароль");
                }
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "DataSource=carpark.db";
                var connection = new SqliteConnection(connectionString);
                connection.Open();
                

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                PRAGMA foreign_keys = ON;
                
                CREATE TABLE IF NOT EXISTS CLIENT (
                  client_id INTEGER PRIMARY KEY,
                  name VARCHAR(30) NOT NULL,
                  phone VARCHAR(15) NOT NULL
                );
                
                CREATE TABLE IF NOT EXISTS VEHICLES (
                  vehicle_id INTEGER PRIMARY KEY,
                  client_id INTEGER NOT NULL,
                  brand VARCHAR(15) NOT NULL,
                  vehicleType VARCHAR(20) NOT NULL,
                  carLicense VARCHAR(20) NOT NULL,

                  FOREIGN KEY (client_id) REFERENCES CLIENT (client_id)
                );

                CREATE TABLE IF NOT EXISTS STAFF (
                  staff_id INTEGER PRIMARY KEY,
                  name VARCHAR(30) NOT NULL,
                  staff_title VARCHAR(20) NOT NULL,
                  pass TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS PARKSPOT (
                  spot_number INTEGER PRIMARY KEY,
                  vehicle_id INTEGER NOT NULL,
                  statusFree BOOL NOT NULL,

                  FOREIGN KEY (vehicle_id) REFERENCES VEHICLES (vehicle_id)
                );

            ";
                // INSERT OR IGNORE INTO STAFF(name, staff_title, pass)
                //  VALUES('Kirill', 'Менеджер БД', 'PassW0rd');
                // INSERT OR IGNORE INTO STAFF(name, staff_title, pass)
                //  VALUES('Kirill2', 'Оператор', 'PassW0rd');

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

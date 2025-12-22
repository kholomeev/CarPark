using CarParkC_.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkC_
{
    public partial class CarParkMenuManager : Form
    {
        public CarParkMenuManager()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я забыр");
        }

        private void bUsersTable_Click(object sender, EventArgs e)
        {
            Hide();
            new Users().Show();
        }

        private void bSpotsTable_Click(object sender, EventArgs e)
        {
            Hide();
            new ParkSpots().Show();
        }

        private void bVehiclesTable_Click(object sender, EventArgs e)
        {
            Hide();
            new Vehicles().Show();
        }
    }
}

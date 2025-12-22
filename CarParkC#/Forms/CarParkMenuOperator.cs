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
    public partial class CarParkMenuOperator : Form
    {
        public CarParkMenuOperator()
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

        private void bTickets_Click(object sender, EventArgs e)
        {
            Hide();
            new TicketToUser().Show();
        }

        private void bNotification_Click(object sender, EventArgs e)
        {
            Hide();
            new Notification().Show();
        }
    }
}

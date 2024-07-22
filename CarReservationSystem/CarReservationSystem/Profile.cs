using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReservationSystem
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void showCars_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();    
            profile.ShowDialog();
        }
    }
}

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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            Database db = new Database();
            if (db.addNewUser(textBoxUsernameR.Text, textBoxPasswordR.Text))
            {
                MessageBox.Show("Register Successful");
                this.Hide();
                LogIn logIn = new LogIn();
                logIn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUsernameR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordR_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}

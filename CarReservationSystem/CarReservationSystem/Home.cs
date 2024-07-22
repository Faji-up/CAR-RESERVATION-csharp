using MySql.Data.MySqlClient;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           
            createPanelCars();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            createPanelCars();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();    
            profile.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();

        }

        public void createPanelCars()
        {   
            Database db = new Database();

           
            int panelW = 200;
            int panelH = 150;
            int panelS = 20;
          
            List<Car> cars = db.getCars("SELECT id,car_name,price,description,image FROM `cars`");
            foreach (Car car in cars)
            {

            }
            
            
            for (int i = 0;i< cars.Count; i++)
            {
                Panel panel = new Panel();
                panel.Size = new System.Drawing.Size(panelW, panelH);
                panel.Location = new System.Drawing.Point(panelS + (panelW + panelS) * i, panelS);
                panel.BorderStyle = BorderStyle.FixedSingle;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(panelW, panelH - 20);
                pictureBox.Location = new System.Drawing.Point(0, 0);

                pictureBox.Image = null; // Properties.Resource.placeholder_image;

                Label label = new Label();
                label.Text = "Panel" + i;
                label.Size = new System.Drawing.Size(panelW, 20);
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.Location = new System.Drawing.Point(0,panelH - 20);

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                
                CarsCon.Controls.Add(panel);
                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void showCars_Click(object sender, EventArgs e)
        {
            
        }
    }
}

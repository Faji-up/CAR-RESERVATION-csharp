using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReservationSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdminHome());

            LogIn logIn = new LogIn();
            
            if (logIn.ShowDialog() == DialogResult.OK ) {
                
                Home home = new Home();
                home.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}

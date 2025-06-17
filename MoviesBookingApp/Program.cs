using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesBookingApp
{
    internal static class 
        Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a form to host the UserControl
           Dashboard_Sujal_ form = new Dashboard_Sujal_();


            Application.Run(form);
        }
    }
}
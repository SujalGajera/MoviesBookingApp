using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesBookingApp
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

            // Create a form to host the UserControl
            Form mainForm = new Form();
            mainForm.Text = "Prime Cinemas - Thank You";
            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.StartPosition = FormStartPosition.CenterScreen;

            // Add your thank you page to the form
            Prabh_s_thankyou_page thankYouPage = new Prabh_s_thankyou_page();
            thankYouPage.Dock = DockStyle.Fill;
            mainForm.Controls.Add(thankYouPage);

            Application.Run(mainForm);
        }
    }
}
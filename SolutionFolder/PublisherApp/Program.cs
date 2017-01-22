using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublisherApp
{
    static class Program
    {
        public static Publisher publisher = new Publisher();
        public static List<SendViaEmail> sendViaEmailList = new List<SendViaEmail>();
        public static List<SendViaMobile> sendViaMobileList = new List<SendViaMobile>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

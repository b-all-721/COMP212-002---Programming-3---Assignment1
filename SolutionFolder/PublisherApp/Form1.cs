using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublisherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_manageSubscription_Click(object sender, EventArgs e)
        {
            FormSubscription formSubscription = new FormSubscription();
            formSubscription.Show();

        }

        private void button_publishNotification_Click(object sender, EventArgs e)
        {
            FormNotification formNotification = new FormNotification();
            formNotification.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

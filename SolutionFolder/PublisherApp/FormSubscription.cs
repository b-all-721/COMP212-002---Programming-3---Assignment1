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
    public partial class FormSubscription : Form
    {
        public FormSubscription()
        {
            InitializeComponent();
        }

        private void button_subscribe_Click(object sender, EventArgs e)
        {
            // For email subscription.
            if (checkBox_sentByMail.Checked)
            {
                // Check if email is valid.
                if (textBox_email.Text == "")
                {
                    MessageBox.Show("Email can't be empty.");
                }
                else
                {
                    // Creat a new SendViaEmail object.
                    SendViaEmail sendViaEmailObj = new SendViaEmail(textBox_email.Text);

                    // Subscribe.
                    sendViaEmailObj.Subscribe(Program.publisher);

                    // Add the email from the textbox to the email list.
                    Program.sendViaEmailList.Add(sendViaEmailObj);

                    //
                    MessageBox.Show(textBox_email.Text + " subscribed.");
                }

            }


            // For mobile subscription.
        }
    }
}

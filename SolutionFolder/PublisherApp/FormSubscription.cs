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

        private void processEmail()
        {
            // For email subscription.
            if (checkBox_sentByMail.Checked)
            {
                string email = textBox_email.Text;

                // Check if email is valid.
                if (email == "")
                {
                    MessageBox.Show("Email can't be empty.");
                }
                else
                {
                    //// Creat a new SendViaEmail object for checking of its existence.
                    //SendViaEmail sendViaEmailObjTest = new SendViaEmail(email);

                    // Check existence.
                    foreach (SendViaEmail item in Program.sendViaEmailList)
                    {
                        if (item.getEmailAddr() == email)
                        {
                            //
                            MessageBox.Show(email + " is already subscribed.");
                            return;
                        }
                    }

                    // If the code gets here, create a new email subscription.
                    // Creat a new SendViaEmail object.
                    SendViaEmail sendViaEmailObj = new SendViaEmail(email);

                    // Subscribe.
                    sendViaEmailObj.Subscribe(Program.publisher);

                    // Add the email from the textbox to the email list.
                    Program.sendViaEmailList.Add(sendViaEmailObj);

                    //
                    MessageBox.Show(email + " subscribed.");
                }
            }
        }

        private void processMobile()
        {
            // For mobile subscription.
            if (checkBox_sentByMobile.Checked)
            {
                string mobile = textBox_mobile.Text;

                // Check if mobile is valid.
                if (mobile == "")
                {
                    MessageBox.Show("Mobile can't be empty.");
                }
                else
                {
                    // Check existence.
                    foreach (SendViaMobile item in Program.sendViaMobileList)
                    {
                        if (item.getMobile() == mobile)
                        {
                            //
                            MessageBox.Show(mobile + " is already subscribed.");
                            return;
                        }
                    }

                    // If the code gets here, create a new mobile subscription.
                    // Creat a new SendViaMobile object.
                    SendViaMobile sendViaMobileObj = new SendViaMobile(mobile);

                    // Subscribe.
                    sendViaMobileObj.Subscribe(Program.publisher);

                    // Add the mobile from the textbox to the mobile list.
                    Program.sendViaMobileList.Add(sendViaMobileObj);

                    //
                    MessageBox.Show(mobile + " subscribed.");
                }
            }
        }

        private void button_subscribe_Click(object sender, EventArgs e)
        {
            processEmail();
            processMobile();


        }

        private void button_unsubscribe_Click(object sender, EventArgs e)
        {
            //
            MessageBox.Show("button_unsubscribe pressed.");
        }
    }
}

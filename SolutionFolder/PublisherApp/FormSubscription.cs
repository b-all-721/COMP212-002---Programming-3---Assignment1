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

        /*
         * Go through all the checks to validate
         * the email.
         */
        private void processEmail()
        {
            // For email subscription.
            if (checkBox_sentByMail.Checked)
            {
                string email = textBox_email.Text;

                // Check if email is empty.
                if (email == "")
                {
                    MessageBox.Show("Email can't be empty.");
                }
                else
                {
                    // Check if the email already exists in the emailList.
                    foreach (SendViaEmail item in Program.sendViaEmailList)
                    {
                        if (item.getEmailAddr() == email)
                        {
                            //
                            MessageBox.Show(email + " is already subscribed.");
                            return;
                        }
                    }

                    // If the code gets here, that means the email
                    // entered passed all the test.
                    // So now, create a new email subscription and
                    // creat a new SendViaEmail object.
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
            processEmailToUnsubscribe();
            processMobileToUnsubscribe();
        }

        private void processMobileToUnsubscribe()
        {
            // Make sure the mobile checkbox is checked.
            if (checkBox_sentByMobile.Checked)
            {
                string mobile = textBox_mobile.Text;

                // Check if mobile is empty.
                if (mobile == "")
                {
                    MessageBox.Show("Mobile can't be empty.");
                }
                else
                {
                    // Check if the mobile exists in the mobileList.
                    foreach (SendViaMobile item in Program.sendViaMobileList)
                    {
                        if (item.getMobile() == mobile)
                        {
                            // Unsubscribe.
                            item.Unsubscribe(Program.publisher);

                            // Remove the item from the mobileList.
                            Program.sendViaMobileList.Remove(item);

                            //
                            MessageBox.Show(mobile + " was removed from the subscription list.");
                            return;
                        }
                    }

                    // If the code gets here, that means the mobile
                    // entered does not exist in the mobileList.
                    MessageBox.Show(mobile + " does not exist in the mobile list.");
                }
            }
        }

        private void processEmailToUnsubscribe()
        {
            // Make sure the email checkbox is checked.
            if (checkBox_sentByMail.Checked)
            {
                string email = textBox_email.Text;

                // Check if email is empty.
                if (email == "")
                {
                    MessageBox.Show("Email can't be empty.");
                }
                else
                {
                    // Check if the email exists in the emailList.
                    foreach (SendViaEmail item in Program.sendViaEmailList)
                    {
                        if (item.getEmailAddr() == email)
                        {
                            // Unsubscribe.
                            item.Unsubscribe(Program.publisher);

                            // Remove from the emailList.
                            Program.sendViaEmailList.Remove(item);
                            
                            // 
                            MessageBox.Show(email + " was removed from the subscription list.");
                            return;
                        }
                    }

                    // If the code gets here, that means the email
                    // entered does not exist in the emailList.
                    MessageBox.Show(email + " does not exist in the email list.");
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSubscription_Load(object sender, EventArgs e)
        {

        }
    }
}

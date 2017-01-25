using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublisherApp
{
    public class SendViaEmail
    {
        private String emailAddr;

        public SendViaEmail() { }

        public SendViaEmail(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public void setEmailAddr(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public String getEmailAddr()
        {
            return emailAddr;
        }

        public void sendEmail(string msg)
        {
            MessageBox.Show("The message" + "\"" + msg + "\" has already been sent to " + emailAddr);

        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;
        }

        public void Unsubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmail;
        }
    }
}

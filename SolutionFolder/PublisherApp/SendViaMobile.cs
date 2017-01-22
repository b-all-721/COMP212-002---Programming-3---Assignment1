using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublisherApp
{
    public class SendViaMobile
    {
        private String cellPhone;

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            cellPhone = phone;
        }

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        private void sendMessage(string msg)
        {
            //Console.WriteLine("The message "+ "\"" + msg+ "\" has already texted to " + cellPhone );
            MessageBox.Show("The message" + "\"" + msg + "\" has already been sent to " + cellPhone);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }
    }
}

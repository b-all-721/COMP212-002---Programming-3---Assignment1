using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherApp
{
    class SubscriptionList
    {
        public static List<SendViaEmail> sendViaEmailList = new List<SendViaEmail>();
        public static List<SendViaMobile> sendViaMobileList = new List<SendViaMobile>();
    }
}

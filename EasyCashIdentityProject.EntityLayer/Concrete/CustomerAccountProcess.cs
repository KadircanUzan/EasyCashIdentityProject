using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string CustomerAccountProcessType { get; set; }
        public decimal CustomerAccountProcessAmount { get; set; }
        public DateTime CustomerAccountProcessDate { get; set; }

        public int? CustomerSenderId { get; set; }
        public CustomerAccount SenderCustomer { get; set; }
        public int? CustomerReceiverId { get; set; }
        public CustomerAccount ReceiverCustomer { get; set; }
    }
}

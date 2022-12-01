using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_Application.Classes
{
    internal class CardHolder
    {
        public string cardNumber { get; set; }

        public int pin { get; set; }   
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }

        public double accountBalance { get; set; }   
    
    }
}

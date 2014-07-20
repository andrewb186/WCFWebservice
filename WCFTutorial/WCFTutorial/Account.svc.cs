using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFTutorial
{
   
    public class Account : IAccount
    {
        public string GetAccountNumber(string personID)
        {
            return "5000-3569852-248";
        }

    }
}

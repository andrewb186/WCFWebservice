using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WCFTutorial
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAccount" in both code and config file together.
    [ServiceContract]
    public interface IAccount
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "getaccountnumber/{personID}",
                   Method = "GET",
                   BodyStyle = WebMessageBodyStyle.Bare)]
        string GetAccountNumber(string personID);
    }
}

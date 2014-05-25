using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFTutorial.Objects;

namespace WCFTutorial
{
    [ServiceContract]
    public interface IPersonService
    {

        [OperationContract]
        [WebInvoke(UriTemplate="getname/{personID}", 
                   Method="GET",
                   BodyStyle=WebMessageBodyStyle.Bare)]
        string GetName(string personID);

        [OperationContract]
        [WebInvoke(UriTemplate = "insertperson",
                   Method = "PUT",
                   BodyStyle = WebMessageBodyStyle.Bare,
                   RequestFormat=WebMessageFormat.Json)]
        PersonResponse insertPerson(PersonRequest request);


        [OperationContract]
        [WebInvoke(UriTemplate = "updateperson",
                   Method = "PUT",
                   BodyStyle = WebMessageBodyStyle.Bare,
                   RequestFormat = WebMessageFormat.Json)]
        PersonResponse updatePerson(PersonRequest request);

        [OperationContract]
        [WebInvoke(UriTemplate = "getperson/{personID}",
                    Method = "GET",
                    BodyStyle = WebMessageBodyStyle.Bare)]
        PersonResponse getPerson(string personID);

        [OperationContract]
        [WebInvoke(UriTemplate = "getcontacts",
                   Method = "GET",
                   BodyStyle = WebMessageBodyStyle.Bare,
                   RequestFormat = WebMessageFormat.Json)]
        ContactsResponse getContacts();

    }

}

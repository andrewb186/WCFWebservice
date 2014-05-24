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
        string GetName(int personID);

        [OperationContract]
        PersonResponse insertPerson(PersonRequest request);


        [OperationContract]
        PersonResponse updatePerson(PersonRequest request);

        [OperationContract]
        PersonResponse getPerson(int personID);

        [OperationContract]
        ContactsResponse getContacts();

    }

}

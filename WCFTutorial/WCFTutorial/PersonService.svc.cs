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
    public class PersonService : IPersonService
    {

        public string GetName(int personID)
        {
            return "Andrew Brincat";
        }

        public PersonResponse insertPerson(Objects.PersonRequest request)
        {
            PersonResponse response = new PersonResponse();
            response.Person = request;
            response.IsErrorFound = false;

            return response;
        }

        public PersonResponse updatePerson(Objects.PersonRequest request)
        {
            PersonResponse response = new PersonResponse();
            response.Person = new PersonRequest();
            response.IsErrorFound = false;
            return response;
        }

        public PersonResponse getPerson(int personID)
        {
            PersonResponse response = new PersonResponse();
            response.Person = new PersonRequest();
            response.IsErrorFound = false;
            return response;
        }

        public ContactsResponse getContacts()
        {
            ContactsResponse response = new ContactsResponse();
            response.PersonCollection.Add(new PersonRequest());
            return response;
        }
    }
}

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

        public string GetName(string personID)
        {
            return "Andrew Brincat";
        }

        public PersonResponse insertPerson(PersonRequest request)
        {
            PersonResponse response = new PersonResponse();
            response.Person = request;
            response.IsErrorFound = false;

            return response;
        }

        public PersonResponse updatePerson(PersonRequest request)
        {
            PersonResponse response = new PersonResponse();
            response.Person = new PersonRequest();
            response.IsErrorFound = false;
            return response;
        }

        public PersonResponse getPerson(string personID)
        {
            PersonResponse response = new PersonResponse();
            response.Person = new PersonRequest();
            response.Person.Address = "Street 123, Mosta";
            response.Person.Name = "Andrew";
            response.Person.Surname = "Brincat";
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

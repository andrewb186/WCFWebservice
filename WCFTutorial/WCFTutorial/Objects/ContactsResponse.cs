using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Collections;

namespace WCFTutorial.Objects
{

    [DataContract]
    public class ContactsResponse
    {
        private List<PersonRequest> _PersonCollection;

        [DataMember]
        public List<PersonRequest> PersonCollection
        {
            get { return _PersonCollection; }
            set { _PersonCollection = value; }
        }


        public ContactsResponse()
        {
            _PersonCollection = new List<PersonRequest>();
        }

    }

}
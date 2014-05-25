using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace WCFTutorial.Objects
{
    [DataContract]
    public class PersonResponse
    {
        private bool _ErrorFound;
        [DataMember]
        public bool IsErrorFound
        {
            get { return _ErrorFound; }
            set { _ErrorFound = value; }
        }



        private PersonRequest _Person;
        [DataMember]
        public PersonRequest Person
        {
            get { return _Person; }
            set { _Person = value; }
        }
        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCFTutorial.Objects
{
    [DataContract]
    public class PersonRequest
    {

        private string _Name;
        [DataMember]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        private string _Surname;
        [DataMember]
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }


        private int _Age;
        [DataMember]
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        
        
        private string _Address;
        [DataMember]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace O.Cherkashyn_E_VT_2021_V_S_tal_TaskPerson
{
    class Person
    {
        string firstName;
        string lastName;
        long isikKod;
       

       
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public long IsikKod { get { return isikKod; } }


        public Person(string firstName,string lastName,long isikKod)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.isikKod = isikKod;
        }


        public override string ToString()
        {
            return String.Format("{0,3} {1,3} {2,3}", firstName, lastName, isikKod);
        }
    }
}

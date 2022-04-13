using System;
using System.Collections.Generic;
using System.Text;

namespace O.Cherkashyn_E_VT_2021_V_S_tal_TaskPerson
{
    class PersonList
    {
        
        List<Person> list;
        public PersonList()
        {
            list = new List<Person>();
        }
        public int Count
        {
            get { return list.Count; }
        }
        public string Add(Person person)
        {
            foreach(Person p in list)
            {
                if (person.FirstName == p.FirstName && person.LastName == p.LastName && person.IsikKod == p.IsikKod)
                {
                    return "Error!!! This user is already in the list!";
                   
                }
                
                    
            }
            list.Add(person);
            return "Person has been added :)";
            
        }
        
        public void CountAllPersons()
        {
            if(list.Count== 0)
            {
                Console.WriteLine("List is empty:(");
            }
            else
            {
                foreach(Person person1 in list)
                {
                    Console.WriteLine("Person:{0,3}",person1);
                }
            }

        }
        
    }
}

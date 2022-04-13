using System;

namespace O.Cherkashyn_E_VT_2021_V_S_tal_TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PersonList personlist1 = new PersonList();
            personlist1.CountAllPersons();
            Person person1 = new Person("Vladimir", "Putin", 43126532);
            Person person2 = new Person("Anton", "Makarov", 34242555);
            Person person3 = new Person("Erik", "Morozov", 13536423);
            personlist1.CountAllPersons();
            
            personlist1.CountAllPersons();
            */

            Person person1 = new Person("Vasja", "Petrov",390050670);
            Console.WriteLine(person1);

            Person person2 = new Person("Lena", "Lvova",490050670);
            Console.WriteLine(person2);
            Person person3 = new Person("Erik", "Morozov", 13536423);
            PersonList personlist = new PersonList();
            personlist.CountAllPersons();

            personlist.Add(person1);
            personlist.Add(person2);
            personlist.Add(person3);
            personlist.CountAllPersons();
        }
    }
}

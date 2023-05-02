using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerate
{
    public  class VirtualDataBase
    {
        public List<Persons> Persons = new List<Persons>();

        int les18Age = 0;
        int between18and60 = 0;
        int greater60 = 0;
        string MainPath="C:\\Country";
        string CountryPath;
        public List<Persons> GetPersons(int count)
        {
            //Persons.Clear();
            
            for (int i = 1; i < count; i++)
            {
                Persons person = new Persons();

                person.Id = i;
                person.Name = FakeData.NameData.GetFirstName();
                person.Surname = FakeData.NameData.GetSurname();
                person.Age = FakeData.NumberData.GetNumber(10, 120);
                person.Country = FakeData.PlaceData.GetCountry();
                person.Email = FakeData.NetworkData.GetEmail();
                Persons.Add(person);
            }

            return Persons;
        }
    }
}

using System;

namespace Demo.Simple.AAT
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public Person(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - Birthdate.Year;
        }
    }
}

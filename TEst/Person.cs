using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TEst
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Phone;
        public string ContactHour;
        public string PreferredTime;
        public InterestedIn insurances = new InterestedIn();
    }

    public class InterestedIn
    {
        public bool home;
        public bool family;
        public bool vehicle;
        public bool health;
        public bool pet;
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Owner
    {
        public Owner(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
}

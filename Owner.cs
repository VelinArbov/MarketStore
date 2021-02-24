using System;

namespace MarketStore
{
    public class Owner
    {

        private string _firstName;
        private string _lastName;

        public Owner(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        private string FirstName
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                _firstName = value;
            }
        }

        private string LastName
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                _lastName = value;
            }
        }


    }
}

namespace _01.HumanStudentAndWorker
{
    using System;
    using System.Text.RegularExpressions;

    public abstract class Human
    {
        private string firstName;

        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Value cannot be null or empty!");
                }

                Regex rgx = new Regex(@"[^A-Za-z-]");
                if (rgx.IsMatch(value))
                {
                    throw new FormatException("Value is not in the correct format for a name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Value cannot be null or empty!");
                }

                Regex rgx = new Regex(@"[^A-Za-z-]");
                if (rgx.IsMatch(value))
                {
                    throw new FormatException("Value is not in the correct format for a name!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}", this.FirstName, this.LastName);
        }
    }
}

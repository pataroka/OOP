namespace _01.HumanStudentAndWorker
{
    using System;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                Regex rgx = new Regex(@"[^A-Za-z0-9]");
                if (rgx.IsMatch(value))
                {
                    throw new FormatException("Value cannot contain any symbols other than letters and/or digits!");
                }

                if (value.Length > 10 || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be a string between 5 and 10 characters long!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Faculty number: {1}", base.ToString(), this.FacultyNumber);
        }
    }
}

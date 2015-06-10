namespace _02.Animals
{
    public class Kitten : Cat
    {
        private new const string Gender = "Female";

        public Kitten(string name, int age, string hairType)
            : base(name, age, Gender, hairType)
        {
        }
    }
}

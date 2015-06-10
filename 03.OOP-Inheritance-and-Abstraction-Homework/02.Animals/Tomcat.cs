namespace _02.Animals
{
    public class Tomcat : Cat
    {
        private new const string Gender = "male";

        public Tomcat(string name, int age, string hairType)
            : base(name, age, Gender, hairType)
        {
        }
    }
}

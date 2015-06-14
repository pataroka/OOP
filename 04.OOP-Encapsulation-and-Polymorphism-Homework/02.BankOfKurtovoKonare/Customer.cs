namespace _02.BankOfKurtovoKonare
{
    public class Customer
    {
        public Customer(string name, Entity entity)
        {
            this.Name = name;
            this.Entity = entity;
        }

        public string Name { get; set; }

        public Entity Entity { get; private set; }
    }
}

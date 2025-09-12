namespace TanacsadoLib
{
    public class Customer
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Phone { get; init; }
        public string Email { get; init; }

        public Customer(string line)
        {
            string[] parts = line.Split(';');

            Id = int.Parse(parts[0]);
            Name = parts[1];
            Phone = parts[2];
            Email = parts[3];
        }
    }
}

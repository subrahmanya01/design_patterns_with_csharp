namespace Structural.Adapter
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Employee(int id, string? name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}

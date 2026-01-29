namespace Structural.Adapter
{
    internal class EmployeeInfoProcessor : IEmployeeInfoProcessor
    {
        public EmployeeInfoProcessor() { }

        public void ProcessEmployeeExpenseClaims(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees) { 
                Console.WriteLine($"Processing employee claim with id {employee.Id}");
            }
        }
    }
}

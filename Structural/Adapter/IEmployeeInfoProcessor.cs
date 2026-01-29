namespace Structural.Adapter
{
    internal interface IEmployeeInfoProcessor
    {
        void ProcessEmployeeExpenseClaims(IEnumerable<Employee> employees);
    }
}

namespace Structural.Adapter
{
    internal interface IEmployeeManager
    {
        IEnumerable<EmployeeInfo> GetEmployees();
    }
}

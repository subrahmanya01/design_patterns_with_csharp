namespace Structural.Adapter
{

    interface IEmployeeFormatAdapter
    {
        IEnumerable<Employee> GetEmployees();
    }

    internal class EmployeeFormatAdapter : IEmployeeFormatAdapter
    {
        private readonly IEmployeeManager _employeeManager;
        public EmployeeFormatAdapter(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeManager.GetEmployees().Select(x=> new Employee(x.EmployeeID, x.EmployeeName!));
        }
    }
}

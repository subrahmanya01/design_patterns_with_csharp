namespace Structural.Adapter
{
    internal class EmployeeInfo
    {
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeePhone { get; set; }
        public int EmployeeAge { get; set; }

        public EmployeeInfo(int id, string name, string phone, int age)
        {   
            EmployeeID = id;
            EmployeeName = name;
            EmployeePhone = phone;
            EmployeeAge = age;
        }
    }

    internal class EmployeeManager : IEmployeeManager
    {

        private IEnumerable<EmployeeInfo> _employees = [
                new EmployeeInfo(1, "Subrahmanya", "9141471464", 24),
                new EmployeeInfo(2, "Jayanth", "9141471467", 25),
                new EmployeeInfo(3, "Amith", "9141471461", 26),
                new EmployeeInfo(4, "Santhosh", "9141471466", 30)
            ];

        public IEnumerable<EmployeeInfo> GetEmployees()
        {
            return this._employees;
        }
    }
}

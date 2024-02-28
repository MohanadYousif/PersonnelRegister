
namespace PersonnelRegister
{
    internal class Payroll
    {
        public List<Employee> employees { get; set; }

        public Payroll()
        {
            employees = new List<Employee>();
        }

        internal void AddEmployee(String name, int salary)
        {
            Employee employee = new Employee();
            employee.name = name;
            employee.Salary = salary;
            employees.Add(employee);
        }

        internal IEnumerable<Employee> GetEmployees()
        {
            return employees.ToArray();
        }
    }
}

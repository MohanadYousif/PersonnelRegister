
namespace PersonnelRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            Payroll payroll = new Payroll();
            while (true)
            {
                Employee employee = new Employee();

                Console.WriteLine("Pleas Enter new Employee's name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Pleas Enter new Employee's salary: ");
                string SalaryValue = Console.ReadLine();

                int Salary = String.IsNullOrEmpty(SalaryValue) || !int.TryParse(SalaryValue, out _) ? 0 : Convert.ToInt16(SalaryValue);

                payroll.AddEmployee(name, Salary);

                Console.WriteLine("Press Enter to print list of employees, or type anything to add more employees.");
                if (String.IsNullOrEmpty(Console.ReadLine())) break;

            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.name} Salary: {employee.Salary}");
            }
        }
    }
}

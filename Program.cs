
namespace PersonnelRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employeeList = new List<Employee>();

            while (true)
            {
                Employee employee = new Employee();

                Console.WriteLine("Pleas Enter new Employee's first name: ");
                employee.firstName = Console.ReadLine();

                Console.WriteLine("Pleas Enter new Employee's last name: ");
                employee.lastName = Console.ReadLine();

                Console.WriteLine("Pleas Enter new Employee's salary: ");
                string Salary = Console.ReadLine();

                employee.Salary = !String.IsNullOrEmpty(Salary) ? Convert.ToInt32(Salary) : 0;

                employeeList.Add(employee);

                Console.WriteLine("Enter P to print a list of employees.");
                String print = Console.ReadLine().Trim().ToUpper();

                if (print.Equals("P")) break;

            }

            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine(i + ". Employee's name is " + employeeList.ElementAt(i).firstName + " " + employeeList.ElementAt(i).lastName +
                    " and his salary is " + employeeList.ElementAt(i).Salary + " sek per month");
            }
        }
    }
}

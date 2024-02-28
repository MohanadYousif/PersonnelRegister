namespace PersonnelRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> names = new Dictionary<string, int>();
            int count = 1;

            while (true)
            {
                Console.WriteLine("Pleas Enter new Employee's name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Pleas Enter new Employee's salary: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                names.Add(name, salary);

                Console.WriteLine("Enter P to print a list of employees.");
                String print = Console.ReadLine().Trim().ToUpper();

                if (print.Equals("P")) break;

            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(count + ". Employee's name is " + names.ElementAt(i).Key + " and his salary is " + names.ElementAt(i).Value.ToString() + " sek per month");
            }
        }
    }
}

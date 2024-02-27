namespace PersonnelRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> names = new Dictionary<string, int>();
            Boolean AddMore = true;
            int count = 1;

            while (AddMore)
            {
                Console.WriteLine("Pleas Enter new Employee's name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Pleas Enter new Employee's salary: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                names.Add(name, salary);

                Console.WriteLine("Enter P to print a list of employees.");
                String print = Console.ReadLine().Trim().ToUpper();

                if (print.Equals("P")) AddMore = false;

            }

            foreach (var name in names)
            { 
                Console.WriteLine(count + ". Employee's name is " + name.Key + " and his salary is " + name.Value.ToString() + " sek per month");
                count++;
            }
        }
    }
}

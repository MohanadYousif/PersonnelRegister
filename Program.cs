namespace PersonnelRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas Enter new Employee's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Pleas Enter new Employee's salary: ");
            string salary = Console.ReadLine();

            Console.WriteLine("The new Employee's name is " + name + " and his salary is " + salary + " sek per month");
        }
    }
}

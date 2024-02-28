
namespace PersonnelRegister
{
    internal class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        private int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }

    }
}

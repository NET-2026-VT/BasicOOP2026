namespace BasicOOP2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
        }

        private static void Part1()
        {
            Person p = new Person();
            p.Name = "Kalle";
            //p.Salary = 25000;
            Employee e = new Employee();
            e.Name = "Anna";
            e.Salary = 25000;
            //e.Department = "HR"; 
            Admin a = new Admin();
            a.Name = "Kim";
            a.Salary = 35000;
            a.Department = "IT";

            Employee admin = new Admin();
            Person admin2 = new Admin();
            Admin admin3 = new Admin();

            Do(p);
            Do(e);
            Do(a);
            Do(admin);
            Do(admin2);
            Do(admin3);

            List<Person> people = new List<Person>
            {
                p,
                e,
                a,
                admin,
                admin2,
                admin3
            };
        }

        private static void Do(Person p)
        {
            Console.WriteLine(p);
        }
    }
}

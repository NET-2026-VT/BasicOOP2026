namespace BasicOOP2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AbstractVehicle av = new AbstractVehicle(); 
            Vehicle v = new Vehicle("Volvo");
            //Console.WriteLine(v.Drive(10));
            Car c = new Car("BMW", "E39");
            //Console.WriteLine(c.Drive(15));
            //v.Stop();
            //c.Stop(); 
            Saab s = new Saab();
            //Console.WriteLine(s.Drive(10));
            //Console.WriteLine(s.SpecialMethod());
            //v.SpecialMethod();
            //c.SpecialMethod(); 

            List<IDriveable> vehicles = new List<IDriveable>
            {
                v,
                c,
                s
            };

            foreach (AbstractVehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(50));
                Console.WriteLine(vehicle.Turn());
                Console.WriteLine(vehicle.Drive(50));
                Console.WriteLine(vehicle.Turn());
                Console.WriteLine(vehicle.Drive(50));
                Console.WriteLine(vehicle.Turn());
                Console.WriteLine(vehicle.Drive(50));
                Console.WriteLine(vehicle.Turn());
                Console.WriteLine(vehicle.Drive(50));

                //vehicle.SpecialMethod(); 

                //Unsafe cast
                //Saab saab = (Saab)vehicle;

                //Saab saab = vehicle as Saab;
                //if(saab != null)

                //if (vehicle is Saab)
                //{
                //    Saab saab = (Saab)vehicle;
                //    Console.WriteLine(saab.SpecialMethod());
                //}

                if (vehicle is Saab castedToSaab)
                    Console.WriteLine(castedToSaab.SpecialMethod());
            }
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

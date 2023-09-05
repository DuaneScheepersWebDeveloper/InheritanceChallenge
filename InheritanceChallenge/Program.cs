namespace InheritanceChallenge
{
    internal class Program
    {

        //Create a main class with the Main method, then a base class employee with the properties Name,
        //FirstName, Salary and the methods Work() and Pause().
        //Create a deriving class boss with the propertie CompanyCar and the method Lead()
        //Create another deriving class of employees - trainee with the properties WorkingHours
        //and SchoolHours and a method Learn()
        //Override the methods Work() of the trainee class so that it indicates
        //the working hours of the trainee.
        //Don't forget to create the constructors.
        //Create an object of each of the three classes (with arbitrary values)
        //and call the methods, Lead() of Boss and Work() of Trainee.
        //Just print out the respective text, what the respective employees do
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee employee = new Employee("John", "Doe", 50000);

            // Create an instance of the Boss class
            Boss boss = new Boss("Alice", "Smith", 80000, "CompanyCar");

            // Create an instance of the Trainee class
            Trainee trainee = new Trainee("Bob", "Johnson", 20000, 40, 20);

            // Call methods
            boss.Lead();
            trainee.Work(); // This will call the overridden Work() method in the Trainee class
            trainee.Learn();

            Console.ReadKey();
        }
    }
}
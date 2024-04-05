using System;
    class operators
{
    static void Main(string[] args)
    {

        Employee employee1 = new Employee() { Id = 1 };
        Console.WriteLine("ENTER THE FIRST EMPLOYEE ID:");
        Console.ReadLine();
        Employee employee2 = new Employee() { Id = 2 };
        Console.WriteLine("ENTER THE SECOND EMPLOYEE ID: ");
        Console.ReadLine();
    }

    public class Employee
    {

        public int Id { get; set; }
           
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee e1, Employee e2)
        {
            return (e1.Id == e2.Id);
            
 }
        public static bool operator !=(Employee e1, Employee e2)
        {
            return (e1.Id != e2.Id);
        }
    }

}



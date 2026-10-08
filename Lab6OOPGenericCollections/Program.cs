using System.Reflection.Metadata;

namespace Lab6OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new(0, "Anas", "Male", 20000);
            Employee employee2 = new(1, "Hanna", "Female", 30000);
            Employee employee3 = new(2, "Tobias", "Male", 40000);
            Employee employee4 = new(3, "Sarah", "Female", 40000);
            Employee employee5 = new(4, "Anna", "Female", 50000);

            Stack<Employee> employees = new Stack<Employee>();

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            Console.WriteLine("Show All");
            ShowAllEmployers(employees);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Retrive using Pop method");
            ShowAllEmployersAndPop(employees);

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Retrive using Peek method");
            ShowEmployeeWithPeek(employees);
            Console.WriteLine("--------------------------");
            if (employees.Contains(employee3))
            {
                Console.WriteLine("Employee 3 Exist");
            }

            List<Employee> EmployeesList = new List<Employee>();
            EmployeesList.Add(employee1);
            EmployeesList.Add(employee2);
            EmployeesList.Add(employee3);
            EmployeesList.Add(employee4);
            EmployeesList.Add(employee5);

            // Skapa ett villkor med Contains()-metoden för att kolla om ett visst objekt finns i listan. 
            if (Contains(ref EmployeesList, v => v.Name == "Hanna"))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            if (EmployeesList.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Console.WriteLine(EmployeesList.Find(e => e.Gender == "Male"));

            {
                List<Employee> localList = EmployeesList.FindAll(e => e.Gender == "Male").ToList();
                Console.WriteLine("For Each ---------------------");

                foreach (Employee employee in localList)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine("---------------------");
                }
            }

        }

        static bool Contains(ref List<Employee> employees, Func<Employee, bool> condition)
        {

            for (int i = 0; i < employees.Count; i++)
            {
                if (condition(employees[i]))
                {
                    return true;
                }
            }

            return false;
        }

        static void ShowAllEmployers(Stack<Employee> stack)
        {
            foreach (Employee employee in stack)
            {
                Console.WriteLine($"Id: {employee.Id} Name: {employee.Name} Gender: {employee.Gender} Salary: {employee.Salary}");
                Console.WriteLine($"Employee left in the stack: {stack.Count}");
            }
        }

        static void ShowAllEmployersAndPop(Stack<Employee> stack)
        {
            int count = stack.Count;

            for (int i = 0; i < count; i++)
            {
                Employee employee = stack.Pop();
                Console.WriteLine($"Id: {employee.Id} Name: {employee.Name} Gender: {employee.Gender} Salary: {employee.Salary}");
                Console.WriteLine($"Employee left in the stack: {stack.Count}");
            }
        }

        static void ShowEmployeeWithPeek(Stack<Employee> stack)
        {
            int count = stack.Count;

            for (int i = 3; i < count; i++)
            {
                Employee employee = stack.Peek();
                Console.WriteLine($"Id: {employee.Id} Name: {employee.Name} Gender: {employee.Gender} Salary: {employee.Salary}");
                Console.WriteLine($"Employee left in the stack: {stack.Count}");
            }
        }

    }
}

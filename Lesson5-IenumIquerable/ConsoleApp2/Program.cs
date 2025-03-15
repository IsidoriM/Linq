// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Model;
using System.Reflection;

class Program
{

    public static void Main()
    {
        Reflection reflection = new Reflection();
         reflection.GetDati();
         var cx = new Context();
        IEnumerable<Employee> em = cx.Employees.Where(c => c.Id > 0);

        foreach(Employee emp in em)
        {
            Console.WriteLine(emp.Name);

        }
    }
}
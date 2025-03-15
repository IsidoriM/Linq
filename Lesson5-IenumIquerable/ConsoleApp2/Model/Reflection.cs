using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ConsoleApp2.Model
{
    public  class Reflection
    {
        public void GetDati()
        {
            Reflection p = new Reflection();
            //Dichiaro un tipo ed ottengo le informazioni dall'argomento Persona p
            Type Tipo = p.GetType();
            DbSet<Employee> Employees;
       
            var assembly = Tipo.Assembly;

            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine($"Type: {type.Name}");
                Console.WriteLine("============================");

                var instance = Activator.CreateInstance(type);

                foreach (var field in type.GetFields(BindingFlags.NonPublic |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly))
                {
                    Console.WriteLine($"Field: {field.Name}");
                    field.SetValue(instance, Employees);
                }
                Console.WriteLine("============================");

                foreach (var method in type.GetMethods(BindingFlags.Public |
                    BindingFlags.NonPublic |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly)
                    .Where(m => !m.IsSpecialName))
                {
                    Console.WriteLine($"Method: {method.Name}");
                    if (method.GetParameters().Length > 0)
                    {
                        method.Invoke(instance, new[] { "Bilbo" });
                    }
                    else if (method.ReturnType.Name != "Void")
                    {
                        var returnedValue = method.Invoke(instance, null);
                        Console.WriteLine($"Returned value from method: {returnedValue}");
                    }
                    else
                    {
                        method.Invoke(instance, null);
                    }
                }
                Console.WriteLine("============================");

                foreach (var property in type.GetProperties())
                {
                    Console.WriteLine($"Property: {property.Name}");
                    var propertyValue = property.GetValue(instance);
                    Console.WriteLine($"Property value: {propertyValue}");
                }
            }


            }

    }
}

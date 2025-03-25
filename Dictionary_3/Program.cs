using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, Employee> employees = new SortedDictionary<int, Employee>();
            string command = Console.ReadLine();
            Console.WriteLine("Vuvedete danni ili break za prekusvane:");
            while (command.ToLower() != "break")
            {
                Console.Write("ID: ");
                int id;
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Employee employee = new Employee(id, name);
                    if (!employees.ContainsKey(id)) 
                    {
                        employees.Add(id, employee);
                    }
                    else
                    {
                        Console.WriteLine("ID sushtestvuva");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Slujiteli");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Value); 
            }
        }
    }
}

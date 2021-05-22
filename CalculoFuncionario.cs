using System;
using System.Collections.Generic;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();

            }

            Console.WriteLine("Insira a id do funcionário que terá aumento de salário: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.WriteLine(" Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);

            }
            else
            {
                Console.WriteLine(" Esse Id não Existe! ");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
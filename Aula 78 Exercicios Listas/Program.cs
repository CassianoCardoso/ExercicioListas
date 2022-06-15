using System;
using System.Collections.Generic;
using System.Globalization;
namespace Aula_78_Exercicios_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Funcionario deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());

            List<Empregados>list = new List<Empregados>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Empregado: {i} : ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Empregados(id, nome, salario));    
              
                
            }

            Console.WriteLine("Insira o ID do funcionário que vai ter o aumento no seu salario");
            int aumento = int.Parse(Console.ReadLine());

            Empregados emp = list.Find(list => list.Id == aumento);

            if (emp != null)
            {
                Console.WriteLine("Entre com a procentagem de aumento:");
                double porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncrementaSalario(porcento);
            }
            else
            {
                Console.WriteLine("ID não encontrado!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de empregados atualizados: ");

            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
           
        }
    }
}

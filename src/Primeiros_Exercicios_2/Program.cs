using System;
using System.Globalization;

namespace Primeiros_Exercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionarios funcionario1 = new Funcionarios();
            Funcionarios funcionario2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (funcionario1.salario + funcionario2.salario) / 2.0;

            Console.WriteLine($"Sálario médio: {mediaSalario.ToString("F2",CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}

using Programa3;
using System;
using System.Globalization;

namespace Programa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados Aluno = new Dados();
            
            Console.Write("Nome do Aluno: ");
            Aluno.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite as três notas do Aluno:");
            Aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = " + Aluno.NotaFinal(). ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            if (Aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine();
                Console.WriteLine("Faltam " + Aluno.NotaRestante(). ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Exercicio_Prova_Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, trabalho, media;
            string nome;

            Console.WriteLine("Digite o nome do Aluno");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a Nota da prova 1");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Nota da prova 2");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Nota do Trabalho");
            trabalho = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + trabalho) / 3;
            Console.WriteLine("A media de " + nome + ":" + media);

            if (media >= 8.5)
            {
                Console.WriteLine("Conceito A");
            }
            if (media >= 7 && media <= 8.4)
            {
                Console.WriteLine("Conceito é B");
            }
            if (media >=6 && media <= 6.9)
            {
                Console.WriteLine("Conceito C");
            }
            if (media >=0.1 && media <= 5.9)
            {
                Console.WriteLine("Conceito D");
            }
            else if (media == 0)
            {
                Console.WriteLine("Conceito E");
            }

            Console.ReadKey();  
        }
    }
}

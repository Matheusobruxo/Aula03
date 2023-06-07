using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string c = "Vascão"; // string precisa estar sempre entre aspas
            int a = 70;
            float altura = 1.70f; //colocar f para o float ser considerado, senão da erro
            float money = 50.49f;
            int soma = 78 + 192; //é possivel fazer soma na variavel
            float peso = 70.0f;
            float imc = peso / (altura * altura);

            Console.WriteLine("Aula 03 variaveis");
            Console.WriteLine("Programa criado por " + c); //variável fora das aspas
            Console.WriteLine("Eu sou o " + c);
            Console.WriteLine("Lembrando quem fez foi o cadu ");
            Console.WriteLine("minha idade é " + a);
            Console.WriteLine($"minha altura é {altura}");
            Console.WriteLine("Meu nome é " + c + " e eu tenho " + a + "anos"); // colocar + e abrir "" para continuar escrevendo apos variavel // concatenação
            Console.WriteLine($"Meu nome é {c} e eu tenho {a} anos");
            Console.WriteLine($"Na minha carteira tem {money}"); //($"{}" usar para escrita de variaveis em writeline sem a necessidade de usar + //interpolação
            Console.WriteLine($"{soma}");
            Console.WriteLine($"{imc}");


            Console.ReadKey();
        }
    }
}

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

            string c = "Carlos"; //string variavel texto (colocar um nome e em seguida colocar "")
            //Juntar um texto com outro se chama CONCATENAÇÃO
            int a = 18;
            float altura = 1.70f; //colocar f senão não ira reconhecer
            float money = 50.49f;
            int soma = 78 + 192;//é possivel fazer soma na variavel
            float peso = 70.0f;
            float imc = peso / (altura * altura);

            Console.WriteLine("Aula 03 variaveis");
            Console.WriteLine("Programa criado por " + c); //escrever variavel dentro do () dps da ""
            Console.WriteLine("Eu sou o " + c);
            Console.WriteLine("Lembrando quem fez foi o cadu ");
            Console.WriteLine("minha idade é " + a);
            Console.WriteLine($"minha altura é {altura}");
            Console.WriteLine("Meu nome é " + c + " e eu tenho " + a + "anos"); // colocar + e abrir "" para continuar escrevendo apos variavel
            Console.WriteLine($"Meu nome é {c} e eu tenho {a} anos");
            Console.WriteLine($"Na minha carteira tem {money}"); //($"{}" usar para escrita de variaveis em writeline sem a necessidade de usar + //interpolação
            Console.WriteLine($"{imc}");
            Console.WriteLine($"{soma}");

            Console.ReadKey();
        }
    }
}
using System.Globalization;
using System.Security.Cryptography;

namespace Exercicio01.ConsoleApp
{
    internal class ExercicioUm
    {
        /*Escreva um programa que receba uma frase do usuário e
         * converta todas as palavras para o formato "Title Case",
         * ou seja,
         * todas as primeiras letras das palavras devem ser maiúsculas.*/
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Digite uma frase: ");
                string fraseInputada = Console.ReadLine();
                TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                string fraseConvertidaParaTitleCase = textInfo.ToTitleCase(fraseInputada);
                Console.WriteLine(fraseConvertidaParaTitleCase);
                Console.ReadLine();
            }
        }
    }
}
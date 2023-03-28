namespace Exercicio02.ConsoleApp
{
    internal class Exercicio02
    {
        static void Main(string[] args)
        {
            /*Dada uma string contendo uma frase,
             * escreva um programa em C# que conte o número de palavras na frase e
             * imprima o resultado.*/
            while (true) 
            {
                string frase = "Palmeiras nao tem mundial";
                string[] palavras = frase.Trim().Split();
                int qntdPalavras = palavras.Length;
                Console.WriteLine($"Quantidade de palavras: {qntdPalavras}");
                Console.ReadLine();
            }
        }
    }
}
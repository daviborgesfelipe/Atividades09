namespace Exercicio05.ConsoleApp
{
    internal class Exercicio05
    {
        /*
            Crie um programa em C# que solicite ao usuário que digite uma frase. 
            Em seguida, o programa deve utilizar métodos da classe string para realizar as seguintes operações:

                 Imprimir a frase em letras maiúsculas;
                 Imprimir a frase em letras minúsculas;
                 Imprimir a quantidade de caracteres da frase;
                 Imprimir a primeira palavra da frase;
                 Imprimir a última palavra da frase.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string fraseInputada = Console.ReadLine();
            Console.WriteLine($"Frase em letras maiuscula: {fraseInputada.ToUpper()}");
            Console.WriteLine($"Frase em letras minuscula: {fraseInputada.ToLower()}");
            Console.WriteLine($"Frase quantidade de caracteres: {fraseInputada.Length}");
            string[] fraseArray = fraseInputada.Split(' ');
            Console.WriteLine($"Primeira palavra da frase: {fraseArray[0]}");
            Console.WriteLine($"Ultima palavra da frase: {fraseArray[fraseArray.Length - 1]}");
        }
    }
}
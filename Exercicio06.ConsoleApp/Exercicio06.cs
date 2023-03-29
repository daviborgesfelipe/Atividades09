namespace Exercicio06.ConsoleApp
{
    internal class Exercicio06
    {
        /*
            Desenvolva um programa em C# que leia o arquivo cidades.csv e
            dê a possibilidade de apresentar as cidades agrupadas
            pela primeira letra ou
            pelo estado que pertence.
         */
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite a inicial da cidade ou o estado");
            string letraOuEstadoInputada = Console.ReadLine();
            Console.WriteLine();
            StreamReader streamReader = new StreamReader("C:\\AcademiaProgramador\\Atividades09\\Exercicio06.ConsoleApp\\docs\\cidades.csv");
            streamReader.ReadLine();
            if (letraOuEstadoInputada.Length == 1)
            {
                Console.WriteLine($"Cidades que iniciam com a letra {letraOuEstadoInputada}");
            }
            else
            {
                Console.WriteLine($"Cidades que pertencem ao estado {letraOuEstadoInputada}");
            }
            while (!streamReader.EndOfStream) 
            {
                string linha = streamReader.ReadLine();
                string cidade = linha.Split(',')[2];
                string cidadePorEstado = linha.Split(",")[3];
                if (letraOuEstadoInputada.Length == 1)
                {
                    if (cidade.StartsWith(letraOuEstadoInputada))
                    {
                        Console.WriteLine(cidade);
                    }
                }
                if(letraOuEstadoInputada.Length > 1)
                {
                    if(cidadePorEstado.Contains(letraOuEstadoInputada))
                    {
                        Console.WriteLine(cidade);
                    }
                }

            }
                Console.ReadLine();
        }
    }
}
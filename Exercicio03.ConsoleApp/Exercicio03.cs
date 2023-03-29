namespace Exercicio03.ConsoleApp
{
    internal class Exercicio03
    {
        static void Main(string[] args)
        {
            /*
             * Desenvolva uma aplicação troque cada letra de um texto por outra do alfabeto X posições a frente,
             * onde X pode ser escolhido por você (cifra de César)
                a. Exemplo com X=2:
                b. “DIEGO” passará a ser “FKGIQ”
            */

            while (true) 
            { 
                Console.Clear();

                char[] letraAlfabeto = ConverterAlfabeto();
                int parcela = GerarParcela();
                char[] fraseConvertidaChar = GerarFrase();

                GerarCriptografia(parcela, fraseConvertidaChar, letraAlfabeto);
                Console.ReadLine();
            }
        }
        public static void GerarCriptografia(int parcela, char[] fraseConvertidaChar, char[] letraAlfabeto)
        {
            for (int indiceFrase = 0; indiceFrase < fraseConvertidaChar.Length; indiceFrase++)
            {
                for (int indiceAlfabeto = 0; indiceAlfabeto < letraAlfabeto.Length; indiceAlfabeto++)
                {
                    if (fraseConvertidaChar[indiceFrase] == letraAlfabeto[indiceAlfabeto])
                    {
                        fraseConvertidaChar[indiceFrase] = letraAlfabeto[indiceAlfabeto + parcela];
                        indiceAlfabeto = 0;
                        break;
                    }
                }
            }
            Console.WriteLine(fraseConvertidaChar);
        }
        public static int GerarParcela()
        {
            Console.WriteLine("Digite o valor inteiro da parcela a ser somada");
            int parcela = Convert.ToInt32(Console.ReadLine());
            return parcela;
        }
        public static char[] GerarFrase()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            char[] fraseConvertida = frase.ToCharArray();
            return fraseConvertida;
        }
        public static char[] ConverterAlfabeto()
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXZWY";
            char[] letraAlfabeto = alfabeto.ToCharArray();
            return letraAlfabeto;
        }
    }
}
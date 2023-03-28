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
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXZWY";
            char[] letraAlfabeto = alfabeto.ToCharArray();

            while (true) 
            { 
                Console.WriteLine("Digite uma frase: ");
                string frase = Console.ReadLine();
                frase = frase.ToUpper();
                char[] fraseConvertidaChar = frase.ToCharArray();
                for (int indiceFrase = 0; indiceFrase < fraseConvertidaChar.Length; indiceFrase++)
                {
                    for (int indiceAlfabeto = 0; indiceAlfabeto < alfabeto.Length; indiceAlfabeto++)
                    {
                        if (fraseConvertidaChar[indiceFrase] == letraAlfabeto[indiceAlfabeto])
                        {
                            int indice = indiceAlfabeto + 2;
                            fraseConvertidaChar[indiceFrase] = letraAlfabeto[indice];
                            Console.WriteLine(fraseConvertidaChar);
                            indiceAlfabeto = 0;
                            break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
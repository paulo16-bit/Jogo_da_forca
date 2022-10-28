using System;


namespace Jogo_da_forca
{
    public class Interface
    {
        public void ImprimeInterface(char[] palavra, int erro, string dica)
        {
            switch (erro)
            {
                case 0:
                    Console.WriteLine("________        {0}", dica);
                    Console.WriteLine("|      |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    for (int i = 0; i < palavra.Length; i++) { Console.Write(palavra[i] + " "); }
                    break;
                case 1:
                    Console.WriteLine("________        {0}", dica); Console.WriteLine("|      |");
                    Console.WriteLine("|      O");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    for (int i = 0; i < palavra.Length; i++) { Console.Write(palavra[i] + " "); }
                    break;
                case 2:
                    Console.WriteLine("________        {0}", dica);
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      O");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|");
                    for (int i = 0; i < palavra.Length; i++) { Console.Write(palavra[i] + " "); }
                    break;
                case 3:
                    Console.WriteLine("________        {0}", dica);
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      O");
                    Console.WriteLine("|     /|");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|");
                    for (int i = 0; i < palavra.Length; i++) { Console.Write(palavra[i] + " "); }
                    break;
                case 4:
                    Console.WriteLine("________        {0}", dica);
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      O");
                    Console.WriteLine("|     /|\\");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|");
                    for (int i = 0; i < palavra.Length; i++) { Console.Write(palavra[i] + " "); }
                    break;
                case 5:
                    Console.WriteLine("________        {0}", dica);
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      O");
                    Console.WriteLine("|     /|\\");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|     /");
                    for (int i = 0; i < palavra.Length; i++) { Console.Write(palavra[i] + " "); }
                    break;
                case 6:
                    Console.WriteLine("________        {0}", dica);
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      O");
                    Console.WriteLine("|     /|\\");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|     / \\");
                    for (int i = 0; i < palavra.Length; i++) { Console.Write(palavra[i] + " "); }
                    break;

            }
        }

    }
}

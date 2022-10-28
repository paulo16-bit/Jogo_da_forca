using System;


namespace Jogo_da_forca
{
    public class Arbitro
    {
        public void VerificaResultado(int erro)
        {
            if (erro < 6) { Console.WriteLine("\nParabéns! Você acertou a palavra"); }
            else { Console.WriteLine("\nQue pena! Na próxima você consegui"); }
        }
    }
}

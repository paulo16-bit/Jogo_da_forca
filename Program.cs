using System;
using System.Collections;
using System.Linq;

namespace Jogo_da_forca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            Arbitro arbitro = new Arbitro();
            Interface interface1 = new Interface();

            string[] palavraEscolhida = jogo.EscolhePalavra();
            char[] palavraFatiada = palavraEscolhida[0].ToCharArray();
            string dica = palavraEscolhida[1];
            ArrayList letra_inserida = new ArrayList();
            char[] forca = (char[])palavraFatiada.Clone();
            char letra;
            int erro = 0, acerto = 0;
            
            
            for(int i = 0; i < palavraFatiada.Length; i++) {
                forca[i] = '_';
            }
            
            while (true)
            {
                Console.Clear();
                interface1.ImprimeInterface(forca, erro, dica);
                
                if(acerto == palavraFatiada.Length) { break; }
                if (erro == 6) { break; }

                Console.WriteLine("\nDigite uma letra: ");
                letra = Console.ReadKey(false).KeyChar;
                if (letra_inserida.Contains(letra))
                {
                    Console.WriteLine(" já foi digitada. Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }
                
                letra_inserida.Add(letra);
                if (palavraFatiada.Contains(letra))
                {
                    for(int i = 0; i < palavraFatiada.Length; i++)
                    {
                        if(palavraFatiada[i] == letra){ 
                            acerto++;
                            forca[i] = letra;
                        }
                    }
                }

                else { erro++; }
                
            }
            arbitro.VerificaResultado(erro);
        }
    }
}

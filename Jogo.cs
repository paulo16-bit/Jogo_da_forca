using System;
using System.Collections.Generic;
using System.Linq;

namespace Jogo_da_forca
{
    public class Jogo
    {
		IDictionary<string, string[]> palavras = new Dictionary<string, string[]>()
		{
			{ "fruta", new string[]{"banana", "morango", "abacate" } },
			{ "objeto", new string[]{"caneta", "borracha", "pingente"} }

		};

        public string[] EscolhePalavra()
        {
			Random rnd = new Random();
			int categoria = rnd.Next(palavras.Count);
			int palavra = rnd.Next(palavras.ElementAt(categoria).Value.Count());

			return new string[] { palavras.ElementAt(categoria).Value[palavra], palavras.ElementAt(categoria).Key };
		}
    }
}

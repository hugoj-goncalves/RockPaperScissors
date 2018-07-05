using System;

namespace RockPaperScissors
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var resultado = new Jogo().Torneio(DadosTorneio.PrimeiroTorneio);
			Console.WriteLine($"{resultado.Jogador} ganhou com a estratégia {resultado.Estrategia}");
		}
	}
}

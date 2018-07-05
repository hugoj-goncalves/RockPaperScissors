using System.Linq;
using NUnit.Framework;
using RockPaperScissors;

namespace RockPaperScissorsTests
{
	[TestFixture]
	public class JogoTests
	{
		private const string JOGADOR_UM = "1";
		private const string JOGADOR_DOIS = "2";

		[TestCase(Estrategias.Tesoura, Estrategias.Tesoura, JOGADOR_UM)]
		[TestCase(Estrategias.Tesoura, Estrategias.Papel, JOGADOR_UM)]
		[TestCase(Estrategias.Tesoura, Estrategias.Pedra, JOGADOR_DOIS)]

		[TestCase(Estrategias.Papel, Estrategias.Tesoura, JOGADOR_DOIS)]
		[TestCase(Estrategias.Papel, Estrategias.Papel, JOGADOR_UM)]
		[TestCase(Estrategias.Papel, Estrategias.Pedra, JOGADOR_UM)]

		[TestCase(Estrategias.Pedra, Estrategias.Tesoura, JOGADOR_UM)]
		[TestCase(Estrategias.Pedra, Estrategias.Papel, JOGADOR_DOIS)]
		[TestCase(Estrategias.Pedra, Estrategias.Pedra, JOGADOR_UM)]
		public void Deve_obter_jogada_ganhadora(Estrategias estrategiaPrimeiroJogador, Estrategias estrategiaSegundoJogador, string jogadorGanhador)
		{
			var jogo = new Jogo();
			var jogadas = new[]
			{
				new Jogada(JOGADOR_UM, estrategiaPrimeiroJogador), new Jogada(JOGADOR_DOIS, estrategiaSegundoJogador),
			};

			var resultado = jogo.ObterJogadaGanhadora(jogadas);

			var jogadaGanhadoraEsperada = jogadas.Single(m => m.Jogador == jogadorGanhador);
			Assert.AreEqual(jogadaGanhadoraEsperada, resultado);
		}

		[Test]
		public void Deve_obter_resultado_torneio()
		{
			var jogo = new Jogo();

			var resultado = jogo.Torneio(DadosTorneio.PrimeiroTorneio);
			Assert.AreEqual("Richard", resultado.Jogador);
		}
	}
}

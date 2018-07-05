using System.Linq;
using RockPaperScissors.Exceptions;

namespace RockPaperScissors
{
	public class Jogo
	{
		public Jogada ObterJogadaGanhadora(Jogada[] jogadas)
		{
			if (jogadas.Length != 2)
				throw new NumeroIncorretoDeJogadoresException();

			if (jogadas.Any(jogada => jogada.Estrategia == Estrategias.Invalida))
				throw new EstrategiaInvalidaException();

			var jogadaPrimeiroJogador = jogadas[0];
			var jogadaSegundoJogador = jogadas[1];

			var estrategiaPrimeiroJogador = jogadaPrimeiroJogador.Estrategia;
			var estrategiaSegundoJogador = jogadaSegundoJogador.Estrategia;

			if (estrategiaPrimeiroJogador == estrategiaSegundoJogador)
				return jogadaPrimeiroJogador;

			if (estrategiaPrimeiroJogador == Estrategias.Pedra)
			{
				return estrategiaSegundoJogador == Estrategias.Tesoura
					? jogadaPrimeiroJogador
					: jogadaSegundoJogador;
			}
			if (estrategiaPrimeiroJogador == Estrategias.Papel)
			{
				return estrategiaSegundoJogador == Estrategias.Pedra
					? jogadaPrimeiroJogador
					: jogadaSegundoJogador;
			}
			if (estrategiaPrimeiroJogador == Estrategias.Tesoura)
			{
				return estrategiaSegundoJogador == Estrategias.Papel
					? jogadaPrimeiroJogador
					: jogadaSegundoJogador;
			}

			throw new ErroInesperadoException();
		}

		public Jogada Torneio(object torneio)
		{
			var tipo = torneio.GetType();
			if (tipo == typeof(Jogada[]))
				return ObterJogadaGanhadora((Jogada[])torneio);

			var torneioAtual = (object[]) torneio;
			var ganhadores = new[] 
			{
				Torneio(torneioAtual[0]),
				Torneio(torneioAtual[1]),
			};

			return ObterJogadaGanhadora(ganhadores);
		}
	}
}
namespace RockPaperScissors
{
	public class Jogada
	{
		public string Jogador { get; set; }
		public Estrategias Estrategia { get; set; }

		public Jogada(string jogador, Estrategias estrategia)
		{
			Jogador = jogador;
			Estrategia = estrategia;
		}
	}
}
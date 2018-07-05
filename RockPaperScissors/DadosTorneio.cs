namespace RockPaperScissors
{
	public static class DadosTorneio
	{
		public static Jogada[][][] PrimeiroTorneio =
		{
			new []
			{
				new [] { new Jogada("Armando", Estrategias.Papel), new Jogada("Dave", Estrategias.Tesoura) },
				new [] { new Jogada("Richard", Estrategias.Pedra), new Jogada("Michael", Estrategias.Tesoura) }
			},
			new []
			{
				new [] { new Jogada("Allen", Estrategias.Tesoura), new Jogada("Omer", Estrategias.Papel) },
				new [] { new Jogada("David. E.", Estrategias.Pedra), new Jogada("Richard X.", Estrategias.Papel) }
			}
		};
	}
}
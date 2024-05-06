class program

{

	static void Main()
	{
		Random rnd = new Random();
		int pp = 0;
		int pv = 0;

		
		while (pp < 3 && pv < 3)
		{
			Console.WriteLine("elija piedra, papel, tijera");
			String eperson = Console.ReadLine().ToLower();

			if (eperson != "piedra" && eperson != "papel" && eperson != "tijera")
			{
				Console.WriteLine("Ups! solo puedes elegir entre piedra papel y tijera");
			}

			
			String[] opciones = { "piedra", "papel", "tijera" };
			int opcionaleatoria = rnd.Next(0, 3);
			String evirtual = opciones[opcionaleatoria];

			
			Console.WriteLine("tu elegiste " + eperson);
			Console.WriteLine("el jugador virtual eligio " + evirtual);

			
			if (eperson == evirtual)
			{
				Console.WriteLine("Empate!!");
			}
			else
				if ((eperson == "piedra" && evirtual == "tijera") ||
				(eperson == "papel" && evirtual == "piedra") ||
				(eperson == "tijera" && evirtual == "papel"))

			{
				Console.WriteLine("ganaste esta ronda");
				pp++;
			}
			else
			{
				Console.WriteLine("el jugador virtual a ganado esta ronda");
				pv++;
			}
			Console.WriteLine($"marcador actual:tu [{pp}] - jugador virtual [{pv}] ");
			Console.WriteLine();

		}
		
		if (pp >= 3)
		{
			Console.WriteLine("has ganado");
		}
		else if (pv >= 3)
		{
			Console.WriteLine("juagador virtual ha ganado");
		}

	}
}

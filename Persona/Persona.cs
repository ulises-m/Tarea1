using System;

namespace Persona
{
	public class Persona
	{
		public string nombre; 
		public string correo;
		public int edad;

		public Persona ()
		{

			Console.Write("Dame el nombre:");
			nombre = Console.ReadLine();
			Console.Write("Dame el correo:");
			correo = Console.ReadLine();
			Console.Write("Dame la edad:");
			edad = int.Parse(Console.ReadLine());
		   
			Console.Clear();
		
			Console.Write("\r\n"+ nombre +"\r\n"+correo  +"\r\n"+edad);



	}
}

}
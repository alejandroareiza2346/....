// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejercicio8 {

		static void Main(string[] args) {
			double temp_celcius;
			double temp_fahrenheit;
			Console.WriteLine("ingrese una temperatura en graso celcius");
			temp_celcius = Double.Parse(Console.ReadLine());
			temp_fahrenheit = temp_celcius*9/5+32;
			Console.WriteLine("la temperatura en grados fahrenheit es "+temp_fahrenheit);
		}

	}

}


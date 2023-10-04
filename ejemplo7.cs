// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejercicio7 {

		static void Main(string[] args) {
			double facotrial;
			int factorial;
			int i;
			int num1;
			double x;
			Console.WriteLine("Por favor, ingresa un número entero positivo: ");
			num1 = int.Parse(Console.ReadLine());
			if (num1<0) {
				Console.WriteLine("el numero es calculable");
			} else {
				i = 1;
				facotrial = 1;
				while (i<=num1) {
					factorial = factorial*i;
					x = x+1;
				}
			}
			Console.WriteLine("el factorial de numero "+num1+" es "+facotrial);
		}

	}

}


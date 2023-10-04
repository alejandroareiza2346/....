// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejercicio9 {

		static void Main(string[] args) {
			int contador;
			int divisor;
			int num1;
			contador = 0;
			Console.WriteLine("Por favor, ingresa un número entero positivo: ");
			num1 = int.Parse(Console.ReadLine());
			if (num1<=1) {
				Console.WriteLine("El número no es primo.");
			} else {
				for (divisor=2;divisor<=num1-1;divisor++) {
					if (num1%divisor==0) {
						contador = contador+1;
					}
				}
				if (contador==0) {
					Console.WriteLine("El número es primo.");
				} else {
					Console.WriteLine("El número no es primo.");
				}
			}
		}

	}

}


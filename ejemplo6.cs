// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejercicio6 {

		static void Main(string[] args) {
			double num1;
			double num2;
			Console.WriteLine("ingrese un numero y voy a imprimir si es par o impar");
			num1 = Double.Parse(Console.ReadLine());
			num2 = num1%2;
			if (num2==0) {
				Console.WriteLine("el numero "+num1+" es par");
			} else {
				Console.WriteLine("el numero "+num1+" es impar");
			}
		}

	}

}


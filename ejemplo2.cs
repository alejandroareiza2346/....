// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejercicio2 {

		static void Main(string[] args) {
			double divicion;
			double multiplicacion;
			double num1;
			double num2;
			int opciones;
			double resta;
			double suma;
			Console.WriteLine("hola, voy a realizar una operacion que elija con dos numeros que ingrese");
			Console.WriteLine("ingrese el primer numero");
			num1 = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el segundo numero");
			num2 = Double.Parse(Console.ReadLine());
			Console.WriteLine("escriba 1. para suma, 2.para resta, 3.para multiplicacion, 4.para divicion ");
			opciones = int.Parse(Console.ReadLine());
			switch (opciones) {
			case 1:
				suma = num1+num2;
				Console.WriteLine("el resultado de la suma es "+suma);
				break;
			case 2:
				resta = num1-num2;
				Console.WriteLine("el resultado de la resta es "+resta);
				break;
			case 3:
				multiplicacion = num1*num2;
				Console.WriteLine("el resultado de la multiplicacion es "+multiplicacion);
				break;
			case 4:
				divicion = num1/num2;
				Console.WriteLine("el resultado de la divicion es "+divicion);
				break;
			}
		}

	}

}


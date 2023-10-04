// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejercicio3 {

		static void Main(string[] args) {
            using System;
            using System.Linq;

class Program
        {
            static void Main()
            {
                string[] palabras = { "computadora", "programacion", "ahorcado", "jugador" };
                string palabraSecreta = SeleccionarPalabraSecreta(palabras);
                char[] palabraAdivinada = new char[palabraSecreta.Length];

                for (int i = 0; i < palabraAdivinada.Length; i++)
                {
                    palabraAdivinada[i] = '_';
                }

                int intentosMaximos = 6;
                int intentos = 0;

                while (intentos < intentosMaximos)
                {
                    Console.WriteLine("Palabra a adivinar: " + new string(palabraAdivinada));
                    Console.WriteLine("Intentos restantes: " + (intentosMaximos - intentos));

                    Console.Write("Ingresa una letra: ");
                    char letra = Console.ReadLine().ToLower()[0];

                    if (!char.IsLetter(letra))
                    {
                        Console.WriteLine("Por favor, ingresa una letra válida.");
                        continue;
                    }

                    if (palabraSecreta.Contains(letra))
                    {
                        for (int i = 0; i < palabraSecreta.Length; i++)
                        {
                            if (palabraSecreta[i] == letra)
                            {
                                palabraAdivinada[i] = letra;
                            }
                        }
                    }
                    else
                    {
                        intentos++;
                    }

                    if (palabraAdivinada.SequenceEqual(palabraSecreta.ToCharArray()))
                    {
                        Console.WriteLine("¡Ganaste! La palabra era: " + palabraSecreta);
                        break;
                    }
                }

                if (!palabraAdivinada.SequenceEqual(palabraSecreta.ToCharArray()))
                {
                    Console.WriteLine("Perdiste. La palabra era: " + palabraSecreta);
                }
            }

            static string SeleccionarPalabraSecreta(string[] palabras)
            {
                Random random = new Random();
                int indice = random.Next(0, palabras.Length);
                return palabras[indice];
                Console.ReadLine();
            }
        }
    }

}

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_del_Ahorcado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego del ahorcado");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Ingrese la palabra a adivinar");
                Console.WriteLine("Presione 1 para salir");
                string palabra = Console.ReadLine().ToUpper();
                if (palabra == "1")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Tiene 5 intentos para fallar");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                int intentos = 5;
                string palabraoculta = "";
                for (int i = 0; i < palabra.Length; i++)
                {
                    palabraoculta += "_";
                }
                while (intentos > 0)
                {
                    Console.WriteLine("Palabra a adivinar: " + palabraoculta);
                    Console.WriteLine("Ingrese una letra");
                    string letra = Console.ReadLine().ToUpper();
                    if (letra.Length > 1)
                    {
                        Console.WriteLine("Solo puede ingresar una letra");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    bool acierto = false;
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabra[i] == letra[0])
                        {
                            palabraoculta = palabraoculta.Remove(i, 1);
                            palabraoculta = palabraoculta.Insert(i, letra);
                            acierto = true;
                        }
                    }
                    if (acierto == false)
                    {
                        intentos--;
                        Console.WriteLine("Letra incorrecta");
                        Console.WriteLine("Intentos restantes: " + intentos);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Letra correcta");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (palabraoculta == palabra)
                    {
                        Console.WriteLine("Felicidades, adivinaste la palabra");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
                if (intentos == 0)
                {
                    Console.WriteLine("Perdiste, la palabra era: " + palabra);
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            }
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    internal class Juego
    {
        public void Jugar()
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.WriteLine("\nJuego de Dados\n");
                Console.WriteLine("Presione ENTER para Jugar o ESC para cerrar el juego.");
                tecla = Console.ReadKey();

                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("\nHa iniciado la partida...\n");
                    Inicio();
                }
                else
                {
                    Console.WriteLine("\n CERRO EL JUEGO!");
                }
            } while (tecla.Key == ConsoleKey.Enter);
        }

        private void Inicio()
        {
            Dado fichaUno = new Dado();
            Dado fichaDos = new Dado();
            Dado fichaTres = new Dado();

            Console.WriteLine($"Ficha del dado 1: {fichaUno.Resultado}");
            // Agrego un retraso de 1 segundo
            Thread.Sleep(1000);
            Console.WriteLine($"Ficha del dado 2: {fichaDos.Resultado}");
            // Agrego un retraso de 1 segundo
            Thread.Sleep(1000);
            Console.WriteLine($"Ficha del dado 3: {fichaTres.Resultado}");

            if (CompararIgualdad([fichaUno.Resultado, fichaDos.Resultado, fichaTres.Resultado]))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Felicitaciones, has ganado!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo sentimos, has perdido!!!");
                Console.ResetColor();
            }
        }

        private bool CompararIgualdad(int[] valoresDados)
        {
            //Devuelvo true si en los elementos del arreglo solo existe 1 distinto. Osea si todos son iguales.
            return valoresDados.Distinct().Count() == 1;
        }
    }
}

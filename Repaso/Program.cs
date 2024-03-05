using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Program
    {
        static long puntajeRecord = 100;
        static string jugadorRecord = "Juan Perez";

        static void Main(string[] args)
        {
            string continuar="s";
            do
            {
                IniciarJuego();
                Console.WriteLine("desea continuar? ");
                continuar = Console.ReadLine();
            } while (continuar != "n");
            
        }

        static void IniciarJuego()
        {
            Console.WriteLine("ingrese nombre de jugador");
            string nombreJugador = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo puntaje");
            long nuevoPuntaje = long.Parse(Console.ReadLine());
            verificarRecord(nuevoPuntaje, nombreJugador);
            Console.ReadKey(true);
        }

        static void verificarRecord(long nuevoPuntaje, string jugador)
        {
            if (nuevoPuntaje > puntajeRecord)
            {
                Console.WriteLine("La nueva puntuacion mas alta es " + nuevoPuntaje);
                Console.WriteLine("La puntuacion mas alta fue lograda por " + jugador);
                puntajeRecord = nuevoPuntaje;
                jugadorRecord = jugador;
            }else
            {
                Console.WriteLine("La puntuacion mas alta de " + puntajeRecord +
                    " no ha sido superada y aun esta en manos de " + jugadorRecord);
            }
        }
    }
}

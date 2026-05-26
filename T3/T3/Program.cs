
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Random rand = new Random();
            string[] nombresPisos = { "Oficinas    ", "Laboratorios", "Aulas       ", "Biblioteca  ", "Almacen     " };
            int temp = rand.Next(20, 99);
            int P = rand.Next(1, 6);
            string pisoNombre = nombresPisos[P - 1];
            List<string> historial = new List<string>();

            do
            {
                op = MostrarMenu();
                switch (op)
                {
                    case 1:
                        VerificarEstadoEdificio(rand, nombresPisos, historial);
                        break;
                    case 2:
                        MostrarHistorial(historial);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("OPCION NO DISPONIBLE AHORA. INTENTE MAS TARDE");
                        Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case 4:
                        SalirSistema();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("========================================");
                        Console.WriteLine(" OPCION NO VALIDA, INTENTE DE NUEVO  ");
                        Console.WriteLine("========================================");
                        Thread.Sleep(1000);
                        break;
                }
            } while (op != 4);
        }


        static int MostrarMenu()
        {
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");
            Console.WriteLine("                  SCI UPN                ");
            Console.WriteLine("       --PANEL DE CONTROL--             ");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("FECHA Y HORA ACTUAL: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1] VERIFICAR EL ESTADO DEL EDIFICIO ");
            Console.WriteLine("[2] HISTORIAL");
            Console.WriteLine("[3] GENERAR INFORME DE EVENTOS RECIENTES");
            Console.WriteLine("[4] SALIR");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("INGRESE OPCION --> ");
            Console.ResetColor();

            int op;
            while (!int.TryParse(Console.ReadLine(), out op))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor ingrese un número válido.");
                Console.ResetColor();
                Console.Write("INGRESE OPCION --> ");
            }

            return op;
        }
        static void VerificarEstadoEdificio(Random rand, string[] nombresPisos, List<string> historial) { }
        static void MostrarHistorial(List<string> historial) { }
        static void SalirSistema() { }
    }
}

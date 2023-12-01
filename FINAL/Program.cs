using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, opcion1, opcion2, opcion3;
            do
            {
                Console.Clear();
                Pantallas.MenuPrin();
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Pantallas.Menu1();
                            opcion1 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opcion1)
                            {
                                case 1:
                                    Operaciones.Agregar1();
                                    break;
                                case 2:
                                    Operaciones.Eliminar1();
                                    break;
                                case 3:
                                    Operaciones.Modificar1();
                                    break;
                                case 4:
                                    Operaciones.Mostrar1();
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine("VOLVIENDO AL MENU PRINCIPAL...");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("DIGITE UNA OPCION VALIDA...");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (opcion1 != 5);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Pantallas.Menu2();
                            opcion2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opcion2)
                            {
                                case 1:
                                    Operaciones.Agregar2();
                                    break;
                                case 2:
                                    Operaciones.Eliminar2();
                                    break;
                                case 3:
                                    Operaciones.Mostrar2();
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine("VOLVIENDO AL MENU PRINCIPAL...");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("DIGITE UNA OPCION VALIDA...");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (opcion2 != 4);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Pantallas.Menu3();
                            opcion3 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opcion3)
                            {
                                case 1:
                                    Operaciones.IngresarProd();
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    Operaciones.Mostrar3();
                                    break;
                                case 4:
                                    Console.WriteLine("VOLVIENDO AL MENU PRINCIPAL...");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("DIGITE UNA OPCION VALIDA...");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (opcion3 != 4);
                        break;
                    case 4:
                        Console.WriteLine("SALIENDO DEL PROGRAMA...");
                        break;
                    default:
                        Console.WriteLine("DIGITE UNA OPCION VALIDA...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 4);

            Console.ReadKey();
        }
    }
}

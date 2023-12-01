using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    class Operaciones
    {
        // ARREGLOS DEL MENU 1
        public static string[] nombres = new string[5];
        public static float[] precio = new float[5];
        public static int[] stock = new int[5];
        public static int limite = 0;
        // ARREGLOS DEL MENU 2
        public static string[] almacenes = new string[5];
        public static int limite2 = 0;
        // ARREGLOS MENU 3
        public static string[] almacenes2 = new string[5];
        public static string[] producto = new string[5];
        public static int[] stock2 = new int[5];
        public static int limite3 = 0;

        // OPCIONES MENU 1
        public static void Eliminar1()
        {
            Mostrar1();
            Console.Write("\nescriba el nombre del producto que desea eliminar: ");
            string eliminar = Console.ReadLine();
            bool encontrado = false;
            for(int i = 0; i < limite; i++)
            {
                if (eliminar == nombres[i])
                {
                    encontrado = true;
                    for(int j = i; j < limite-1; j++)
                    {
                        nombres[j] = nombres[j + 1];
                        precio[j] = precio[j + 1];
                        stock[j] = stock[j + 1];
                    }
                    limite--;
                    Console.WriteLine("ELEMENTO ELIMINADO...");
                    Console.ReadKey();
                }
            }
            if (encontrado != true)
            {
                Console.WriteLine("NO SE ENCONTRO EL PRODUCTO...");
                Console.ReadKey();
            }
        }
        public static void Agregar1()
        {
            if (limite != 5)
            {
                Console.Write("ingrese el nombre del producto: ");
                nombres[limite] = Console.ReadLine();
                Console.Write("ingrese el precio del producto: ");
                precio[limite] = float.Parse(Console.ReadLine());
                Console.Write("ingrese el stock del producto: ");
                stock[limite] = int.Parse(Console.ReadLine());
                Console.WriteLine("datos ingresados correctamente. ");
                limite++;
            }
            else
            {
                Console.WriteLine("SE HA ALCANZADO EL LIMITE DEL ARREGLO");
                Console.ReadKey();
            }
        }
        public static void Mostrar1()
        {
            Console.WriteLine("PRODUCTO / PRECIO / STOCK");
            for (int i = 0; i < limite; i++)
            {
                Console.Write("\n"+nombres[i] + " / " + precio[i] + " / " + stock[i]);
            }
        }
        public static void Modificar1()
        {
            Mostrar1();
            Console.Write("\nescriba el nombre del producto que desea modificar: ");
            string modificar = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < limite; i++)
            {
                if (modificar == nombres[i])
                {
                    encontrado = true;
                    Console.WriteLine("producto encontrado: ");
                    Console.WriteLine(nombres[i] + " / " + precio[i] + " / " + stock[i]);
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.Write("ingrese el nombre a reemplazar: ");
                    nombres[i] = Console.ReadLine();
                    Console.Write("ingrese precio a reemplazar: ");
                    precio[i] = float.Parse(Console.ReadLine());
                    Console.Write("ingrese stock a reemplazar: ");
                    stock[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("producto reemplazado: ");
                    Console.WriteLine(nombres[i] + " / " + precio[i] + " / " + stock[i]);
                    Console.WriteLine("retornando al menu...");
                    Console.ReadKey();
                }
            }
            if (encontrado!=true)
            {
                Console.WriteLine("EL PRODUCTO NO SE HA ENCONTRADO...");
                Console.ReadKey();
            }
        }
        // OPCIONES MENU 2
        public static void Agregar2()
        {
            if (limite2 != 5)
            {
                Console.Write("ingrese el nombre del producto: ");
                almacenes[limite2] = Console.ReadLine();
                Console.WriteLine("datos ingresados correctamente. ");
                limite2++;
            }
            else
            {
                Console.WriteLine("SE HA ALCANZADO EL LIMITE DEL ARREGLO");
                Console.ReadKey();
            }
        }
        public static void Eliminar2()
        {
            Mostrar2();
            Console.Write("\nescriba el nombre del producto que desea eliminar: ");
            string eliminar = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < limite2; i++)
            {
                if (eliminar == almacenes[i])
                {
                    encontrado = true;
                    for (int j = i; j < limite2 - 1; j++)
                    {
                        almacenes[j] = almacenes[j + 1];
                    }
                    limite2--;
                    Console.WriteLine("ELEMENTO ELIMINADO...");
                    Console.ReadKey();
                }
            }
            if (encontrado != true)
            {
                Console.WriteLine("NO SE ENCONTRO EL PRODUCTO...");
                Console.ReadKey();
            }
        }
        public static void Mostrar2()
        {
            Console.WriteLine("ALMACENES:");
            for (int i = 0; i < limite2; i++)
            {
                Console.Write("\nalmacen {0}: {1} ",i+1,almacenes[i]);
            }
        }
        //OPCIONES MENU 3
        public static void IngresarProd()
        {
            Mostrar2();
            bool existe = false;
            bool existe2 = false;
            do
            {
                Console.Write("\ningrese el nombre del almacen: ");
                almacenes2[limite3] = Console.ReadLine();
                for(int i = 0; i < limite2; i++)
                {
                    if (almacenes[i] == almacenes2[limite3])
                    {
                        existe2 = true;
                    }
                }
            } while (existe2 != true);
            Console.WriteLine("****************************************************");
            Mostrar1();
            do
            {
                Console.Write("\ningrese el nombre del producto a ingresar: ");
                producto[limite3] = Console.ReadLine();
                for (int i = 0; i < limite; i++)
                {
                    if (producto[limite3] == nombres[i])
                    {
                        existe = true;
                    }
                }
                if (existe == false)
                {
                    Console.WriteLine("EL PRODUCTO INGRESADO NO EXISTE...");
                    Console.WriteLine("VUELVA A DIGITAR UN PRODUCTO.");
                }
            } while (existe != true);
            bool negativo = true;
            do
            {
                string producto;
                int stock2;
                Console.Write("\ningrese el nombre del stock a ingresar: ");
                stock2[limite3] = int.Parse(Console.ReadLine());
                Console.WriteLine("PRODUCTO INGRESADO.");
                
                for (int i = 0; i < limite; i++)
                {
                    if (producto == nombres[i])
                    {
                        if (stock[i] - stock2 < 0)
                        {
                            Console.WriteLine("el stock excede las existencias disponibles.");
                            Console.WriteLine("VUELVA A DIGITAR EL STOCK...");
                            Console.ReadKey();
                        }
                        else
                        {
                            stock[i] = stock[i] - stock2;
                            negativo = false;
                        }
                    }
                }
                


            } while (negativo != false);
            Console.ReadKey();

        }
        public static bool Restar(string producto,int stock2)
        {
            bool negativo=true;
            for (int i = 0; i < limite; i++)
            {
                if (producto == nombres[i])
                {
                    if (stock[i] - stock2 < 0)
                    {
                        Console.WriteLine("el stock excede las existencias disponibles.");
                        Console.WriteLine("VUELVA A DIGITAR EL STOCK...");
                        Console.ReadKey();
                    }
                    else
                    {
                        stock[i] = stock[i] - stock2;
                        negativo = false;
                    }
                }
            }
            return negativo;
        }
        public static void Mostrar3()
        {
            Console.WriteLine("producto / alamcen / cantidad");
            for (int i = 0; i < limite3; i++)
            {
                Console.Write("\n" + producto[i] + " / " + almacenes2[i] + " / " + stock2[i]);
            }
            Console.ReadKey();
        }
    }
}

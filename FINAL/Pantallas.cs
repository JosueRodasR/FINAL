using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    class Pantallas
    {
        public static void MenuPrin()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("  Sistema de inventario Mi tiendita   ");
            Console.WriteLine("======================================");
            Console.WriteLine("1. gestionar productos.");
            Console.WriteLine("2. gestionar almacenes.");
            Console.WriteLine("3. agregar extraer productos");
            Console.WriteLine("4. salir.");
            Console.WriteLine("======================================");
            Console.Write("digite su opcion: ");
        }
        public static void Menu1()
        {
            Console.WriteLine("          Gestionar productan           ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. agregar producto.");
            Console.WriteLine("2. eliminar producto.");
            Console.WriteLine("3. modificar producto");
            Console.WriteLine("4. mostrar inventario.");
            Console.WriteLine("5. volver al menu principal.");
            Console.WriteLine("======================================");
            Console.Write("digite su opcion: ");
        }
        public static void Menu2()
        {
            Console.WriteLine("           Gestionar almacenes          ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. agregar almacen.");
            Console.WriteLine("2. eliminar almacen.");
            Console.WriteLine("3. mostrar almacenes.");
            Console.WriteLine("4. volver al menu principal.");
            Console.WriteLine("======================================");
            Console.Write("digite su opcion: ");
        }
        public static void Menu3()
        {
            Console.WriteLine("       Agregar y Extraer Productos      ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. ingresar producto en almacen.");
            Console.WriteLine("2. extraer producto de almacen.");
            Console.WriteLine("3. ver stock actual.");
            Console.WriteLine("4. volver al menu principal.");
            Console.WriteLine("======================================");
            Console.Write("digite su opcion: ");
        }
    }
}

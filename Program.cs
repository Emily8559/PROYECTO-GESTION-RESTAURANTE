// See https://aka.ms/new-console-template for more information
using System;

namespace PRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
             SistemaRestaurante sistema = new SistemaRestaurante();
            int opcion;

            do
            {
                 Console.WriteLine("\n=== SISTEMA DE GESTIÓN DE RESTAURANTE ===");
                Console.WriteLine("1. Crear restaurante");
                Console.WriteLine("2. Listar restaurantes");
                Console.WriteLine("3. Crear cliente");
                Console.WriteLine("4. Listar clientes");
                Console.WriteLine("5. Crear plato");
                Console.WriteLine("6. Listar menú");
                Console.WriteLine("7. Tomar pedido");
                Console.WriteLine("8. Despachar pedido");
                Console.WriteLine("9. Mostrar ganancias");
                Console.WriteLine("0. Salir");
                Console.Write(" Opción: ");
                opcion = int.Parse(Console.ReadLine() ?? "0");

                switch (opcion)                 // 5
                {                               // 5
                    case 1:
                        Console.Write("NIT: "); string nit = Console.ReadLine() ?? "";
                        Console.Write("Nombre: "); string nombre = Console.ReadLine() ?? "";
                        Console.Write("Dueño: "); string dueno = Console.ReadLine() ?? "";
                        Console.Write("Celular: "); string cel = Console.ReadLine() ?? "";
                        Console.Write("Dirección: "); string dir = Console.ReadLine() ?? "";
                        sistema.CrearRestaurante(nit, nombre, dueno, cel, dir);
                        break;
                    case 2: sistema.ListarRestaurantes(); break;

                    case 3:
                        Console.Write("Cédula: "); string ced = Console.ReadLine() ?? "";
                        Console.Write("Nombre: "); string nomC = Console.ReadLine() ?? "";
                        Console.Write("Celular: "); string celC = Console.ReadLine() ?? "";
                        Console.Write("Email: "); string email = Console.ReadLine() ?? "";
                        sistema.CrearCliente(ced, nomC, celC, email);
                        break;

                    case 4: sistema.ListarClientes(); break;

                    case 5:
                        Console.Write("Código: "); string cod = Console.ReadLine() ?? "";
                        Console.Write("Nombre: "); string nomP = Console.ReadLine() ?? "";
                        Console.Write("Descripción: "); string desc = Console.ReadLine() ?? "";
                        Console.Write("Precio: "); decimal precio = decimal.Parse(Console.ReadLine() ?? "0");
                        sistema.CrearPlato(cod, nomP, desc, precio);
                        break;

                    case 6: sistema.ListarPlatos(); break;

                    case 7:
                        Console.Write("Cédula del cliente: ");
                        string cedulaPedido = Console.ReadLine() ?? "";
                        sistema.TomarPedido(cedulaPedido);
                        break;

                    case 8: sistema.DespacharPedido(); break;

                    case 9: sistema.MostrarGanancias(); break;
                    case 0: Console.WriteLine("Saliendo del sistema"); break;
                    default: Console.WriteLine("Opción no válida"); break;

                }

            }  while (opcion != 0);
        }
    }
}

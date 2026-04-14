using MySql_Conexion.Data;
using MySql_Conexion.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Bienvenido al Administrador de Usuarios y Companies");

Database database = new Database();
var db = database.Context;

int opcion;

do
{
    Console.WriteLine("\n--- Menú ---");
    Console.WriteLine("1. Agregar Usuario");
    Console.WriteLine("2. Listar Usuarios");
    Console.WriteLine("3. Buscar Usuario por ID");
    Console.WriteLine("4. Agregar Company");
    Console.WriteLine("5. Listar Companies");
    Console.WriteLine("6. Buscar Company por ID");
    Console.WriteLine("7. Salir");
    Console.Write("Elige una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opción no válida.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre del usuario: ");
            string nombre = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            db.Usuarios.Add(new Usuario { Nombre = nombre, Email = email });
            db.SaveChanges();
            Console.WriteLine("Usuario agregado a la DB.");
            break;

        case 2:
            Console.WriteLine("--- Lista de Usuarios ---");
            var usuarios = db.Usuarios.ToList();
            if (usuarios.Count == 0) Console.WriteLine("No hay usuarios.");
            else usuarios.ForEach(u => Console.WriteLine(u));
            break;

        case 3:
            Console.Write("ID del usuario a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int idU))
            {
                var u = db.Usuarios.Find(idU);
                Console.WriteLine(u != null ? u.ToString() : "Usuario no encontrado.");
            }
            break;

        case 4:
            Console.Write("Nombre de la company: ");
            string cname = Console.ReadLine();
            Console.Write("Industria: ");
            string industria = Console.ReadLine();
            Console.Write("Pais: ");
            string pais = Console.ReadLine();
            Console.Write("UsuarioID propietario: ");
            if (!int.TryParse(Console.ReadLine(), out int uid))
            {
                Console.WriteLine("ID no válido.");
                break;
            }

            db.Companies.Add(new Company
            {
                Nombre = cname,
                Industria = industria,
                Pais = pais,
                UsuarioId = uid
            });
            db.SaveChanges();
            Console.WriteLine("Company agregada a la DB.");
            break;

        case 5:
            Console.WriteLine("--- Lista de Companies ---");
            var companies = db.Companies.ToList();
            if (companies.Count == 0) Console.WriteLine("No hay companies.");
            else companies.ForEach(c => Console.WriteLine(c));
            break;

        case 6:
            Console.Write("ID de la company a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int idC))
            {
                var c = db.Companies.Find(idC);
                Console.WriteLine(c != null ? c.ToString() : "Company no encontrada.");
            }
            break;

        case 7:
            Console.WriteLine("¡Hasta luego!");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

} while (opcion != 7);
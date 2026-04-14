using System;
using System.Collections.Generic;

List<Users> listaUsuarios = new List<Users>();

Console.Write("Nombre: ");
string name = Console.ReadLine();

Console.Write("Edad: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Email: ");
string email = Console.ReadLine();


Users usuarios = new Users
{
    Name = name,
    Age = age,
    Email = email
};

listaUsuarios.Add(usuarios);

Console.WriteLine($"Usuario guardado: {listaUsuarios[0].Name}, {listaUsuarios[0].Age}, {listaUsuarios[0].Email}");

class Users
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}
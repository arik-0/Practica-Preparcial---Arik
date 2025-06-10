using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practica_programacion_EJ_1
{
    class Cliente
    {
        
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; }

        public void Login()
        {
            RepoClientes Repo = new RepoClientes();
            try
            {
                Console.WriteLine("Ingrese su Nombre:");
                string unNombre = Console.ReadLine();

                Console.WriteLine("Ingrese su Apellido:");
                string unApellido = Console.ReadLine();

                Console.WriteLine("Ingrese su Contraseña:");
                string unaContrasena = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(unNombre) ||
                    string.IsNullOrWhiteSpace(unApellido) ||
                    string.IsNullOrWhiteSpace(unaContrasena))
                {
                    throw new ArgumentException("Ninguno de los campos puede estar vacío.");
                }

                Cliente cliente = RepoClientes.BuscarCliente(unNombre, unApellido);

                if (cliente.Contrasena == unaContrasena)
                {
                    Console.WriteLine("Inicio de sesión exitoso.");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de autenticación: " + ex.Message);
                Console.WriteLine("Desea Registrarse?");
                Console.WriteLine("1 - Si");
                Console.WriteLine("2 - Salir");
                string estaRegistrado = Console.ReadLine();
                if (estaRegistrado == "1")
                {
                    Cliente NuevoCliente = new Cliente();
                    Console.WriteLine("Nombre:");
                    NuevoCliente.Nombre = Console.ReadLine();
                    Console.WriteLine("Apellido:");
                    NuevoCliente.Apellido = Console.ReadLine();
                    Console.WriteLine("Clave:");
                    NuevoCliente.Contrasena = Console.ReadLine();
                    Repo.AgregarCliente(NuevoCliente);
                }
                else { Environment.Exit(1); }
            }
        }
    }
}
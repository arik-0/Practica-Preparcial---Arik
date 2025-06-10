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
            try
            {
                Console.WriteLine("Ingrese su Nombre:");
                string unNombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Apellido:");
                string unApellido = Console.ReadLine();
                Console.WriteLine("Ingrese su Contraseña:");
                string unaContrasena = Console.ReadLine();

                // Validación básica (puedes expandir esto con lógica real)
                if (string.IsNullOrWhiteSpace(unNombre) ||
                    string.IsNullOrWhiteSpace(unApellido) ||
                    string.IsNullOrWhiteSpace(unaContrasena))
                {
                    throw new ArgumentException("Ninguno de los campos puede estar vacío.");
                }

                // Aquí podrías validar contra las propiedades del objeto Cliente
                if (unNombre == Nombre && unApellido == Apellido && unaContrasena == Contrasena)
                {
                    Console.WriteLine("Inicio de sesión exitoso.");
                }
                else
                {
                    Console.WriteLine("Credenciales incorrectas.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
            }
        }
    }
}

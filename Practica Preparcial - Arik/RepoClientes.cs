using System;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_programacion_EJ_1
{
    class RepoClientes
    {
        private static List<Cliente> clientes = new List<Cliente>{};

        public static Cliente BuscarCliente(string nombre, string apellido)
        {
            var cliente = clientes.FirstOrDefault(c =>
                c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                c.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));

            if (cliente == null)
            {
                throw new Exception("Cliente no encontrado.");
            }
            return cliente;
        }
        public void AgregarCliente(Cliente nuevoCliente)
        {
            clientes.Add(nuevoCliente);
        }
    }
}
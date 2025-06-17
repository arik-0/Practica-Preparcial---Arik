using System;
using System.Collections.Generic;
using System.Linq;
using Practica_programacion_EJ_1;
using Practica_Preparcial___Arik;

namespace Practica_Preparcial___Arik
{
    public class Banco
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<CuentaBancaria> Cuentas { get; set; } = new List<CuentaBancaria>();

        public void AgregarCliente(Cliente cliente)
        {
            if (cliente != null && !Clientes.Contains(cliente))
            {
                Clientes.Add(cliente);
                Console.WriteLine($"Cliente {cliente.Nombre} {cliente.Apellido} agregado al banco.");
            }
        }

        public void AgregarCuenta(Cliente cliente, CuentaBancaria cuenta)
        {
            if (cliente == null || cuenta == null) return;

            cuenta.Titular = $"{cliente.Nombre} {cliente.Apellido}";
            cuenta.NumeroCuenta = GenerarNumeroCuentaUnico();
            Cuentas.Add(cuenta);

            if (cliente.Cuentas == null)
                cliente.Cuentas = new List<CuentaBancaria>();

            cliente.Cuentas.Add(cuenta);

            Console.WriteLine($"Cuenta N° {cuenta.NumeroCuenta} agregada para {cuenta.Titular}.");
        }

        public CuentaBancaria BuscarCuenta(int numeroCuenta)
        {
            return Cuentas.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
        }

        public Cliente BuscarCliente(string nombre, string apellido)
        {
            return Clientes.FirstOrDefault(c =>
                c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                c.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));
        }

        private int GenerarNumeroCuentaUnico()
        {
            Random rnd = new Random();
            int nuevoNumero;
            do
            {
                nuevoNumero = rnd.Next(10000, 99999);
            } while (Cuentas.Any(c => c.NumeroCuenta == nuevoNumero));

            return nuevoNumero;
        }

        public void MostrarCuentasDeCliente(Cliente cliente)
        {
            if (cliente?.Cuentas == null || cliente.Cuentas.Count == 0)
            {
                Console.WriteLine("Este cliente no tiene cuentas asociadas.");
                return;
            }

            Console.WriteLine($"Cuentas de {cliente.Nombre} {cliente.Apellido}:");
            foreach (var cuenta in cliente.Cuentas)
            {
                Console.WriteLine($"- Cuenta N° {cuenta.NumeroCuenta} | Tipo: {cuenta.GetType().Name} | Saldo: ${cuenta.Saldo}");
            }
        }
    }
}

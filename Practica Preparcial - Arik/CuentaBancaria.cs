using Practica_programacion_EJ_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Preparcial___Arik
{
    public abstract class CuentaBancaria
    {
        public int NumeroCuenta { get; set; }
        public string Titular { get; set; }
        public int Saldo { get; set; }
        
        public void Depositar(Cliente unCliente) 
        {
            try
            {
                Console.WriteLine($"Bienvenido {unCliente.Nombre}, ingrese el monto a depositar:");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int monto) || monto <= 0)
                {
                    throw new ArgumentException("Monto inválido. Debe ser un número positivo.");
                }

                Saldo += monto;
                Console.WriteLine($"Depósito exitoso. Su nuevo saldo es: ${Saldo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al depositar: " + ex.Message);
            }
        }
        public abstract void Retirar();
        public abstract int ConsultarSaldo();


    }
    
    
}

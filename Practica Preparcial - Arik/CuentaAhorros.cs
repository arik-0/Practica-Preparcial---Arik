using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Preparcial___Arik
{
    using System;

     public class CuentaAhorros : CuentaBancaria
        {
            private int retirosRealizadosEsteMes = 0;
            private const int MAX_RETIROS_POR_MES = 3;

            public override void Retirar()
            {
                try
                {
                    if (retirosRealizadosEsteMes >= MAX_RETIROS_POR_MES)
                    {
                        throw new InvalidOperationException("Límite de retiros mensuales alcanzado (3).");
                    }

                    Console.WriteLine("Ingrese el monto a retirar:");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int monto) || monto <= 0)
                    {
                        throw new ArgumentException("Monto inválido. Debe ser un número positivo.");
                    }

                    if (Saldo < monto)
                    {
                        throw new InvalidOperationException("Fondos insuficientes.");
                    }

                    Saldo -= monto;
                    retirosRealizadosEsteMes++;
                    Console.WriteLine($"Retiro exitoso. Retiros restantes este mes: {MAX_RETIROS_POR_MES - retirosRealizadosEsteMes}");
                    Console.WriteLine($"Nuevo saldo: ${Saldo}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al retirar: " + ex.Message);
                }
            }

            public override int ConsultarSaldo()
            {
                Console.WriteLine($"Su saldo actual es: ${Saldo}");
                return Saldo;
            }

            // Método opcional que podrías llamar desde algún cron para reiniciar el contador cada mes
            public void ReiniciarContadorMensual()
            {
                retirosRealizadosEsteMes = 0;
            }
     }
}

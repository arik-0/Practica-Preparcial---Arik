namespace Practica_Preparcial___Arik
{
    public class CuentaCorriente : CuentaBancaria
    {
        private const int LIMITE_SOBREGIRO = -100000;

        public override void Retirar()
        {
            try
            {
                Console.WriteLine("Ingrese el monto a retirar:");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int monto) || monto <= 0)
                {
                    throw new ArgumentException("Monto inválido. Debe ser un número positivo.");
                }

                if (Saldo - monto < LIMITE_SOBREGIRO)
                {
                    throw new InvalidOperationException("Fondos insuficientes. Ha excedido el límite de sobregiro.");
                }

                Saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: ${Saldo}");
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
    }
}

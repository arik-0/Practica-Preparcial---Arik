using Practica_Preparcial___Arik; // Asegúrate de que estos namespaces son correctos
using Practica_programacion_EJ_1; // y que contienen las clases necesarias.
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    // Si usas este repositorio, considera hacerlo static o instanciarlo en Main.
    // RepoClientes repositorio = new RepoClientes(); 
    
    public static void Main(string[] args)
    {
        
        Menu();
    }

    public static void Menu()
    {
        bool sigue = true;
        
            
            Cliente unCliente = new Cliente();
            // Asumiendo que Login() devuelve un booleano indicando si el login fue exitoso.
            unCliente.Login();

        while (sigue == true)
        {

            

            CuentaBancaria cuenta = SeleccionCuenta();

            if (cuenta == null)
            {
                Console.WriteLine("Selección de cuenta inválida. Saliendo del programa.");
                return;
            }
            Console.WriteLine("************ Menu Bancario 3000 xt 3d 4k ************");
            Console.WriteLine("Indique su operacion deseada");
            Console.WriteLine(" 0 - Salir");
            Console.WriteLine(" 1 - Retirar");
            Console.WriteLine(" 2 - Depositar");
            Console.WriteLine(" 3 - Consultar Saldo");
            string eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "0":
                    Console.WriteLine("Saliendo del Menu Bancario...");
                    sigue = false;
                    break;
                case "1":
                    cuenta.Retirar(); // Llama al método Retirar de la instancia de cuenta.
                    break;
                case "2":
                    cuenta.Depositar(unCliente); // Llama al método Depositar de la instancia de cuenta.
                    break;
                case "3":
                    cuenta.ConsultarSaldo(); // Llama al método ConsultarSaldo de la instancia de cuenta.
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
        }
    }

    // Este método ahora crea y devuelve una instancia de la cuenta seleccionada.
    public static CuentaBancaria SeleccionCuenta() // 1 Corriente 2 Ahorros
    {
        Console.WriteLine(" Seleccione su tipo de Cuenta ");
        Console.WriteLine(" 1 - Cuenta Corriente");
        Console.WriteLine(" 2 - Cuenta Ahorros");
        string cuentARetirar = Console.ReadLine();
        int cuentaRetirarNum;

        if (int.TryParse(cuentARetirar, out cuentaRetirarNum))
        {
            if (cuentaRetirarNum == 1)
            {
                return new CuentaCorriente();
            }
            else if (cuentaRetirarNum == 2)
            {
                return new CuentaAhorros();
            }
            else
            {
                Console.WriteLine("Número de cuenta inválido.");
                return null; 
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
            return null; 
        }
    }
}
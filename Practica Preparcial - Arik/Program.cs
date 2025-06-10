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
        Cliente unCliente = new Cliente();
        // Asumiendo que Login() devuelve un booleano indicando si el login fue exitoso.
        unCliente.Login(); 

        Console.WriteLine("************ Menu Bancario 3000 xt 3d 4k ************");
        Console.WriteLine("Indique su operacion deseada");
        Console.WriteLine(" 0 - Salir");
        Console.WriteLine(" 1 - Retirar");
        Console.WriteLine(" 2 - Depositar");
        Console.WriteLine(" 3 - Consultar Saldo");
        
        string eleccion = Console.ReadLine();
        
        // Declara la variable 'cuenta' fuera de los bloques if/else para que sea accesible.
        // Asume que tienes una clase base 'Cuenta'.
        CuentaBancaria cuenta = SeleccionCuenta(); 

        if (cuenta == null) // Si la selección de cuenta fue inválida.
        {
            Console.WriteLine("Selección de cuenta inválida. Saliendo del programa.");
            return;
        }

        switch (eleccion)
        {
            case "0":
                Console.WriteLine("Saliendo del Menu Bancario...");
                break;
            case "1":
                cuenta.Retirar(); // Llama al método Retirar de la instancia de cuenta.
                break;
            case "2":
                cuenta.Depositar(); // Llama al método Depositar de la instancia de cuenta.
                break;
            case "3":
                cuenta.ConsultarSaldo(); // Llama al método ConsultarSaldo de la instancia de cuenta.
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                break;
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
                return null; // Retorna null si la opción no es 1 o 2.
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
            return null; // Retorna null si la entrada no es un número.
        }
    }
}

// *** EJEMPLOS DE CLASES (Necesitarás definirlas en tus archivos .cs) ***
// Si no tienes estas clases, el código corregido no compilará.

// public abstract class Cuenta
// {
//     public decimal Saldo { get; protected set; } // Propiedad para el saldo
//     public abstract void Retirar();
//     public abstract void Depositar();
//     public abstract void ConsultarSaldo();
// }

// public class CuentaCorriente : Cuenta
// {
//     public override void Retirar()
//     {
//         Console.WriteLine("Realizando retiro en Cuenta Corriente...");
//         // Lógica para retirar de cuenta corriente
//     }

//     public override void Depositar()
//     {
//         Console.WriteLine("Realizando depósito en Cuenta Corriente...");
//         // Lógica para depositar en cuenta corriente
//     }

//     public override void ConsultarSaldo()
//     {
//         Console.WriteLine($"Saldo actual en Cuenta Corriente: {Saldo}");
//     }
// }

// public class CuentaAhorros : Cuenta
// {
//     public override void Retirar()
//     {
//         Console.WriteLine("Realizando retiro en Cuenta de Ahorros...");
//         // Lógica para retirar de cuenta de ahorros
//     }

//     public override void Depositar()
//     {
//         Console.WriteLine("Realizando depósito en Cuenta de Ahorros...");
//         // Lógica para depositar en cuenta de ahorros
//     }

//     public override void ConsultarSaldo()
//     {
//         Console.WriteLine($"Saldo actual en Cuenta de Ahorros: {Saldo}");
//     }
// }

// public class Cliente
// {
//     public bool Login()
//     {
//         Console.WriteLine("Simulando login...");
//         Console.Write("Usuario: ");
//         string user = Console.ReadLine();
//         Console.Write("Contraseña: ");
//         string pass = Console.ReadLine();

//         // Lógica de validación de login. Por ahora, siempre true.
//         return true; 
//     }
// }

// public class RepoClientes
// {
//     // Esta clase no se usó en el código proporcionado, pero es útil para gestionar clientes.
// }
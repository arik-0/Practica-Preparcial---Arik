using Practica_Preparcial___Arik;
using Practica_programacion_EJ_1;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    RepoClientes repositorio = new RepoClientes();
    public static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Cliente unCliente = new Cliente();
        unCliente.Login();
        bool logueado = false;
        Console.WriteLine("************ Menu Bancario 3000 xt 3d 4k ************");
        Console.WriteLine("Indique su operacion deseada");
        Console.WriteLine(" 0 - Salir");
        Console.WriteLine(" 1 - Retirar");
        Console.WriteLine(" 2 - Depositar");
        Console.WriteLine(" 3 - Consultar Saldo");
        
        string eleccion = Console.ReadLine();
        logueado = SeleccionCuenta();
        if (logueado = true)
        {
            switch (eleccion)
            {
                case "0":
                    break;
                case "1":
                   // Retirar();
                    break;
                case "2":
                   // Depositar();
                    break;
                case "3":
                 //   ConsultarSaldo();
                    break;
            }
        }
        else { Console.WriteLine(); }
        

    }
    public static bool SeleccionCuenta()
    {
        
        Console.WriteLine(" Seleccione su tipo de Cuenta ");
        Console.WriteLine(" 1 - Cuenta Corriente");
        Console.WriteLine(" 2 - Cuenta Ahorros");
        string cuentARetirar = Console.ReadLine();
        return true;
    }
}
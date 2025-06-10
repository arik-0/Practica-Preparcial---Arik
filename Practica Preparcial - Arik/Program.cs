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
    Cliente unCliente = new Cliente();
    public static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
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
                break;
            case "1":
                Retirar();
                SeleccionCuenta();
                break;
            case "2":
                Depositar();
                SeleccionCuenta();
                break; 
            case "3":
                ConsultarSaldo();
                break;
        }

    }
    public static void SeleccionCuenta()
    {
        Cliente.Login();
        Console.WriteLine(" Seleccione su tipo de Cuenta ");
        Console.WriteLine(" 1 - Cuenta Corriente");
        Console.WriteLine(" 2 - Cuenta Ahorros");
    }
}
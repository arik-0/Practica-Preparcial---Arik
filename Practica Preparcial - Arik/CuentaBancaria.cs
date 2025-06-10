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

        
        public void Depositar() 
        {
            
        }
        public void Retirar()
        {

        }
        public int ConsultarSaldo()
        {
            return 0;
        }


    }
    
    
}

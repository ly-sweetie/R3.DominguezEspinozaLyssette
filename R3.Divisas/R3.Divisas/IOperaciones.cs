using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3.Divisas
{
    
    
        interface IOperaciones
        {
            //Clase de la interfas y sus metodos
            double DolaresaPesos();
            double PesosaDolares();
            double DolaresaEuros();
            double EurosaYen();
            double WonaLibra();
            double PesosaWon();
        }
    
}

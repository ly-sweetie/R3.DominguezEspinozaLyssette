using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3.Divisas
{
    
   //Crear interfas
        interface IConvertir
        {
            //Encapsular datos
            double Dolares { get; set; }
            double Pesos { get; set; }
            double Euros { get; set; }
            double Won { get; set; }
            double Libra { get; set; }
            double Yen { get; set; }
        }
    
}

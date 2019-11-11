using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3.Divisas
{
    class Operaciones: Principal, IConvertir
    {
        // Instanciar objetos
        public double DaP { get; set; }
        public double PaD { get; set; }
        public double DaE { get; set; }
        public double EaY { get; set; }
        public double WaL { get; set; }
        public double PaW { get; set; }

        public double Pesos { get; set; }
        public double Dolares { get; set; }
        public double Euros { get; set; }
        public double Won { get; set; }
        public double Libra { get; set; }
        public double Yen { get; set; }

        //Metodo para convertir dolares a pesos
        public double DolaresaPesos()
        {
            DaP = 18.30 * Dolares;
            return DaP;
        }

        //Metodo para convertir pesos a dolares
        public double PesosaDolres()
        {
            PaD = Pesos / 18.30;
            return PaD;
        }

        //Metodo para convertir Dolares a Euros
        public double DolaresaEuros()
        {
            DaE =Dolares*0.91;
            return DaE;
        }

        //Metodos para convertir Euros a Yen
    
        public double EurosaYen()
        {
            EaY = Euros * 120.36;
            return EaY;
        }
      
        //Metodo para convertir Won a Libra
        public double WonaLibra()
        {
            WaL = Libra / 1482.63;
            return WaL;
        }

        //Metodo para convertir Pesos a Won
        public double PesosaWon()
        {
            PaW = Pesos * 60.72;
            return PaW;
        }
    }



    
}



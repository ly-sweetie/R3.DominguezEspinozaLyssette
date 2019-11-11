using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3.Divisas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear Objeto
            Random rnd = new Random();
            Operaciones Op = new Operaciones();
            Op.Pesos = rnd.Next(100, 500); ;
            Op.Dolares = rnd.Next(100, 500); ;
            Op.Won = rnd.Next(100, 500); ;
            Op.Euros = rnd.Next(100, 500); ;
            Op.Libra = rnd.Next(100, 500); ;
            Op.Yen = rnd.Next(100, 500); ;
            Menu();


            void Menu()
            {
                //Bienvenida al programa
                Console.WriteLine("Bienvenido a la mejor calculadora del mundo");

                //Menu de converciones de divisas
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("1.-Dolares a Pesos\n2.-Pesos a Dolares\n3-Dolares a Euros\n4.-EurosaYen\n5.-Won a Libra\n6.-PesosaWon\n7.-Salir");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("El resultado de dolares a pesos es: " + Op.DolaresaPesos());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();

                        break;
                    case "2":
                        Console.WriteLine("El resultado de pesos a dolares: " + Op.PesosaDolres());
                        Console.ReadKey();
                        Console.Clear();
                       
                        break;

                    case "3":
                        Console.WriteLine("El resultado de dolares a euros:" + Op.DolaresaEuros());
                        Console.ReadKey();
                        Console.Clear();
                     
                        break;

                    case "4":
                        Console.WriteLine("El resultado de euros a Yen:"+ Op.EurosaYen());
                        Console.ReadKey();
                        Console.Clear();
                      
                        break;

                    case "5":
                        Console.WriteLine("El resultado de won a Libra:" + Op.WonaLibra());
                        Console.ReadKey();
                        Console.Clear();
                      
                        break;

                    case "6":
                        Console.WriteLine("El resultado de pesos a Won:"+ Op.PesosaWon());
                        Console.ReadKey();
                        Console.Clear();
                      
                        break;

                    case "7":
                        Console.WriteLine("bye bye");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        //Si se ingresa alguna opcion que no es la edecuada 
                        Console.WriteLine("No es valido");
                        break;
                }
                Console.Clear();
                Menu();
            }
        }
    }
}
    


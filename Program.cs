using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
             AvisosTrafico av1 = new AvisosTrafico();

            av1.MostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial Madrid", "Sancion de velocidad $300.00", "20-05-24");

            Console.WriteLine(av2.getFecha()); 

            av2.MostrarAviso();
        }
    }
}

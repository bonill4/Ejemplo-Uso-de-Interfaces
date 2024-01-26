using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    internal class AvisosTrafico : IAvisos
    {

        public AvisosTrafico() 
        {

            remitente = "DGT";

            mensaje = "Sancion cometida, Pague antes de 3 dias y se beneficiara de una reduccion en la sancion del 50%";

            fecha = "";
        
        }

        public AvisosTrafico(String remitente, String mensaje, String fecha)
        {

            this.remitente = remitente;

            this.mensaje = mensaje;

            this.fecha = fecha;

        }

        public string getFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine($"{mensaje} ha sido enviado por {remitente} el dia {fecha} ");
        }

        private String remitente;

        private String mensaje;

        private String fecha;
    }
}

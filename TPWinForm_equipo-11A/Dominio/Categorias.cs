using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categorias
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        //Sobreescribimos el método para que cuando lo ejecutemos devuelva la descripción en vez de la definición el objeto 
        //Porque por defecto el método tostring devuelve la definición. 
        public override string ToString()
        {
            return Descripcion;
        }

    }
}

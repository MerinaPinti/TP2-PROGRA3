using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_11A
{
    internal class Articulo
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ID_Marca { get; set; }
        public int ID_Categoria { get; set; }
        public float Precio { get; set; }

    }
}

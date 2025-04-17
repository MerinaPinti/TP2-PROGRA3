using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dominio
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ID_Marca { get; set; }
        public int ID_Categoria { get; set; }
        public float Precio { get; set; }


        public Categorias Categoria { get; set; }

        public Marcas Marca { get; set; }

        public Imagenes Imagen { get; set; } 




    }
}

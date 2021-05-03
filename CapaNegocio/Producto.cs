using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto
    {
        // definir atributos
        private string nombre;
        private string precio;
        private string presentacion;
        private string fechaVencimiento;
        private string fechaFabricacion;
        private string unidadDisponibles;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Presentacion { get => presentacion; set => presentacion = value; }
        public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public string FechaFabricacion { get => fechaFabricacion; set => fechaFabricacion = value; }
        public string UnidadDisponibles { get => unidadDisponibles; set => unidadDisponibles = value; }

        //Propiedades: Como parte de la clase
        //Metodos
        public string Caducar()
        {
            return "Metodo caducar no esta disponible";
        }
        public string Curar()
        {
            return "Metodo curar no esta disponible";
        }
        public string Ayudar()
        {
            return "Metodo ayudar no esta disponible";
        }
    }
}

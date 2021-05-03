using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Local
    {
        // definir atributos
        private string direccion;
        private string tamaño;
        private string permisos;
        private string aforo;

        //Propiedades: Como parte de la clase

        public string Direccion { get => direccion; set => direccion = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public string Permisos { get => permisos; set => permisos = value; }
        public string Aforo { get => aforo; set => aforo = value; }

        //Metodos
        public string Almacenar()
        {
            return "Metodo Almacenar no esta implementado";
        }
        public string AcogerClientes()
        {
            return "Metodo Acoger Clientes no esta implementado";
        }

    }
}

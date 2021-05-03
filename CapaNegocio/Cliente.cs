using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente
    {
        //Atributos
        private string nombres;
        private string apellidos;
        private string sexo;
        private string edad;
        private string dni;
        //Propiedades : parte de la clase que permite acceder a los atributos 
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value; }
        //Metodos
        public string Comprar()
        {
            return "El método comprar no esta implementado.";
        }
        public string Consultar()
        {
            return "El método consultar no esta implementado.";
        }
        public string Elegir()
        {
            return "El método elegir no esta implementado.";
        }
        public string Recoger()
        {
            return "El método recoger no esta implementado.";
        }

    }
}

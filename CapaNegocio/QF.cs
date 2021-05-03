using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class QF
    {
        //Definir Atributos
        private string apellidos;
        private string nombres;
        private string experienciaLaboral;
        private string edad;
        private string dni;
        //Propiedades
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombrees { get => nombres; set => nombres = value; }
        public string ExperienciaLaboral { get => experienciaLaboral; set => experienciaLaboral = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value; }

        public string Controlar()
        {
            return "No se encuentra disponible";
        }
        public string Estudiar()
        {
            return "No se encuentra disponible";
        }
        public string Atender()
        {
            return "No se encuentra disponible";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tecnico
    {
        //Definir Atributos
        private string apellidos;
        private string nombres;
        private string experienciaLaboral;
        private string estudios;
        private string domicilio;
        //Propiedades
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string ExperienciaLaboral { get => experienciaLaboral; set => experienciaLaboral = value; }
        public string Estudios { get => estudios; set => estudios = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }

        public string ControlarVentas()
        {
            return "No se encuentra disponible";
        }
        public string AtenderVentas()
        {
            return "No se encuentra disponible";
        }
        public double BalanceDiario()
        {
            return 0;
        }
    }
}

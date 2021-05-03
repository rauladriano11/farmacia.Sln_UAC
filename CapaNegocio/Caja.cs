using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Caja
    {
        // definir atributos
        private string dinero;
        private string numeroTarjeta;
        private string recibo;
        private string computadora;

        //propiedades: como partes de la clase que permite acceder a los atributos
        public string Dinero { get => dinero; set => dinero = value; }
        public string NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }

        public string Computadora { get => computadora; set => computadora = value; }
        public string Recibo { get => recibo; set => recibo = value; }
        //metodos

        public string CobrarDinero()
        {
            return "Metodo Cobrar Dinero no esta implementado";
        }

        public string DarVuelto()
        {
            return "Metodo Dar vuelto, no esta implementado";
        }
        public string RegistrarVenta()
        {
            return "Metodo Registrar Venta, no esta implementado";
        }

        public string DarRecibo()
        {
            return "Metodo Dar Recibo, no esta implementado";
        }

    }
}

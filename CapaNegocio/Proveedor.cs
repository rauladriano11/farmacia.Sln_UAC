using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proveedor
    {
        // definir atributos
        private string nombre;
        private string ubicacion;
        private string pedidos;
        private string telefono;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Pedidios { get => pedidos; set => pedidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        //Propiedades: Como parte de la clase


        //Metodos
        public string AgregarProducto()
        {
            return "Metodo Agregar Producto no esta implementado";
        }
        public string QuitarProducto()
        {
            return "Metodo Quitar Producto no esta implementado";
        }
        public string CantPedidos()
        {
            return "Metodo Cantidad de Pedidos no esta implementado";
        }
        public string EnviarProductos()
        {
            return "Metodo Enviar Productos no esta implementado";
        }
    }
}

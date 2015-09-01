using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_08_26
{
    class Usuario
    {
        public string nombre;
        public string apellido;
        public long dni;
        public Vehiculo auto;
        //sobrecarga:
        //nombrar de la misma manera al metodo y cambiarle la firma al metodo 
        //(modificando el tipo de parametro y el orden en el que recibe los parametros)

        public Usuario(long DNIingresado)
        {
            this.dni = DNIingresado;
        }

        public Usuario(long DNIingresado,string apellidoIngresado)
        {
            this.dni = DNIingresado;
            this.apellido = apellidoIngresado;
        }

        public Usuario(long DNIingresado, string apellidoIngresado, string nombreIngresado)
        {
            this.dni = DNIingresado;
            this.apellido = apellidoIngresado;
            this.nombre = nombreIngresado;
        }

        public Usuario(Usuario usuarioIngresado)
        {
            this.nombre = usuarioIngresado.nombre;
            this.apellido = usuarioIngresado.apellido;
            this.dni = usuarioIngresado.dni;
            this.auto = usuarioIngresado.auto;
        }

    }
}

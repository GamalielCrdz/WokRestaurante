using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokRestaurante.Entidades
{
    class Cliente
    {
        String nombre;
        String telefono;
        String direccion;
        String edad;

        public Cliente(String nombre, String telefono, String direccion, String edad)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.edad = edad;
        }
    }
}

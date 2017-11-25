using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokRestaurante.Entidades
{
    class Orden
    {
        String estado;
        String fecha;
        String hora;
        Cliente cliente;

        public Orden(String estado,String fecha,String hora, Cliente cliente)
        {
            this.estado = estado;
            this.fecha = fecha;
            this.hora = hora;
            this.cliente = cliente;
        }
    }
}

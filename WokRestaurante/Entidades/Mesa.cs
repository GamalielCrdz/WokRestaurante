using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokRestaurante.Entidades
{
    class Mesa
    {
        int id;
        String capacidad;

        public Mesa(int id, String capacidad)
        {
            this.id = id;
            this.capacidad = capacidad;
        }
    }
}

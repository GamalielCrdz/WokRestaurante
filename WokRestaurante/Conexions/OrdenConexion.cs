using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokRestaurante.Conexions
{
    class OrdenConexion
    {
        public String conexion;
        public String query;
        public OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
        public DataTable dataTable = new DataTable();

        public OrdenConexion() {
            this.query = "SELECT Articulo.Nombre, Articulo.Costo, Articulo.Tipo, Orden.Estado, Orden.IdMesa " +
                "FROM (((Rel_Per_Art " +
                "INNER JOIN Persona ON Rel_Per_Art.IdPersona = Persona.IdPersona) " +
                "INNER JOIN  Orden  ON Persona.IdOrden = Orden.IdCliente) "+
            "INNER JOIN Articulo ON Rel_Per_Art.IdArticulo = Articulo.IdArticulo)";
            this.conexion = "Provider=Microsoft.Jet.OLEDB.4.0 ;Data Source=" + 
                "C:\\Users\\gama_\\Documents\\Visual Studio 2017\\Projects\\Prototipo\\Prototipo\\bin\\Debug" + 
                "\\BD.mdb";
        }

        public DataTable getOrdenFromDb()
        {
            oleDbDataAdapter = new OleDbDataAdapter(query, conexion);
            oleDbDataAdapter.Fill(dataTable);
            return this.dataTable;
        }
    }
}
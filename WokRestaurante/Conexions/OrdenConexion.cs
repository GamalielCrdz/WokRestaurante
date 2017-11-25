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
            this.query = "SELECT * FROM Orden";
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

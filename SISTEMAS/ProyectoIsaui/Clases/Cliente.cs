using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIsaui.Clases
{
    public class Cliente
    {
     
        public void Insertar(string Nombre, string Apellido, string Telefono, string Documento)
        {
            string sql = "insert into cliente (nombre, apellido)";
            sql = sql + "values (" + "'" + Nombre + "'";
            sql = sql + "," + "'" + Apellido + "'";
            sql = sql + "," + "'" + Telefono + "'";
            sql = sql + "," + "'" + Documento + "'";
            sql = sql + ")";
            Db.Guardar(sql);
        }
    }
}

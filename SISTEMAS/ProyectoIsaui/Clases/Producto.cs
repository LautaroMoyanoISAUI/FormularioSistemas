using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIsaui.Clases
{
    public class Producto
    {
        public void Insertar(string nombre, double precio, string codbarra, int stock)
        {
            string sql = "insert into producto(nombre, precio, codigobarra, stock)";
            sql = sql + "values (" + "'" + nombre + "'";
            sql = sql + "," + precio.ToString();
            sql = sql + "," + "'" + codbarra + "'";
            sql = sql + "," + "'" + stock + "'";
            sql = sql + ")"; 
            Db.Guardar(sql);
            
        }
        
        public DataTable Buscar (string nombre)
        {
            string sql = "select codproducto, nombre, precio, CodigoBarra, stock";
            sql = sql + " from producto";
            return Db.Select(sql);
            
        }
        public DataTable BuscarCodBarra(string codigo)
        {
            string sql = "select codproducto, nombre, precio, CodigoBarra";
            sql = sql + " from producto";
            sql = sql + " where CodigoBarra = " + "'" + codigo + "'";
            return Db.Select(sql);
        }
        public DataTable BuscarPorID(int codproducto)
        {
            string sql = "select codproducto, nombre, precio, CodigoBarra";
            sql = sql + " from producto";
            sql = sql + " where codProducto = " + "'" + codproducto + "'";
            return Db.Select(sql);
        }

        public void Modificar(int codproducto, string nombre, double precio)
        {
            string sql = "update producto set ";
            sql = sql + "nombre = " + "'" + nombre + "'";
            sql = sql + ",precio = " + "'" + precio.ToString() + "'";
            sql = sql + "where codproducto = " + codproducto;
            Db.Guardar(sql);
        }

        public void Borrar(int codproducto)
        {
            string sql = "delete from producto where";
            sql = sql + " codproducto =" + codproducto.ToString();
            Db.Guardar(sql);
        }
    }   

}

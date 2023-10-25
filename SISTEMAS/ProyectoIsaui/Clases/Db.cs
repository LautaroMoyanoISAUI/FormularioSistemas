using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace ProyectoIsaui.Clases
{
    public static class Db
    {
        public static string GetCadena()
        {
            string Cadena = "datasource=localhost;port=3306;User Id=root;database=isaui;Password='123';SSL Mode=None;";
            return Cadena;
        }

        public static void Guardar(string sql)
        {
            string Cadena = GetCadena();
            MySqlConnection con = new MySqlConnection(Cadena);
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable Select(string sql)
        {
            string Cadena = GetCadena();
            MySqlConnection con = new MySqlConnection(Cadena);
            MySqlCommand comand = new MySqlCommand();
            comand.CommandText = sql;
            comand.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = comand;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class conexionsql
    {
        static string conexionstring = "server=DESKTOP-7L3JSUP\\SQLEXPRESS;database=sis1;integrated security=true";
        SqlConnection con = new SqlConnection(conexionstring);


        public int consultalogin(string usu, string cons)
        {
            int count;
            con.Open();
            string Query = "Select Count (*) From persona where usuario='" + usu + "'and contrasena='" + cons + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }
        public DataTable consultaUsuariosdg()
        {
            string query = "select * from persona";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public int insertarusuario(string nombre, string apellidos, string ci, string cel, string usuario, string contrasena)
        {
            int flag = 0;
            con.Open();
            string query = "insert into persona values ('" + nombre + "','" + apellidos + "','" + ci + "','" + cel + "','" + usuario + "','" + contrasena + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

        }
        public int modificarusuario(string nombre, string apellidos, string ci, string cel, string usuario, string contrasena)
        {
            int flag = 0;
            con.Open();
            string query = "Update persona set nombre='" + nombre + "',apellidos='" + apellidos + "',ci='" + ci + "',telefono='" + cel + "',usuario='" + usuario + "',contrasena='" + contrasena + "' where ci='" + ci + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int eliminarusuario(string ci)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from persona where ci='" + ci + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

        }
    }
}
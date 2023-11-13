using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class conexionsqln
    {
        conexionsql cn = new conexionsql();
        public int consql(string user, string pass )
        {
            return cn.consultalogin( user,pass );
        }
        public DataTable consultadt()
        {
            return cn.consultaUsuariosdg();
        }
        public int insertarusuario(string nombre, string apellidos, string ci, string cel, string usuario, string contrasena)
        {


            return cn.insertarusuario(nombre, apellidos, ci, cel, usuario, contrasena);

        }

        public int modificarusuario(string nombre, string apellidos, string ci, string cel, string usuario, string contrasena)
        {
            return cn.modificarusuario(nombre, apellidos, ci, cel, usuario, contrasena);
        }

        public int eliminarusuario(string ci)
        {
            return cn.eliminarusuario(ci);

        }

    }

}

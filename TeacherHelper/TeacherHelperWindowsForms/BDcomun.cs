#region librerias ("BNL")
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
#endregion

namespace TeacherHelperWindowsForms
{
    public class BDComun
    {
        #region coneccion sql ("BNL")
        public static SqlConnection ObtnerCOnexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source=(Local);Initial Catalog=BDREGISTRO;Integrated Security=True");
            Conn.Open();

            return Conn;
        }
        #endregion

    }
}
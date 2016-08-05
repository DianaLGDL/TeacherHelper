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
    class UsuarioDAL
    {

        #region crear cuentas ("BNL")
        public static int CrearCuentas(string pUsuario, string pContraseña, String pCorreo, String pNombre, String pProfesion)
        {
            int resultado = 0;
            SqlConnection Conn = BDComun.ObtnerCOnexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into TEACHER(USUARIO, CONTRASEÑA, CORREO, NOMBRE, PROFESION)values('{0}' , PwdEncrypt('{1}'),'{2}','{3}','{4}')", pUsuario, pContraseña, pCorreo, pNombre, pProfesion), Conn);
            resultado = Comando.ExecuteNonQuery();
            Conn.Close();
            return resultado;


        }
        #endregion

        #region Autentificar ("BNL")
        public static int Autentificar(String pUsuario, String pContraseña)
        {
            int resultado = -1;

            SqlConnection conexion = BDComun.ObtnerCOnexion();
            SqlCommand comando = new SqlCommand(string.Format(
            "Select * From TEACHER where USUARIO = '{0}' and PwdCompare('{1}',CONTRASEÑA)= 1", pUsuario, pContraseña), conexion);

            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;

        }
    }
    #endregion
}

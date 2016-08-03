#region Librerias ("BNL")
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace TeacherHelperWindowsForms
{
    class Conexion_Registro
    {
        #region comandos sql
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        #endregion

        #region registro
        public string registro(int NUM_LISTA, int MATRICULA, string NOMBRE, int CALIFICACIONES, int PROMEDIO, string CORREO, string NOTAS)
        {
            string salida = "Registro correcto";
            try
            {
                cmd
                =
                new
                SqlCommand("Insert into Segundo_A(NUM_LISTA) values (" + RFC + ",'" + NOMBRE + "','" + SEXO + "'," + EDAD + ",'" + CALLE + "','" + COLONIA + "'," + CODIGO_POSTAL + ",'" + MUNICIPIO + "','" + ESTADO + "','" + PAIS + "'," + TEL + "," + TEL_TRABAJO + "," + FAX + "," + CEL + ")", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo registrar";
            }
            return salida;
        }
        #endregion
    }
}

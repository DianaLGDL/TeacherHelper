#region Librerias ("BNL")
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace TeacherHelperWindowsForms
{
    class Conexion_Registro
    {
        #region comandos sql ("BNL")
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        #endregion

        #region conexion sql ("BNL")
        public Conexion_Registro()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=PROGRAMA_1; Integrated Security=True");
                cn.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto");
            }
        }
        #endregion

        #region cargar LISTA SEGUNDO BIS ("BNL")
        public void LISTA_SEGUNDO_BIS(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select*from Segundo_A order by NUM_LISTA ASC", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la lista de los Alumnos");
            }
        }
        #endregion

        /*
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
    */
    }
}

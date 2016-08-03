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
                cn = new SqlConnection("Data Source=.;Initial Catalog=EXAMEN2;Integrated Security=True");
                cn.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto");
            }
        }
        #endregion

        #region cargar LISTA SEGUNDO BIS ("BNL")
        //checar codigo
        public void LISTA_SEGUNDO_BIS(DataGridView dataGridView1)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Segundo_A", cn);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la lista de las citas");
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

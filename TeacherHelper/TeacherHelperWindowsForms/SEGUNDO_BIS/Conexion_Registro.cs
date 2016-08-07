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

        #region registro ("BNL")
        public string registro(int NUM_LISTA, int MATRICULA, string NOMBRE, int CAL1, int CAL2,int CAL3, int CAL4, int CAL5, int CAL6, int PROMEDIO, string CORREO, string NOTAS)
        {
            string salida = "Registro correcto";
            try
            {
                cmd
                =
                new
                SqlCommand("Insert into Segundo_A(NUM_LISTA,MATRICULA,NOMBRE,CAL1,CAL2,CAL3,CAL4,CAL5,CAL6,PROMEDIO,CORREO,NOTAS) values (" +NUM_LISTA+ "," +MATRICULA+ ",'" +NOMBRE+ "'," +CAL1+ "," + CAL2 + "," + CAL3 + "," + CAL4 + "," + CAL5 + "," + CAL6 + "," + PROMEDIO+ ",'" + CORREO + "','" + NOTAS + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo registrar";
            }
            return salida;
        }
        #endregion

        #region registro existente ("BNL")
        public int registroExistente(int MATRICULA)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Segundo_A where MATRICULA =" + MATRICULA + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ya existe Alumno");
            }
            return contador;
        }
        #endregion

        #region mostrar registro ("BNL")
        public void Mostrar(int MATRICULA, ComboBox cbxNumList, TextBox txtNombre, ComboBox cbCal1, ComboBox cbCal2, ComboBox cbCal3, ComboBox cbCal4, ComboBox cbCal5, ComboBox cbCal6, ComboBox cbPromedio, TextBox txtCorreo, TextBox txtNotas)
        {
            try
            {
                cmd = new SqlCommand("Select * from Segundo_A where MATRICULA="+MATRICULA+"",cn);
                dr = cmd.ExecuteReader();
                if( dr.Read())
                {
                    Convert.ToInt32(cbxNumList.Text = dr["NUM_LISTA"].ToString());
                    txtNombre.Text = dr["NOMBRE"].ToString();
                    Convert.ToInt32(cbCal1.Text = dr["CAL1"].ToString());
                    Convert.ToInt32(cbCal2.Text = dr["CAL2"].ToString());
                    Convert.ToInt32(cbCal3.Text = dr["CAL3"].ToString());
                    Convert.ToInt32(cbCal4.Text = dr["CAL4"].ToString());
                    Convert.ToInt32(cbCal5.Text = dr["CAL5"].ToString());
                    Convert.ToInt32(cbCal6.Text = dr["CAL6"].ToString());
                    Convert.ToInt32(cbPromedio.Text = dr["PROMEDIO"].ToString());
                    txtCorreo.Text = dr["CORREO"].ToString();
                    txtNotas.Text = dr["NOTAS"].ToString();
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos");
            }
        }
        #endregion

        #region ACTUALIZAR ("BNL")
        public string actualizar(int MATRICULA, int NUM_LISTA, string NOMBRE, int CAL1, int CAL2, int CAL3, int CAL4, int CAL5, int CAL6, int PROMEDIO, string CORREO, string NOTAS)
        {
            string AC = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("Update Segundo_A set NUM_LISTA = " + NUM_LISTA + ", NOMBRE = '" + NOMBRE + "', CAL1 = " + CAL1 + ", CAL2 = " + CAL2 + ", CAL3 = " + CAL3 + ", CAL4 = " + CAL4 + ", CAL5 = " + CAL5 + ", CAL6 = " + CAL6 + ", PROMEDIO = " + PROMEDIO + ", CORREO = '" + CORREO + "', NOTAS = '" + NOTAS + "' WHERE MATRICULA = " + MATRICULA + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                AC = "No se pudo actualizar" + ex.ToString();
            }
            return AC;
        }
        #endregion

    }
}

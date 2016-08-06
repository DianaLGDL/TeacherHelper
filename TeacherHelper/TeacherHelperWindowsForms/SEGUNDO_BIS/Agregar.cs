#region librerias ("BNL")
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace TeacherHelperWindowsForms.SEGUNDO_BIS
{
    public partial class Agregar : Form
    {
        Conexion_Registro c = new Conexion_Registro();
        public Agregar()
        {
            InitializeComponent();
        }

        #region groupbox ("BNL")
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        #region textbox ("BNL")
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region botones ("BNL")
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (c.registroExistente(Convert.ToInt32(txtMatricula.Text)) == 0)
            {
                MessageBox.Show(c.registro(Convert.ToInt32(cbxNumList.Text), Convert.ToInt32(txtMatricula.Text), txtNombre.Text, Convert.ToInt32(cbCal1.Text), Convert.ToInt32(cbCal2.Text), Convert.ToInt32(cbCal3.Text), Convert.ToInt32(cbCal4.Text), Convert.ToInt32(cbCal5.Text),Convert.ToInt32(cbCal6.Text), Convert.ToInt32(cbPromedio.Text),txtCorreo.Text,txtNotas.Text));
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}

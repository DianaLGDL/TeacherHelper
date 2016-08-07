#region LIBRERIAS ("BNL")
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
    public partial class Eliminar : Form
    {
        Conexion_Registro c = new Conexion_Registro();
        public Eliminar()
        {
            InitializeComponent();

        }

        #region VENTANA ("BNL")
        private void Eliminar_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region BOTONES ("BNL")
        private void btnBorrarRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.BorrarAlumno(Convert.ToInt32(txtMatricula.Text)));
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNumList.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region txtEjecutar ("BNL")
        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

            if (c.registroExistente(Convert.ToInt32(txtMatricula.Text)) > 0)
            {
                c.MostrarAlumno(Convert.ToInt32(txtMatricula.Text), txtNombre, txtNumList);
            }
            else
            {
                
                txtNombre.Text = "";
                txtNumList.Text = "";
         
            }
        }
        #endregion

    }
}

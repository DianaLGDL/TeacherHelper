#region Librerias ("BNL")
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
    public partial class Modificar : Form
    {
        Conexion_Registro c = new Conexion_Registro();
        public Modificar()
        {
            InitializeComponent();
        }

        #region botones ("BNL")
        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.actualizar(Convert.ToInt32(txtMatricula.Text), Convert.ToInt32(cbxNumList.Text), txtNombre.Text, Convert.ToInt32(cbCal1.Text), Convert.ToInt32(cbCal2.Text), Convert.ToInt32(cbCal3.Text), Convert.ToInt32(cbCal4.Text), Convert.ToInt32(cbCal5.Text), Convert.ToInt32(cbCal6.Text), Convert.ToInt32(cbPromedio.Text), txtCorreo.Text, txtNotas.Text));
        }
        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            
            cbxNumList.Text = "";
            txtNombre.Text = "";
            cbCal1.Text = "";
            cbCal2.Text = "";
            cbCal3.Text = "";
            cbCal4.Text = "";
            cbCal5.Text = "";
            cbCal6.Text = "";
            cbPromedio.Text = "";
            txtNombre.Text = "";
            txtNotas.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region TXTEJECUTAR
        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

            if (c.registroExistente(Convert.ToInt32(txtMatricula.Text)) > 0)
            {
                c.Mostrar(Convert.ToInt32(txtMatricula.Text), cbxNumList, txtNombre, cbCal1, cbCal2, cbCal3, cbCal4, cbCal5, cbCal6, cbPromedio, txtCorreo, txtNotas);
            }
            else
            {
                cbxNumList.Text = "";
                txtNombre.Text = "";
                cbCal1.Text = "";
                cbCal2.Text = "";
                cbCal3.Text = "";
                cbCal4.Text = "";
                cbCal5.Text = "";
                cbCal6.Text = "";
                cbPromedio.Text = "";
                txtNombre.Text = "";
                txtNotas.Text = "";
            }
            
        }

       
    }
    #endregion
}

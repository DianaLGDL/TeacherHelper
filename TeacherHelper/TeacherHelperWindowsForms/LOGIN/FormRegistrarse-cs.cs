using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherHelperWindowsForms
{
    public partial class FormRegistrarse_cs : Form
    {
        public FormRegistrarse_cs()
        {
            InitializeComponent();
        }

        #region form ("BNL")
        private void FormRegistrarse_cs_Load(object sender, EventArgs e)
        {
            btncuenta.Enabled = false;
        }
        #endregion

        #region botones ("BNL")

        private void btncuenta_Click(object sender, EventArgs e)
        {

            

            if (textBox2.Text == textBox5.Text)
            {
                if (UsuarioDAL.CrearCuentas(textBox1.Text, textBox5.Text, textBox3.Text, textBox4.Text, textBox6.Text ) > 0)
                {
                    MessageBox.Show("cuenta creada con exito");

                }

            }
            else MessageBox.Show("No se creo la cuenta");
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        #endregion

        #region textbox ("BNL")
        private void textBox2_TextChanged(object sender, EventArgs e)//textbox contraseña//
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//textbox confirmar//
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//textbox usuario//
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//textbox correo//
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//textbox nombre//
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)//textbox profesion//
        {

        }
        #endregion

        #region checkbox ("BNL")
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btncuenta.Enabled = !btncuenta.Enabled;
        }
        #endregion

    }
}


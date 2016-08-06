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

namespace TeacherHelperWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region form ("BNL")
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        #endregion

        #region botones ("BNL")

        private void btnRegistrarse_Click_1(object sender, EventArgs e)
        {
            FormRegistrarse_cs r = new FormRegistrarse_cs();
            r.ShowDialog();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (UsuarioDAL.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
            {
                GRUPOS g = new GRUPOS();
                g.ShowDialog();
            }
            else
                MessageBox.Show("Error en los datos");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

#endregion
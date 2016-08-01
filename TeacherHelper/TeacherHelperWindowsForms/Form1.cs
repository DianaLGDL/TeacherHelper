#region librerias
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region botones
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (UsuarioDAL.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
            {
                TeacherHelper t = new TeacherHelper();
                t.ShowDialog();
            }
            else
                MessageBox.Show("Error en los datos");
        } 

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrarse_cs r = new FormRegistrarse_cs();
            r.ShowDialog();
        }
    }
}
#endregion
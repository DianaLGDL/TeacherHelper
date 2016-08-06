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
using TeacherHelperWindowsForms.SEGUNDO_BIS;
#endregion

namespace TeacherHelperWindowsForms
{
    public partial class GRUPOS : Form
    {
        public GRUPOS()
        {
            InitializeComponent();
        }

        #region ventana ("BNL")
        private void GRUPOS_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region radio buttons ("BNL")
        private void Rb_2Bis_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region botones ("BNL")
        private void button1_Click(object sender, EventArgs e)
        {
            if (Rb_2Bis.Enabled)
            {
                LIST_ALUMN_BIS BIS = new LIST_ALUMN_BIS();
                BIS.ShowDialog();
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}

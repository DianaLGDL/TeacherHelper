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
    public partial class LIST_ALUMN_BIS : Form
    {
        Conexion_Registro c = new Conexion_Registro();
        public LIST_ALUMN_BIS()
        {
            InitializeComponent();
        }

        #region Ventana ("BNL")
        private void LIST_ALUMN_BIS_Load(object sender, EventArgs e)
        {
            Conexion_Registro c = new Conexion_Registro();
            c.LISTA_SEGUNDO_BIS(dataGridView1);

        }
        #endregion

        #region GridView ("BNL")
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region BOTONES ("BNL")
        private void btnLista_Click(object sender, EventArgs e)
        {
            c.LISTA_SEGUNDO_BIS(dataGridView1);
        }
        #endregion
    }
}

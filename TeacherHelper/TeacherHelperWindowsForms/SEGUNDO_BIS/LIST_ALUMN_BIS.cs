using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherHelperWindowsForms.SEGUNDO_BIS
{
    public partial class LIST_ALUMN_BIS : Form
    {
        Conexion_Registro c = new Conexion_Registro();
        public LIST_ALUMN_BIS()
        {
            InitializeComponent();
        }

        private void LIST_ALUMN_BIS_Load(object sender, EventArgs e)
        {
            c.LISTA_SEGUNDO_BIS(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }
    }
}

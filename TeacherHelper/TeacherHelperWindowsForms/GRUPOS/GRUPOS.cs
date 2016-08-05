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

namespace TeacherHelperWindowsForms
{
    public partial class GRUPOS : Form
    {
        public GRUPOS()
        {
            InitializeComponent();
        }

        #region ventana
        private void GRUPOS_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region radio buttons
        private void Rb_2Bis_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region botones
        private void button1_Click(object sender, EventArgs e)
        {
            if (Rb_2Bis.Enabled)
            {
                LIST_ALUMN_BIS BIS = new LIST_ALUMN_BIS();
                BIS.ShowDialog();
            }
        }
        #endregion
    }
}

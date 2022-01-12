using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class REGISTRO_PARTICIPACION : Form
    {
        public REGISTRO_PARTICIPACION()
        {
            InitializeComponent();
        }
        private static REGISTRO_PARTICIPACION _Abrir;
        public static REGISTRO_PARTICIPACION Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new REGISTRO_PARTICIPACION();
                return _Abrir;
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

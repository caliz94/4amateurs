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
    public partial class CP_CONTENEDOR : Form
    {
        public CP_CONTENEDOR()
        {
            InitializeComponent();
        }

        
        private void eSTADISTICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integrantes abrirform = Integrantes.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }
        private void estadisticasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuPrincipal abrirform = MenuPrincipal.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }
        private void aDMINISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGIST_USU_AMATEURS abrirform = REGIST_USU_AMATEURS.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void rEGISTRODEPLACASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRO_PLACAS abrirform = REGISTRO_PLACAS.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void gANADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pARTICIPANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pARTICIPACIONESDESALASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

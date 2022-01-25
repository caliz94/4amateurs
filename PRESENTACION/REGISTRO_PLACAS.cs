using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class REGISTRO_PLACAS : Form
    {
        public REGISTRO_PLACAS()
        {
            InitializeComponent();
        }

        //HACER REFERENCIA A LA CLASE DE LA CAPA NEGOCIO
        CN_INTEGRANTES integrantes_cn = new CN_INTEGRANTES();
        CN_PLacas AGREGARPLACAS_CN = new CN_PLacas();
       
        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_integrante.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_id_integrante, "Obligatorio");
                    errorProvider1.SetError(txt_mes, "");
                    errorProvider1.SetError(txt_Nombre, "");
                    errorProvider1.SetError(txt_semana, "");
                }
                else if (txt_mes.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_id_integrante, "");
                    errorProvider1.SetError(txt_mes, "Obligatorio");
                    errorProvider1.SetError(txt_Nombre, "");
                    errorProvider1.SetError(txt_semana, "");
                }
                else if (txt_Nombre.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_id_integrante, "");
                    errorProvider1.SetError(txt_mes, "");
                    errorProvider1.SetError(txt_Nombre, "Obligatorio");
                    errorProvider1.SetError(txt_semana, "");
                }
                else if (txt_semana.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_id_integrante, "");
                    errorProvider1.SetError(txt_mes, "");
                    errorProvider1.SetError(txt_Nombre, "");
                    errorProvider1.SetError(txt_semana, "Obligatorio");
                }
                else
                {
         
                 
                    AGREGARPLACAS_CN.insertar_placas(Convert.ToInt32(txt_id_integrante.Text),txt_mes.Text, txt_semana.Text,Convert.ToInt32(txt_placas.Text));
                    MessageBox.Show("Se Registraron " + txt_placas.Text + " al integrante " +txt_Nombre.Text+ " Exitosamente");
                    txt_id_integrante.Clear();
                    txt_Nombre.Clear();
                    txt_mes.Clear();
                    txt_semana.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error ========>     " + ex);
            }

            
        }

        private void MostrarIntegrantes()
        {
            CN_PLacas mostarplacas = new CN_PLacas();
            dgv_integrantes.DataSource = mostarplacas.dt_MostrarIntegrantes();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static REGISTRO_PLACAS _Abrir;
        public static REGISTRO_PLACAS Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new REGISTRO_PLACAS();
                return _Abrir;
            }
        }

        private void REGISTRO_PLACAS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        private void REGISTRO_PLACAS_Load(object sender, EventArgs e)
        {
            MostrarIntegrantes();
           

        }


        private void dgv_integrantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            txt_id_integrante.Text = dgv_integrantes.CurrentRow.Cells["ID_INTEGRANTE"].Value.ToString();
            txt_Nombre.Text = dgv_integrantes.CurrentRow.Cells["USUARIO"].Value.ToString();              
        }
    }
}

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
    public partial class REGIST_USU_AMATEURS : Form
    {
        public REGIST_USU_AMATEURS()
        {
            InitializeComponent();
        }

        private static REGIST_USU_AMATEURS _Abrir;
        public static REGIST_USU_AMATEURS Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new REGIST_USU_AMATEURS();
                return _Abrir;
            }
        }

        //HACER REFERENCIA A LA CLASE DE LA CAPA NEGOCIO
        CN_INTEGRANTES INTEGRANTES_CN = new CN_INTEGRANTES();

        private bool editar = false;
        private void limpiar()
        {
            txt_usuario.Clear();
            txt_celular.Clear();
            txt_pais.Clear();
            txt_fecha_ingreso.Clear();
            txt_comentario.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {           
           if (editar == false)
            {
                try
                {
                    INTEGRANTES_CN.insertar_integrante(txt_usuario.Text, txt_celular.Text, txt_pais.Text, Convert.ToDateTime(txt_fecha_ingreso.Text), txt_comentario.Text/*, txt_estado.Text*/);
                    MessageBox.Show("Se Registro al integrante " + txt_usuario.Text + " Exitosamente");
                    mostrar();
                    limpiar();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("error"+ex);
                }
            }

            if (editar == true)
            {
                try
                {
                    INTEGRANTES_CN.editar_integrante(Convert.ToInt32(txt_id_integrante.Text),txt_usuario.Text, txt_celular.Text, txt_pais.Text, Convert.ToDateTime(txt_fecha_ingreso.Text), txt_comentario.Text);
                    MessageBox.Show("Se actualizo datos al integrante " + txt_usuario.Text + " Exitosamente");
                    mostrar();
                    limpiar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error al editar "+ex);
                }
            }

        }

        private void REGIST_USU_AMATEURS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        public void mostrar()
        {
            dgv_usuarios.DataSource = INTEGRANTES_CN.mostar_integ();
        }

        private void REGIST_USU_AMATEURS_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            editar = true;
            txt_id_integrante.Text = dgv_usuarios.CurrentRow.Cells["ID_INTEGRANTE"].Value.ToString();
            txt_usuario.Text = dgv_usuarios.CurrentRow.Cells["USUARIO"].Value.ToString();
            txt_celular.Text = dgv_usuarios.CurrentRow.Cells["CELULAR"].Value.ToString();
            txt_pais.Text = dgv_usuarios.CurrentRow.Cells["PAIS_NACIONALIDAD"].Value.ToString(); ;
            txt_fecha_ingreso.Text = dgv_usuarios.CurrentRow.Cells["FECHA_INGRESO"].Value.ToString();
            txt_comentario.Text = dgv_usuarios.CurrentRow.Cells["COMENTARIO"].Value.ToString();          
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {               
                INTEGRANTES_CN.eliminar_integrante(Convert.ToInt32(txt_id_integrante.Text));
                MessageBox.Show("Se elimino al integrante " + txt_usuario.Text + " Exitosamente");
                mostrar();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

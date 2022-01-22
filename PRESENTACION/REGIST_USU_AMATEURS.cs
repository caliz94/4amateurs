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
        #region singlenton
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
        private void REGIST_USU_AMATEURS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        #endregion

        //HACER REFERENCIA A LA CLASE DE LA CAPA NEGOCIO
        CN_INTEGRANTES INTEGRANTES_CN = new CN_INTEGRANTES();
        private bool editar = false;


        #region guardar
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == string.Empty)
            {
                errorProvider1.SetError(txt_pais, "");
                errorProvider1.SetError(txt_celular, "");
                errorProvider1.SetError(txt_usuario, "");
                errorProvider1.SetError(txt_fecha_ingreso, "");
                errorProvider1.SetError(txt_usuario, "Ingrese un Nombre de Usuario");
            }

            else if (txt_celular.Text == string.Empty)
            {
                errorProvider1.SetError(txt_usuario, "");
                errorProvider1.SetError(txt_pais, "");
                errorProvider1.SetError(txt_celular, "");
                errorProvider1.SetError(txt_usuario, "");
                errorProvider1.SetError(txt_fecha_ingreso, "");
                errorProvider1.SetError(txt_celular, "Ingrese un Numero celular");
            }

            else if (txt_pais.Text == string.Empty)
            {
                errorProvider1.SetError(txt_celular, "");
                errorProvider1.SetError(txt_usuario, "");
                errorProvider1.SetError(txt_pais, "");
                errorProvider1.SetError(txt_celular, "");
                errorProvider1.SetError(txt_usuario, "");
                errorProvider1.SetError(txt_fecha_ingreso, "");
                errorProvider1.SetError(txt_pais, "Ingrese el nombre del pais donde localidad");
            }

            else if (txt_fecha_ingreso.Text == string.Empty)
            {
                errorProvider1.SetError(txt_pais, "");
                errorProvider1.SetError(txt_celular, "");
                errorProvider1.SetError(txt_usuario, "");
                errorProvider1.SetError(txt_fecha_ingreso, "");
                errorProvider1.SetError(txt_fecha_ingreso, "Ingrese una fecha con un formato dd/mm/aaaa");
            }
            else
            {
                errorProvider1.SetError(txt_pais, "");
                errorProvider1.SetError(txt_celular, "");
                errorProvider1.SetError(txt_usuario, "");
                errorProvider1.SetError(txt_fecha_ingreso, "");

                if (editar == false)
                {
                    try
                    {
                        INTEGRANTES_CN.insertar_integrante(txt_usuario.Text, txt_celular.Text, txt_pais.Text, Convert.ToDateTime(txt_fecha_ingreso.Text), txt_comentario.Text/*, txt_estado.Text*/);
                        MessageBox.Show("Se Registro al integrante " + txt_usuario.Text + " Exitosamente");
                        mostrar();
                        limpiar();
                        editar = false;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("error" + ex);
                    }
                }

                if (editar == true)
                {
                    try
                    {
                        int id_integrante = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells["ID_INTEGRANTE"].Value.ToString());

                        INTEGRANTES_CN.editar_integrante(id_integrante, txt_usuario.Text, txt_celular.Text, txt_pais.Text, Convert.ToDateTime(txt_fecha_ingreso.Text), txt_comentario.Text);
                        MessageBox.Show("Se actualizo datos al integrante " + txt_usuario.Text + " Exitosamente");
                        mostrar();
                        limpiar();
                        editar = false;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("error al editar " + ex);
                    }
                }
            }
        }
        #endregion
        #region eliminar

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            int id_integrante = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells["ID_INTEGRANTE"].Value.ToString());
            string usuario = dgv_usuarios.CurrentRow.Cells["USUARIO"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Desea eliminar "+ usuario, "!Eliminar!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {                    
                    //INTEGRANTES_CN.eliminar_integrante(Convert.ToInt32(txt_id_integrante.Text));
                    INTEGRANTES_CN.eliminar_integrante(id_integrante);
                    MessageBox.Show("Se elimino al integrante " + id_integrante + " de nombre " + usuario + " Exitosamente");
                    mostrar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se elimino el registro, consulte a su administrador " + ex);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

          
        }
        #endregion
     

        public void mostrar()
        {
            CN_INTEGRANTES INTEGRANTES_CNeg = new CN_INTEGRANTES();
            dgv_usuarios.DataSource = INTEGRANTES_CNeg.mostar_integ();
        }
        private void limpiar()
        {
            txt_usuario.Clear();
            txt_celular.Clear();
            txt_pais.Clear();
            txt_fecha_ingreso.Clear();
            txt_comentario.Clear();
        }
        private void REGIST_USU_AMATEURS_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            editar = true;
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

        private void validaciones()
        {
       
           
        }
    }
}

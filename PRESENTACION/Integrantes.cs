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
using System.Data.SqlClient;
using System.Collections;

namespace PRESENTACION
{
    public partial class Integrantes : Form
    {
        public Integrantes()
        {
            InitializeComponent();
        }

        #region IMPLEMENTACIÓN SINGLENTON
        private static Integrantes _Abrir;
        public static Integrantes Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new Integrantes();
                return _Abrir;
            }
        }
        private void Integrantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        CN_INTEGRANTES Integrantes_cn = new CN_INTEGRANTES();
        private void mostrarIntegrantes()
        {
            dgv_integrantes.DataSource = Integrantes_cn.mostar_integ_2();
        }
        private void Integrantes_Load(object sender, EventArgs e)
        {
            mostrarIntegrantes();
        }
       
        //CADENA CON EL SERVIDOR DE BASE DE DATOS
        private SqlConnection Conexion = new SqlConnection("Server=.;database=AMATEURS;INTEGRATED SECURITY=TRUE");
        SqlCommand cmd;
        SqlDataReader dr;

        #region graficas
        //grafica de las placas al Año del integranmte x
        ArrayList total = new ArrayList();
        ArrayList mes = new ArrayList();
        private void Grafañointegrant()
        {
            total.Clear();
            mes.Clear();
            cmd = new SqlCommand("grafi_año_inte", Conexion);
            cmd.Parameters.AddWithValue("@id_integrante", txt_idUsuario.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                mes.Add(dr.GetString(1));
                total.Add(dr.GetInt32(0));
            }
            chart1.Series[0].Points.DataBindXY(mes, total);
            dr.Close();
            cmd.Parameters.Clear();
            Conexion.Close();
        }

        //grafica de las placas del mes del usuario x
        ArrayList Categoria = new ArrayList();
        ArrayList CantProd = new ArrayList();
        private void GrafCategorias()
        {
            Categoria.Clear();
            CantProd.Clear();
                cmd = new SqlCommand("grafi_mes_inte", Conexion);
                cmd.Parameters.AddWithValue("@id_integrante", txt_idUsuario.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                Conexion.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Categoria.Add(dr.GetInt32(0));
                    CantProd.Add(dr.GetInt32(1));
                }
                chart2.Series[0].Points.DataBindXY(CantProd, Categoria);
              
                dr.Close();
                Conexion.Close();                
        }

      
        ArrayList totalplacas = new ArrayList();
      
        private void tt_placas()
        {
            totalplacas.Clear();
            //mes.Clear();
            cmd = new SqlCommand("tt_placas", Conexion);
            cmd.Parameters.AddWithValue("@id_integrante", txt_idUsuario.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                totalplacas.Add(dr.GetInt32(0));               
            }
            chart3.Series[0].Points.DataBindY(totalplacas);
            dr.Close();
            cmd.Parameters.Clear();
            Conexion.Close();
        }
        //PROMEDIO
        ArrayList PROMEDIOX = new ArrayList();       
        private void PM_placas()
        {
            PROMEDIOX.Clear();
            cmd = new SqlCommand("pm_placas", Conexion);
            cmd.Parameters.AddWithValue("@id_integrante", txt_idUsuario.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PROMEDIOX.Add(dr.GetInt32(0));                
            }
            chart4.Series[0].Points.DataBindY(PROMEDIOX);
            dr.Close();
            cmd.Parameters.Clear();
            Conexion.Close();
        }        

        #endregion

        private void txt_idUsuario_TextChanged(object sender, EventArgs e)
        {
            fotos();
            GrafCategorias();
            Grafañointegrant();
            tt_placas();
            PM_placas();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void dgv_integrantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idUsuario.Text = dgv_integrantes.CurrentRow.Cells["ID_INTEGRANTE"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("no posee valores");
            }
        }

        public void fotos()
        {
            if (txt_idUsuario.Text == "1")
            {
                pictureBox1.Image = global::PRESENTACION.Properties.Resources._1;
            }
            if (txt_idUsuario.Text == "2")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._2;
            }
            if (txt_idUsuario.Text == "3")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._3;
            }
         
            if (txt_idUsuario.Text == "5")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._5;
               
            }
            if (txt_idUsuario.Text == "6")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._6;
            }
            //if (txt_idUsuario.Text == "")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._7;
            //}
            if (txt_idUsuario.Text == "8")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._8;
            }
            if (txt_idUsuario.Text == "9")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._9;
            }
            if (txt_idUsuario.Text == "10")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._10;
            }
            //if (txt_idUsuario.Text == "11")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._11;
            //}
            //if (txt_idUsuario.Text == "12")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._12;
            //}
            if (txt_idUsuario.Text == "13")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._13;
            }
            if (txt_idUsuario.Text == "14")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._14;
            }
            if (txt_idUsuario.Text == "15")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._15;
            }
            if (txt_idUsuario.Text == "16")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._16;
            }
            if (txt_idUsuario.Text == "17")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._17;
            }
            if (txt_idUsuario.Text == "18")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._18;
            }
            if (txt_idUsuario.Text == "19")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._19;
            }
            //if (txt_idUsuario.Text == "20")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._20;
            //}
            //if (txt_idUsuario.Text == "21")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._21;
            //}
            if (txt_idUsuario.Text == "22")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._22;
            }
            //if (txt_idUsuario.Text == "23")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._23;
            //}
            if (txt_idUsuario.Text == "24")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._24;
            }
            if (txt_idUsuario.Text == "25")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._25;
            }
            if (txt_idUsuario.Text == "26")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._26;
            }
            //if (txt_idUsuario.Text == "27")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._27;
            //}
            if (txt_idUsuario.Text == "28")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._28;
            }
            //if (txt_idUsuario.Text == "29")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._29;
            //}
            if (txt_idUsuario.Text == "30")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._30;
            }
            if (txt_idUsuario.Text == "31")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._31;
            }
            //if (txt_idUsuario.Text == "32")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._32;
            //}
            //if (txt_idUsuario.Text == "33")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._33;
            //}
            //if (txt_idUsuario.Text == "34")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._34;
            //}
            //if (txt_idUsuario.Text == "35")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._35;
            //}
            //if (txt_idUsuario.Text == "36")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._36;
            //}
            //if (txt_idUsuario.Text == "37")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._37;
            //}
            //if (txt_idUsuario.Text == "38")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._38;
            //}

        }

    }
}

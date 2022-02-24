using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace PRESENTACION
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        //CADENA CON EL SERVIDOR DE BASE DE DATOS
        public SqlConnection Conexion = new SqlConnection("Server=.;database=AMATEURS;INTEGRATED SECURITY=TRUE");
  
        SqlCommand cmd;
        SqlDataReader dar;
        SqlDataReader dr;

        ArrayList Categoria = new ArrayList();
        ArrayList CantProd = new ArrayList();
        private void GrafCategorias()
        {
            cmd = new SqlCommand("placas_mes", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dar = cmd.ExecuteReader();
           
            
            while (dar.Read())
            {
                Categoria.Add(dar.GetString(0));
                CantProd.Add(dar.GetInt32(1));
            }
            chart3.Series[0].Points.DataBindXY(Categoria, CantProd);
            dar.Close();
            Conexion.Close();

        }

        ArrayList Producto = new ArrayList();
        ArrayList Cant = new ArrayList();
        private void mejores_5_mes()
        {
            cmd = new SqlCommand("mejores_5_mes", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            chart1.Series[0].Points.DataBindXY(Producto, Cant);
            dr.Close();
            Conexion.Close();
        }
        ArrayList PLACAS = new ArrayList();
        ArrayList MES = new ArrayList();       
        private void placas_anuales()
        {
            cmd = new SqlCommand("sp_anual", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PLACAS.Add(dr.GetInt32(0));
                MES.Add(dr.GetString(1));
            }
            chart2.Series[0].Points.DataBindXY(MES, PLACAS);
            dr.Close();
            Conexion.Close();
        }

       public Integrantes int_fotos = new Integrantes();
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
            top_1();
            fotos();
           
            GrafCategorias();
            mejores_5_mes();
            placas_anuales();
        }



        #region fotos
        public void fotos()
        {
            if (txt_idUsuario.Text == "1")
            {
                pictureBox1.Image = global::PRESENTACION.Properties.Resources._1;
            }
            else if (txt_idUsuario.Text == "2")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._2;
            }
            else if (txt_idUsuario.Text == "3")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._3;
            }

            else if (txt_idUsuario.Text == "5")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._5;

            }
            else if (txt_idUsuario.Text == "6")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._6;
            }
            //else if (txt_idUsuario.Text == "")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._7;
            //}
            else if (txt_idUsuario.Text == "8")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._8;
            }
            else if (txt_idUsuario.Text == "9")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._9;
            }
            else if (txt_idUsuario.Text == "10")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._10;
            }
            //else if (txt_idUsuario.Text == "11")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._11;
            //}
            //else if (txt_idUsuario.Text == "12")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._12;
            //}
            else if (txt_idUsuario.Text == "13")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._13;
            }
            else if (txt_idUsuario.Text == "14")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._14;
            }
            else if (txt_idUsuario.Text == "15")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._15;
            }
            else if (txt_idUsuario.Text == "16")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._16;
            }
            else if (txt_idUsuario.Text == "17")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._17;
            }
            else if (txt_idUsuario.Text == "18")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._18;
            }
            else if (txt_idUsuario.Text == "19")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._19;
            }
            //else if (txt_idUsuario.Text == "20")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._20;
            //}
            //else if (txt_idUsuario.Text == "21")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._21;
            //}
            else if (txt_idUsuario.Text == "22")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._22;
            }
            //else if (txt_idUsuario.Text == "23")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._23;
            //}
            else if (txt_idUsuario.Text == "24")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._24;
            }
            else if (txt_idUsuario.Text == "25")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._25;
            }
            else if (txt_idUsuario.Text == "26")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._26;
            }
            //else if (txt_idUsuario.Text == "27")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._27;
            //}
            else if (txt_idUsuario.Text == "28")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._28;
            }
            //else if (txt_idUsuario.Text == "29")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._29;
            //}
            else if (txt_idUsuario.Text == "30")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._30;
            }
            else if (txt_idUsuario.Text == "31")
            {
                this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._31;
            }
            //else if (txt_idUsuario.Text == "32")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._32;
            //}
            //else if (txt_idUsuario.Text == "33")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._33;
            //}
            //else if (txt_idUsuario.Text == "34")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._34;
            //}
            //else if (txt_idUsuario.Text == "35")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._35;
            //}
            //else if (txt_idUsuario.Text == "36")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._36;
            //}
            //else if (txt_idUsuario.Text == "37")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._37;
            //}
            //else if (txt_idUsuario.Text == "38")
            //{
            //    this.pictureBox1.Image = global::PRESENTACION.Properties.Resources._38;
            //}
            else
            {

            }
        }
        #endregion

        private static MenuPrincipal _Abrir;
        public static MenuPrincipal Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new MenuPrincipal();
                return _Abrir;
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

   
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void top_1()
        {
            cmd = new SqlCommand("top_1_mes", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
           
           if (dr.Read())
            {
                txt_idUsuario.Text = dr[0].ToString();
                txt_usuario.Text = dr[1].ToString();
                txt_cel.Text = dr[2].ToString();
                txt_nac.Text = dr[3].ToString();
                txt_ingr.Text = dr[4].ToString();
                txt_placas.Text = dr[5].ToString();
            }
           
            dr.Close();
            Conexion.Close();
        }

    }
}

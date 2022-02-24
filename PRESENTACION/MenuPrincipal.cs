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
            Grf_PlacasMes.Series[0].Points.DataBindXY(Categoria, CantProd);
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

    

          public void fotos()
        {
            

        }

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

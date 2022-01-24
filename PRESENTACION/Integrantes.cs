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
        //grafica de las placas al oño del integranmte x
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


        private void dgv_integrantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idUsuario.Text = dgv_integrantes.CurrentRow.Cells["ID_INTEGRANTE"].Value.ToString();          
        }

        private void txt_idUsuario_TextChanged(object sender, EventArgs e)
        {
            GrafCategorias();
            Grafañointegrant();
            tt_placas();
            PM_placas();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }
     
     

    }
}

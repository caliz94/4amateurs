﻿using System;
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
            AGREGARPLACAS_CN.insertar_placas(Convert.ToInt32(txt_id_integrante.Text), Convert.ToInt32(txt_placas.Text),txt_mes.Text, txt_semana.Text);
            MessageBox.Show("Se Registro al integrante  Exitosamente");
            txt_id_integrante.Clear();
            txt_placas.Clear();
            txt_mes.Clear();
            txt_semana.Clear();
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

        }
    }
}

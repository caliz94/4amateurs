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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "decaliz")
            {
                if (textBox2.Text == "1234")
                {
                    CP_CONTENEDOR abrirform =new CP_CONTENEDOR();
                    abrirform.TopLevel = true;                    
                    abrirform.Show();

                    textBox1.Clear();
                    textBox2.Clear();                   
                }
                else
                {
                    errorProvider1.SetError(textBox1,"");
                    errorProvider1.SetError(textBox2, "Contraseña Incorrecta");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1,"El Usuario No existe");
            }
          
        }
    }
}

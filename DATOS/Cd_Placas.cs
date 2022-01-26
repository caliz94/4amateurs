using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
   public class Cd_Placas
    {
        //hacer referencia a la clase de la conexion con el servidor
        private Da_conex_servidor cadena = new Da_conex_servidor();
        SqlCommand cmd = new SqlCommand();


        //metodo para insertar
        public void insertar(int ID_INTEGRANTE,string SEMANA, int R_PLACAS)
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "sp_reg_placas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_INTEGRANTE", ID_INTEGRANTE);                    
            cmd.Parameters.AddWithValue("@SEMANA", SEMANA);
            cmd.Parameters.AddWithValue("@R_PLACAS", R_PLACAS);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();
        }

        SqlDataReader integrantes;
        DataTable dt_integrantes = new DataTable();

        public DataTable dt_MostrarIntegrantes()
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "sp_MostrarIntegrantes";
            cmd.CommandType = CommandType.StoredProcedure;          

            integrantes=  cmd.ExecuteReader();
            dt_integrantes.Load(integrantes);
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();
            return dt_integrantes;
        }
    }
}

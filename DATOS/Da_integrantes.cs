using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DATOS
{
    public class Da_integrantes
    {
        //hacer referencia a la clase de la conexion con el servidor
        private Da_conex_servidor cadena = new Da_conex_servidor();
        SqlCommand cmd = new SqlCommand();


        //metodo para insertar
        public void insertar(string USUARIO,string CELULAR,string PAIS_NACIONALIDAD,DateTime FECHA_INGRESO,string COMENTARIO/*, string ESTADO*/)
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "sp_insertar_integrante";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USUARIO", USUARIO);
            cmd.Parameters.AddWithValue("@CELULAR", CELULAR);
            cmd.Parameters.AddWithValue("@PAIS_NACIONALIDAD", PAIS_NACIONALIDAD);
            cmd.Parameters.AddWithValue("@FECHA_INGRESO", FECHA_INGRESO);
            cmd.Parameters.AddWithValue("@COMENTARIO", COMENTARIO);
            //cmd.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();                            
        }

        //editar usuarios

        private void editar(int ID_INTEGRANTE, string USUARIO, string CELULAR, string PAIS_NACIONALIDAD, DateTime FECHA_INGRESO, string COMENTARIO, string ESTADO)
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "editar_usuario";
        }

        //ELIMINAR usuarios

        private void eliminar(int ID_INTEGRANTE)
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "eliminar_usuario";
        }


        //ver usuarios

        public DataTable usuarios = new DataTable();
        SqlDataReader cargar_usuarios;

        public DataTable ver_usuarios()
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "verusuarios";
            cmd.CommandType = CommandType.StoredProcedure;
            cargar_usuarios = cmd.ExecuteReader();

            usuarios.Load(cargar_usuarios);
            cadena.CERRAR_SERVER();
            return usuarios;
        }

      
        SqlDataReader leer;
       public DataTable tabla_integrantes = new DataTable(); 

        public DataTable mostrar_integrantes()
        {
            //tabla_integrantes.Clear();
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "sp_MostrarIntegrantes";
            cmd.CommandType = CommandType.StoredProcedure;

            leer = cmd.ExecuteReader();
            tabla_integrantes.Load(leer);
            cadena.CERRAR_SERVER();
            return tabla_integrantes;
        }
    }
}

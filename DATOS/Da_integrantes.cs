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

        public void editar(int ID_INTEGRANTE, string USUARIO, string CELULAR, string PAIS_NACIONALIDAD, DateTime FECHA_INGRESO, string COMENTARIO)
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "editar_usuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_INTEGRANTE", ID_INTEGRANTE);
            cmd.Parameters.AddWithValue("@USUARIO", USUARIO);
            cmd.Parameters.AddWithValue("@CELULAR", CELULAR);
            cmd.Parameters.AddWithValue("@PAIS_NACIONALIDAD", PAIS_NACIONALIDAD);
            cmd.Parameters.AddWithValue("@FECHA_INGRESO", FECHA_INGRESO);
            cmd.Parameters.AddWithValue("@COMENTARIO", COMENTARIO);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();
        }

        //ELIMINAR usuarios

        public void eliminar(int ID_INTEGRANTE)
        {
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "eliminar_usuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_INTEGRANTE", ID_INTEGRANTE);           
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();

        }


        //ver usuarios
        SqlDataReader cargar_usuarios;
        DataTable usuarios = new DataTable();
      
        public DataTable ver_usuarios()
        {
            
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "verusuarios";
            cmd.CommandType = CommandType.StoredProcedure;

            cargar_usuarios = cmd.ExecuteReader();
            usuarios.Load(cargar_usuarios);
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();
            return usuarios;
        }

      
        SqlDataReader leer;
       public DataTable tabla_integrantes = new DataTable(); 

        public DataTable mostrar_integrantes()
        {
            cmd.Parameters.Clear();
            //tabla_integrantes.Clear();
            cmd.Connection = cadena.ABRIR_SERVER();
            cmd.CommandText = "sp_MostrarIntegrantes";
            cmd.CommandType = CommandType.StoredProcedure;

            leer = cmd.ExecuteReader();
            tabla_integrantes.Load(leer);
            cmd.Parameters.Clear();
            cadena.CERRAR_SERVER();
            return tabla_integrantes;
        }
    }
}

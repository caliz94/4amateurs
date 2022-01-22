using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using System.Data;

namespace NEGOCIO
{
    public class CN_INTEGRANTES
    {
        //hacer referencia a la clase de la capa de datos
        public Da_integrantes integrantes_CD = new Da_integrantes();

        //metodo para insertar integrante
        public void insertar_integrante(string USUARIO, string CELULAR, string PAIS_NACIONALIDAD, DateTime FECHA_INGRESO, string COMENTARIO/*, string ESTADO*/)
        {
            integrantes_CD.insertar(USUARIO, CELULAR, PAIS_NACIONALIDAD, FECHA_INGRESO, COMENTARIO/*, ESTADO*/);
        }

        //metodo para editar integrante
        public void editar_integrante(int ID_INTEGRANTE, string USUARIO, string CELULAR, string PAIS_NACIONALIDAD, DateTime FECHA_INGRESO, string COMENTARIO)
        {
            integrantes_CD.editar(ID_INTEGRANTE,USUARIO, CELULAR, PAIS_NACIONALIDAD, FECHA_INGRESO, COMENTARIO);
        }

        //metodo para eliminar integrante
        public void eliminar_integrante(int ID_INTEGRANTE)
        {
            integrantes_CD.eliminar(ID_INTEGRANTE);
        }

        public DataTable mostar_integ()
       {
           DataTable tabla = new DataTable();
           tabla = integrantes_CD.ver_usuarios();
           return tabla;
       }

        public DataTable mostar_integ_2()
        {
            DataTable tabla = new DataTable();
            tabla = integrantes_CD.mostrar_integrantes();
            return tabla;
        }


    }
}

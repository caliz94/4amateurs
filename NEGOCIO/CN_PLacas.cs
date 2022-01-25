using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using System.Data;

namespace NEGOCIO
{
    public class CN_PLacas
    {
        //hacer referencia a la clase de la capa de datos
        private Cd_Placas placas_cd = new Cd_Placas();

        //metodo para insertar integrante
        public void insertar_placas(int ID_INTEGRANTE, string MES, string SEMANA, int R_PLACAS)
        {
            placas_cd.insertar(ID_INTEGRANTE, MES, SEMANA, R_PLACAS);
        }
        public DataTable dt_MostrarIntegrantes()
        {
            DataTable dt = new DataTable();
            dt = placas_cd.dt_MostrarIntegrantes();
            return dt;
        }
    }
}

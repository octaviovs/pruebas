using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.View;
using System.Data;
using System.Data.SqlClient;

namespace Core.Presenter
{
   
    public class WCIE10
    {
        ManagerBD Manager;
        ICIE10 ViewCIE10;
        CCIE10 objCIE10;
        public WCIE10(ICIE10 InterfazCIE10)
        {
            objCIE10 = new CCIE10();
            Manager = new ManagerBD();
            ViewCIE10 = InterfazCIE10;
        }
        public bool ExisteConexion()
        {
            bool ConexcionAvierta = false;
            SqlConnection sqlCon = Manager.GetConnection();
            if (sqlCon.State == ConnectionState.Open)
            {
                ConexcionAvierta = true;
            }
            return ConexcionAvierta;
        }

        public void listado(int opcion, CCIE10 datos)
        {
            DataSet infoCIE10 = new DataSet();
       
            bool  ExisteDatos= false;

            if (ExisteConexion())
            {
                ExisteDatos = new CCIE10().consulta(1,ref infoCIE10,datos);
                if (ExisteDatos)
                {
                    try
                    {

                        ViewCIE10.cieDt = infoCIE10;
                    }
                    catch (Exception)
                    {
                      //  ViewCIE10.cieDt = null;

                    }
                }
                else
                {
                    ViewCIE10.cieDt = null;
                    ViewCIE10.Mensaje("No Valido", 2);
                }
            }
            else
            {
                ViewCIE10.Mensaje("No hay conexion en red", 1);
            }
        }
    }
}

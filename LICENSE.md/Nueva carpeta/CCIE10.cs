using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Core.Model
{
    public class CCIE10
    {
        public CCIE10() {
            objManagerBD = new ManagerBD();
        }

        public CCIE10(string id, string value)
        {
            this.id = id;
            this.value = value;
            objManagerBD = new ManagerBD();
        }

        public bool consulta(int opcion, ref DataSet objDatos, CCIE10 objCIE)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@value", SqlDbType.NVarChar, 50) { Value = objCIE.value });
        
            objDatos = objManagerBD.GetData("apiCIE10", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;

            return ExisteDatos;
        }


        #region Variables del usuario
        ManagerBD objManagerBD;
        //para consulta
        public string id { get; set; }
        public string value { get; set; }
        
        #endregion
    }
}

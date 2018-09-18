using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.View;
using Core.Presenter;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace AVM.Paginas.Servicios
{
    public partial class acie : System.Web.UI.Page,ICIE10
    {
        CCIE10 miCie10;
        WCIE10 vistaCIE;
        protected void Page_Load(object sender, EventArgs e)
        {
            miCie10 = new CCIE10();
            vistaCIE = new WCIE10(this);
            try
            {
                if (Request.QueryString["value"] != null)
                {
                    miCie10.value = Convert.ToString(Request.QueryString["value"]);
                    vistaCIE.listado(1, miCie10);
                }
            }
            catch (Exception)
            {


            }

        }

        public DataSet cieDt
        {

            set
            {

                if (value != null)
                {

            
                    List<object> datos = new List<object>();
                    int x = 0;
                    foreach (DataRow item in value.Tables[0].Rows)
                    {
                       

                        datos.Add(new CCIE10(Convert.ToString(item[0]), Convert.ToString(item[1])));
                    }

                    List<object> aux = datos;
                    string json = JsonConvert.SerializeObject(datos, Formatting.Indented);

                    Response.Clear();
                    Response.ContentType = "application/json; charset=utf-8";
                    Response.Write(json);
                    Response.End();
                }
            }
        }


        public CCIE10 objCie
        {
            get
            {
                return null;
            }

            set
            {
           
            }
        }

        public void Mensaje(string Mensaje, int tipo)
        {
          
        }

      
    }
}
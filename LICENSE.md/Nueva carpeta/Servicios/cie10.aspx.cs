using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Core.Model;
using Core.Presenter;
using Core.View;
using System.Data;

using Newtonsoft.Json;
using System.Web.Services;
using System.Web.Script.Services;

namespace AVM.Paginas.Servicios
{
    public partial class cie10 : System.Web.UI.Page,ICIE10
    {
        CCIE10 miCie10;
        WCIE10 vistaCIE;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            miCie10 = new CCIE10();
            vistaCIE=new WCIE10(this);
            try
            {
                if (Request.QueryString["value"]!=null)
                {
                    miCie10.value= Convert.ToString(Request.QueryString["value"]);
                    vistaCIE.listado(1, miCie10);
                }
            }
            catch (Exception )
            {

                
            }
        }



   
        // return subject ;

        public DataSet cieDt
        {
           
            set
            {
            
                Core.Model.CCIE10 obj = new CCIE10();
                if (value!=null)
                {

                    List<cie10> datos = new List<cie10>();
                    int x = 0;
                    foreach (DataRow item in value.Tables[0].Rows)
                    {
                        obj.id = Convert.ToString(item[0]);
                        obj.value = Convert.ToString(item[1]);
                  
                    }

                    string json=JsonConvert.SerializeObject(datos, Formatting.Indented);

                    Response.Clear();
                    Response.ContentType = "application/json; charset=utf-8";
                    Response.Write(json);
                    Response.End();
                }
            }
        }

        

        CCIE10 ICIE10.objCie
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Mensaje(string Mensaje, int tipo)
        {
           
        }

    }
}
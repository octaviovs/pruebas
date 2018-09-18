using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using System.Data;

namespace Core.View
{
   public interface ICIE10
    {
        void Mensaje(string Mensaje, int tipo);
   
        CCIE10 objCie { get; set; }
        
        DataSet cieDt { set; }

    }
}

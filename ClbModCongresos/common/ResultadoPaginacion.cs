using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClbModGestionAxD.Common
{
    public class ResultadoPaginacion
    {
        public ClsModResultado ObjModResultado { get; set; }
        public bool ExisteOtraPagina { get; set; }
        public int Total { get; set; }
        public object Result { get; set; }
    }
}

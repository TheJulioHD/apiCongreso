using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClbModCongresos.common
{
    public class AppSettings
    {
        public string ConexionSecurity { get; set; }
        public string ConexionApplication { get; set; }
        public string Secret { get; set; }
        public string JwtIssuer { get; set; }
        public int JwtExpireDays { get; set; }
    }
}

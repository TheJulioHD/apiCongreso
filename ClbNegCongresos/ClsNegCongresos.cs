using ClbModCongresos;
using ClbModCongresos.common;
using ClbModGestionAxD.Common;
using ClsDatCongreos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClbNegCongresos
{
    public class ClsNegCongresos
    {
        private readonly AppSettings appSettings;


        public ClsNegCongresos(AppSettings AppSettings)
        {
            appSettings = AppSettings;
        }
        public ResultadoPaginacion CargarTipoNotificaciones(AppSettings appSettings)
        {
            return new ClsDatCongresos(appSettings).CargarTipoNotificaciones();
        }
        public ResultadoPaginacion CargarCongresoByID(AppSettings appSettings, ClsModCongresoParams objCongreso)
        {
            return new ClsDatCongresos(appSettings).CargarCongresoByID(objCongreso);
        }
    }
}

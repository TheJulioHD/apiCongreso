using ClbModCongresos;
using ClbModCongresos.common;
using ClbModGestionAxD.Common;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsDatCongreos
{
    public class ClsDatCongresos
    {
        private readonly AppSettings appSettings;
        public ClsDatCongresos(AppSettings AppSettings)
        {
            appSettings = AppSettings;
        }

        public ResultadoPaginacion CargarTipoNotificaciones()
        {
            ResultadoPaginacion objModResultado = new ResultadoPaginacion();
            objModResultado.ObjModResultado = new ClsModResultado();
            try
            {
                using (var conexion = new SqlConnection(appSettings.ConexionSecurity))
                {
                    conexion.Open();
                    var lstResult = conexion.Query<DtoCongreso>("SpCatCongresoLoad", commandType: CommandType.StoredProcedure);
                    objModResultado.Result = lstResult.ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception("Dat , " + e.Message);
            }

            return objModResultado;
        }
        public ResultadoPaginacion CargarCongresoByID(ClsModCongresoParams objcongreso)
        {
            ResultadoPaginacion objModResultado = new ResultadoPaginacion();
            objModResultado.ObjModResultado = new ClsModResultado();
            try
            {
                using (var conexion = new SqlConnection(appSettings.ConexionSecurity))
                {
                    conexion.Open();
                    var lstResult = conexion.Query<ClsModCongreso>("SpCatCongresoLoadByID", new
                    {
                        IdCongreso = objcongreso.IdCongreso
                    }, commandType: CommandType.StoredProcedure);
                    objModResultado.Result = lstResult.ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception("Dat , " + e.Message);
            }

            return objModResultado;
        }
    }
}

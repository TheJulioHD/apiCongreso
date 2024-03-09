using ClbModCongresos;
using ClbModCongresos.common;
using ClbNegCongresos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ApiCongresosv3.Controllers
{
    public class CongresoController : Controller
    {
        private readonly AppSettings appSettings;

        public CongresoController(IOptions<AppSettings> AppSettings)
        {
            this.appSettings = AppSettings.Value;
        }

        [HttpGet("Cargar")]
        public IActionResult Cargar()
        {
            ClsNegCongresos objNegcatUsuario = new ClsNegCongresos(this.appSettings);
            var result = objNegcatUsuario.CargarTipoNotificaciones(this.appSettings);
            return Ok(result);

        }
        [HttpGet("CargarByID")]
        public IActionResult CargarByID(ClsModCongresoParams objCongreso)
        {
            ClsNegCongresos objNegcatUsuario = new ClsNegCongresos(this.appSettings);
            var result = objNegcatUsuario.CargarCongresoByID(this.appSettings, objCongreso);
            return Ok(result);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClbModCongresos
{
    public class ClsModCongreso
    {
        public int IdCongreso { get; set; }
        public string Congreso { get; set; }
        public string img { get; set; }
        //equipo
        public int? IdEquipo { get; set; }
        public string? nombre { get; set; }
        public string? apellidop { get; set; }
        public string? apellidom { get; set; }
        //taller
        public int? IdTaller { get; set; }
        public string? Taller { get; set; }
        public string? Tallerista { get; set; }
        //empresa
        public int? IdEmpresa { get; set; }
        public string? Empresa { get; set; }
        public string? InicioHora { get; set; }
        public string? FinHora { get; set; }
    }
}

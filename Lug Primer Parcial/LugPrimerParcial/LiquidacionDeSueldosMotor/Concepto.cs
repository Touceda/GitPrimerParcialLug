using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldosMotor
{
    public class Concepto
    {
        private int id;
        private string descripcion;
        private int porcentajeAplicado;
        private string tipoConcepto;

        public int Id { get { return id; } set { id = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int PorcentajeAplicado { get { return porcentajeAplicado; } set { porcentajeAplicado = value; } }
        public string TipoCocepto { get { return tipoConcepto; } set { tipoConcepto = value; } }

        public Concepto(string Cdescripcion, int CporcentajeAplicado, string CtipoConcepto)
        {
            this.descripcion = Cdescripcion;
            this.porcentajeAplicado = CporcentajeAplicado;
            this.tipoConcepto = CtipoConcepto;
        }

    }
}

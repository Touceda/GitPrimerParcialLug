using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldosMotor
{
    /*
    Legajo
    Nombre y Apellido
    Cuil
    Fecha Alta
    */

    public class Empleado
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int cuil;
        private string fechaAlta;

        public int Legajo { get { return legajo; } set { legajo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Cuil { get { return cuil; } set { cuil = value; } }
        public string FechaAlta { get { return fechaAlta; } set { fechaAlta = value; } }

        public Empleado(string Cnombre, string Capellido, int Ccuil, string CfechaAlta)
        {
            this.nombre = Cnombre;
            this.apellido = Capellido;
            this.cuil = Ccuil;
            this.fechaAlta = CfechaAlta;  
        }
    }
}

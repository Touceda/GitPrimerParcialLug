using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldosMotor
{
    /*
    Mes y Año
    Sueldo en bruto
    Sueldo Neto
    Total descuentos
    Lista de conceptos
    */
    public class Recibo
    {
        private int legajo;
        private string fecha;
        private int sueldoBruto;
        private int sueldoNeto;
        private int descuentoTotal;
        private string conceptos;

        public int Legajo { get { return legajo; } set { legajo = value; } }
        public string Fecha { get { return fecha; } set { fecha = value; } }
        public int SueldoBruto { get { return sueldoBruto; } set { sueldoBruto = value; } }
        public int SueldoNeto { get { return sueldoNeto; } set { sueldoNeto = value; } }
        public int DescuentoTotal { get { return descuentoTotal; } set { descuentoTotal = value; } }
        public string Conceptos { get { return conceptos; } set { conceptos = value; } }

        private List<Concepto> conceptosList;

        public Recibo(int Clegajo, string Cfecha, int CsueldoBruto, List<Concepto> CconceptosList)
        {
            this.legajo = Clegajo;
            this.fecha = Cfecha;
            this.sueldoBruto = CsueldoBruto;
            this.conceptosList = CconceptosList;

            RecalcularSueldos();          
            this.conceptos = GuardarConceptos();
        }

        public Recibo(int Clegajo, string Cfecha, int CsueldoBruto, int CsueldoNeto, int CdescuntoTotal, string Cconceptos)
        {
            this.legajo = Clegajo;
            this.fecha = Cfecha;
            this.sueldoBruto = CsueldoBruto;
            this.sueldoNeto = CsueldoNeto;
            this.descuentoTotal = CdescuntoTotal;
            this.conceptos = Cconceptos;
        }



        private void RecalcularSueldos()
        {
            List<Concepto> TodosLosConceptos = conceptosList;
            List<Concepto> ConceptosPositivos = new List<Concepto>();
            List<Concepto> ConceptosNegativos = new List<Concepto>();

            foreach (Concepto c in TodosLosConceptos)
            {
                if (c.TipoCocepto == "Positivo") 
                {
                    ConceptosPositivos.Add(c);
                }
                else
                {
                    ConceptosNegativos.Add(c);
                }
            }

            //Calculo el sueldo bruto con los conceptos positivos
            float sb;
            foreach (Concepto c in ConceptosPositivos) 
            {
                sb = (sueldoBruto * c.PorcentajeAplicado) / 100;
                float nuevoSueldoBruto = sueldoBruto + sb;
                sueldoBruto = Convert.ToInt32(nuevoSueldoBruto);
            }

  

            //Calculo el sueldo Neto con los conceptos negativos
            float sn;
            sueldoNeto = sueldoBruto;
            foreach (Concepto c in ConceptosNegativos)
            {
                sn = (sueldoNeto * c.PorcentajeAplicado) / 100;
                float nuevoSueldoNeto = sueldoNeto - sn;
                sueldoNeto = Convert.ToInt32(nuevoSueldoNeto);
            }
            descuentoTotal = sueldoBruto - sueldoNeto;
        }

        private string GuardarConceptos()
        {
            string concepto = "";
            foreach (Concepto c in conceptosList)
            {
                concepto += c.Descripcion + " " + c.PorcentajeAplicado.ToString() + "% " + c.TipoCocepto.ToString() + " - ";
            }

            if (concepto == "") 
            {
                return "No hay conceptos aplicados en este Recibo";
            }
            return concepto;
        }

    }
}
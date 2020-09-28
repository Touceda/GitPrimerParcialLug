using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Acceso;
namespace LiquidacionDeSueldosMotor
{
    public class Empresa
    {
        Conexion ConexionClas = new Conexion();
        #region A M B Empleado
        public bool AltaEmpleado(Empleado empleado)
        {
            if (ConexionClas.OpenConexion())
            {
                List<IDbDataParameter> Parametros = new List<IDbDataParameter>();

                Parametros.Add(ConexionClas.CrearParametro("@nom", empleado.Nombre));
                Parametros.Add(ConexionClas.CrearParametro("@ape", empleado.Apellido));
                Parametros.Add(ConexionClas.CrearParametro("@cui", empleado.Cuil));
                Parametros.Add(ConexionClas.CrearParametro("@fecha", empleado.FechaAlta));
                ConexionClas.CrearComando("EmpleadoAlta", Parametros);

                ConexionClas.ClosedConexion();
                return true;
            }


            return false;
        }

        public bool ModificacionEmpleado(int legajo, string nombre, string apellido, int cuil)
        {
            if (ConexionClas.OpenConexion())
            {
                List<IDbDataParameter> Parametros = new List<IDbDataParameter>();

                Parametros.Add(ConexionClas.CrearParametro("@legajo", legajo));
                Parametros.Add(ConexionClas.CrearParametro("@nom", nombre));
                Parametros.Add(ConexionClas.CrearParametro("@ape", apellido));
                Parametros.Add(ConexionClas.CrearParametro("@cuil", cuil));

                ConexionClas.CrearComando("EmpleadoModificar", Parametros);

                ConexionClas.ClosedConexion();
                return true;
            }
            return false;
        }

        public bool BajaEmpleado(int legajo)
        {
            if (ConexionClas.OpenConexion())
            {
                List<IDbDataParameter> Parametros = new List<IDbDataParameter>();

                Parametros.Add(ConexionClas.CrearParametro("@legajo", legajo));
                ConexionClas.CrearComando("EmpleadoBaja", Parametros);
                ConexionClas.ClosedConexion();
                return true;
            }

            return false;
        }
        #endregion

        #region A M B Conceptos
        public bool AltaConcepto(Concepto concepto)
        {
            if (ConexionClas.OpenConexion())
            {
                List<IDbDataParameter> Parametros = new List<IDbDataParameter>();

                Parametros.Add(ConexionClas.CrearParametro("@descripcion", concepto.Descripcion));
                Parametros.Add(ConexionClas.CrearParametro("@porcentaje", concepto.PorcentajeAplicado));
                Parametros.Add(ConexionClas.CrearParametro("@tipo", concepto.TipoCocepto));
                ConexionClas.CrearComando("ConceptoAlta", Parametros);

                ConexionClas.ClosedConexion();
                return true;
            }


            return false;
        }

        public bool ModificacionConcepto(int id, string nuevaDescripcion, int nuevoPorcentaje,string nuevoTipo)
        {
            if (ConexionClas.OpenConexion())
            {
                List<IDbDataParameter> Parametros = new List<IDbDataParameter>();

                Parametros.Add(ConexionClas.CrearParametro("@id", id));
                Parametros.Add(ConexionClas.CrearParametro("@descripcion", nuevaDescripcion));
                Parametros.Add(ConexionClas.CrearParametro("@porcentaje", nuevoPorcentaje));
                Parametros.Add(ConexionClas.CrearParametro("@tipo", nuevoTipo));

                ConexionClas.CrearComando("ConceptoModificar", Parametros);

                ConexionClas.ClosedConexion();
                return true;
            }
            return false;
        }

        public bool BajaConcepto(int idConcepto)
        {
            if (ConexionClas.OpenConexion())
            {
                List<IDbDataParameter> Parametros = new List<IDbDataParameter>();

                Parametros.Add(ConexionClas.CrearParametro("@id", idConcepto));
                ConexionClas.CrearComando("ConceptoBaja", Parametros);
                ConexionClas.ClosedConexion();
                return true;
            }

            return false;
        }
        #endregion

        #region ALTA Recibo
        public bool AltaRecibo(Recibo recibo)
        {
            if (ConexionClas.OpenConexion())
            {
                List<IDbDataParameter> Parametros = new List<IDbDataParameter>();

                Parametros.Add(ConexionClas.CrearParametro("@legajo", recibo.Legajo));
                Parametros.Add(ConexionClas.CrearParametro("@fecha", recibo.Fecha));
                Parametros.Add(ConexionClas.CrearParametro("@sueldobruto", recibo.SueldoBruto));
                Parametros.Add(ConexionClas.CrearParametro("@sueldoneto", recibo.SueldoNeto));
                Parametros.Add(ConexionClas.CrearParametro("@totaldescuento", recibo.DescuentoTotal));
                Parametros.Add(ConexionClas.CrearParametro("@Conceptos", recibo.Conceptos));
                ConexionClas.CrearComando("ReciboAlta", Parametros);

                ConexionClas.ClosedConexion();
                return true;
            }
            return false;
        }
        #endregion

        #region Leer Empleados Conceptos y Recibos
        public List<Empleado> LeerEmpleados()
        {
            List<Empleado> Empleados = new List<Empleado>();

            ConexionClas.OpenConexion();
            DataTable TablaDeEmpleados = ConexionClas.LeerBaseDeDatos("EmpleadoLeer");
            ConexionClas.ClosedConexion();
    
            foreach (DataRow fila in TablaDeEmpleados.Rows)
            {
                int legajo = int.Parse(fila[0].ToString());
                string nombre = fila[1].ToString();
                string apellido = fila[2].ToString();
                int cuil = int.Parse(fila[3].ToString());
                string fecha = fila[4].ToString();
                Empleado e = new Empleado(nombre,apellido,cuil,fecha);
                e.Legajo = legajo;
                Empleados.Add(e);
                
            }
            return Empleados;
        }

        public List<Concepto> LeerConceptos()
        {

            List<Concepto> Conceptos = new List<Concepto>();

            ConexionClas.OpenConexion();
            DataTable TablaDeConceptos = ConexionClas.LeerBaseDeDatos("ConceptoLeer");
            ConexionClas.ClosedConexion();

            foreach (DataRow fila in TablaDeConceptos.Rows)
            {
                int id = int.Parse(fila[0].ToString());
                string descripcion = fila[1].ToString();            
                int porcentaje = int.Parse(fila[2].ToString());
                string tipo = fila[3].ToString();

                Concepto c = new Concepto(descripcion, porcentaje, tipo);
                c.Id = id;
                Conceptos.Add(c);
            }
            return Conceptos;
        }

        public List<Recibo> LeerRecibos(int id)
        {
            List<Recibo> Recibos = new List<Recibo>();

            ConexionClas.OpenConexion();
            DataTable TablaDeConceptos = ConexionClas.LeerBaseDeDatos("ReciboLeer",id);
            ConexionClas.ClosedConexion();

            foreach (DataRow fila in TablaDeConceptos.Rows)
            {
                int legajo = int.Parse(fila[0].ToString());
                string fecha = fila[1].ToString();
                int sueldoB = int.Parse(fila[2].ToString());
                int sueldoN = int.Parse(fila[3].ToString());
                int sueldoDescuento = int.Parse(fila[4].ToString());
                string conceptos = fila[5].ToString();


                Recibo r = new Recibo(legajo, fecha, sueldoB, sueldoN, sueldoDescuento, conceptos);             
                Recibos.Add(r);
            }
            return Recibos;
        }

        public List<Recibo> LeerRecibos()
        {
            List<Recibo> Recibos = new List<Recibo>();

            ConexionClas.OpenConexion();
            DataTable TablaDeConceptos = ConexionClas.LeerBaseDeDatos("ReciboLeerHistorialCompleto");
            ConexionClas.ClosedConexion();

            foreach (DataRow fila in TablaDeConceptos.Rows)
            {
                int legajo = int.Parse(fila[0].ToString());
                string fecha = fila[1].ToString();
                int sueldoB = int.Parse(fila[2].ToString());
                int sueldoN = int.Parse(fila[3].ToString());
                int sueldoDescuento = int.Parse(fila[4].ToString());
                string conceptos = fila[5].ToString();


                Recibo r = new Recibo(legajo, fecha, sueldoB, sueldoN, sueldoDescuento, conceptos);
                Recibos.Add(r);
            }
            return Recibos;
        }
        #endregion
    }
}

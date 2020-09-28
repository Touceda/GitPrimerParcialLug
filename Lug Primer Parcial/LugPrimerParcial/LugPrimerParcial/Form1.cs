using LiquidacionDeSueldosMotor;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LugPrimerParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa Empresa;
        private void Form1_Load(object sender, EventArgs e)
        {
            Empresa = new Empresa();
            ActualizarEmpleadosDGV();
            ActualziarCheckListBox();
        }

        #region A B M Empleados
        private void btbAltaEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Cual es su nombre?","Registro De Nuevo Empleado");
                string apellido = Interaction.InputBox("Cual es su apellido?", "Registro De Nuevo Empleado");
                int cuil = int.Parse(Interaction.InputBox("Cual es su cuil?", "Registro De Nuevo Empleado"));
                string fechaAlta = DateTime.Now.ToString("dd/MM/yyyy");
                if (Empresa.AltaEmpleado(new Empleado(nombre, apellido, cuil, fechaAlta)) != true) 
                {
                    MessageBox.Show("Ocurrio un error en la conexion");
                    return;
                }
                ActualizarEmpleadosDGV();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocurrio Un Error en la Base De Datos", "Error SQL");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio Un Error en el Registro", "Error de registro");
            }
        }

        private void btbModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvListaDeEmpleados.CurrentRow.Index;
                int legajo = int.Parse(dgvListaDeEmpleados.Rows[fila].Cells[0].Value.ToString());

                string nombre = Interaction.InputBox("Cual es su Nuevo nombre?", "ACTUALIZACION");
                string apellido = Interaction.InputBox("Cual es su Nuevo apellido?", "ACTUALIZACION");
                int cuil = int.Parse(Interaction.InputBox("Cual es su Nuevo cuil?", "ACTUALIZACION"));

                if (Empresa.ModificacionEmpleado(legajo, nombre, apellido, cuil) != true)
                {
                    MessageBox.Show("Ocurrio un error en la conexion");
                    return;
                }
                ActualizarEmpleadosDGV();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocurrio Un Error en la Base De Datos", "Error SQL");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio Un Error en la Baja", "Error de Baja");
            }
        }

        private void btbBajaEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvListaDeEmpleados.CurrentRow.Index;
                int Nro = int.Parse(dgvListaDeEmpleados.Rows[fila].Cells[0].Value.ToString());

                if (Empresa.BajaEmpleado(Nro) != true)
                {
                    MessageBox.Show("Ocurrio un error en la conexion");
                    return;
                }
                ActualizarEmpleadosDGV();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocurrio Un Error en la Base De Datos", "Error SQL");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio Un Error en la Baja", "Error de Baja");
            }
        }
        #endregion

        List<Concepto> Conceptos = new List<Concepto>(); 
        #region A B M Conceptos
        private void btbAltaConcepto_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = Interaction.InputBox("Cual es el nuevo Concepto?", "Nuevo Concepto");
                int porcentaje = int.Parse(Interaction.InputBox("Cual es el porcentaje?", "Nuevo Concepto"));
                DialogResult x = MessageBox.Show("Si el porcentaje aplicado es Positivo oprima SI, en caso de ser negativo, Oprima NO", "Nuevo Concepto", MessageBoxButtons.YesNo);
                string tipoPorcentaje;
                if (x==DialogResult.Yes)
                {
                    tipoPorcentaje = "Positivo";
                }
                else
                {
                    tipoPorcentaje = "Negativo";
                }
                if (Empresa.AltaConcepto(new Concepto(descripcion, porcentaje, tipoPorcentaje)) != true)
                {
                    MessageBox.Show("Ocurrio un error en la conexion");
                    return;
                }
                ActualziarCheckListBox();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocurrio Un Error en la Base De Datos", "Error SQL");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio Un Error en el Registro", "Error de registro");
            }
        }

        private void btbModificarConcepto_Click(object sender, EventArgs e)
        {
            try
            {
                int itemSeleccionado = cblConceptos.SelectedIndex;
                string item = cblConceptos.Items[itemSeleccionado].ToString();
                int idConcepto = int.Parse(item[0].ToString());

                string descripcion = Interaction.InputBox("Cual es la nueva Descripcion?", "ACTUALIZACION");
                int porcentaje = int.Parse(Interaction.InputBox("Cual es el nuevo Porcentaje?", "ACTUALIZACION"));

                DialogResult x = MessageBox.Show("Si el porcentaje aplicado es Positivo oprima SI, en caso de ser negativo, Oprima NO", "Nuevo Concepto", MessageBoxButtons.YesNo);
                string tipoPorcentaje;
                if (x == DialogResult.Yes)
                {
                    tipoPorcentaje = "Positivo";
                }
                else
                {
                    tipoPorcentaje = "Negativo";
                }

                if (Empresa.ModificacionConcepto(idConcepto, descripcion, porcentaje, tipoPorcentaje) != true)
                {
                    MessageBox.Show("Ocurrio Un Error en la Conexion", "Error SQL");
                    return;
                }
                ActualziarCheckListBox();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocurrio Un Error en la Base De Datos", "Error SQL");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio Un Error en la Baja", "Error de Baja");
            }
        }

        private void btbBajaConcepto_Click(object sender, EventArgs e)
        {
            try
            {
                int itemSeleccionado = cblConceptos.SelectedIndex;
                string item = cblConceptos.Items[itemSeleccionado].ToString();
                int idConcepto = int.Parse(item[0].ToString());
                if (Empresa.BajaConcepto(idConcepto) != true)
                {
                    MessageBox.Show("Ocurrio Un Error en la Conexion", "Error SQL");
                    return;
                }
                ActualziarCheckListBox();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocurrio Un Error en la Base De Datos", "Error SQL");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio Un Error", "Error");
            }
        }
        #endregion

        Recibo UltimoRecibo;
        #region Alta y Mostrar Recibos
        private void btbAltaRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvListaDeEmpleados.CurrentRow.Index;
                int legajo = int.Parse(dgvListaDeEmpleados.Rows[fila].Cells[0].Value.ToString());
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                int sueldoBruto = int.Parse(Interaction.InputBox("Cual es su sueldo Bruto?", "Creando Recibo"));
                List<Concepto> conceptosAplicados = ConceptosAplicadosAlRecibo();
                UltimoRecibo = new Recibo(legajo, fecha, sueldoBruto, conceptosAplicados);
                if (Empresa.AltaRecibo(UltimoRecibo) != true)
                {
                    MessageBox.Show("Ocurrio un error en la conexion");
                    return;
                }
                ActualizarRecibosDGV(UltimoRecibo);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocurrio Un Error en la Base De Datos", "Error SQL");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio Un Error en el Registro", "Error de registro");
            }
        }

        private List<Concepto> ConceptosAplicadosAlRecibo()
        {
            List<Concepto> conceptosAplicados = new List<Concepto>();
            List<int> conceptosIndex = new List<int>();
            int checkElementos = cblConceptos.Items.Count;//Obtengo la cantidad de items del Check box y recorro un for 1 ves por item

            for (int i = 1; i <= checkElementos; i++)
            {
                if (cblConceptos.GetItemChecked(i-1) == true)//Reviso si el item esta marcado o no
                {                         
                    string concepto = cblConceptos.Items[i - 1].ToString(); //Si esta marcado lo extraigo y solo guardo el indice
                    conceptosIndex.Add(int.Parse(concepto[0].ToString()));//Teniendo el indice me sirve para filtrar los conceptos que correspondan a este recibo
                }
            }

            foreach (Concepto c in Conceptos)
            {
                foreach (int index in conceptosIndex)
                {
                    if (index == c.Id)
                    {
                        conceptosAplicados.Add(c);
                    }
                }
            }
            return conceptosAplicados;
        }


        private void btbMostrarRecibos_Click(object sender, EventArgs e)
        {
            int fila = dgvListaDeEmpleados.CurrentRow.Index;
            int legajo = int.Parse(dgvListaDeEmpleados.Rows[fila].Cells[0].Value.ToString());
            ActualizarRecibosDGV(legajo);
        }

        private void btbRecibosHistorialCompletos_Click(object sender, EventArgs e)
        {
            ActualizarRecibosDGV(Empresa.LeerRecibos());
        }
        #endregion





        private void ActualizarEmpleadosDGV()
        {
            this.dgvListaDeEmpleados.DataSource = null;        
            this.dgvListaDeEmpleados.DataSource = Empresa.LeerEmpleados();
        }
        private void ActualziarCheckListBox()
        {
            cblConceptos.Items.Clear();

            Conceptos = Empresa.LeerConceptos();
            foreach (var concepto in Conceptos)
            {
                cblConceptos.Items.Add(concepto.Id.ToString() + " " + concepto.Descripcion.ToString() + ": " + concepto.PorcentajeAplicado.ToString() + "% " + concepto.TipoCocepto.ToString());
            }
        }
        private void ActualizarRecibosDGV(List<Recibo> recibos)
        {
            dgvRecibos.Rows.Clear();
            foreach (Recibo r in recibos)
            {
                var Fila = dgvRecibos.Rows.Add();
                dgvRecibos.Rows[Fila].Cells[0].Value = r.Legajo.ToString();
                dgvRecibos.Rows[Fila].Cells[1].Value = r.Fecha.ToString();
                dgvRecibos.Rows[Fila].Cells[2].Value = r.SueldoBruto.ToString();
                dgvRecibos.Rows[Fila].Cells[3].Value = r.SueldoNeto.ToString();
                dgvRecibos.Rows[Fila].Cells[4].Value = r.DescuentoTotal.ToString();
                dgvRecibos.Rows[Fila].Cells[5].Value = r.Conceptos.ToString();
            }          
            dgvRecibos.AllowUserToAddRows = false;
        }
        private void ActualizarRecibosDGV(Recibo r)
        {
            dgvRecibos.Rows.Clear();
            var Fila = dgvRecibos.Rows.Add();
            dgvRecibos.Rows[Fila].Cells[0].Value = r.Legajo.ToString();
            dgvRecibos.Rows[Fila].Cells[1].Value = r.Fecha.ToString();
            dgvRecibos.Rows[Fila].Cells[2].Value = r.SueldoBruto.ToString();
            dgvRecibos.Rows[Fila].Cells[3].Value = r.SueldoNeto.ToString();
            dgvRecibos.Rows[Fila].Cells[4].Value = r.DescuentoTotal.ToString();
            dgvRecibos.Rows[Fila].Cells[5].Value = r.Conceptos.ToString();
            dgvRecibos.AllowUserToAddRows = false;
        }
        private void ActualizarRecibosDGV(int id)
        {
            var recibos = Empresa.LeerRecibos(id);
            if (recibos.Count == 0)
            {
                MessageBox.Show("Esta Persona no posee ningun resibo registrado");
            }
            else
            {
                dgvRecibos.Rows.Clear();
                foreach (Recibo r in recibos)
                {
                    var Fila = dgvRecibos.Rows.Add();
                    dgvRecibos.Rows[Fila].Cells[0].Value = r.Legajo.ToString();
                    dgvRecibos.Rows[Fila].Cells[1].Value = r.Fecha.ToString();
                    dgvRecibos.Rows[Fila].Cells[2].Value = r.SueldoBruto.ToString();
                    dgvRecibos.Rows[Fila].Cells[3].Value = r.SueldoNeto.ToString();
                    dgvRecibos.Rows[Fila].Cells[4].Value = r.DescuentoTotal.ToString();
                    dgvRecibos.Rows[Fila].Cells[5].Value = r.Conceptos.ToString();
                }
                
                dgvRecibos.AllowUserToAddRows = false;
                //dgvRecibos.DataSource = null;
                //dgvRecibos.DataSource = Empresa.LeerRecibos();
            }   
        }
      
    }
}

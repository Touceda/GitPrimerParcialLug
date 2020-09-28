namespace LugPrimerParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaDeEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btbAltaEmpleado = new System.Windows.Forms.Button();
            this.btbModificarEmpleado = new System.Windows.Forms.Button();
            this.btbBajaEmpleado = new System.Windows.Forms.Button();
            this.cblConceptos = new System.Windows.Forms.CheckedListBox();
            this.btbBajaConcepto = new System.Windows.Forms.Button();
            this.btbModificarConcepto = new System.Windows.Forms.Button();
            this.btbAltaConcepto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptosAplicados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btbAltaRecibo = new System.Windows.Forms.Button();
            this.btbMostrarRecibos = new System.Windows.Forms.Button();
            this.btbRecibosHistorialCompletos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDeEmpleados
            // 
            this.dgvListaDeEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeEmpleados.Location = new System.Drawing.Point(12, 43);
            this.dgvListaDeEmpleados.Name = "dgvListaDeEmpleados";
            this.dgvListaDeEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaDeEmpleados.Size = new System.Drawing.Size(465, 436);
            this.dgvListaDeEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Empleados";
            // 
            // btbAltaEmpleado
            // 
            this.btbAltaEmpleado.Location = new System.Drawing.Point(12, 495);
            this.btbAltaEmpleado.Name = "btbAltaEmpleado";
            this.btbAltaEmpleado.Size = new System.Drawing.Size(151, 133);
            this.btbAltaEmpleado.TabIndex = 2;
            this.btbAltaEmpleado.Text = "Alta Empleado";
            this.btbAltaEmpleado.UseVisualStyleBackColor = true;
            this.btbAltaEmpleado.Click += new System.EventHandler(this.btbAltaEmpleado_Click);
            // 
            // btbModificarEmpleado
            // 
            this.btbModificarEmpleado.Location = new System.Drawing.Point(169, 495);
            this.btbModificarEmpleado.Name = "btbModificarEmpleado";
            this.btbModificarEmpleado.Size = new System.Drawing.Size(151, 133);
            this.btbModificarEmpleado.TabIndex = 3;
            this.btbModificarEmpleado.Text = "Modificar Empleado";
            this.btbModificarEmpleado.UseVisualStyleBackColor = true;
            this.btbModificarEmpleado.Click += new System.EventHandler(this.btbModificarEmpleado_Click);
            // 
            // btbBajaEmpleado
            // 
            this.btbBajaEmpleado.Location = new System.Drawing.Point(326, 495);
            this.btbBajaEmpleado.Name = "btbBajaEmpleado";
            this.btbBajaEmpleado.Size = new System.Drawing.Size(151, 133);
            this.btbBajaEmpleado.TabIndex = 4;
            this.btbBajaEmpleado.Text = "Baja Empleado";
            this.btbBajaEmpleado.UseVisualStyleBackColor = true;
            this.btbBajaEmpleado.Click += new System.EventHandler(this.btbBajaEmpleado_Click);
            // 
            // cblConceptos
            // 
            this.cblConceptos.FormattingEnabled = true;
            this.cblConceptos.Location = new System.Drawing.Point(507, 43);
            this.cblConceptos.Name = "cblConceptos";
            this.cblConceptos.Size = new System.Drawing.Size(230, 214);
            this.cblConceptos.TabIndex = 5;
            // 
            // btbBajaConcepto
            // 
            this.btbBajaConcepto.Location = new System.Drawing.Point(507, 413);
            this.btbBajaConcepto.Name = "btbBajaConcepto";
            this.btbBajaConcepto.Size = new System.Drawing.Size(230, 66);
            this.btbBajaConcepto.TabIndex = 8;
            this.btbBajaConcepto.Text = "Baja Concepto";
            this.btbBajaConcepto.UseVisualStyleBackColor = true;
            this.btbBajaConcepto.Click += new System.EventHandler(this.btbBajaConcepto_Click);
            // 
            // btbModificarConcepto
            // 
            this.btbModificarConcepto.Location = new System.Drawing.Point(507, 341);
            this.btbModificarConcepto.Name = "btbModificarConcepto";
            this.btbModificarConcepto.Size = new System.Drawing.Size(230, 66);
            this.btbModificarConcepto.TabIndex = 9;
            this.btbModificarConcepto.Text = "Modificar Concepto";
            this.btbModificarConcepto.UseVisualStyleBackColor = true;
            this.btbModificarConcepto.Click += new System.EventHandler(this.btbModificarConcepto_Click);
            // 
            // btbAltaConcepto
            // 
            this.btbAltaConcepto.Location = new System.Drawing.Point(507, 269);
            this.btbAltaConcepto.Name = "btbAltaConcepto";
            this.btbAltaConcepto.Size = new System.Drawing.Size(230, 66);
            this.btbAltaConcepto.TabIndex = 10;
            this.btbAltaConcepto.Text = "Alta Concepto";
            this.btbAltaConcepto.UseVisualStyleBackColor = true;
            this.btbAltaConcepto.Click += new System.EventHandler(this.btbAltaConcepto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lista de Conceptos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nota del Programador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Para dar de BAJA o MODIFICAR un CONCEPTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "NO hay que tildar el CheckBock, simplemente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "hay que seleccionar el item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "El item seleccionado es el que se coloreara en AZUL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 631);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Los BOX tiltados, no afectan a la BAJA ni la MODIFICACION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(959, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Recibos";
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Fecha,
            this.SueldoBruto,
            this.SueldoNeto,
            this.DescuentoTotal,
            this.ConceptosAplicados});
            this.dgvRecibos.Location = new System.Drawing.Point(779, 43);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibos.Size = new System.Drawing.Size(465, 436);
            this.dgvRecibos.TabIndex = 19;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // SueldoBruto
            // 
            this.SueldoBruto.HeaderText = "Sueldo Bruto";
            this.SueldoBruto.Name = "SueldoBruto";
            // 
            // SueldoNeto
            // 
            this.SueldoNeto.HeaderText = "Sueldo Neto";
            this.SueldoNeto.Name = "SueldoNeto";
            // 
            // DescuentoTotal
            // 
            this.DescuentoTotal.HeaderText = "Descuento Total";
            this.DescuentoTotal.Name = "DescuentoTotal";
            // 
            // ConceptosAplicados
            // 
            this.ConceptosAplicados.HeaderText = "Conceptos Aplicados";
            this.ConceptosAplicados.Name = "ConceptosAplicados";
            // 
            // btbAltaRecibo
            // 
            this.btbAltaRecibo.Location = new System.Drawing.Point(779, 495);
            this.btbAltaRecibo.Name = "btbAltaRecibo";
            this.btbAltaRecibo.Size = new System.Drawing.Size(168, 133);
            this.btbAltaRecibo.TabIndex = 20;
            this.btbAltaRecibo.Text = "Alta Recibo";
            this.btbAltaRecibo.UseVisualStyleBackColor = true;
            this.btbAltaRecibo.Click += new System.EventHandler(this.btbAltaRecibo_Click);
            // 
            // btbMostrarRecibos
            // 
            this.btbMostrarRecibos.Location = new System.Drawing.Point(953, 495);
            this.btbMostrarRecibos.Name = "btbMostrarRecibos";
            this.btbMostrarRecibos.Size = new System.Drawing.Size(168, 133);
            this.btbMostrarRecibos.TabIndex = 21;
            this.btbMostrarRecibos.Text = "Mostrar todos los recibos de un Empleado";
            this.btbMostrarRecibos.UseVisualStyleBackColor = true;
            this.btbMostrarRecibos.Click += new System.EventHandler(this.btbMostrarRecibos_Click);
            // 
            // btbRecibosHistorialCompletos
            // 
            this.btbRecibosHistorialCompletos.Location = new System.Drawing.Point(1127, 495);
            this.btbRecibosHistorialCompletos.Name = "btbRecibosHistorialCompletos";
            this.btbRecibosHistorialCompletos.Size = new System.Drawing.Size(117, 133);
            this.btbRecibosHistorialCompletos.TabIndex = 22;
            this.btbRecibosHistorialCompletos.Text = "Historial Completo de Recibos";
            this.btbRecibosHistorialCompletos.UseVisualStyleBackColor = true;
            this.btbRecibosHistorialCompletos.Click += new System.EventHandler(this.btbRecibosHistorialCompletos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 646);
            this.Controls.Add(this.btbRecibosHistorialCompletos);
            this.Controls.Add(this.btbMostrarRecibos);
            this.Controls.Add(this.btbAltaRecibo);
            this.Controls.Add(this.dgvRecibos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbAltaConcepto);
            this.Controls.Add(this.btbModificarConcepto);
            this.Controls.Add(this.btbBajaConcepto);
            this.Controls.Add(this.cblConceptos);
            this.Controls.Add(this.btbBajaEmpleado);
            this.Controls.Add(this.btbModificarEmpleado);
            this.Controls.Add(this.btbAltaEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaDeEmpleados);
            this.Name = "Form1";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbAltaEmpleado;
        private System.Windows.Forms.Button btbModificarEmpleado;
        private System.Windows.Forms.Button btbBajaEmpleado;
        private System.Windows.Forms.CheckedListBox cblConceptos;
        private System.Windows.Forms.Button btbBajaConcepto;
        private System.Windows.Forms.Button btbModificarConcepto;
        private System.Windows.Forms.Button btbAltaConcepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvRecibos;
        private System.Windows.Forms.Button btbAltaRecibo;
        private System.Windows.Forms.Button btbMostrarRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptosAplicados;
        private System.Windows.Forms.Button btbRecibosHistorialCompletos;
    }
}


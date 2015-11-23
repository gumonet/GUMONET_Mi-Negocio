namespace Mi_Negocio.Cotizaciones
{
    partial class frmCotizaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataFacturas = new System.Windows.Forms.DataGridView();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timbrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturas)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizaciónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cotizaciónToolStripMenuItem
            // 
            this.cotizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
            this.cotizaciónToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.cotizaciónToolStripMenuItem.Text = "Cotización";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dataFacturas
            // 
            this.dataFacturas.AllowUserToAddRows = false;
            this.dataFacturas.AllowUserToDeleteRows = false;
            this.dataFacturas.AllowUserToResizeColumns = false;
            this.dataFacturas.AllowUserToResizeRows = false;
            this.dataFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_factura,
            this.email,
            this.FECHA,
            this.rfc,
            this.nombre,
            this.importe_subtotal,
            this.importe_total,
            this.FOLIO,
            this.timbrado});
            this.dataFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataFacturas.Location = new System.Drawing.Point(12, 79);
            this.dataFacturas.MultiSelect = false;
            this.dataFacturas.Name = "dataFacturas";
            this.dataFacturas.ReadOnly = true;
            this.dataFacturas.RowHeadersVisible = false;
            this.dataFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFacturas.Size = new System.Drawing.Size(1063, 337);
            this.dataFacturas.TabIndex = 6;
            // 
            // id_factura
            // 
            this.id_factura.DataPropertyName = "id_factura";
            this.id_factura.HeaderText = "id_factura";
            this.id_factura.Name = "id_factura";
            this.id_factura.ReadOnly = true;
            this.id_factura.Visible = false;
            this.id_factura.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "fecha";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 200;
            // 
            // rfc
            // 
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.Name = "rfc";
            this.rfc.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "RAZÓN SOCIAL";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 500;
            // 
            // importe_subtotal
            // 
            this.importe_subtotal.DataPropertyName = "importe_subtotal";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "$###,##0.##";
            this.importe_subtotal.DefaultCellStyle = dataGridViewCellStyle22;
            this.importe_subtotal.HeaderText = "SUBTOTAL";
            this.importe_subtotal.Name = "importe_subtotal";
            this.importe_subtotal.ReadOnly = true;
            // 
            // importe_total
            // 
            this.importe_total.DataPropertyName = "importe_total";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "$###,##0.##";
            this.importe_total.DefaultCellStyle = dataGridViewCellStyle23;
            this.importe_total.HeaderText = "TOTAL";
            this.importe_total.Name = "importe_total";
            this.importe_total.ReadOnly = true;
            // 
            // FOLIO
            // 
            this.FOLIO.DataPropertyName = "folio";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.NullValue = "$###,##0.##";
            this.FOLIO.DefaultCellStyle = dataGridViewCellStyle24;
            this.FOLIO.HeaderText = "FOLIO";
            this.FOLIO.Name = "FOLIO";
            this.FOLIO.ReadOnly = true;
            this.FOLIO.Width = 60;
            // 
            // timbrado
            // 
            this.timbrado.DataPropertyName = "timbrado";
            this.timbrado.HeaderText = "ESTATUS";
            this.timbrado.Name = "timbrado";
            this.timbrado.ReadOnly = true;
            this.timbrado.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dateInicio);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dateFinal);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnNuevaFactura);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 46);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "A";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(422, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 31);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateInicio
            // 
            this.dateInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(4, 13);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(104, 23);
            this.dateInicio.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(250, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 23);
            this.txtSearch.TabIndex = 17;
            // 
            // dateFinal
            // 
            this.dateFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.Location = new System.Drawing.Point(136, 13);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(105, 23);
            this.dateFinal.TabIndex = 19;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(974, 10);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(86, 28);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(886, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(82, 28);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFactura.Location = new System.Drawing.Point(768, 11);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(112, 27);
            this.btnNuevaFactura.TabIndex = 13;
            this.btnNuevaFactura.Text = "Nueva Cotización";
            this.btnNuevaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Eliminar";
            // 
            // frmCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 430);
            this.Controls.Add(this.dataFacturas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCotizaciones";
            this.Text = "frmCotizaciones";
            this.Load += new System.EventHandler(this.frmCotizaciones_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cotizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOLIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn timbrado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnNuevaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
namespace Mi_Negocio.Almacenes
{
    partial class frmAlmacen
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
            this.generalMenu = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioBajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalMenu
            // 
            this.generalMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.generalMenu.Location = new System.Drawing.Point(0, 0);
            this.generalMenu.Name = "generalMenu";
            this.generalMenu.Size = new System.Drawing.Size(1480, 24);
            this.generalMenu.TabIndex = 0;
            this.generalMenu.Text = "Menu Almacen";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInventarioToolStripMenuItem,
            this.inventarioBajoToolStripMenuItem,
            this.openImprimirToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // openInventarioToolStripMenuItem
            // 
            this.openInventarioToolStripMenuItem.Name = "openInventarioToolStripMenuItem";
            this.openInventarioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openInventarioToolStripMenuItem.Text = "Inventario";
            this.openInventarioToolStripMenuItem.Click += new System.EventHandler(this.openInventarioToolStripMenuItem_Click);
            // 
            // inventarioBajoToolStripMenuItem
            // 
            this.inventarioBajoToolStripMenuItem.Name = "inventarioBajoToolStripMenuItem";
            this.inventarioBajoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.inventarioBajoToolStripMenuItem.Text = "Inventario Bajo";
            // 
            // openImprimirToolStripMenuItem
            // 
            this.openImprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.porFechaToolStripMenuItem,
            this.porCategoríaToolStripMenuItem});
            this.openImprimirToolStripMenuItem.Name = "openImprimirToolStripMenuItem";
            this.openImprimirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openImprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.porFechaToolStripMenuItem.Text = "Por Fecha";
            // 
            // porCategoríaToolStripMenuItem
            // 
            this.porCategoríaToolStripMenuItem.Name = "porCategoríaToolStripMenuItem";
            this.porCategoríaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.porCategoríaToolStripMenuItem.Text = "Por Departamento";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMovimientosToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // openMovimientosToolStripMenuItem
            // 
            this.openMovimientosToolStripMenuItem.Name = "openMovimientosToolStripMenuItem";
            this.openMovimientosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openMovimientosToolStripMenuItem.Text = "Ver";
            this.openMovimientosToolStripMenuItem.Click += new System.EventHandler(this.openMovimientosToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genralToolStripMenuItem,
            this.entradasToolStripMenuItem1,
            this.salidasToolStripMenuItem});
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // genralToolStripMenuItem
            // 
            this.genralToolStripMenuItem.Name = "genralToolStripMenuItem";
            this.genralToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.genralToolStripMenuItem.Text = "Genral";
            // 
            // entradasToolStripMenuItem1
            // 
            this.entradasToolStripMenuItem1.Name = "entradasToolStripMenuItem1";
            this.entradasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.entradasToolStripMenuItem1.Text = "Entradas";
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salidasToolStripMenuItem.Text = "Salidas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 647);
            this.Controls.Add(this.generalMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.generalMenu;
            this.Name = "frmAlmacen";
            this.Text = "Almacen";
            this.generalMenu.ResumeLayout(false);
            this.generalMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip generalMenu;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioBajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}
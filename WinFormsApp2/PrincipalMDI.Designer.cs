namespace WinFormsApp2
{
    partial class PrincipalMDI
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
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            mnuManUsuarios = new ToolStripMenuItem();
            mnuManProductos = new ToolStripMenuItem();
            mnuManCategorias = new ToolStripMenuItem();
            mnuManProveedores = new ToolStripMenuItem();
            mnuManClientes = new ToolStripMenuItem();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            registrarVentaToolStripMenuItem = new ToolStripMenuItem();
            registrarCompraToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reporteDeVentasToolStripMenuItem = new ToolStripMenuItem();
            reporteDeComprasToolStripMenuItem = new ToolStripMenuItem();
            inventarioDeProductosToolStripMenuItem = new ToolStripMenuItem();
            reporteDeProveedoresToolStripMenuItem = new ToolStripMenuItem();
            reporteDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            reporteDeClientesToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, procesosToolStripMenuItem, reportesToolStripMenuItem, sistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuManUsuarios, mnuManProductos, mnuManCategorias, mnuManProveedores, mnuManClientes });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(101, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            mnuManUsuarios.Name = "mnuManUsuarios";
            mnuManUsuarios.Size = new Size(180, 22);
            mnuManUsuarios.Text = "Usuarios";
            mnuManUsuarios.Click += mnuManUsuarios_Click;
            // 
            // mnuManProductos
            // 
            mnuManProductos.Name = "mnuManProductos";
            mnuManProductos.Size = new Size(180, 22);
            mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            mnuManCategorias.Name = "mnuManCategorias";
            mnuManCategorias.Size = new Size(180, 22);
            mnuManCategorias.Text = "Categorías";
            // 
            // mnuManProveedores
            // 
            mnuManProveedores.Name = "mnuManProveedores";
            mnuManProveedores.Size = new Size(180, 22);
            mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            mnuManClientes.Name = "mnuManClientes";
            mnuManClientes.Size = new Size(180, 22);
            mnuManClientes.Text = "Clientes";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarVentaToolStripMenuItem, registrarCompraToolStripMenuItem });
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(66, 20);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // registrarVentaToolStripMenuItem
            // 
            registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            registrarVentaToolStripMenuItem.Size = new Size(166, 22);
            registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            // 
            // registrarCompraToolStripMenuItem
            // 
            registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            registrarCompraToolStripMenuItem.Size = new Size(166, 22);
            registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteDeVentasToolStripMenuItem, reporteDeComprasToolStripMenuItem, inventarioDeProductosToolStripMenuItem, reporteDeProveedoresToolStripMenuItem, reporteDeUsuariosToolStripMenuItem, reporteDeClientesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            reporteDeVentasToolStripMenuItem.Size = new Size(200, 22);
            reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            // 
            // reporteDeComprasToolStripMenuItem
            // 
            reporteDeComprasToolStripMenuItem.Name = "reporteDeComprasToolStripMenuItem";
            reporteDeComprasToolStripMenuItem.Size = new Size(200, 22);
            reporteDeComprasToolStripMenuItem.Text = "Reporte de compras";
            // 
            // inventarioDeProductosToolStripMenuItem
            // 
            inventarioDeProductosToolStripMenuItem.Name = "inventarioDeProductosToolStripMenuItem";
            inventarioDeProductosToolStripMenuItem.Size = new Size(200, 22);
            inventarioDeProductosToolStripMenuItem.Text = "Inventario de productos";
            // 
            // reporteDeProveedoresToolStripMenuItem
            // 
            reporteDeProveedoresToolStripMenuItem.Name = "reporteDeProveedoresToolStripMenuItem";
            reporteDeProveedoresToolStripMenuItem.Size = new Size(200, 22);
            reporteDeProveedoresToolStripMenuItem.Text = "Reporte de proveedores";
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            reporteDeUsuariosToolStripMenuItem.Size = new Size(200, 22);
            reporteDeUsuariosToolStripMenuItem.Text = "Reporte de usuarios";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            reporteDeClientesToolStripMenuItem.Size = new Size(200, 22);
            reporteDeClientesToolStripMenuItem.Text = "Reporte de clientes.";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(180, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // PrincipalMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "PrincipalMDI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Panel principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem mnuManUsuarios;
        private ToolStripMenuItem mnuManProductos;
        private ToolStripMenuItem mnuManCategorias;
        private ToolStripMenuItem mnuManProveedores;
        private ToolStripMenuItem mnuManClientes;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem registrarVentaToolStripMenuItem;
        private ToolStripMenuItem registrarCompraToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private ToolStripMenuItem reporteDeComprasToolStripMenuItem;
        private ToolStripMenuItem inventarioDeProductosToolStripMenuItem;
        private ToolStripMenuItem reporteDeProveedoresToolStripMenuItem;
        private ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}
namespace Computacion.Formularios
{
    partial class frmProcesadores
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
            this.dgvProcesadores = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBuscarxId = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtTurboBoost = new System.Windows.Forms.TextBox();
            this.lblTurboBoost = new System.Windows.Forms.Label();
            this.txtFrecuencia = new System.Windows.Forms.TextBox();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNucleos = new System.Windows.Forms.TextBox();
            this.lblNucleos = new System.Windows.Forms.Label();
            this.txtSubnucleos = new System.Windows.Forms.TextBox();
            this.lblSubnucleos = new System.Windows.Forms.Label();
            this.txtCache = new System.Windows.Forms.TextBox();
            this.lblCache = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcesadores
            // 
            this.dgvProcesadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesadores.Location = new System.Drawing.Point(184, 56);
            this.dgvProcesadores.Name = "dgvProcesadores";
            this.dgvProcesadores.Size = new System.Drawing.Size(546, 301);
            this.dgvProcesadores.TabIndex = 31;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(508, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(427, 14);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 29;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBuscarxId
            // 
            this.btnBuscarxId.Location = new System.Drawing.Point(346, 14);
            this.btnBuscarxId.Name = "btnBuscarxId";
            this.btnBuscarxId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarxId.TabIndex = 28;
            this.btnBuscarxId.Text = "Buscar por Id";
            this.btnBuscarxId.UseVisualStyleBackColor = true;
            this.btnBuscarxId.Click += new System.EventHandler(this.btnBuscarxId_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(265, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(184, 14);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtTurboBoost
            // 
            this.txtTurboBoost.Location = new System.Drawing.Point(58, 166);
            this.txtTurboBoost.Name = "txtTurboBoost";
            this.txtTurboBoost.Size = new System.Drawing.Size(100, 20);
            this.txtTurboBoost.TabIndex = 25;
            // 
            // lblTurboBoost
            // 
            this.lblTurboBoost.AutoSize = true;
            this.lblTurboBoost.Location = new System.Drawing.Point(15, 169);
            this.lblTurboBoost.Name = "lblTurboBoost";
            this.lblTurboBoost.Size = new System.Drawing.Size(65, 13);
            this.lblTurboBoost.TabIndex = 24;
            this.lblTurboBoost.Text = "TurboBoost:";
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Location = new System.Drawing.Point(58, 131);
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.Size = new System.Drawing.Size(100, 20);
            this.txtFrecuencia.TabIndex = 23;
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(15, 134);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(63, 13);
            this.lblFrecuencia.TabIndex = 22;
            this.lblFrecuencia.Text = "Frecuencia:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(58, 94);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 21;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(15, 97);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(58, 56);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 19;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(15, 59);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 18;
            this.lblMarca.Text = "Marca:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(58, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 17;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Id:";
            // 
            // txtNucleos
            // 
            this.txtNucleos.Location = new System.Drawing.Point(58, 207);
            this.txtNucleos.Name = "txtNucleos";
            this.txtNucleos.Size = new System.Drawing.Size(100, 20);
            this.txtNucleos.TabIndex = 33;
            // 
            // lblNucleos
            // 
            this.lblNucleos.AutoSize = true;
            this.lblNucleos.Location = new System.Drawing.Point(15, 210);
            this.lblNucleos.Name = "lblNucleos";
            this.lblNucleos.Size = new System.Drawing.Size(49, 13);
            this.lblNucleos.TabIndex = 32;
            this.lblNucleos.Text = "Nucleos:";
            // 
            // txtSubnucleos
            // 
            this.txtSubnucleos.Location = new System.Drawing.Point(56, 245);
            this.txtSubnucleos.Name = "txtSubnucleos";
            this.txtSubnucleos.Size = new System.Drawing.Size(100, 20);
            this.txtSubnucleos.TabIndex = 35;
            // 
            // lblSubnucleos
            // 
            this.lblSubnucleos.AutoSize = true;
            this.lblSubnucleos.Location = new System.Drawing.Point(13, 248);
            this.lblSubnucleos.Name = "lblSubnucleos";
            this.lblSubnucleos.Size = new System.Drawing.Size(71, 13);
            this.lblSubnucleos.TabIndex = 34;
            this.lblSubnucleos.Text = "SubNucleos::";
            // 
            // txtCache
            // 
            this.txtCache.Location = new System.Drawing.Point(58, 284);
            this.txtCache.Name = "txtCache";
            this.txtCache.Size = new System.Drawing.Size(100, 20);
            this.txtCache.TabIndex = 37;
            // 
            // lblCache
            // 
            this.lblCache.AutoSize = true;
            this.lblCache.Location = new System.Drawing.Point(15, 287);
            this.lblCache.Name = "lblCache";
            this.lblCache.Size = new System.Drawing.Size(41, 13);
            this.lblCache.TabIndex = 36;
            this.lblCache.Text = "Cache:";
            // 
            // frmProcesadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 371);
            this.Controls.Add(this.txtCache);
            this.Controls.Add(this.lblCache);
            this.Controls.Add(this.txtSubnucleos);
            this.Controls.Add(this.lblSubnucleos);
            this.Controls.Add(this.txtNucleos);
            this.Controls.Add(this.lblNucleos);
            this.Controls.Add(this.dgvProcesadores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBuscarxId);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtTurboBoost);
            this.Controls.Add(this.lblTurboBoost);
            this.Controls.Add(this.txtFrecuencia);
            this.Controls.Add(this.lblFrecuencia);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "frmProcesadores";
            this.Text = "Procesadores";
            this.Load += new System.EventHandler(this.frmProcesadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcesadores;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBuscarxId;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtTurboBoost;
        private System.Windows.Forms.Label lblTurboBoost;
        private System.Windows.Forms.TextBox txtFrecuencia;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNucleos;
        private System.Windows.Forms.Label lblNucleos;
        private System.Windows.Forms.TextBox txtSubnucleos;
        private System.Windows.Forms.Label lblSubnucleos;
        private System.Windows.Forms.TextBox txtCache;
        private System.Windows.Forms.Label lblCache;
    }
}
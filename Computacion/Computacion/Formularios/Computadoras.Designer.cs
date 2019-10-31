namespace Computacion.Formularios
{
    partial class frmComputadoras
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarxId = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvComputadoras = new System.Windows.Forms.DataGridView();
            this.tabDatos = new System.Windows.Forms.TabControl();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblBateria = new System.Windows.Forms.Label();
            this.txtAltoPantalla = new System.Windows.Forms.TextBox();
            this.txtRanuras = new System.Windows.Forms.TextBox();
            this.lblRanuras = new System.Windows.Forms.Label();
            this.txtAnchoPantalla = new System.Windows.Forms.TextBox();
            this.lblAnchoPantalla = new System.Windows.Forms.Label();
            this.txtPulgadasPantalla = new System.Windows.Forms.TextBox();
            this.lblPulgadasPantalla = new System.Windows.Forms.Label();
            this.txtTipoPantalla = new System.Windows.Forms.TextBox();
            this.lblTipoPantalla = new System.Windows.Forms.Label();
            this.lblSistemaOperativo = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtBateria = new System.Windows.Forms.TextBox();
            this.lblVersionSO = new System.Windows.Forms.Label();
            this.txtSistemaOperativo = new System.Windows.Forms.TextBox();
            this.lblAltoPantalla = new System.Windows.Forms.Label();
            this.txtTarjetaVideo = new System.Windows.Forms.TextBox();
            this.txtDiscoDuro = new System.Windows.Forms.TextBox();
            this.lblDiscoDuro = new System.Windows.Forms.Label();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.lblTarjetaVideo = new System.Windows.Forms.Label();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.txtVersionSO = new System.Windows.Forms.TextBox();
            this.lblProcesador = new System.Windows.Forms.Label();
            this.chkUnidadOptica = new System.Windows.Forms.CheckBox();
            this.chkTecladoIluminado = new System.Windows.Forms.CheckBox();
            this.chkDetectorHuella = new System.Windows.Forms.CheckBox();
            this.tabIngresar = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputadoras)).BeginInit();
            this.tabDatos.SuspendLayout();
            this.tabIngresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(328, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(409, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarxId
            // 
            this.btnBuscarxId.Location = new System.Drawing.Point(490, 12);
            this.btnBuscarxId.Name = "btnBuscarxId";
            this.btnBuscarxId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarxId.TabIndex = 12;
            this.btnBuscarxId.Text = "Buscar por Id";
            this.btnBuscarxId.UseVisualStyleBackColor = true;
            this.btnBuscarxId.Click += new System.EventHandler(this.btnBuscarxId_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(571, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(652, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvComputadoras
            // 
            this.dgvComputadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputadoras.Location = new System.Drawing.Point(328, 52);
            this.dgvComputadoras.Name = "dgvComputadoras";
            this.dgvComputadoras.Size = new System.Drawing.Size(399, 301);
            this.dgvComputadoras.TabIndex = 15;
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.tabIngresar);
            this.tabDatos.Location = new System.Drawing.Point(12, 12);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.SelectedIndex = 0;
            this.tabDatos.Size = new System.Drawing.Size(297, 352);
            this.tabDatos.TabIndex = 16;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(14, 118);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(57, 85);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(57, 111);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(16, 88);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(57, 62);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(14, 62);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(57, 33);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(14, 36);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(57, 6);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNumSerie.TabIndex = 1;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(14, 9);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(89, 13);
            this.lblNumSerie.TabIndex = 0;
            this.lblNumSerie.Text = "Numero de Serie:";
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.Location = new System.Drawing.Point(8, 274);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(43, 13);
            this.lblBateria.TabIndex = 18;
            this.lblBateria.Text = "Bateria:";
            // 
            // txtAltoPantalla
            // 
            this.txtAltoPantalla.Location = new System.Drawing.Point(57, 219);
            this.txtAltoPantalla.Name = "txtAltoPantalla";
            this.txtAltoPantalla.Size = new System.Drawing.Size(100, 20);
            this.txtAltoPantalla.TabIndex = 17;
            // 
            // txtRanuras
            // 
            this.txtRanuras.Location = new System.Drawing.Point(57, 245);
            this.txtRanuras.Name = "txtRanuras";
            this.txtRanuras.Size = new System.Drawing.Size(100, 20);
            this.txtRanuras.TabIndex = 19;
            // 
            // lblRanuras
            // 
            this.lblRanuras.AutoSize = true;
            this.lblRanuras.Location = new System.Drawing.Point(8, 245);
            this.lblRanuras.Name = "lblRanuras";
            this.lblRanuras.Size = new System.Drawing.Size(50, 13);
            this.lblRanuras.TabIndex = 16;
            this.lblRanuras.Text = "Ranuras:";
            // 
            // txtAnchoPantalla
            // 
            this.txtAnchoPantalla.Location = new System.Drawing.Point(57, 193);
            this.txtAnchoPantalla.Name = "txtAnchoPantalla";
            this.txtAnchoPantalla.Size = new System.Drawing.Size(100, 20);
            this.txtAnchoPantalla.TabIndex = 15;
            // 
            // lblAnchoPantalla
            // 
            this.lblAnchoPantalla.AutoSize = true;
            this.lblAnchoPantalla.Location = new System.Drawing.Point(10, 196);
            this.lblAnchoPantalla.Name = "lblAnchoPantalla";
            this.lblAnchoPantalla.Size = new System.Drawing.Size(108, 13);
            this.lblAnchoPantalla.TabIndex = 14;
            this.lblAnchoPantalla.Text = "Ancho de la Pantalla:";
            // 
            // txtPulgadasPantalla
            // 
            this.txtPulgadasPantalla.Location = new System.Drawing.Point(57, 170);
            this.txtPulgadasPantalla.Name = "txtPulgadasPantalla";
            this.txtPulgadasPantalla.Size = new System.Drawing.Size(100, 20);
            this.txtPulgadasPantalla.TabIndex = 13;
            // 
            // lblPulgadasPantalla
            // 
            this.lblPulgadasPantalla.AutoSize = true;
            this.lblPulgadasPantalla.Location = new System.Drawing.Point(10, 170);
            this.lblPulgadasPantalla.Name = "lblPulgadasPantalla";
            this.lblPulgadasPantalla.Size = new System.Drawing.Size(118, 13);
            this.lblPulgadasPantalla.TabIndex = 12;
            this.lblPulgadasPantalla.Text = "Pulgadas de la Pantalla";
            // 
            // txtTipoPantalla
            // 
            this.txtTipoPantalla.Location = new System.Drawing.Point(57, 140);
            this.txtTipoPantalla.Name = "txtTipoPantalla";
            this.txtTipoPantalla.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPantalla.TabIndex = 11;
            // 
            // lblTipoPantalla
            // 
            this.lblTipoPantalla.AutoSize = true;
            this.lblTipoPantalla.Location = new System.Drawing.Point(10, 143);
            this.lblTipoPantalla.Name = "lblTipoPantalla";
            this.lblTipoPantalla.Size = new System.Drawing.Size(87, 13);
            this.lblTipoPantalla.TabIndex = 10;
            this.lblTipoPantalla.Text = "Tipo de Pantalla:";
            // 
            // lblSistemaOperativo
            // 
            this.lblSistemaOperativo.AutoSize = true;
            this.lblSistemaOperativo.Location = new System.Drawing.Point(6, 405);
            this.lblSistemaOperativo.Name = "lblSistemaOperativo";
            this.lblSistemaOperativo.Size = new System.Drawing.Size(96, 13);
            this.lblSistemaOperativo.TabIndex = 28;
            this.lblSistemaOperativo.Text = "Sistema Operativo:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(57, 379);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 29;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(8, 379);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 26;
            this.lblPeso.Text = "Peso:";
            // 
            // txtBateria
            // 
            this.txtBateria.Location = new System.Drawing.Point(57, 271);
            this.txtBateria.Name = "txtBateria";
            this.txtBateria.Size = new System.Drawing.Size(100, 20);
            this.txtBateria.TabIndex = 21;
            // 
            // lblVersionSO
            // 
            this.lblVersionSO.AutoSize = true;
            this.lblVersionSO.Location = new System.Drawing.Point(6, 437);
            this.lblVersionSO.Name = "lblVersionSO";
            this.lblVersionSO.Size = new System.Drawing.Size(66, 13);
            this.lblVersionSO.TabIndex = 30;
            this.lblVersionSO.Text = "Version S.O.";
            // 
            // txtSistemaOperativo
            // 
            this.txtSistemaOperativo.Location = new System.Drawing.Point(59, 408);
            this.txtSistemaOperativo.Name = "txtSistemaOperativo";
            this.txtSistemaOperativo.Size = new System.Drawing.Size(100, 20);
            this.txtSistemaOperativo.TabIndex = 31;
            // 
            // lblAltoPantalla
            // 
            this.lblAltoPantalla.AutoSize = true;
            this.lblAltoPantalla.Location = new System.Drawing.Point(10, 222);
            this.lblAltoPantalla.Name = "lblAltoPantalla";
            this.lblAltoPantalla.Size = new System.Drawing.Size(95, 13);
            this.lblAltoPantalla.TabIndex = 40;
            this.lblAltoPantalla.Text = "Alto de la Pantalla:";
            // 
            // txtTarjetaVideo
            // 
            this.txtTarjetaVideo.Location = new System.Drawing.Point(59, 513);
            this.txtTarjetaVideo.Name = "txtTarjetaVideo";
            this.txtTarjetaVideo.Size = new System.Drawing.Size(100, 20);
            this.txtTarjetaVideo.TabIndex = 39;
            // 
            // txtDiscoDuro
            // 
            this.txtDiscoDuro.Location = new System.Drawing.Point(59, 539);
            this.txtDiscoDuro.Name = "txtDiscoDuro";
            this.txtDiscoDuro.Size = new System.Drawing.Size(100, 20);
            this.txtDiscoDuro.TabIndex = 41;
            // 
            // lblDiscoDuro
            // 
            this.lblDiscoDuro.AutoSize = true;
            this.lblDiscoDuro.Location = new System.Drawing.Point(6, 542);
            this.lblDiscoDuro.Name = "lblDiscoDuro";
            this.lblDiscoDuro.Size = new System.Drawing.Size(63, 13);
            this.lblDiscoDuro.TabIndex = 38;
            this.lblDiscoDuro.Text = "Disco Duro:";
            // 
            // txtMemoria
            // 
            this.txtMemoria.Location = new System.Drawing.Point(59, 487);
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(100, 20);
            this.txtMemoria.TabIndex = 37;
            // 
            // lblTarjetaVideo
            // 
            this.lblTarjetaVideo.AutoSize = true;
            this.lblTarjetaVideo.Location = new System.Drawing.Point(4, 516);
            this.lblTarjetaVideo.Name = "lblTarjetaVideo";
            this.lblTarjetaVideo.Size = new System.Drawing.Size(73, 13);
            this.lblTarjetaVideo.TabIndex = 36;
            this.lblTarjetaVideo.Text = "Tarjeta Video:";
            // 
            // txtProcesador
            // 
            this.txtProcesador.Location = new System.Drawing.Point(59, 461);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(100, 20);
            this.txtProcesador.TabIndex = 35;
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(4, 490);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(50, 13);
            this.lblMemoria.TabIndex = 34;
            this.lblMemoria.Text = "Memoria:";
            // 
            // txtVersionSO
            // 
            this.txtVersionSO.Location = new System.Drawing.Point(59, 435);
            this.txtVersionSO.Name = "txtVersionSO";
            this.txtVersionSO.Size = new System.Drawing.Size(100, 20);
            this.txtVersionSO.TabIndex = 33;
            // 
            // lblProcesador
            // 
            this.lblProcesador.AutoSize = true;
            this.lblProcesador.Location = new System.Drawing.Point(4, 463);
            this.lblProcesador.Name = "lblProcesador";
            this.lblProcesador.Size = new System.Drawing.Size(64, 13);
            this.lblProcesador.TabIndex = 32;
            this.lblProcesador.Text = "Procesador:";
            // 
            // chkUnidadOptica
            // 
            this.chkUnidadOptica.AutoSize = true;
            this.chkUnidadOptica.Location = new System.Drawing.Point(76, 298);
            this.chkUnidadOptica.Name = "chkUnidadOptica";
            this.chkUnidadOptica.Size = new System.Drawing.Size(91, 17);
            this.chkUnidadOptica.TabIndex = 42;
            this.chkUnidadOptica.Text = "UnidadOptica";
            this.chkUnidadOptica.UseVisualStyleBackColor = true;
            // 
            // chkTecladoIluminado
            // 
            this.chkTecladoIluminado.AutoSize = true;
            this.chkTecladoIluminado.Location = new System.Drawing.Point(74, 321);
            this.chkTecladoIluminado.Name = "chkTecladoIluminado";
            this.chkTecladoIluminado.Size = new System.Drawing.Size(113, 17);
            this.chkTecladoIluminado.TabIndex = 43;
            this.chkTecladoIluminado.Text = "Teclado Iluminado";
            this.chkTecladoIluminado.UseVisualStyleBackColor = true;
            // 
            // chkDetectorHuella
            // 
            this.chkDetectorHuella.AutoSize = true;
            this.chkDetectorHuella.Location = new System.Drawing.Point(74, 348);
            this.chkDetectorHuella.Name = "chkDetectorHuella";
            this.chkDetectorHuella.Size = new System.Drawing.Size(115, 17);
            this.chkDetectorHuella.TabIndex = 44;
            this.chkDetectorHuella.Text = "Detector de Huella";
            this.chkDetectorHuella.UseVisualStyleBackColor = true;
            // 
            // tabIngresar
            // 
            this.tabIngresar.AutoScroll = true;
            this.tabIngresar.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.tabIngresar.Controls.Add(this.chkDetectorHuella);
            this.tabIngresar.Controls.Add(this.chkTecladoIluminado);
            this.tabIngresar.Controls.Add(this.chkUnidadOptica);
            this.tabIngresar.Controls.Add(this.lblProcesador);
            this.tabIngresar.Controls.Add(this.txtVersionSO);
            this.tabIngresar.Controls.Add(this.lblMemoria);
            this.tabIngresar.Controls.Add(this.txtProcesador);
            this.tabIngresar.Controls.Add(this.lblTarjetaVideo);
            this.tabIngresar.Controls.Add(this.txtMemoria);
            this.tabIngresar.Controls.Add(this.lblDiscoDuro);
            this.tabIngresar.Controls.Add(this.txtDiscoDuro);
            this.tabIngresar.Controls.Add(this.txtTarjetaVideo);
            this.tabIngresar.Controls.Add(this.lblAltoPantalla);
            this.tabIngresar.Controls.Add(this.txtSistemaOperativo);
            this.tabIngresar.Controls.Add(this.lblVersionSO);
            this.tabIngresar.Controls.Add(this.txtBateria);
            this.tabIngresar.Controls.Add(this.lblPeso);
            this.tabIngresar.Controls.Add(this.txtPeso);
            this.tabIngresar.Controls.Add(this.lblSistemaOperativo);
            this.tabIngresar.Controls.Add(this.lblTipoPantalla);
            this.tabIngresar.Controls.Add(this.txtTipoPantalla);
            this.tabIngresar.Controls.Add(this.lblPulgadasPantalla);
            this.tabIngresar.Controls.Add(this.txtPulgadasPantalla);
            this.tabIngresar.Controls.Add(this.lblAnchoPantalla);
            this.tabIngresar.Controls.Add(this.txtAnchoPantalla);
            this.tabIngresar.Controls.Add(this.lblRanuras);
            this.tabIngresar.Controls.Add(this.txtRanuras);
            this.tabIngresar.Controls.Add(this.txtAltoPantalla);
            this.tabIngresar.Controls.Add(this.lblBateria);
            this.tabIngresar.Controls.Add(this.lblNumSerie);
            this.tabIngresar.Controls.Add(this.txtNumSerie);
            this.tabIngresar.Controls.Add(this.lblMarca);
            this.tabIngresar.Controls.Add(this.txtMarca);
            this.tabIngresar.Controls.Add(this.lblModelo);
            this.tabIngresar.Controls.Add(this.txtModelo);
            this.tabIngresar.Controls.Add(this.lblTipo);
            this.tabIngresar.Controls.Add(this.txtColor);
            this.tabIngresar.Controls.Add(this.txtTipo);
            this.tabIngresar.Controls.Add(this.lblColor);
            this.tabIngresar.Location = new System.Drawing.Point(4, 22);
            this.tabIngresar.Name = "tabIngresar";
            this.tabIngresar.Size = new System.Drawing.Size(289, 326);
            this.tabIngresar.TabIndex = 0;
            this.tabIngresar.Text = "Ingresar Datos:";
            this.tabIngresar.UseVisualStyleBackColor = true;
            // 
            // frmComputadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 365);
            this.Controls.Add(this.tabDatos);
            this.Controls.Add(this.dgvComputadoras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBuscarxId);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Name = "frmComputadoras";
            this.Text = "Computadoras";
            this.Load += new System.EventHandler(this.frmComputadoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputadoras)).EndInit();
            this.tabDatos.ResumeLayout(false);
            this.tabIngresar.ResumeLayout(false);
            this.tabIngresar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarxId;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvComputadoras;
        private System.Windows.Forms.TabControl tabDatos;
        private System.Windows.Forms.TabPage tabIngresar;
        private System.Windows.Forms.CheckBox chkDetectorHuella;
        private System.Windows.Forms.CheckBox chkTecladoIluminado;
        private System.Windows.Forms.CheckBox chkUnidadOptica;
        private System.Windows.Forms.Label lblProcesador;
        private System.Windows.Forms.TextBox txtVersionSO;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.Label lblTarjetaVideo;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.Label lblDiscoDuro;
        private System.Windows.Forms.TextBox txtDiscoDuro;
        private System.Windows.Forms.TextBox txtTarjetaVideo;
        private System.Windows.Forms.Label lblAltoPantalla;
        private System.Windows.Forms.TextBox txtSistemaOperativo;
        private System.Windows.Forms.Label lblVersionSO;
        private System.Windows.Forms.TextBox txtBateria;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblSistemaOperativo;
        private System.Windows.Forms.Label lblTipoPantalla;
        private System.Windows.Forms.TextBox txtTipoPantalla;
        private System.Windows.Forms.Label lblPulgadasPantalla;
        private System.Windows.Forms.TextBox txtPulgadasPantalla;
        private System.Windows.Forms.Label lblAnchoPantalla;
        private System.Windows.Forms.TextBox txtAnchoPantalla;
        private System.Windows.Forms.Label lblRanuras;
        private System.Windows.Forms.TextBox txtRanuras;
        private System.Windows.Forms.TextBox txtAltoPantalla;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblColor;
    }
}
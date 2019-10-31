namespace Escuela
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEscuela = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbEscuela
            // 
            this.cmbEscuela.FormattingEnabled = true;
            this.cmbEscuela.Items.AddRange(new object[] {
            "Seleccionar...",
            "Carreras",
            "Especialidades",
            "Materias",
            "Alumnos",
            "Calificaciones"});
            this.cmbEscuela.Location = new System.Drawing.Point(73, 31);
            this.cmbEscuela.Name = "cmbEscuela";
            this.cmbEscuela.Size = new System.Drawing.Size(121, 21);
            this.cmbEscuela.TabIndex = 0;
            this.cmbEscuela.SelectedIndexChanged += new System.EventHandler(this.cmbEscuela_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbEscuela);
            this.Name = "frmPrincipal";
            this.Text = "Escuela";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEscuela;
    }
}


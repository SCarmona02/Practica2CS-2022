
namespace appPractica2
{
    partial class frmUniversidad
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
            this.lblReglasDeNegocio = new System.Windows.Forms.Label();
            this.lblTipoDeEstudiante = new System.Windows.Forms.Label();
            this.lblCarne = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.cmbTipoEst = new System.Windows.Forms.ComboBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.gpbRpta = new System.Windows.Forms.GroupBox();
            this.lblVrAPagar = new System.Windows.Forms.Label();
            this.lblVrDscto = new System.Windows.Forms.Label();
            this.lblVrCredito = new System.Windows.Forms.Label();
            this.lblNroCreditos = new System.Windows.Forms.Label();
            this.txtNroCred = new System.Windows.Forms.TextBox();
            this.txtVrCred = new System.Windows.Forms.TextBox();
            this.txtVrDesc = new System.Windows.Forms.TextBox();
            this.txtVrPagar = new System.Windows.Forms.TextBox();
            this.txtMsj = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.gpbRpta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReglasDeNegocio
            // 
            this.lblReglasDeNegocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReglasDeNegocio.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReglasDeNegocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReglasDeNegocio.Location = new System.Drawing.Point(0, 0);
            this.lblReglasDeNegocio.Name = "lblReglasDeNegocio";
            this.lblReglasDeNegocio.Size = new System.Drawing.Size(639, 45);
            this.lblReglasDeNegocio.TabIndex = 0;
            this.lblReglasDeNegocio.Text = "Reglas de Negocio";
            this.lblReglasDeNegocio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipoDeEstudiante
            // 
            this.lblTipoDeEstudiante.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeEstudiante.ForeColor = System.Drawing.Color.Blue;
            this.lblTipoDeEstudiante.Location = new System.Drawing.Point(94, 39);
            this.lblTipoDeEstudiante.Name = "lblTipoDeEstudiante";
            this.lblTipoDeEstudiante.Size = new System.Drawing.Size(128, 43);
            this.lblTipoDeEstudiante.TabIndex = 1;
            this.lblTipoDeEstudiante.Text = "Tipo de Estudiante:";
            this.lblTipoDeEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCarne
            // 
            this.lblCarne.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarne.ForeColor = System.Drawing.Color.Blue;
            this.lblCarne.Location = new System.Drawing.Point(94, 82);
            this.lblCarne.Name = "lblCarne";
            this.lblCarne.Size = new System.Drawing.Size(128, 43);
            this.lblCarne.TabIndex = 2;
            this.lblCarne.Text = "Carné:";
            this.lblCarne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Blue;
            this.lblNombre.Location = new System.Drawing.Point(94, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 43);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPromedio
            // 
            this.lblPromedio.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.ForeColor = System.Drawing.Color.Blue;
            this.lblPromedio.Location = new System.Drawing.Point(94, 168);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(128, 43);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio:";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTipoEst
            // 
            this.cmbTipoEst.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoEst.FormattingEnabled = true;
            this.cmbTipoEst.Location = new System.Drawing.Point(228, 48);
            this.cmbTipoEst.Name = "cmbTipoEst";
            this.cmbTipoEst.Size = new System.Drawing.Size(314, 28);
            this.cmbTipoEst.TabIndex = 5;
            // 
            // txtCarne
            // 
            this.txtCarne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarne.Location = new System.Drawing.Point(228, 91);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(150, 26);
            this.txtCarne.TabIndex = 6;
            this.txtCarne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(228, 134);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(314, 26);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(228, 177);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(79, 26);
            this.txtPromedio.TabIndex = 8;
            this.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(98, 214);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 41);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProcesar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(376, 214);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(166, 41);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            // 
            // gpbRpta
            // 
            this.gpbRpta.BackColor = System.Drawing.Color.Silver;
            this.gpbRpta.Controls.Add(this.txtVrPagar);
            this.gpbRpta.Controls.Add(this.txtVrCred);
            this.gpbRpta.Controls.Add(this.txtNroCred);
            this.gpbRpta.Controls.Add(this.txtVrDesc);
            this.gpbRpta.Controls.Add(this.lblVrAPagar);
            this.gpbRpta.Controls.Add(this.lblVrDscto);
            this.gpbRpta.Controls.Add(this.lblVrCredito);
            this.gpbRpta.Controls.Add(this.lblNroCreditos);
            this.gpbRpta.Location = new System.Drawing.Point(98, 261);
            this.gpbRpta.Name = "gpbRpta";
            this.gpbRpta.Size = new System.Drawing.Size(443, 113);
            this.gpbRpta.TabIndex = 11;
            this.gpbRpta.TabStop = false;
            // 
            // lblVrAPagar
            // 
            this.lblVrAPagar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrAPagar.ForeColor = System.Drawing.Color.Black;
            this.lblVrAPagar.Location = new System.Drawing.Point(217, 68);
            this.lblVrAPagar.Name = "lblVrAPagar";
            this.lblVrAPagar.Size = new System.Drawing.Size(128, 26);
            this.lblVrAPagar.TabIndex = 5;
            this.lblVrAPagar.Text = "Nro. Créditos:";
            this.lblVrAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVrDscto
            // 
            this.lblVrDscto.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrDscto.ForeColor = System.Drawing.Color.Black;
            this.lblVrDscto.Location = new System.Drawing.Point(217, 42);
            this.lblVrDscto.Name = "lblVrDscto";
            this.lblVrDscto.Size = new System.Drawing.Size(128, 26);
            this.lblVrDscto.TabIndex = 4;
            this.lblVrDscto.Text = "Vr. Dscto";
            this.lblVrDscto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVrCredito
            // 
            this.lblVrCredito.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrCredito.ForeColor = System.Drawing.Color.Black;
            this.lblVrCredito.Location = new System.Drawing.Point(217, 16);
            this.lblVrCredito.Name = "lblVrCredito";
            this.lblVrCredito.Size = new System.Drawing.Size(128, 26);
            this.lblVrCredito.TabIndex = 3;
            this.lblVrCredito.Text = "Vr. Crédito:";
            this.lblVrCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNroCreditos
            // 
            this.lblNroCreditos.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCreditos.ForeColor = System.Drawing.Color.Black;
            this.lblNroCreditos.Location = new System.Drawing.Point(6, 16);
            this.lblNroCreditos.Name = "lblNroCreditos";
            this.lblNroCreditos.Size = new System.Drawing.Size(128, 26);
            this.lblNroCreditos.TabIndex = 2;
            this.lblNroCreditos.Text = "Nro. Créditos:";
            this.lblNroCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNroCred
            // 
            this.txtNroCred.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCred.Location = new System.Drawing.Point(140, 16);
            this.txtNroCred.Name = "txtNroCred";
            this.txtNroCred.ReadOnly = true;
            this.txtNroCred.Size = new System.Drawing.Size(58, 26);
            this.txtNroCred.TabIndex = 9;
            this.txtNroCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVrCred
            // 
            this.txtVrCred.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrCred.Location = new System.Drawing.Point(351, 16);
            this.txtVrCred.Name = "txtVrCred";
            this.txtVrCred.ReadOnly = true;
            this.txtVrCred.Size = new System.Drawing.Size(58, 26);
            this.txtVrCred.TabIndex = 10;
            this.txtVrCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVrDesc
            // 
            this.txtVrDesc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrDesc.Location = new System.Drawing.Point(351, 42);
            this.txtVrDesc.Name = "txtVrDesc";
            this.txtVrDesc.ReadOnly = true;
            this.txtVrDesc.Size = new System.Drawing.Size(58, 26);
            this.txtVrDesc.TabIndex = 11;
            this.txtVrDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVrPagar
            // 
            this.txtVrPagar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrPagar.Location = new System.Drawing.Point(351, 68);
            this.txtVrPagar.Name = "txtVrPagar";
            this.txtVrPagar.ReadOnly = true;
            this.txtVrPagar.Size = new System.Drawing.Size(58, 26);
            this.txtVrPagar.TabIndex = 12;
            this.txtVrPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMsj
            // 
            this.txtMsj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMsj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsj.Location = new System.Drawing.Point(98, 390);
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsj.Size = new System.Drawing.Size(444, 50);
            this.txtMsj.TabIndex = 12;
            this.txtMsj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTerminar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(449, 470);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(166, 41);
            this.btnTerminar.TabIndex = 13;
            this.btnTerminar.Text = "Limpiar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 523);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.txtMsj);
            this.Controls.Add(this.gpbRpta);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.cmbTipoEst);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCarne);
            this.Controls.Add(this.lblTipoDeEstudiante);
            this.Controls.Add(this.lblReglasDeNegocio);
            this.Name = "frmUniversidad";
            this.Text = "Práctica # 2 - Reglas de Negocio";
            this.gpbRpta.ResumeLayout(false);
            this.gpbRpta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReglasDeNegocio;
        private System.Windows.Forms.Label lblTipoDeEstudiante;
        private System.Windows.Forms.Label lblCarne;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ComboBox cmbTipoEst;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox gpbRpta;
        private System.Windows.Forms.Label lblVrAPagar;
        private System.Windows.Forms.Label lblVrDscto;
        private System.Windows.Forms.Label lblVrCredito;
        private System.Windows.Forms.Label lblNroCreditos;
        private System.Windows.Forms.TextBox txtVrPagar;
        private System.Windows.Forms.TextBox txtVrCred;
        private System.Windows.Forms.TextBox txtNroCred;
        private System.Windows.Forms.TextBox txtVrDesc;
        private System.Windows.Forms.TextBox txtMsj;
        private System.Windows.Forms.Button btnTerminar;
    }
}


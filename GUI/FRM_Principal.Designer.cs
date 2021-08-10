namespace GUI
{
    partial class FRM_Principal
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
            this.btn_SimularEvaluaciones = new System.Windows.Forms.Button();
            this.btn_ConsultarTratamiento = new System.Windows.Forms.Button();
            this.lblDatosPaciente = new System.Windows.Forms.Label();
            this.lblPatologiasPresentadas = new System.Windows.Forms.Label();
            this.cboPatologiaPresentada = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cboEdad = new System.Windows.Forms.ComboBox();
            this.lblDeporte1 = new System.Windows.Forms.Label();
            this.cboDeporte = new System.Windows.Forms.ComboBox();
            this.lblFuma = new System.Windows.Forms.Label();
            this.cboFuma = new System.Windows.Forms.ComboBox();
            this.lblDeporte2 = new System.Windows.Forms.Label();
            this.cboTiempoParaSi = new System.Windows.Forms.ComboBox();
            this.lblTiempoParaSi2 = new System.Windows.Forms.Label();
            this.lblTiempoParaSi1 = new System.Windows.Forms.Label();
            this.rtbxEvaluaciones = new System.Windows.Forms.RichTextBox();
            this.lblEvaluaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SimularEvaluaciones
            // 
            this.btn_SimularEvaluaciones.Location = new System.Drawing.Point(76, 326);
            this.btn_SimularEvaluaciones.Name = "btn_SimularEvaluaciones";
            this.btn_SimularEvaluaciones.Size = new System.Drawing.Size(118, 23);
            this.btn_SimularEvaluaciones.TabIndex = 0;
            this.btn_SimularEvaluaciones.Text = "Simular Evaluaciones";
            this.btn_SimularEvaluaciones.UseVisualStyleBackColor = true;
            this.btn_SimularEvaluaciones.Click += new System.EventHandler(this.btn_SimularEvaluaciones_Click);
            // 
            // btn_ConsultarTratamiento
            // 
            this.btn_ConsultarTratamiento.Location = new System.Drawing.Point(396, 240);
            this.btn_ConsultarTratamiento.Name = "btn_ConsultarTratamiento";
            this.btn_ConsultarTratamiento.Size = new System.Drawing.Size(118, 23);
            this.btn_ConsultarTratamiento.TabIndex = 1;
            this.btn_ConsultarTratamiento.Text = "Consultar Tratamiento";
            this.btn_ConsultarTratamiento.UseVisualStyleBackColor = true;
            this.btn_ConsultarTratamiento.Click += new System.EventHandler(this.btn_ConsultarTratamiento_Click);
            // 
            // lblDatosPaciente
            // 
            this.lblDatosPaciente.AutoSize = true;
            this.lblDatosPaciente.Location = new System.Drawing.Point(322, 9);
            this.lblDatosPaciente.Name = "lblDatosPaciente";
            this.lblDatosPaciente.Size = new System.Drawing.Size(100, 13);
            this.lblDatosPaciente.TabIndex = 2;
            this.lblDatosPaciente.Text = "Datos del Paciente:";
            // 
            // lblPatologiasPresentadas
            // 
            this.lblPatologiasPresentadas.AutoSize = true;
            this.lblPatologiasPresentadas.Location = new System.Drawing.Point(322, 200);
            this.lblPatologiasPresentadas.Name = "lblPatologiasPresentadas";
            this.lblPatologiasPresentadas.Size = new System.Drawing.Size(113, 13);
            this.lblPatologiasPresentadas.TabIndex = 3;
            this.lblPatologiasPresentadas.Text = "Patología Presentada:";
            // 
            // cboPatologiaPresentada
            // 
            this.cboPatologiaPresentada.FormattingEnabled = true;
            this.cboPatologiaPresentada.Items.AddRange(new object[] {
            "Angustia",
            "Ansiedad",
            "Baja autoestima",
            "Depresión",
            "Estrés",
            "Lumbalgia",
            "Migraña"});
            this.cboPatologiaPresentada.Location = new System.Drawing.Point(451, 197);
            this.cboPatologiaPresentada.Name = "cboPatologiaPresentada";
            this.cboPatologiaPresentada.Size = new System.Drawing.Size(121, 21);
            this.cboPatologiaPresentada.TabIndex = 4;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.cboGenero.Location = new System.Drawing.Point(451, 33);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(322, 36);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Género:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(322, 63);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            // 
            // cboEdad
            // 
            this.cboEdad.FormattingEnabled = true;
            this.cboEdad.Location = new System.Drawing.Point(451, 60);
            this.cboEdad.Name = "cboEdad";
            this.cboEdad.Size = new System.Drawing.Size(121, 21);
            this.cboEdad.TabIndex = 8;
            // 
            // lblDeporte1
            // 
            this.lblDeporte1.AutoSize = true;
            this.lblDeporte1.Location = new System.Drawing.Point(322, 87);
            this.lblDeporte1.Name = "lblDeporte1";
            this.lblDeporte1.Size = new System.Drawing.Size(100, 13);
            this.lblDeporte1.TabIndex = 9;
            this.lblDeporte1.Text = "Actividad Deportiva";
            // 
            // cboDeporte
            // 
            this.cboDeporte.FormattingEnabled = true;
            this.cboDeporte.Location = new System.Drawing.Point(451, 87);
            this.cboDeporte.Name = "cboDeporte";
            this.cboDeporte.Size = new System.Drawing.Size(121, 21);
            this.cboDeporte.TabIndex = 10;
            // 
            // lblFuma
            // 
            this.lblFuma.AutoSize = true;
            this.lblFuma.Location = new System.Drawing.Point(322, 122);
            this.lblFuma.Name = "lblFuma";
            this.lblFuma.Size = new System.Drawing.Size(45, 13);
            this.lblFuma.TabIndex = 11;
            this.lblFuma.Text = "¿Fuma?";
            // 
            // cboFuma
            // 
            this.cboFuma.FormattingEnabled = true;
            this.cboFuma.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cboFuma.Location = new System.Drawing.Point(451, 114);
            this.cboFuma.Name = "cboFuma";
            this.cboFuma.Size = new System.Drawing.Size(121, 21);
            this.cboFuma.TabIndex = 12;
            // 
            // lblDeporte2
            // 
            this.lblDeporte2.AutoSize = true;
            this.lblDeporte2.Location = new System.Drawing.Point(322, 100);
            this.lblDeporte2.Name = "lblDeporte2";
            this.lblDeporte2.Size = new System.Drawing.Size(92, 13);
            this.lblDeporte2.TabIndex = 13;
            this.lblDeporte2.Text = "(días por semana)";
            // 
            // cboTiempoParaSi
            // 
            this.cboTiempoParaSi.FormattingEnabled = true;
            this.cboTiempoParaSi.Location = new System.Drawing.Point(451, 141);
            this.cboTiempoParaSi.Name = "cboTiempoParaSi";
            this.cboTiempoParaSi.Size = new System.Drawing.Size(121, 21);
            this.cboTiempoParaSi.TabIndex = 14;
            // 
            // lblTiempoParaSi2
            // 
            this.lblTiempoParaSi2.AutoSize = true;
            this.lblTiempoParaSi2.Location = new System.Drawing.Point(322, 154);
            this.lblTiempoParaSi2.Name = "lblTiempoParaSi2";
            this.lblTiempoParaSi2.Size = new System.Drawing.Size(92, 13);
            this.lblTiempoParaSi2.TabIndex = 16;
            this.lblTiempoParaSi2.Text = "(horas semanales)";
            // 
            // lblTiempoParaSi1
            // 
            this.lblTiempoParaSi1.AutoSize = true;
            this.lblTiempoParaSi1.Location = new System.Drawing.Point(322, 141);
            this.lblTiempoParaSi1.Name = "lblTiempoParaSi1";
            this.lblTiempoParaSi1.Size = new System.Drawing.Size(123, 13);
            this.lblTiempoParaSi1.TabIndex = 15;
            this.lblTiempoParaSi1.Text = "Tiempo para distenderse";
            // 
            // rtbxEvaluaciones
            // 
            this.rtbxEvaluaciones.Location = new System.Drawing.Point(13, 33);
            this.rtbxEvaluaciones.Name = "rtbxEvaluaciones";
            this.rtbxEvaluaciones.Size = new System.Drawing.Size(303, 287);
            this.rtbxEvaluaciones.TabIndex = 17;
            this.rtbxEvaluaciones.Text = "";
            // 
            // lblEvaluaciones
            // 
            this.lblEvaluaciones.AutoSize = true;
            this.lblEvaluaciones.Location = new System.Drawing.Point(13, 8);
            this.lblEvaluaciones.Name = "lblEvaluaciones";
            this.lblEvaluaciones.Size = new System.Drawing.Size(74, 13);
            this.lblEvaluaciones.TabIndex = 18;
            this.lblEvaluaciones.Text = "Evaluaciones:";
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblEvaluaciones);
            this.Controls.Add(this.rtbxEvaluaciones);
            this.Controls.Add(this.lblTiempoParaSi2);
            this.Controls.Add(this.lblTiempoParaSi1);
            this.Controls.Add(this.cboTiempoParaSi);
            this.Controls.Add(this.lblDeporte2);
            this.Controls.Add(this.cboFuma);
            this.Controls.Add(this.lblFuma);
            this.Controls.Add(this.cboDeporte);
            this.Controls.Add(this.lblDeporte1);
            this.Controls.Add(this.cboEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboPatologiaPresentada);
            this.Controls.Add(this.lblPatologiasPresentadas);
            this.Controls.Add(this.lblDatosPaciente);
            this.Controls.Add(this.btn_ConsultarTratamiento);
            this.Controls.Add(this.btn_SimularEvaluaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SimularEvaluaciones;
        private System.Windows.Forms.Button btn_ConsultarTratamiento;
        private System.Windows.Forms.Label lblDatosPaciente;
        private System.Windows.Forms.Label lblPatologiasPresentadas;
        private System.Windows.Forms.ComboBox cboPatologiaPresentada;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.ComboBox cboEdad;
        private System.Windows.Forms.Label lblDeporte1;
        private System.Windows.Forms.ComboBox cboDeporte;
        private System.Windows.Forms.Label lblFuma;
        private System.Windows.Forms.ComboBox cboFuma;
        private System.Windows.Forms.Label lblDeporte2;
        private System.Windows.Forms.ComboBox cboTiempoParaSi;
        private System.Windows.Forms.Label lblTiempoParaSi2;
        private System.Windows.Forms.Label lblTiempoParaSi1;
        private System.Windows.Forms.RichTextBox rtbxEvaluaciones;
        private System.Windows.Forms.Label lblEvaluaciones;
    }
}
namespace SistemaEscuela
{
    partial class frmAsistencia
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.cboEstudiante = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chkPresente = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(165, 45);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso:";
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Location = new System.Drawing.Point(165, 90);
            this.lblSeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(49, 13);
            this.lblSeccion.TabIndex = 2;
            this.lblSeccion.Text = "Seccion:";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(165, 136);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(60, 13);
            this.lblEstudiante.TabIndex = 3;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(165, 190);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(251, 42);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(100, 21);
            this.cboCurso.TabIndex = 5;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // cboSeccion
            // 
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Location = new System.Drawing.Point(251, 87);
            this.cboSeccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(92, 21);
            this.cboSeccion.TabIndex = 6;
            this.cboSeccion.SelectedIndexChanged += new System.EventHandler(this.cboSeccion_SelectedIndexChanged);
            // 
            // cboEstudiante
            // 
            this.cboEstudiante.FormattingEnabled = true;
            this.cboEstudiante.Location = new System.Drawing.Point(251, 133);
            this.cboEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstudiante.Name = "cboEstudiante";
            this.cboEstudiante.Size = new System.Drawing.Size(92, 21);
            this.cboEstudiante.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(251, 184);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(151, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // chkPresente
            // 
            this.chkPresente.AutoSize = true;
            this.chkPresente.Location = new System.Drawing.Point(202, 239);
            this.chkPresente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPresente.Name = "chkPresente";
            this.chkPresente.Size = new System.Drawing.Size(68, 17);
            this.chkPresente.TabIndex = 9;
            this.chkPresente.Text = "Presente";
            this.chkPresente.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(314, 239);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(56, 19);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkPresente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboEstudiante);
            this.Controls.Add(this.cboSeccion);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.lblCurso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAsistencia";
            this.Text = "frmAsistencia";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.ComboBox cboEstudiante;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chkPresente;
        private System.Windows.Forms.Button btnRegistrar;
    }
}
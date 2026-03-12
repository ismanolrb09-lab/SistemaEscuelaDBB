namespace SistemaEscuela
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Asistencia Escolar";
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Location = new System.Drawing.Point(289, 112);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(163, 23);
            this.btnEstudiantes.TabIndex = 1;
            this.btnEstudiantes.Text = "Gestionar Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(289, 153);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(163, 23);
            this.btnAsistencia.TabIndex = 2;
            this.btnAsistencia.Text = "Registrar Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(289, 194);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(164, 23);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Ver Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(328, 235);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(767, 347);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnEstudiantes);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
    }
}
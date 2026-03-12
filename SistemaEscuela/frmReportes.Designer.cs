namespace SistemaEscuela
{
    partial class frmReportes
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
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnAlertas = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(40, 102);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(2);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(180, 19);
            this.btnRanking.TabIndex = 0;
            this.btnRanking.Text = "Ranking Inasistencias";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnAlertas
            // 
            this.btnAlertas.Location = new System.Drawing.Point(62, 135);
            this.btnAlertas.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(131, 19);
            this.btnAlertas.TabIndex = 1;
            this.btnAlertas.Text = "Alertas menor 80%";
            this.btnAlertas.UseVisualStyleBackColor = true;
            this.btnAlertas.Click += new System.EventHandler(this.btnAlertas_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(37, 257);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 2;
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(260, 24);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 24;
            this.dgvReporte.Size = new System.Drawing.Size(332, 319);
            this.dgvReporte.TabIndex = 3;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAlertas);
            this.Controls.Add(this.btnRanking);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnAlertas;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvReporte;
    }
}
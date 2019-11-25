namespace ISO25010_Evaluador
{
    partial class Recuperacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSubCaracteristica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCaracteristica = new System.Windows.Forms.ComboBox();
            this.dgvChingueAsuMadreElAmerica = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChingueAsuMadreElAmerica)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SubCaracteristica";
            // 
            // cbxSubCaracteristica
            // 
            this.cbxSubCaracteristica.FormattingEnabled = true;
            this.cbxSubCaracteristica.Location = new System.Drawing.Point(25, 91);
            this.cbxSubCaracteristica.Name = "cbxSubCaracteristica";
            this.cbxSubCaracteristica.Size = new System.Drawing.Size(223, 21);
            this.cbxSubCaracteristica.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caracteristicas";
            // 
            // cbxCaracteristica
            // 
            this.cbxCaracteristica.FormattingEnabled = true;
            this.cbxCaracteristica.Location = new System.Drawing.Point(25, 40);
            this.cbxCaracteristica.Name = "cbxCaracteristica";
            this.cbxCaracteristica.Size = new System.Drawing.Size(223, 21);
            this.cbxCaracteristica.TabIndex = 4;
            // 
            // dgvChingueAsuMadreElAmerica
            // 
            this.dgvChingueAsuMadreElAmerica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChingueAsuMadreElAmerica.Location = new System.Drawing.Point(25, 155);
            this.dgvChingueAsuMadreElAmerica.Name = "dgvChingueAsuMadreElAmerica";
            this.dgvChingueAsuMadreElAmerica.Size = new System.Drawing.Size(966, 374);
            this.dgvChingueAsuMadreElAmerica.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(916, 89);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Recuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 607);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvChingueAsuMadreElAmerica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSubCaracteristica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCaracteristica);
            this.Name = "Recuperacion";
            this.Text = "Recuperacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChingueAsuMadreElAmerica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSubCaracteristica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCaracteristica;
        private System.Windows.Forms.DataGridView dgvChingueAsuMadreElAmerica;
        private System.Windows.Forms.Button btnGuardar;
    }
}
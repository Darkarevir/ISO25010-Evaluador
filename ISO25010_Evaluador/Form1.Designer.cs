﻿namespace ISO25010_Evaluador
{
    partial class Evaluador
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
            this.cbxCaracteristica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSubCaracteristica = new System.Windows.Forms.ComboBox();
            this.dgvHu = new System.Windows.Forms.DataGridView();
            this.subCaracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumple = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCumple = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.valorHU = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCaracteristica
            // 
            this.cbxCaracteristica.FormattingEnabled = true;
            this.cbxCaracteristica.Location = new System.Drawing.Point(81, 43);
            this.cbxCaracteristica.Name = "cbxCaracteristica";
            this.cbxCaracteristica.Size = new System.Drawing.Size(223, 21);
            this.cbxCaracteristica.TabIndex = 0;
            this.cbxCaracteristica.TextChanged += new System.EventHandler(this.CbxCaracteristica_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caracteristicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SubCaracteristica";
            // 
            // cbxSubCaracteristica
            // 
            this.cbxSubCaracteristica.FormattingEnabled = true;
            this.cbxSubCaracteristica.Location = new System.Drawing.Point(81, 94);
            this.cbxSubCaracteristica.Name = "cbxSubCaracteristica";
            this.cbxSubCaracteristica.Size = new System.Drawing.Size(223, 21);
            this.cbxSubCaracteristica.TabIndex = 2;
            this.cbxSubCaracteristica.TextChanged += new System.EventHandler(this.CbxSubCaracteristica_TextChanged);
            // 
            // dgvHu
            // 
            this.dgvHu.AllowUserToAddRows = false;
            this.dgvHu.AllowUserToDeleteRows = false;
            this.dgvHu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subCaracteristica,
            this.huName,
            this.cumple,
            this.valor});
            this.dgvHu.Location = new System.Drawing.Point(81, 182);
            this.dgvHu.Name = "dgvHu";
            this.dgvHu.Size = new System.Drawing.Size(645, 212);
            this.dgvHu.TabIndex = 4;
            // 
            // subCaracteristica
            // 
            this.subCaracteristica.HeaderText = "SUBCARACTERISTICA";
            this.subCaracteristica.MinimumWidth = 150;
            this.subCaracteristica.Name = "subCaracteristica";
            this.subCaracteristica.Width = 150;
            // 
            // huName
            // 
            this.huName.HeaderText = "NOMBRE HU";
            this.huName.MinimumWidth = 150;
            this.huName.Name = "huName";
            this.huName.Width = 150;
            // 
            // cumple
            // 
            this.cumple.HeaderText = "CUMPLE";
            this.cumple.MinimumWidth = 150;
            this.cumple.Name = "cumple";
            this.cumple.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cumple.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cumple.Width = 150;
            // 
            // valor
            // 
            this.valor.HeaderText = "VALOR";
            this.valor.MinimumWidth = 150;
            this.valor.Name = "valor";
            this.valor.Width = 150;
            // 
            // txtHU
            // 
            this.txtHU.Location = new System.Drawing.Point(113, 142);
            this.txtHU.Name = "txtHU";
            this.txtHU.Size = new System.Drawing.Size(161, 20);
            this.txtHU.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "HU:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(280, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(361, 142);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 8;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // tbnOk
            // 
            this.tbnOk.Location = new System.Drawing.Point(442, 142);
            this.tbnOk.Name = "tbnOk";
            this.tbnOk.Size = new System.Drawing.Size(75, 23);
            this.tbnOk.TabIndex = 9;
            this.tbnOk.Text = "Guardar";
            this.tbnOk.UseVisualStyleBackColor = true;
            this.tbnOk.Click += new System.EventHandler(this.TbnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // cbCumple
            // 
            this.cbCumple.AutoSize = true;
            this.cbCumple.Location = new System.Drawing.Point(523, 148);
            this.cbCumple.Name = "cbCumple";
            this.cbCumple.Size = new System.Drawing.Size(80, 17);
            this.cbCumple.TabIndex = 12;
            this.cbCumple.Text = "checkBox1";
            this.cbCumple.UseVisualStyleBackColor = true;
            this.cbCumple.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // valorHU
            // 
            this.valorHU.AutoSize = true;
            this.valorHU.Location = new System.Drawing.Point(609, 148);
            this.valorHU.Name = "valorHU";
            this.valorHU.Size = new System.Drawing.Size(50, 13);
            this.valorHU.TabIndex = 16;
            this.valorHU.Text = "Valor HU";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(602, 102);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 17;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.BtnEvaluar_Click);
            // 
            // Evaluador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.valorHU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCumple);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbnOk);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHU);
            this.Controls.Add(this.dgvHu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSubCaracteristica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCaracteristica);
            this.Name = "Evaluador";
            this.Text = "Evaluador ISO25010";
            this.Load += new System.EventHandler(this.Evaluador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCaracteristica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSubCaracteristica;
        private System.Windows.Forms.DataGridView dgvHu;
        private System.Windows.Forms.TextBox txtHU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button tbnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCaracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn huName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cumple;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.CheckBox cbCumple;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label valorHU;
        private System.Windows.Forms.Button btnEvaluar;
    }
}


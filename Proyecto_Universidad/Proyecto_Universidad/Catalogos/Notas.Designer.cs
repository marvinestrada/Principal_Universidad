namespace Proyecto_Universidad.Catalogos
{
    partial class Notas
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
            this.dataNota = new System.Windows.Forms.DataGridView();
            this.Id_nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_estud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promovido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboxCarrera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboxCiclo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboxCatedra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModN = new System.Windows.Forms.Button();
            this.btnalirN = new System.Windows.Forms.Button();
            this.btnRefreshN = new System.Windows.Forms.Button();
            this.btnaceptarN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNota)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNota
            // 
            this.dataNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_nota,
            this.Cod_estud,
            this.Estudiante,
            this.Zona,
            this.Parcial,
            this.Final,
            this.Total,
            this.Promovido});
            this.dataNota.Location = new System.Drawing.Point(12, 119);
            this.dataNota.Name = "dataNota";
            this.dataNota.Size = new System.Drawing.Size(788, 234);
            this.dataNota.TabIndex = 0;
            // 
            // Id_nota
            // 
            this.Id_nota.DataPropertyName = "Id_nota";
            this.Id_nota.HeaderText = "Id_nota";
            this.Id_nota.Name = "Id_nota";
            this.Id_nota.Visible = false;
            // 
            // Cod_estud
            // 
            this.Cod_estud.DataPropertyName = "Id_matricula";
            this.Cod_estud.HeaderText = "Matricula";
            this.Cod_estud.Name = "Cod_estud";
            this.Cod_estud.Width = 60;
            // 
            // Estudiante
            // 
            this.Estudiante.DataPropertyName = "Estudiante";
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Width = 200;
            // 
            // Zona
            // 
            this.Zona.DataPropertyName = "Zona";
            this.Zona.HeaderText = "Zona";
            this.Zona.Name = "Zona";
            // 
            // Parcial
            // 
            this.Parcial.DataPropertyName = "Parcial";
            this.Parcial.HeaderText = "Parcial";
            this.Parcial.Name = "Parcial";
            // 
            // Final
            // 
            this.Final.DataPropertyName = "Final";
            this.Final.HeaderText = "Final";
            this.Final.Name = "Final";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Promovido
            // 
            this.Promovido.DataPropertyName = "Promovido";
            this.Promovido.HeaderText = "Promovido";
            this.Promovido.Name = "Promovido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboxCarrera);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboxCiclo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboxCatedra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboxCarrera
            // 
            this.comboxCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboxCarrera.FormattingEnabled = true;
            this.comboxCarrera.Location = new System.Drawing.Point(98, 19);
            this.comboxCarrera.Name = "comboxCarrera";
            this.comboxCarrera.Size = new System.Drawing.Size(210, 28);
            this.comboxCarrera.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Carrera:";
            // 
            // comboxCiclo
            // 
            this.comboxCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboxCiclo.FormattingEnabled = true;
            this.comboxCiclo.Location = new System.Drawing.Point(412, 19);
            this.comboxCiclo.Name = "comboxCiclo";
            this.comboxCiclo.Size = new System.Drawing.Size(361, 28);
            this.comboxCiclo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(359, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciclo:";
            // 
            // comboxCatedra
            // 
            this.comboxCatedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboxCatedra.FormattingEnabled = true;
            this.comboxCatedra.Location = new System.Drawing.Point(98, 62);
            this.comboxCatedra.Name = "comboxCatedra";
            this.comboxCatedra.Size = new System.Drawing.Size(210, 28);
            this.comboxCatedra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catedra:";
            // 
            // btnModN
            // 
            this.btnModN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModN.Location = new System.Drawing.Point(603, 359);
            this.btnModN.Name = "btnModN";
            this.btnModN.Size = new System.Drawing.Size(97, 35);
            this.btnModN.TabIndex = 2;
            this.btnModN.Text = "Modificar";
            this.btnModN.UseVisualStyleBackColor = true;
            // 
            // btnalirN
            // 
            this.btnalirN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnalirN.Location = new System.Drawing.Point(706, 359);
            this.btnalirN.Name = "btnalirN";
            this.btnalirN.Size = new System.Drawing.Size(97, 35);
            this.btnalirN.TabIndex = 3;
            this.btnalirN.Text = "Salir";
            this.btnalirN.UseVisualStyleBackColor = true;
            // 
            // btnRefreshN
            // 
            this.btnRefreshN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefreshN.Location = new System.Drawing.Point(500, 359);
            this.btnRefreshN.Name = "btnRefreshN";
            this.btnRefreshN.Size = new System.Drawing.Size(97, 35);
            this.btnRefreshN.TabIndex = 4;
            this.btnRefreshN.Text = "Refrescar";
            this.btnRefreshN.UseVisualStyleBackColor = true;
            // 
            // btnaceptarN
            // 
            this.btnaceptarN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnaceptarN.Location = new System.Drawing.Point(397, 359);
            this.btnaceptarN.Name = "btnaceptarN";
            this.btnaceptarN.Size = new System.Drawing.Size(97, 35);
            this.btnaceptarN.TabIndex = 5;
            this.btnaceptarN.Text = "Aceptar";
            this.btnaceptarN.UseVisualStyleBackColor = true;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 402);
            this.Controls.Add(this.btnaceptarN);
            this.Controls.Add(this.btnRefreshN);
            this.Controls.Add(this.btnalirN);
            this.Controls.Add(this.btnModN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataNota);
            this.Name = "Notas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNota)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboxCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboxCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboxCatedra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModN;
        private System.Windows.Forms.Button btnalirN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_estud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promovido;
        private System.Windows.Forms.Button btnRefreshN;
        private System.Windows.Forms.Button btnaceptarN;
    }
}
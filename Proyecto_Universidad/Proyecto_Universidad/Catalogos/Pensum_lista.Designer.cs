namespace Proyecto_Universidad.Catalogos
{
    partial class Pensum_lista
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
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_actualizar = new System.Windows.Forms.Button();
            this.boton_refrescar = new System.Windows.Forms.Button();
            this.boton_crear = new System.Windows.Forms.Button();
            this.datos_carrera = new System.Windows.Forms.DataGridView();
            this.Id_carrera_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_catedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datos_carrera)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_eliminar.Location = new System.Drawing.Point(454, 312);
            this.boton_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(121, 41);
            this.boton_eliminar.TabIndex = 9;
            this.boton_eliminar.Text = "ELIMINAR";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            // 
            // boton_actualizar
            // 
            this.boton_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_actualizar.Location = new System.Drawing.Point(304, 312);
            this.boton_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.boton_actualizar.Name = "boton_actualizar";
            this.boton_actualizar.Size = new System.Drawing.Size(121, 41);
            this.boton_actualizar.TabIndex = 8;
            this.boton_actualizar.Text = "ACTUALIZAR";
            this.boton_actualizar.UseVisualStyleBackColor = true;
            // 
            // boton_refrescar
            // 
            this.boton_refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_refrescar.Location = new System.Drawing.Point(158, 312);
            this.boton_refrescar.Margin = new System.Windows.Forms.Padding(2);
            this.boton_refrescar.Name = "boton_refrescar";
            this.boton_refrescar.Size = new System.Drawing.Size(121, 41);
            this.boton_refrescar.TabIndex = 7;
            this.boton_refrescar.Text = "REFRESCAR";
            this.boton_refrescar.UseVisualStyleBackColor = true;
            // 
            // boton_crear
            // 
            this.boton_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_crear.Location = new System.Drawing.Point(9, 312);
            this.boton_crear.Margin = new System.Windows.Forms.Padding(2);
            this.boton_crear.Name = "boton_crear";
            this.boton_crear.Size = new System.Drawing.Size(121, 41);
            this.boton_crear.TabIndex = 6;
            this.boton_crear.Text = "CREAR";
            this.boton_crear.UseVisualStyleBackColor = true;
            // 
            // datos_carrera
            // 
            this.datos_carrera.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datos_carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_carrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_carrera_cat,
            this.Ciclo,
            this.Codigo_carrera,
            this.Carrera,
            this.Codigo_catedra,
            this.Catedra});
            this.datos_carrera.Location = new System.Drawing.Point(9, 11);
            this.datos_carrera.Margin = new System.Windows.Forms.Padding(2);
            this.datos_carrera.Name = "datos_carrera";
            this.datos_carrera.RowHeadersWidth = 51;
            this.datos_carrera.RowTemplate.Height = 24;
            this.datos_carrera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_carrera.Size = new System.Drawing.Size(566, 271);
            this.datos_carrera.TabIndex = 5;
            // 
            // Id_carrera_cat
            // 
            this.Id_carrera_cat.DataPropertyName = "Id_carrera_cat";
            this.Id_carrera_cat.HeaderText = "Id";
            this.Id_carrera_cat.Name = "Id_carrera_cat";
            this.Id_carrera_cat.Width = 40;
            // 
            // Ciclo
            // 
            this.Ciclo.DataPropertyName = "Ciclo";
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.Name = "Ciclo";
            // 
            // Codigo_carrera
            // 
            this.Codigo_carrera.DataPropertyName = "Id_carrera";
            this.Codigo_carrera.HeaderText = "Codigo Carrera";
            this.Codigo_carrera.Name = "Codigo_carrera";
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "Carrera";
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            // 
            // Codigo_catedra
            // 
            this.Codigo_catedra.DataPropertyName = "Id_catedra";
            this.Codigo_catedra.HeaderText = "Codigo Catedra";
            this.Codigo_catedra.Name = "Codigo_catedra";
            // 
            // Catedra
            // 
            this.Catedra.DataPropertyName = "Catedra";
            this.Catedra.HeaderText = "Caterdra";
            this.Catedra.Name = "Catedra";
            // 
            // Pensum_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_actualizar);
            this.Controls.Add(this.boton_refrescar);
            this.Controls.Add(this.boton_crear);
            this.Controls.Add(this.datos_carrera);
            this.Name = "Pensum_lista";
            this.Text = "Pensum Listado";
            ((System.ComponentModel.ISupportInitialize)(this.datos_carrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Button boton_actualizar;
        private System.Windows.Forms.Button boton_refrescar;
        private System.Windows.Forms.Button boton_crear;
        private System.Windows.Forms.DataGridView datos_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_carrera_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_catedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catedra;
    }
}
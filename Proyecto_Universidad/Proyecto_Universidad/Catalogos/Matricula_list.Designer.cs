namespace Proyecto_Universidad.Catalogos
{
    partial class Matricula_list
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
            this.bot_eliminar = new System.Windows.Forms.Button();
            this.bot_actualizar = new System.Windows.Forms.Button();
            this.boton_refrescar = new System.Windows.Forms.Button();
            this.bot_crear = new System.Windows.Forms.Button();
            this.grid_datos = new System.Windows.Forms.DataGridView();
            this.Id_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Establecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // bot_eliminar
            // 
            this.bot_eliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_eliminar.Location = new System.Drawing.Point(528, 358);
            this.bot_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bot_eliminar.Name = "bot_eliminar";
            this.bot_eliminar.Size = new System.Drawing.Size(141, 47);
            this.bot_eliminar.TabIndex = 14;
            this.bot_eliminar.Text = "ELIMINAR";
            this.bot_eliminar.UseVisualStyleBackColor = true;
            this.bot_eliminar.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // bot_actualizar
            // 
            this.bot_actualizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_actualizar.Location = new System.Drawing.Point(357, 358);
            this.bot_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.bot_actualizar.Name = "bot_actualizar";
            this.bot_actualizar.Size = new System.Drawing.Size(141, 47);
            this.bot_actualizar.TabIndex = 13;
            this.bot_actualizar.Text = "ACTUALIZAR";
            this.bot_actualizar.UseVisualStyleBackColor = true;
            this.bot_actualizar.Click += new System.EventHandler(this.bot_actualizar_Click);
            // 
            // boton_refrescar
            // 
            this.boton_refrescar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_refrescar.Location = new System.Drawing.Point(188, 359);
            this.boton_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_refrescar.Name = "boton_refrescar";
            this.boton_refrescar.Size = new System.Drawing.Size(141, 47);
            this.boton_refrescar.TabIndex = 12;
            this.boton_refrescar.Text = "REFRESH";
            this.boton_refrescar.UseVisualStyleBackColor = true;
            this.boton_refrescar.Click += new System.EventHandler(this.bot_refrescar_Click);
            // 
            // bot_crear
            // 
            this.bot_crear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_crear.Location = new System.Drawing.Point(18, 359);
            this.bot_crear.Margin = new System.Windows.Forms.Padding(4);
            this.bot_crear.Name = "bot_crear";
            this.bot_crear.Size = new System.Drawing.Size(141, 47);
            this.bot_crear.TabIndex = 11;
            this.bot_crear.Text = "CREAR";
            this.bot_crear.UseVisualStyleBackColor = true;
            this.bot_crear.Click += new System.EventHandler(this.bot_crear_Click);
            // 
            // grid_datos
            // 
            this.grid_datos.AllowUserToAddRows = false;
            this.grid_datos.AllowUserToDeleteRows = false;
            this.grid_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Matricula,
            this.Id_estudiante,
            this.Establecimiento,
            this.Id_tipo,
            this.Id_ciclo,
            this.Fecha_matricula});
            this.grid_datos.Location = new System.Drawing.Point(18, 18);
            this.grid_datos.Margin = new System.Windows.Forms.Padding(4);
            this.grid_datos.Name = "grid_datos";
            this.grid_datos.ReadOnly = true;
            this.grid_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_datos.Size = new System.Drawing.Size(651, 334);
            this.grid_datos.TabIndex = 10;
            this.grid_datos.DoubleClick += new System.EventHandler(this.grid__DoubleClick);
            // 
            // Id_Matricula
            // 
            this.Id_Matricula.DataPropertyName = "Id_matricula";
            this.Id_Matricula.HeaderText = "Cod. Matricula";
            this.Id_Matricula.Name = "Id_Matricula";
            this.Id_Matricula.ReadOnly = true;
            this.Id_Matricula.Width = 150;
            // 
            // Id_estudiante
            // 
            this.Id_estudiante.DataPropertyName = "Id_estudiante";
            this.Id_estudiante.HeaderText = "Cod. Estudiante";
            this.Id_estudiante.Name = "Id_estudiante";
            this.Id_estudiante.ReadOnly = true;
            this.Id_estudiante.Width = 200;
            // 
            // Establecimiento
            // 
            this.Establecimiento.DataPropertyName = "Id_establecimiento";
            this.Establecimiento.HeaderText = "Cod. Establecimiento";
            this.Establecimiento.Name = "Establecimiento";
            this.Establecimiento.ReadOnly = true;
            // 
            // Id_tipo
            // 
            this.Id_tipo.DataPropertyName = "Id_tipo";
            this.Id_tipo.HeaderText = "Cod. Tipo";
            this.Id_tipo.Name = "Id_tipo";
            this.Id_tipo.ReadOnly = true;
            // 
            // Id_ciclo
            // 
            this.Id_ciclo.DataPropertyName = "Id_ciclo";
            this.Id_ciclo.HeaderText = "Cod. Ciclo";
            this.Id_ciclo.Name = "Id_ciclo";
            this.Id_ciclo.ReadOnly = true;
            // 
            // Fecha_matricula
            // 
            this.Fecha_matricula.DataPropertyName = "Fecha_matricula";
            this.Fecha_matricula.HeaderText = "Fecha";
            this.Fecha_matricula.Name = "Fecha_matricula";
            this.Fecha_matricula.ReadOnly = true;
            // 
            // Matricula_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.bot_eliminar);
            this.Controls.Add(this.bot_actualizar);
            this.Controls.Add(this.boton_refrescar);
            this.Controls.Add(this.bot_crear);
            this.Controls.Add(this.grid_datos);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Matricula_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula_list";
            this.Load += new System.EventHandler(this.Matricula_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bot_eliminar;
        private System.Windows.Forms.Button bot_actualizar;
        private System.Windows.Forms.Button boton_refrescar;
        private System.Windows.Forms.Button bot_crear;
        private System.Windows.Forms.DataGridView grid_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Establecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_matricula;
    }
}
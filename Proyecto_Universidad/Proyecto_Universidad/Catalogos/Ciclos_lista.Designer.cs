namespace Proyecto_Universidad
{
    partial class Ciclos_lista
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
            this.bot_eliminar = new System.Windows.Forms.Button();
            this.bot_actualizar = new System.Windows.Forms.Button();
            this.boton_refrescar = new System.Windows.Forms.Button();
            this.bot_crear = new System.Windows.Forms.Button();
            this.grid_datos = new System.Windows.Forms.DataGridView();
            this.Id_ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // bot_eliminar
            // 
            this.bot_eliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_eliminar.Location = new System.Drawing.Point(525, 356);
            this.bot_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bot_eliminar.Name = "bot_eliminar";
            this.bot_eliminar.Size = new System.Drawing.Size(141, 47);
            this.bot_eliminar.TabIndex = 9;
            this.bot_eliminar.Text = "ELIMINAR";
            this.bot_eliminar.UseVisualStyleBackColor = true;
            this.bot_eliminar.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // bot_actualizar
            // 
            this.bot_actualizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_actualizar.Location = new System.Drawing.Point(354, 356);
            this.bot_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.bot_actualizar.Name = "bot_actualizar";
            this.bot_actualizar.Size = new System.Drawing.Size(141, 47);
            this.bot_actualizar.TabIndex = 8;
            this.bot_actualizar.Text = "ACTUALIZAR";
            this.bot_actualizar.UseVisualStyleBackColor = true;
            this.bot_actualizar.Click += new System.EventHandler(this.bot_actualizar_Click);
            // 
            // boton_refrescar
            // 
            this.boton_refrescar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_refrescar.Location = new System.Drawing.Point(185, 357);
            this.boton_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_refrescar.Name = "boton_refrescar";
            this.boton_refrescar.Size = new System.Drawing.Size(141, 47);
            this.boton_refrescar.TabIndex = 7;
            this.boton_refrescar.Text = "REFRESH";
            this.boton_refrescar.UseVisualStyleBackColor = true;
            this.boton_refrescar.Click += new System.EventHandler(this.bot_refrescar_Click);
            // 
            // bot_crear
            // 
            this.bot_crear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_crear.Location = new System.Drawing.Point(15, 357);
            this.bot_crear.Margin = new System.Windows.Forms.Padding(4);
            this.bot_crear.Name = "bot_crear";
            this.bot_crear.Size = new System.Drawing.Size(141, 47);
            this.bot_crear.TabIndex = 6;
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
            this.Id_ciclo,
            this.Ciclo,
            this.Año});
            this.grid_datos.Location = new System.Drawing.Point(15, 16);
            this.grid_datos.Margin = new System.Windows.Forms.Padding(4);
            this.grid_datos.Name = "grid_datos";
            this.grid_datos.ReadOnly = true;
            this.grid_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_datos.Size = new System.Drawing.Size(651, 334);
            this.grid_datos.TabIndex = 5;
            // 
            // Id_ciclo
            // 
            this.Id_ciclo.DataPropertyName = "Id_ciclo";
            this.Id_ciclo.HeaderText = "Cod Ciclo";
            this.Id_ciclo.Name = "Id_ciclo";
            this.Id_ciclo.ReadOnly = true;
            this.Id_ciclo.Width = 150;
            // 
            // Ciclo
            // 
            this.Ciclo.DataPropertyName = "Ciclo";
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.ReadOnly = true;
            this.Ciclo.Width = 200;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "Año";
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Ciclos_lista
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
            this.MaximizeBox = false;
            this.Name = "Ciclos_lista";
            this.Padding = new System.Windows.Forms.Padding(11);
            this.Text = "Lista de Ciclos";
            this.Load += new System.EventHandler(this.Ciclos_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bot_eliminar;
        private System.Windows.Forms.Button bot_actualizar;
        private System.Windows.Forms.Button boton_refrescar;
        private System.Windows.Forms.Button bot_crear;
        private System.Windows.Forms.DataGridView grid_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
    }
}


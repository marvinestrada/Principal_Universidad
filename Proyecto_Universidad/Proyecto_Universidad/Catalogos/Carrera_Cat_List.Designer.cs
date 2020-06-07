namespace Proyecto_Universidad.Catalogos
{
    partial class Carrera_Cat_List
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
            this.boton_crear = new System.Windows.Forms.Button();
            this.boton_refrescar = new System.Windows.Forms.Button();
            this.boton_actualizar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.grid_datos = new System.Windows.Forms.DataGridView();
            this.Id_Carrerra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Catedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_crear
            // 
            this.boton_crear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_crear.Location = new System.Drawing.Point(13, 365);
            this.boton_crear.Margin = new System.Windows.Forms.Padding(4);
            this.boton_crear.Name = "boton_crear";
            this.boton_crear.Size = new System.Drawing.Size(141, 47);
            this.boton_crear.TabIndex = 12;
            this.boton_crear.Text = "CREAR";
            this.boton_crear.UseVisualStyleBackColor = true;
            this.boton_crear.Click += new System.EventHandler(this.boton_crear_Click);
            // 
            // boton_refrescar
            // 
            this.boton_refrescar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_refrescar.Location = new System.Drawing.Point(184, 365);
            this.boton_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_refrescar.Name = "boton_refrescar";
            this.boton_refrescar.Size = new System.Drawing.Size(141, 47);
            this.boton_refrescar.TabIndex = 13;
            this.boton_refrescar.Text = "REFRESH";
            this.boton_refrescar.UseVisualStyleBackColor = true;
            // 
            // boton_actualizar
            // 
            this.boton_actualizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_actualizar.Location = new System.Drawing.Point(356, 365);
            this.boton_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_actualizar.Name = "boton_actualizar";
            this.boton_actualizar.Size = new System.Drawing.Size(141, 47);
            this.boton_actualizar.TabIndex = 14;
            this.boton_actualizar.Text = "ACTUALIZAR";
            this.boton_actualizar.UseVisualStyleBackColor = true;
            this.boton_actualizar.Click += new System.EventHandler(this.boton_actualizar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_eliminar.Location = new System.Drawing.Point(522, 365);
            this.boton_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(141, 47);
            this.boton_eliminar.TabIndex = 15;
            this.boton_eliminar.Text = "ELIMINAR";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // grid_datos
            // 
            this.grid_datos.AllowUserToAddRows = false;
            this.grid_datos.AllowUserToDeleteRows = false;
            this.grid_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Carrerra,
            this.Carrera,
            this.Id_Catedra,
            this.Catedra,
            this.Id_Profesor,
            this.Profesor});
            this.grid_datos.Location = new System.Drawing.Point(12, 12);
            this.grid_datos.Name = "grid_datos";
            this.grid_datos.ReadOnly = true;
            this.grid_datos.RowHeadersWidth = 51;
            this.grid_datos.RowTemplate.Height = 24;
            this.grid_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_datos.Size = new System.Drawing.Size(651, 336);
            this.grid_datos.TabIndex = 16;
            this.grid_datos.DoubleClick += new System.EventHandler(this.grid_datos_DoubleClick);
            // 
            // Id_Carrerra
            // 
            this.Id_Carrerra.HeaderText = "Id";
            this.Id_Carrerra.MinimumWidth = 6;
            this.Id_Carrerra.Name = "Id_Carrerra";
            this.Id_Carrerra.ReadOnly = true;
            this.Id_Carrerra.Width = 50;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 125;
            // 
            // Id_Catedra
            // 
            this.Id_Catedra.HeaderText = "Id";
            this.Id_Catedra.MinimumWidth = 6;
            this.Id_Catedra.Name = "Id_Catedra";
            this.Id_Catedra.ReadOnly = true;
            this.Id_Catedra.Width = 50;
            // 
            // Catedra
            // 
            this.Catedra.HeaderText = "Catedra";
            this.Catedra.MinimumWidth = 6;
            this.Catedra.Name = "Catedra";
            this.Catedra.ReadOnly = true;
            this.Catedra.Width = 125;
            // 
            // Id_Profesor
            // 
            this.Id_Profesor.HeaderText = "Id";
            this.Id_Profesor.MinimumWidth = 6;
            this.Id_Profesor.Name = "Id_Profesor";
            this.Id_Profesor.ReadOnly = true;
            this.Id_Profesor.Width = 50;
            // 
            // Profesor
            // 
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.MinimumWidth = 6;
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            this.Profesor.Width = 125;
            // 
            // Carrera_Cat_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 442);
            this.Controls.Add(this.grid_datos);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_actualizar);
            this.Controls.Add(this.boton_refrescar);
            this.Controls.Add(this.boton_crear);
            this.Name = "Carrera_Cat_List";
            this.Text = "Carrera_Cat_List";
            this.Load += new System.EventHandler(this.Carrera_Cat_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_crear;
        private System.Windows.Forms.Button boton_refrescar;
        private System.Windows.Forms.Button boton_actualizar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.DataGridView grid_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Carrerra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Catedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
    }
}
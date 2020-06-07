namespace Proyecto_Universidad.Catalogos
{
    partial class Carrera_lista
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
            this.datos_carrera = new System.Windows.Forms.DataGridView();
            this.Id_Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton_crear = new System.Windows.Forms.Button();
            this.boton_refrescar = new System.Windows.Forms.Button();
            this.boton_actualizar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datos_carrera)).BeginInit();
            this.SuspendLayout();
            // 
            // datos_carrera
            // 
            this.datos_carrera.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datos_carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_carrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Carrera,
            this.Carrera});
            this.datos_carrera.Location = new System.Drawing.Point(12, 12);
            this.datos_carrera.Name = "datos_carrera";
            this.datos_carrera.RowHeadersWidth = 51;
            this.datos_carrera.RowTemplate.Height = 24;
            this.datos_carrera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_carrera.Size = new System.Drawing.Size(755, 334);
            this.datos_carrera.TabIndex = 0;
            this.datos_carrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_carrera_CellContentClick);
            // 
            // Id_Carrera
            // 
            this.Id_Carrera.HeaderText = "Id_Carrerra";
            this.Id_Carrera.MinimumWidth = 6;
            this.Id_Carrera.Name = "Id_Carrera";
            this.Id_Carrera.ReadOnly = true;
            this.Id_Carrera.Width = 90;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 200;
            // 
            // boton_crear
            // 
            this.boton_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_crear.Location = new System.Drawing.Point(12, 384);
            this.boton_crear.Name = "boton_crear";
            this.boton_crear.Size = new System.Drawing.Size(161, 50);
            this.boton_crear.TabIndex = 1;
            this.boton_crear.Text = "CREAR";
            this.boton_crear.UseVisualStyleBackColor = true;
            this.boton_crear.Click += new System.EventHandler(this.boton_crear_Click);
            // 
            // boton_refrescar
            // 
            this.boton_refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_refrescar.Location = new System.Drawing.Point(197, 384);
            this.boton_refrescar.Name = "boton_refrescar";
            this.boton_refrescar.Size = new System.Drawing.Size(188, 50);
            this.boton_refrescar.TabIndex = 2;
            this.boton_refrescar.Text = "REFRESCAR";
            this.boton_refrescar.UseVisualStyleBackColor = true;
            this.boton_refrescar.Click += new System.EventHandler(this.boton_refrescar_Click);
            // 
            // boton_actualizar
            // 
            this.boton_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_actualizar.Location = new System.Drawing.Point(405, 384);
            this.boton_actualizar.Name = "boton_actualizar";
            this.boton_actualizar.Size = new System.Drawing.Size(161, 50);
            this.boton_actualizar.TabIndex = 3;
            this.boton_actualizar.Text = "ACTUALIZAR";
            this.boton_actualizar.UseVisualStyleBackColor = true;
            this.boton_actualizar.Click += new System.EventHandler(this.boton_actualizar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_eliminar.Location = new System.Drawing.Point(606, 384);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(161, 50);
            this.boton_eliminar.TabIndex = 4;
            this.boton_eliminar.Text = "ELIMINAR";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // Carrera_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 446);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_actualizar);
            this.Controls.Add(this.boton_refrescar);
            this.Controls.Add(this.boton_crear);
            this.Controls.Add(this.datos_carrera);
            this.Name = "Carrera_lista";
            this.Text = "Lista de Carreras";
            this.Load += new System.EventHandler(this.Carrera_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos_carrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datos_carrera;
        private System.Windows.Forms.Button boton_crear;
        private System.Windows.Forms.Button boton_refrescar;
        private System.Windows.Forms.Button boton_actualizar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
    }
}
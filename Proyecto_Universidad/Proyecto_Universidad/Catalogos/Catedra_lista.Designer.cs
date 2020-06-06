namespace Proyecto_Universidad.Catalogos
{
    partial class Catedra_lista
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
            this.button_crear = new System.Windows.Forms.Button();
            this.button_refrescar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.datos_catedra = new System.Windows.Forms.DataGridView();
            this.id_catedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datos_catedra)).BeginInit();
            this.SuspendLayout();
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(12, 384);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(161, 50);
            this.button_crear.TabIndex = 0;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // button_refrescar
            // 
            this.button_refrescar.Location = new System.Drawing.Point(215, 384);
            this.button_refrescar.Name = "button_refrescar";
            this.button_refrescar.Size = new System.Drawing.Size(161, 50);
            this.button_refrescar.TabIndex = 1;
            this.button_refrescar.Text = "Refrescar";
            this.button_refrescar.UseVisualStyleBackColor = true;
            this.button_refrescar.Click += new System.EventHandler(this.button_refrescar_Click);
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(411, 384);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(161, 50);
            this.button_actualizar.TabIndex = 2;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(606, 384);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(161, 50);
            this.button_eliminar.TabIndex = 3;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // datos_catedra
            // 
            this.datos_catedra.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datos_catedra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_catedra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_catedra,
            this.Catedra});
            this.datos_catedra.Location = new System.Drawing.Point(12, 12);
            this.datos_catedra.Name = "datos_catedra";
            this.datos_catedra.RowHeadersWidth = 51;
            this.datos_catedra.RowTemplate.Height = 24;
            this.datos_catedra.Size = new System.Drawing.Size(755, 334);
            this.datos_catedra.TabIndex = 4;
            this.datos_catedra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_catedra_CellContentClick);
            this.datos_catedra.DoubleClick += new System.EventHandler(this.datos_catedra_DoubleClick);
            // 
            // id_catedra
            // 
            this.id_catedra.HeaderText = "Id_Catedra";
            this.id_catedra.MinimumWidth = 6;
            this.id_catedra.Name = "id_catedra";
            this.id_catedra.Width = 125;
            // 
            // Catedra
            // 
            this.Catedra.HeaderText = "Catedra";
            this.Catedra.MinimumWidth = 6;
            this.Catedra.Name = "Catedra";
            this.Catedra.Width = 125;
            // 
            // Catedra_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 446);
            this.Controls.Add(this.datos_catedra);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_refrescar);
            this.Controls.Add(this.button_crear);
            this.Name = "Catedra_lista";
            this.Text = "Catedra_lista";
            this.Load += new System.EventHandler(this.Catedra_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos_catedra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button button_refrescar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView datos_catedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_catedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catedra;
    }
}
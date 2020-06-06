namespace Proyecto_Universidad.Catalogos
{
    partial class Tipo_lista
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
            this.btnEliminarTip = new System.Windows.Forms.Button();
            this.btnActualizarTip = new System.Windows.Forms.Button();
            this.btnRefrescarTip = new System.Windows.Forms.Button();
            this.btnCrearTip = new System.Windows.Forms.Button();
            this.grid_datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarTip
            // 
            this.btnEliminarTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminarTip.Location = new System.Drawing.Point(601, 380);
            this.btnEliminarTip.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTip.Name = "btnEliminarTip";
            this.btnEliminarTip.Size = new System.Drawing.Size(161, 50);
            this.btnEliminarTip.TabIndex = 19;
            this.btnEliminarTip.Text = "ELIMINAR";
            this.btnEliminarTip.UseVisualStyleBackColor = true;
            this.btnEliminarTip.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // btnActualizarTip
            // 
            this.btnActualizarTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizarTip.Location = new System.Drawing.Point(407, 380);
            this.btnActualizarTip.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarTip.Name = "btnActualizarTip";
            this.btnActualizarTip.Size = new System.Drawing.Size(161, 50);
            this.btnActualizarTip.TabIndex = 18;
            this.btnActualizarTip.Text = "ACTUALIZAR";
            this.btnActualizarTip.UseVisualStyleBackColor = true;
            this.btnActualizarTip.Click += new System.EventHandler(this.bot_actualizar_Click);
            // 
            // btnRefrescarTip
            // 
            this.btnRefrescarTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefrescarTip.Location = new System.Drawing.Point(215, 380);
            this.btnRefrescarTip.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefrescarTip.Name = "btnRefrescarTip";
            this.btnRefrescarTip.Size = new System.Drawing.Size(161, 50);
            this.btnRefrescarTip.TabIndex = 17;
            this.btnRefrescarTip.Text = "REFRESH";
            this.btnRefrescarTip.UseVisualStyleBackColor = true;
            this.btnRefrescarTip.Click += new System.EventHandler(this.bot_refrescar_Click);
            // 
            // btnCrearTip
            // 
            this.btnCrearTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCrearTip.Location = new System.Drawing.Point(19, 380);
            this.btnCrearTip.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearTip.Name = "btnCrearTip";
            this.btnCrearTip.Size = new System.Drawing.Size(161, 50);
            this.btnCrearTip.TabIndex = 16;
            this.btnCrearTip.Text = "CREAR";
            this.btnCrearTip.UseVisualStyleBackColor = true;
            this.btnCrearTip.Click += new System.EventHandler(this.bot_crear_Click);
            // 
            // grid_datos
            // 
            this.grid_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_datos.Location = new System.Drawing.Point(17, 15);
            this.grid_datos.Margin = new System.Windows.Forms.Padding(4);
            this.grid_datos.Name = "grid_datos";
            this.grid_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_datos.Size = new System.Drawing.Size(744, 356);
            this.grid_datos.TabIndex = 15;
            this.grid_datos.DoubleClick += new System.EventHandler(this.grid_datos_DoubleClick);
            // 
            // Tipo_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 446);
            this.Controls.Add(this.btnEliminarTip);
            this.Controls.Add(this.btnActualizarTip);
            this.Controls.Add(this.btnRefrescarTip);
            this.Controls.Add(this.btnCrearTip);
            this.Controls.Add(this.grid_datos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tipo_lista";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo_lista";
            this.Load += new System.EventHandler(this.Tipo_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarTip;
        private System.Windows.Forms.Button btnActualizarTip;
        private System.Windows.Forms.Button btnRefrescarTip;
        private System.Windows.Forms.Button btnCrearTip;
        private System.Windows.Forms.DataGridView grid_datos;
    }
}
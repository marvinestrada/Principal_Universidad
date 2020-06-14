namespace Proyecto_Universidad.Catalogos
{
    partial class Horarios_lista
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
            this.btnEliminarH = new System.Windows.Forms.Button();
            this.btnActualizarH = new System.Windows.Forms.Button();
            this.btnRefrescarH = new System.Windows.Forms.Button();
            this.btnCrearH = new System.Windows.Forms.Button();
            this.data_horario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_horario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarH
            // 
            this.btnEliminarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminarH.Location = new System.Drawing.Point(450, 308);
            this.btnEliminarH.Name = "btnEliminarH";
            this.btnEliminarH.Size = new System.Drawing.Size(121, 41);
            this.btnEliminarH.TabIndex = 15;
            this.btnEliminarH.Text = "ELIMINAR";
            this.btnEliminarH.UseVisualStyleBackColor = true;
            // 
            // btnActualizarH
            // 
            this.btnActualizarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizarH.Location = new System.Drawing.Point(304, 308);
            this.btnActualizarH.Name = "btnActualizarH";
            this.btnActualizarH.Size = new System.Drawing.Size(121, 41);
            this.btnActualizarH.TabIndex = 14;
            this.btnActualizarH.Text = "ACTUALIZAR";
            this.btnActualizarH.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarH
            // 
            this.btnRefrescarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefrescarH.Location = new System.Drawing.Point(160, 308);
            this.btnRefrescarH.Name = "btnRefrescarH";
            this.btnRefrescarH.Size = new System.Drawing.Size(121, 41);
            this.btnRefrescarH.TabIndex = 13;
            this.btnRefrescarH.Text = "REFRESH";
            this.btnRefrescarH.UseVisualStyleBackColor = true;
            // 
            // btnCrearH
            // 
            this.btnCrearH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCrearH.Location = new System.Drawing.Point(13, 308);
            this.btnCrearH.Name = "btnCrearH";
            this.btnCrearH.Size = new System.Drawing.Size(121, 41);
            this.btnCrearH.TabIndex = 12;
            this.btnCrearH.Text = "CREAR";
            this.btnCrearH.UseVisualStyleBackColor = true;
            // 
            // data_horario
            // 
            this.data_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_horario.Location = new System.Drawing.Point(13, 13);
            this.data_horario.Name = "data_horario";
            this.data_horario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_horario.Size = new System.Drawing.Size(558, 289);
            this.data_horario.TabIndex = 11;
            // 
            // Horarios_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnEliminarH);
            this.Controls.Add(this.btnActualizarH);
            this.Controls.Add(this.btnRefrescarH);
            this.Controls.Add(this.btnCrearH);
            this.Controls.Add(this.data_horario);
            this.Name = "Horarios_lista";
            this.Text = "Horarios_lista";
            ((System.ComponentModel.ISupportInitialize)(this.data_horario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarH;
        private System.Windows.Forms.Button btnActualizarH;
        private System.Windows.Forms.Button btnRefrescarH;
        private System.Windows.Forms.Button btnCrearH;
        public System.Windows.Forms.DataGridView data_horario;
    }
}
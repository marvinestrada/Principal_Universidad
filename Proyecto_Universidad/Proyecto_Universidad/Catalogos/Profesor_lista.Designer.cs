namespace Proyecto_Universidad.Catalogos
{
    partial class Profesor_lista
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
            this.data_ListPro = new System.Windows.Forms.DataGridView();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.btnActualizarPro = new System.Windows.Forms.Button();
            this.btnRefrescarPro = new System.Windows.Forms.Button();
            this.btnCrearPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_ListPro)).BeginInit();
            this.SuspendLayout();
            // 
            // data_ListPro
            // 
            this.data_ListPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ListPro.Location = new System.Drawing.Point(12, 12);
            this.data_ListPro.Name = "data_ListPro";
            this.data_ListPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_ListPro.Size = new System.Drawing.Size(558, 289);
            this.data_ListPro.TabIndex = 7;
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminarPro.Location = new System.Drawing.Point(450, 309);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(121, 41);
            this.btnEliminarPro.TabIndex = 14;
            this.btnEliminarPro.Text = "ELIMINAR";
            this.btnEliminarPro.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPro
            // 
            this.btnActualizarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizarPro.Location = new System.Drawing.Point(304, 309);
            this.btnActualizarPro.Name = "btnActualizarPro";
            this.btnActualizarPro.Size = new System.Drawing.Size(121, 41);
            this.btnActualizarPro.TabIndex = 13;
            this.btnActualizarPro.Text = "ACTUALIZAR";
            this.btnActualizarPro.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarPro
            // 
            this.btnRefrescarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefrescarPro.Location = new System.Drawing.Point(160, 309);
            this.btnRefrescarPro.Name = "btnRefrescarPro";
            this.btnRefrescarPro.Size = new System.Drawing.Size(121, 41);
            this.btnRefrescarPro.TabIndex = 12;
            this.btnRefrescarPro.Text = "REFRESH";
            this.btnRefrescarPro.UseVisualStyleBackColor = true;
            // 
            // btnCrearPro
            // 
            this.btnCrearPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCrearPro.Location = new System.Drawing.Point(13, 309);
            this.btnCrearPro.Name = "btnCrearPro";
            this.btnCrearPro.Size = new System.Drawing.Size(121, 41);
            this.btnCrearPro.TabIndex = 11;
            this.btnCrearPro.Text = "CREAR";
            this.btnCrearPro.UseVisualStyleBackColor = true;
            // 
            // Profesor_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnEliminarPro);
            this.Controls.Add(this.btnActualizarPro);
            this.Controls.Add(this.btnRefrescarPro);
            this.Controls.Add(this.btnCrearPro);
            this.Controls.Add(this.data_ListPro);
            this.MaximizeBox = false;
            this.Name = "Profesor_lista";
            this.Text = "Profesor_lista";
            ((System.ComponentModel.ISupportInitialize)(this.data_ListPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_ListPro;
        private System.Windows.Forms.Button btnEliminarPro;
        private System.Windows.Forms.Button btnActualizarPro;
        private System.Windows.Forms.Button btnRefrescarPro;
        private System.Windows.Forms.Button btnCrearPro;
    }
}
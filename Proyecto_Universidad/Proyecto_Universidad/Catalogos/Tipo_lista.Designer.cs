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
            this.data_LisTip = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_LisTip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarTip
            // 
            this.btnEliminarTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminarTip.Location = new System.Drawing.Point(451, 309);
            this.btnEliminarTip.Name = "btnEliminarTip";
            this.btnEliminarTip.Size = new System.Drawing.Size(121, 41);
            this.btnEliminarTip.TabIndex = 19;
            this.btnEliminarTip.Text = "ELIMINAR";
            this.btnEliminarTip.UseVisualStyleBackColor = true;
            // 
            // btnActualizarTip
            // 
            this.btnActualizarTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizarTip.Location = new System.Drawing.Point(305, 309);
            this.btnActualizarTip.Name = "btnActualizarTip";
            this.btnActualizarTip.Size = new System.Drawing.Size(121, 41);
            this.btnActualizarTip.TabIndex = 18;
            this.btnActualizarTip.Text = "ACTUALIZAR";
            this.btnActualizarTip.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarTip
            // 
            this.btnRefrescarTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefrescarTip.Location = new System.Drawing.Point(161, 309);
            this.btnRefrescarTip.Name = "btnRefrescarTip";
            this.btnRefrescarTip.Size = new System.Drawing.Size(121, 41);
            this.btnRefrescarTip.TabIndex = 17;
            this.btnRefrescarTip.Text = "REFRESH";
            this.btnRefrescarTip.UseVisualStyleBackColor = true;
            // 
            // btnCrearTip
            // 
            this.btnCrearTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCrearTip.Location = new System.Drawing.Point(14, 309);
            this.btnCrearTip.Name = "btnCrearTip";
            this.btnCrearTip.Size = new System.Drawing.Size(121, 41);
            this.btnCrearTip.TabIndex = 16;
            this.btnCrearTip.Text = "CREAR";
            this.btnCrearTip.UseVisualStyleBackColor = true;
            // 
            // data_LisTip
            // 
            this.data_LisTip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_LisTip.Location = new System.Drawing.Point(13, 12);
            this.data_LisTip.Name = "data_LisTip";
            this.data_LisTip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_LisTip.Size = new System.Drawing.Size(558, 289);
            this.data_LisTip.TabIndex = 15;
            // 
            // Tipo_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnEliminarTip);
            this.Controls.Add(this.btnActualizarTip);
            this.Controls.Add(this.btnRefrescarTip);
            this.Controls.Add(this.btnCrearTip);
            this.Controls.Add(this.data_LisTip);
            this.Name = "Tipo_lista";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Tipo_lista";
            ((System.ComponentModel.ISupportInitialize)(this.data_LisTip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarTip;
        private System.Windows.Forms.Button btnActualizarTip;
        private System.Windows.Forms.Button btnRefrescarTip;
        private System.Windows.Forms.Button btnCrearTip;
        private System.Windows.Forms.DataGridView data_LisTip;
    }
}
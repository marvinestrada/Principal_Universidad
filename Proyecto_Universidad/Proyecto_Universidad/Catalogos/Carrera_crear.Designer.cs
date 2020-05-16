namespace Proyecto_Universidad.Catalogos
{
    partial class Carrera_crear
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.label_carrera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cerrar.Location = new System.Drawing.Point(445, 598);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(161, 50);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.Text = "CANCELAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_aceptar.Location = new System.Drawing.Point(276, 598);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(161, 50);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txtcarrera
            // 
            this.txtcarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcarrera.Location = new System.Drawing.Point(101, 22);
            this.txtcarrera.Margin = new System.Windows.Forms.Padding(4);
            this.txtcarrera.Multiline = true;
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(505, 32);
            this.txtcarrera.TabIndex = 12;
            // 
            // label_carrera
            // 
            this.label_carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_carrera.Location = new System.Drawing.Point(13, 22);
            this.label_carrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_carrera.Name = "label_carrera";
            this.label_carrera.Size = new System.Drawing.Size(91, 32);
            this.label_carrera.TabIndex = 11;
            this.label_carrera.Text = "Carrera:";
            // 
            // Carrera_crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 661);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.label_carrera);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "Carrera_crear";
            this.Text = "Carrera_crear";
            this.Load += new System.EventHandler(this.Carrera_crear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.Label label_carrera;
    }
}
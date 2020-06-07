namespace Proyecto_Universidad.Catalogos
{
    partial class Carrera_Cat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_carrera = new System.Windows.Forms.TextBox();
            this.text_catedra = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.buscar_estud = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_prof = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Carrera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_Catedras:";
            // 
            // text_carrera
            // 
            this.text_carrera.Location = new System.Drawing.Point(142, 40);
            this.text_carrera.Multiline = true;
            this.text_carrera.Name = "text_carrera";
            this.text_carrera.Size = new System.Drawing.Size(408, 30);
            this.text_carrera.TabIndex = 2;
            this.text_carrera.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_catedra
            // 
            this.text_catedra.Location = new System.Drawing.Point(142, 91);
            this.text_catedra.Multiline = true;
            this.text_catedra.Name = "text_catedra";
            this.text_catedra.Size = new System.Drawing.Size(408, 30);
            this.text_catedra.TabIndex = 3;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(276, 598);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(161, 50);
            this.btn_aceptar.TabIndex = 18;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(445, 598);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(161, 50);
            this.btn_cerrar.TabIndex = 19;
            this.btn_cerrar.Text = "CANCELAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // buscar_estud
            // 
            this.buscar_estud.Location = new System.Drawing.Point(556, 40);
            this.buscar_estud.Name = "buscar_estud";
            this.buscar_estud.Size = new System.Drawing.Size(34, 31);
            this.buscar_estud.TabIndex = 30;
            this.buscar_estud.Text = ">>";
            this.buscar_estud.UseVisualStyleBackColor = true;
            this.buscar_estud.Click += new System.EventHandler(this.buscar_estud_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id_Profesor:";
            // 
            // text_prof
            // 
            this.text_prof.Location = new System.Drawing.Point(142, 142);
            this.text_prof.Multiline = true;
            this.text_prof.Name = "text_prof";
            this.text_prof.Size = new System.Drawing.Size(408, 30);
            this.text_prof.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 31);
            this.button2.TabIndex = 34;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Carrera_Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_prof);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscar_estud);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.text_catedra);
            this.Controls.Add(this.text_carrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Carrera_Cat";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_carrera;
        private System.Windows.Forms.TextBox text_catedra;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button buscar_estud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_prof;
        private System.Windows.Forms.Button button2;
    }
}
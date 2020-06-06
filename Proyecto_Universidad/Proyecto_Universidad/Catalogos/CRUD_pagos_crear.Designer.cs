namespace Proyecto_Universidad.Catalogos
{
    partial class CRUD_pagos_crear
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtcobro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar_cobros = new System.Windows.Forms.Button();
            this.fechaPago = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha:";
            // 
            // txtcobro
            // 
            this.txtcobro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcobro.Location = new System.Drawing.Point(142, 15);
            this.txtcobro.Margin = new System.Windows.Forms.Padding(4);
            this.txtcobro.Name = "txtcobro";
            this.txtcobro.Size = new System.Drawing.Size(412, 31);
            this.txtcobro.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cod Cobro:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(435, 594);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(161, 50);
            this.btn_cerrar.TabIndex = 18;
            this.btn_cerrar.Text = "CANCELAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(266, 594);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(161, 50);
            this.btn_aceptar.TabIndex = 17;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(142, 94);
            this.txtAbono.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(453, 31);
            this.txtAbono.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Abono:";
            // 
            // buscar_cobros
            // 
            this.buscar_cobros.Location = new System.Drawing.Point(561, 15);
            this.buscar_cobros.Name = "buscar_cobros";
            this.buscar_cobros.Size = new System.Drawing.Size(34, 31);
            this.buscar_cobros.TabIndex = 30;
            this.buscar_cobros.Text = ">>";
            this.buscar_cobros.UseVisualStyleBackColor = true;
            this.buscar_cobros.Click += new System.EventHandler(this.buscar_cobros_Click);
            // 
            // fechaPago
            // 
            this.fechaPago.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPago.Location = new System.Drawing.Point(142, 56);
            this.fechaPago.Name = "fechaPago";
            this.fechaPago.Size = new System.Drawing.Size(453, 31);
            this.fechaPago.TabIndex = 35;
            // 
            // CRUD_pagos_crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 661);
            this.Controls.Add(this.fechaPago);
            this.Controls.Add(this.buscar_cobros);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcobro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_aceptar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD_pagos_crear";
            this.Text = "CRUD_pagos_crear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcobro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscar_cobros;
        private System.Windows.Forms.DateTimePicker fechaPago;
    }
}
﻿namespace Proyecto_Universidad
{
    partial class Establecimiento_lista
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
            this.grid_datos = new System.Windows.Forms.DataGridView();
            this.Id_establecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.establecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bot_eliminar = new System.Windows.Forms.Button();
            this.bot_actualizar = new System.Windows.Forms.Button();
            this.boton_refrescar = new System.Windows.Forms.Button();
            this.bot_crear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_datos
            // 
            this.grid_datos.AllowUserToAddRows = false;
            this.grid_datos.AllowUserToDeleteRows = false;
            this.grid_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_establecimiento,
            this.establecimiento,
            this.Id_municipio});
            this.grid_datos.Location = new System.Drawing.Point(16, 14);
            this.grid_datos.Name = "grid_datos";
            this.grid_datos.ReadOnly = true;
            this.grid_datos.RowTemplate.Height = 24;
            this.grid_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_datos.Size = new System.Drawing.Size(651, 336);
            this.grid_datos.TabIndex = 20;
            // 
            // Id_establecimiento
            // 
            this.Id_establecimiento.DataPropertyName = "Id_establecimiento";
            this.Id_establecimiento.HeaderText = "Cod Establecimiento";
            this.Id_establecimiento.Name = "Id_establecimiento";
            this.Id_establecimiento.ReadOnly = true;
            this.Id_establecimiento.Width = 188;
            // 
            // establecimiento
            // 
            this.establecimiento.DataPropertyName = "Establecimiento";
            this.establecimiento.HeaderText = "Establecimiento";
            this.establecimiento.Name = "establecimiento";
            this.establecimiento.ReadOnly = true;
            this.establecimiento.Width = 275;
            // 
            // Id_municipio
            // 
            this.Id_municipio.DataPropertyName = "Id_municipio";
            this.Id_municipio.HeaderText = "Cod Municipio";
            this.Id_municipio.Name = "Id_municipio";
            this.Id_municipio.ReadOnly = true;
            this.Id_municipio.Width = 145;
            // 
            // bot_eliminar
            // 
            this.bot_eliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_eliminar.Location = new System.Drawing.Point(526, 357);
            this.bot_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bot_eliminar.Name = "bot_eliminar";
            this.bot_eliminar.Size = new System.Drawing.Size(141, 47);
            this.bot_eliminar.TabIndex = 19;
            this.bot_eliminar.Text = "ELIMINAR";
            this.bot_eliminar.UseVisualStyleBackColor = true;
            this.bot_eliminar.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // bot_actualizar
            // 
            this.bot_actualizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_actualizar.Location = new System.Drawing.Point(355, 357);
            this.bot_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.bot_actualizar.Name = "bot_actualizar";
            this.bot_actualizar.Size = new System.Drawing.Size(141, 47);
            this.bot_actualizar.TabIndex = 18;
            this.bot_actualizar.Text = "ACTUALIZAR";
            this.bot_actualizar.UseVisualStyleBackColor = true;
            this.bot_actualizar.Click += new System.EventHandler(this.bot_actualizar_Click);
            // 
            // boton_refrescar
            // 
            this.boton_refrescar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_refrescar.Location = new System.Drawing.Point(186, 358);
            this.boton_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_refrescar.Name = "boton_refrescar";
            this.boton_refrescar.Size = new System.Drawing.Size(141, 47);
            this.boton_refrescar.TabIndex = 17;
            this.boton_refrescar.Text = "REFRESH";
            this.boton_refrescar.UseVisualStyleBackColor = true;
            this.boton_refrescar.Click += new System.EventHandler(this.bot_refrescar_Click);
            // 
            // bot_crear
            // 
            this.bot_crear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_crear.Location = new System.Drawing.Point(16, 358);
            this.bot_crear.Margin = new System.Windows.Forms.Padding(4);
            this.bot_crear.Name = "bot_crear";
            this.bot_crear.Size = new System.Drawing.Size(141, 47);
            this.bot_crear.TabIndex = 16;
            this.bot_crear.Text = "CREAR";
            this.bot_crear.UseVisualStyleBackColor = true;
            this.bot_crear.Click += new System.EventHandler(this.bot_crear_Click);
            // 
            // Establecimiento_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.grid_datos);
            this.Controls.Add(this.bot_eliminar);
            this.Controls.Add(this.bot_actualizar);
            this.Controls.Add(this.boton_refrescar);
            this.Controls.Add(this.bot_crear);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Establecimiento_lista";
            this.Padding = new System.Windows.Forms.Padding(11);
            this.Text = "Establecimiento";
            this.Load += new System.EventHandler(this.Establecimiento_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_datos;
        private System.Windows.Forms.Button bot_eliminar;
        private System.Windows.Forms.Button bot_actualizar;
        private System.Windows.Forms.Button boton_refrescar;
        private System.Windows.Forms.Button bot_crear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_establecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn establecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_municipio;
    }
}
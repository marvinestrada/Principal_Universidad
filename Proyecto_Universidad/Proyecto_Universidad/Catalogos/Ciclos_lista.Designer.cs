﻿namespace Proyecto_Universidad
{
    partial class Ciclos_lista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bot_eliminar = new System.Windows.Forms.Button();
            this.bot_actualizar = new System.Windows.Forms.Button();
            this.boton_refrescar = new System.Windows.Forms.Button();
            this.bot_crear = new System.Windows.Forms.Button();
            this.grid_datos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // bot_eliminar
            // 
            this.bot_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(172)))));
            this.bot_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.bot_eliminar.FlatAppearance.BorderSize = 20;
            this.bot_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bot_eliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_eliminar.ForeColor = System.Drawing.Color.White;
            this.bot_eliminar.Location = new System.Drawing.Point(293, 373);
            this.bot_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bot_eliminar.Name = "bot_eliminar";
            this.bot_eliminar.Size = new System.Drawing.Size(131, 30);
            this.bot_eliminar.TabIndex = 9;
            this.bot_eliminar.Text = "Eliminar";
            this.bot_eliminar.UseVisualStyleBackColor = false;
            this.bot_eliminar.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // bot_actualizar
            // 
            this.bot_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(172)))));
            this.bot_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.bot_actualizar.FlatAppearance.BorderSize = 20;
            this.bot_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bot_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_actualizar.ForeColor = System.Drawing.Color.White;
            this.bot_actualizar.Location = new System.Drawing.Point(154, 373);
            this.bot_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.bot_actualizar.Name = "bot_actualizar";
            this.bot_actualizar.Size = new System.Drawing.Size(131, 30);
            this.bot_actualizar.TabIndex = 8;
            this.bot_actualizar.Text = "Actualizar";
            this.bot_actualizar.UseVisualStyleBackColor = false;
            this.bot_actualizar.Click += new System.EventHandler(this.bot_actualizar_Click);
            // 
            // boton_refrescar
            // 
            this.boton_refrescar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_refrescar.ForeColor = System.Drawing.Color.White;
            this.boton_refrescar.Location = new System.Drawing.Point(545, 373);
            this.boton_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_refrescar.Name = "boton_refrescar";
            this.boton_refrescar.Size = new System.Drawing.Size(122, 30);
            this.boton_refrescar.TabIndex = 7;
            this.boton_refrescar.Text = "REFRESH";
            this.boton_refrescar.UseVisualStyleBackColor = true;
            this.boton_refrescar.Visible = false;
            this.boton_refrescar.Click += new System.EventHandler(this.bot_refrescar_Click);
            // 
            // bot_crear
            // 
            this.bot_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(172)))));
            this.bot_crear.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.bot_crear.FlatAppearance.BorderSize = 20;
            this.bot_crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bot_crear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_crear.ForeColor = System.Drawing.Color.White;
            this.bot_crear.Location = new System.Drawing.Point(15, 373);
            this.bot_crear.Margin = new System.Windows.Forms.Padding(4);
            this.bot_crear.Name = "bot_crear";
            this.bot_crear.Size = new System.Drawing.Size(131, 30);
            this.bot_crear.TabIndex = 6;
            this.bot_crear.Text = "Crear";
            this.bot_crear.UseVisualStyleBackColor = false;
            this.bot_crear.Click += new System.EventHandler(this.bot_crear_Click);
            // 
            // grid_datos
            // 
            this.grid_datos.AllowUserToAddRows = false;
            this.grid_datos.AllowUserToDeleteRows = false;
            this.grid_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.grid_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_datos.ColumnHeadersHeight = 28;
            this.grid_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ciclo,
            this.Ciclo,
            this.Año});
            this.grid_datos.EnableHeadersVisualStyles = false;
            this.grid_datos.GridColor = System.Drawing.Color.SteelBlue;
            this.grid_datos.Location = new System.Drawing.Point(16, 36);
            this.grid_datos.Margin = new System.Windows.Forms.Padding(4);
            this.grid_datos.Name = "grid_datos";
            this.grid_datos.ReadOnly = true;
            this.grid_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.grid_datos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_datos.Size = new System.Drawing.Size(651, 329);
            this.grid_datos.TabIndex = 5;
            this.grid_datos.DoubleClick += new System.EventHandler(this.grid_datos_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(172)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 20;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(545, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de Ciclos";
            // 
            // Id_ciclo
            // 
            this.Id_ciclo.DataPropertyName = "Id_ciclo";
            this.Id_ciclo.HeaderText = "Cod Ciclo";
            this.Id_ciclo.Name = "Id_ciclo";
            this.Id_ciclo.ReadOnly = true;
            this.Id_ciclo.Width = 150;
            // 
            // Ciclo
            // 
            this.Ciclo.DataPropertyName = "Ciclo";
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.ReadOnly = true;
            this.Ciclo.Width = 210;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "Año";
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 250;
            // 
            // Ciclos_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bot_eliminar);
            this.Controls.Add(this.bot_actualizar);
            this.Controls.Add(this.boton_refrescar);
            this.Controls.Add(this.bot_crear);
            this.Controls.Add(this.grid_datos);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Ciclos_lista";
            this.Padding = new System.Windows.Forms.Padding(11);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Ciclos";
            this.Load += new System.EventHandler(this.Ciclos_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bot_eliminar;
        private System.Windows.Forms.Button bot_actualizar;
        private System.Windows.Forms.Button boton_refrescar;
        private System.Windows.Forms.Button bot_crear;
        private System.Windows.Forms.DataGridView grid_datos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
    }
}


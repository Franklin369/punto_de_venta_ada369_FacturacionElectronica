﻿
namespace Ada369Csharp.Presentacion.SunatForms
{
    partial class AgregarNotacredito
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgcomprobantes = new System.Windows.Forms.DataGridView();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgcomprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txttipo
            // 
            this.txttipo.BackColor = System.Drawing.Color.White;
            this.txttipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.FormattingEnabled = true;
            this.txttipo.Location = new System.Drawing.Point(161, 59);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(428, 28);
            this.txttipo.TabIndex = 644;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 643;
            this.label3.Text = "Tipo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnconfirmar.BackgroundImage = global::Ada369Csharp.Properties.Resources.azul;
            this.btnconfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconfirmar.FlatAppearance.BorderSize = 0;
            this.btnconfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnconfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.ForeColor = System.Drawing.Color.White;
            this.btnconfirmar.Location = new System.Drawing.Point(161, 170);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(127, 55);
            this.btnconfirmar.TabIndex = 640;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 641;
            this.label1.Text = "Motivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 642;
            this.label2.Text = "Factura a anular:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgcomprobantes
            // 
            this.dgcomprobantes.AllowUserToAddRows = false;
            this.dgcomprobantes.AllowUserToDeleteRows = false;
            this.dgcomprobantes.AllowUserToResizeRows = false;
            this.dgcomprobantes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgcomprobantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgcomprobantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgcomprobantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgcomprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcomprobantes.ColumnHeadersVisible = false;
            this.dgcomprobantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgcomprobantes.EnableHeadersVisualStyles = false;
            this.dgcomprobantes.Location = new System.Drawing.Point(541, 126);
            this.dgcomprobantes.MultiSelect = false;
            this.dgcomprobantes.Name = "dgcomprobantes";
            this.dgcomprobantes.ReadOnly = true;
            this.dgcomprobantes.RowHeadersVisible = false;
            this.dgcomprobantes.RowHeadersWidth = 9;
            this.dgcomprobantes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgcomprobantes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgcomprobantes.RowTemplate.Height = 40;
            this.dgcomprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcomprobantes.Size = new System.Drawing.Size(124, 40);
            this.dgcomprobantes.TabIndex = 638;
            this.dgcomprobantes.Visible = false;
            this.dgcomprobantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // txtmotivo
            // 
            this.txtmotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txtmotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmotivo.ForeColor = System.Drawing.Color.White;
            this.txtmotivo.Location = new System.Drawing.Point(161, 98);
            this.txtmotivo.Multiline = true;
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(310, 49);
            this.txtmotivo.TabIndex = 636;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbuscar.ForeColor = System.Drawing.Color.White;
            this.txtbuscar.Location = new System.Drawing.Point(161, 16);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(261, 26);
            this.txtbuscar.TabIndex = 637;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(688, 1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(57, 56);
            this.btncerrar.TabIndex = 645;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.White;
            this.Panel4.Location = new System.Drawing.Point(161, 48);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(310, 1);
            this.Panel4.TabIndex = 646;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(161, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 1);
            this.panel1.TabIndex = 608;
            // 
            // AgregarNotacredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgcomprobantes);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.txtbuscar);
            this.Name = "AgregarNotacredito";
            this.Size = new System.Drawing.Size(745, 239);
            this.Load += new System.EventHandler(this.AgregarNotacredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcomprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txttipo;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnconfirmar;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgcomprobantes;
        internal System.Windows.Forms.TextBox txtmotivo;
        internal System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btncerrar;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Panel panel1;
    }
}

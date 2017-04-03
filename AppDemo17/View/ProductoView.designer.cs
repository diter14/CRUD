namespace AppDemo17.View
{
    partial class ProductoView
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
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.cboCategoria = new System.Windows.Forms.ComboBox();
      this.txtPrecio = new System.Windows.Forms.TextBox();
      this.txtCantidad = new System.Windows.Forms.TextBox();
      this.dgvProducto = new System.Windows.Forms.DataGridView();
      this.btnAdicionar = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.btnCierre = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 108);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Codigo";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 158);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nombre";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 204);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(81, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Categoria";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(23, 250);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 20);
      this.label4.TabIndex = 3;
      this.label4.Text = "Precio";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(23, 299);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(75, 20);
      this.label5.TabIndex = 4;
      this.label5.Text = "Cantidad";
      // 
      // txtID
      // 
      this.txtID.Location = new System.Drawing.Point(118, 104);
      this.txtID.Margin = new System.Windows.Forms.Padding(4);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(124, 27);
      this.txtID.TabIndex = 5;
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(118, 154);
      this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(165, 27);
      this.txtNombre.TabIndex = 6;
      // 
      // cboCategoria
      // 
      this.cboCategoria.FormattingEnabled = true;
      this.cboCategoria.Items.AddRange(new object[] {
            "Bebidas",
            "Abarrotes",
            "Limpieza",
            "Dulces"});
      this.cboCategoria.Location = new System.Drawing.Point(118, 197);
      this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
      this.cboCategoria.Name = "cboCategoria";
      this.cboCategoria.Size = new System.Drawing.Size(124, 28);
      this.cboCategoria.TabIndex = 7;
      // 
      // txtPrecio
      // 
      this.txtPrecio.Location = new System.Drawing.Point(118, 247);
      this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.Size = new System.Drawing.Size(124, 27);
      this.txtPrecio.TabIndex = 8;
      // 
      // txtCantidad
      // 
      this.txtCantidad.Location = new System.Drawing.Point(118, 296);
      this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new System.Drawing.Size(124, 27);
      this.txtCantidad.TabIndex = 9;
      // 
      // dgvProducto
      // 
      this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProducto.Location = new System.Drawing.Point(316, 73);
      this.dgvProducto.Margin = new System.Windows.Forms.Padding(4);
      this.dgvProducto.Name = "dgvProducto";
      this.dgvProducto.RowTemplate.Height = 24;
      this.dgvProducto.Size = new System.Drawing.Size(884, 289);
      this.dgvProducto.TabIndex = 10;
      // 
      // btnAdicionar
      // 
      this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
      this.btnAdicionar.FlatAppearance.BorderSize = 0;
      this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdicionar.ForeColor = System.Drawing.Color.White;
      this.btnAdicionar.Location = new System.Drawing.Point(141, 383);
      this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
      this.btnAdicionar.Name = "btnAdicionar";
      this.btnAdicionar.Size = new System.Drawing.Size(110, 38);
      this.btnAdicionar.TabIndex = 11;
      this.btnAdicionar.Text = "Adicionar";
      this.btnAdicionar.UseVisualStyleBackColor = false;
      this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
      // 
      // btnCerrar
      // 
      this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
      this.btnCerrar.FlatAppearance.BorderSize = 0;
      this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCerrar.ForeColor = System.Drawing.Color.White;
      this.btnCerrar.Location = new System.Drawing.Point(927, 383);
      this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(102, 38);
      this.btnCerrar.TabIndex = 12;
      this.btnCerrar.Text = "Cerrar";
      this.btnCerrar.UseVisualStyleBackColor = false;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // btnBuscar
      // 
      this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
      this.btnBuscar.FlatAppearance.BorderSize = 0;
      this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.ForeColor = System.Drawing.Color.White;
      this.btnBuscar.Location = new System.Drawing.Point(730, 383);
      this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(111, 38);
      this.btnBuscar.TabIndex = 13;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = false;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
      this.btnEliminar.FlatAppearance.BorderSize = 0;
      this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminar.ForeColor = System.Drawing.Color.White;
      this.btnEliminar.Location = new System.Drawing.Point(534, 383);
      this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(110, 38);
      this.btnEliminar.TabIndex = 14;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = false;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // btnActualizar
      // 
      this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
      this.btnActualizar.FlatAppearance.BorderSize = 0;
      this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnActualizar.ForeColor = System.Drawing.Color.White;
      this.btnActualizar.Location = new System.Drawing.Point(337, 383);
      this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(111, 38);
      this.btnActualizar.TabIndex = 15;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = false;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // btnCierre
      // 
      this.btnCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
      this.btnCierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnCierre.FlatAppearance.BorderSize = 0;
      this.btnCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCierre.ForeColor = System.Drawing.SystemColors.Window;
      this.btnCierre.Location = new System.Drawing.Point(1190, 11);
      this.btnCierre.Name = "btnCierre";
      this.btnCierre.Size = new System.Drawing.Size(29, 30);
      this.btnCierre.TabIndex = 16;
      this.btnCierre.Text = "X";
      this.btnCierre.UseVisualStyleBackColor = false;
      this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
      // 
      // panel1
      // 
      this.panel1.AllowDrop = true;
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.btnCierre);
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1232, 55);
      this.panel1.TabIndex = 15;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.SystemColors.Control;
      this.label6.Location = new System.Drawing.Point(12, 9);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(245, 36);
      this.label6.TabIndex = 17;
      this.label6.Text = "CRUD Productos";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ProductoView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
      this.ClientSize = new System.Drawing.Size(1232, 439);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.btnAdicionar);
      this.Controls.Add(this.dgvProducto);
      this.Controls.Add(this.txtCantidad);
      this.Controls.Add(this.txtPrecio);
      this.Controls.Add(this.cboCategoria);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ProductoView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = ":: C R U D  D E  P R O D U C T O  ::";
      ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}
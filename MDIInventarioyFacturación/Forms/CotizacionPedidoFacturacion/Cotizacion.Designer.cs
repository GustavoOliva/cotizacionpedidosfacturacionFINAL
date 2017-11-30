namespace MDIInventarioyFacturación
{
    partial class Cotizacion
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
            this.dgvtransacciones = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idProducto = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.navegador1 = new Navegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtransacciones
            // 
            this.dgvtransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransacciones.Location = new System.Drawing.Point(62, 376);
            this.dgvtransacciones.Name = "dgvtransacciones";
            this.dgvtransacciones.RowTemplate.Height = 24;
            this.dgvtransacciones.Size = new System.Drawing.Size(725, 214);
            this.dgvtransacciones.TabIndex = 65;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 417);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 109);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.Visible = false;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(520, 243);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(221, 22);
            this.total.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "ID Producto";
            // 
            // idProducto
            // 
            this.idProducto.Location = new System.Drawing.Point(178, 160);
            this.idProducto.Name = "idProducto";
            this.idProducto.Size = new System.Drawing.Size(220, 22);
            this.idProducto.TabIndex = 60;
            this.idProducto.TextChanged += new System.EventHandler(this.idProducto_TextChanged);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(178, 243);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(220, 22);
            this.precio.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Precio";
            // 
            // idVendedor
            // 
            this.idVendedor.Location = new System.Drawing.Point(520, 197);
            this.idVendedor.Name = "idVendedor";
            this.idVendedor.Size = new System.Drawing.Size(221, 22);
            this.idVendedor.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "ID Cliente";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(520, 160);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(221, 22);
            this.fecha.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha:";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(178, 200);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(220, 22);
            this.cantidad.TabIndex = 53;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cantidad";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 51;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(42, 58);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.nombreBD = null;
            this.navegador1.nombreTabla = null;
            this.navegador1.pass = null;
            this.navegador1.servidor = null;
            this.navegador1.Size = new System.Drawing.Size(745, 58);
            this.navegador1.TabIndex = 66;
            this.navegador1.usuario = null;
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 602);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvtransacciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idProducto);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtransacciones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idProducto;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private Navegador.Navegador navegador1;
    }
}
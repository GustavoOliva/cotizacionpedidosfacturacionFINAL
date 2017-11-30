namespace MDIInventarioyFacturación
{
    partial class Pedido
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
            this.insertar = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaCotizacion = new System.Windows.Forms.DateTimePicker();
            this.navegador1 = new Navegador.Navegador();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtransacciones
            // 
            this.dgvtransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransacciones.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvtransacciones.Location = new System.Drawing.Point(228, 318);
            this.dgvtransacciones.Name = "dgvtransacciones";
            this.dgvtransacciones.RowTemplate.Height = 24;
            this.dgvtransacciones.Size = new System.Drawing.Size(458, 201);
            this.dgvtransacciones.TabIndex = 70;
            this.dgvtransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtransacciones_CellContentClick);
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(414, 252);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(75, 23);
            this.insertar.TabIndex = 69;
            this.insertar.Text = "Insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(228, 174);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(200, 22);
            this.total.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Total";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(228, 116);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(200, 22);
            this.nombre.TabIndex = 66;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "ID Cotizacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Fecha Pedido";
            // 
            // fechaCotizacion
            // 
            this.fechaCotizacion.Location = new System.Drawing.Point(580, 114);
            this.fechaCotizacion.Name = "fechaCotizacion";
            this.fechaCotizacion.Size = new System.Drawing.Size(200, 22);
            this.fechaCotizacion.TabIndex = 63;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(62, 29);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.nombreBD = null;
            this.navegador1.nombreTabla = null;
            this.navegador1.pass = null;
            this.navegador1.servidor = null;
            this.navegador1.Size = new System.Drawing.Size(745, 58);
            this.navegador1.TabIndex = 71;
            this.navegador1.usuario = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.Visible = false;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 642);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvtransacciones);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fechaCotizacion);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtransacciones;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechaCotizacion;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
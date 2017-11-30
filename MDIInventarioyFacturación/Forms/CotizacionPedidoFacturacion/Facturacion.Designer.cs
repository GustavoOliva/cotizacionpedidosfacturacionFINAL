namespace MDIInventarioyFacturación
{
    partial class Facturacion
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
            this.navegador1 = new Navegador.Navegador();
            this.label6 = new System.Windows.Forms.Label();
            this.totalFactura = new System.Windows.Forms.TextBox();
            this.insertar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idCliente = new System.Windows.Forms.TextBox();
            this.facturador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.fechaFactura = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtransacciones
            // 
            this.dgvtransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransacciones.Location = new System.Drawing.Point(90, 359);
            this.dgvtransacciones.Name = "dgvtransacciones";
            this.dgvtransacciones.RowTemplate.Height = 24;
            this.dgvtransacciones.Size = new System.Drawing.Size(668, 150);
            this.dgvtransacciones.TabIndex = 75;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(52, 31);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.nombreBD = null;
            this.navegador1.nombreTabla = null;
            this.navegador1.pass = null;
            this.navegador1.servidor = null;
            this.navegador1.Size = new System.Drawing.Size(745, 58);
            this.navegador1.TabIndex = 76;
            this.navegador1.usuario = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "Total Factura";
            // 
            // totalFactura
            // 
            this.totalFactura.Location = new System.Drawing.Point(194, 230);
            this.totalFactura.Name = "totalFactura";
            this.totalFactura.Size = new System.Drawing.Size(200, 22);
            this.totalFactura.TabIndex = 86;
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(96, 297);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(75, 23);
            this.insertar.TabIndex = 85;
            this.insertar.Text = "Insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "ID Cliente";
            // 
            // idCliente
            // 
            this.idCliente.Location = new System.Drawing.Point(194, 182);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(200, 22);
            this.idCliente.TabIndex = 83;
            this.idCliente.TextChanged += new System.EventHandler(this.idCliente_TextChanged);
            // 
            // facturador
            // 
            this.facturador.Location = new System.Drawing.Point(554, 179);
            this.facturador.Name = "facturador";
            this.facturador.Size = new System.Drawing.Size(200, 22);
            this.facturador.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Facturador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 80;
            this.label1.Text = "Fecha de Vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "Fecha Factura";
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.Location = new System.Drawing.Point(554, 134);
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.Size = new System.Drawing.Size(200, 22);
            this.fechaVencimiento.TabIndex = 78;
            // 
            // fechaFactura
            // 
            this.fechaFactura.Location = new System.Drawing.Point(194, 134);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(200, 22);
            this.fechaFactura.TabIndex = 77;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(615, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.Visible = false;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalFactura);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idCliente);
            this.Controls.Add(this.facturador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fechaVencimiento);
            this.Controls.Add(this.fechaFactura);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvtransacciones);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.TextChanged += new System.EventHandler(this.Facturacion_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtransacciones;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalFactura;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idCliente;
        private System.Windows.Forms.TextBox facturador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechaVencimiento;
        private System.Windows.Forms.DateTimePicker fechaFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
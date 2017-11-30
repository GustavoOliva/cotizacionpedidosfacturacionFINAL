using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllconnectionDatabase;
using MDIInventarioyFacturación;

namespace MDIInventarioyFacturación.Forms.TrasladoTransporte
{
    public partial class TransaccionForm : Form
    {

        public static String stringpad = "Driver ={ MySQL ODBC 3.51.30 Driver}; Dsn=hotelsancarlos;";
        dllconnectionDatabaseTraslado.dllconnectionDatabaseTraslado connection = new dllconnectionDatabaseTraslado.dllconnectionDatabaseTraslado(stringpad);
        public TransaccionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            Program.codigoT = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.bodegaS = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.bodegaE = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Program.nombreC = Int32.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            Program.nombreD = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("yyy/MM/dd");
        }

        private void TransaccionForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            connection.OpenConnection();
            dataGridView1.DataSource = connection.llenarDataGridView("select m.codigoMovimientoInventario,m.fecha,b.nombre,b1.nombre,d.Cantidad,p.descripcion from  movimientoinventario m inner join detallemovimiento d on idDetalleMovimiento = codigoMovimientoInventario INNER JOIN productos p on p.idProducto=d.productos_idProducto inner join bodega b on b.idBodega=m.bodega_idBodegaDestino inner join bodega b1 on b.idBodega=m.bodega_idBodegaOrigen where  m.fecha  like'" + textBox1.Text + "%'");
            connection.CloseConnection();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

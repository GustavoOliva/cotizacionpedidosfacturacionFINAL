using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllconnectionDatabaseTraslado;

namespace MDIInventarioyFacturación.Forms.TrasladoTransporte
{
    public partial class Agregar_Unidad : Form
    {
        

        public Agregar_Unidad()
        {
            InitializeComponent();
        }



        public static String stringpad = "Driver ={ MySQL ODBC 3.51.30 Driver}; Dsn=hotelsancarlos;";
        dllconnectionDatabaseTraslado.dllconnectionDatabaseTraslado connection = new dllconnectionDatabaseTraslado.dllconnectionDatabaseTraslado(stringpad);

        private void Button1_Click(object sender, EventArgs e)
        {
            



        }

        private void Agregar_Unidad_Load(object sender, EventArgs e)
        {

           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PilotoForm pf = new PilotoForm();
            pf.ShowDialog();
            lblnombre.Text = Program.nombre;
            lbldpi.Text = Program.dpi.ToString();
            lblresultadopiloto.Text = Program.id.ToString();
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            connection.OpenConnection();
            dataGridView1.DataSource = connection.llenarDataGridView("select * from vehiculo  where  placa  like'" + textBox4.Text + "%'");
            connection.CloseConnection();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            Lblcapacidad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblUnidad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblunidadseleccionada.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DateTimePicker1.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
             
        }

        private void navegador1_RecibidorAnterior(object sender, EventArgs e)
        {

            

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {

            
            this.Hide();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            connection.OpenConnection();

            connection.InsertarRegistro("INSERT INTO viaje(fechaPrevistaOperacion,observaciones,vehiculo_idVehiculo,bodegaProcedencia,bodegaDestino,piloto_idpiloto)VALUES('" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + txtobservaciones.Text + "','" + lblunidadseleccionada.Text + "','" + txtbodegaprocedencia.Text + "','" + txtbodegadestino.Text + "','" + lblresultadopiloto.Text + "');");
           
            connection.CloseConnection();

            lblCant.Text = "";
            Lblcapacidad.Text = "";
            lbldpi.Text = "";
            lblnombre.Text = "";
            lblNomov.Text = "";
            lblprod.Text = "";
            lblresultadopiloto.Text = "";
            lblUnidad.Text = "";
            lblunidadseleccionada.Text = "";
            txtbodegadestino.Text = "";
            txtbodegaprocedencia.Text = "";
            txtobservaciones.Text = "";




        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           TransaccionForm pf = new TransaccionForm();
            pf.ShowDialog();
            lblCant.Text = Program.nombreC.ToString();
            lblprod.Text = Program.nombreD.ToString();
            txtbodegadestino.Text = Program.bodegaE;
            txtbodegaprocedencia.Text = Program.bodegaS;
            lblNomov.Text = Program.codigoT.ToString();

        }
    }
}

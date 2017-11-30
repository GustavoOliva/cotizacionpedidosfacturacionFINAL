using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data.Odbc;
using dllconnectionDataBase;
using System.Data.SqlClient;

namespace MDIInventarioyFacturación
{
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            InitializeComponent();
            llenarDataGridPrincipal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String stringpad = "server=192.168.1.10 ;user id=inventariofacturacion; password=Inventariofacturacion1234; database=hotelSanCarlos";
            dllconnectionDataBase.dllconnectionDataBase connection = new dllconnectionDataBase.dllconnectionDataBase(stringpad);

            connection.OpenConnection();
            connection.InsertarRegistro("insert into cotizacion ( `productos_idProducto`, `cantidad`, `fechaCotizacion`, `total`, `cliente_idCliente`) VALUES ( " + this.idProducto.Text + ", " + this.cantidad.Text + ",'" + this.fecha.Text + "'," + this.total.Text + "," + this.idVendedor.Text + ");");
            connection.CloseConnection();
            llenarDataGridPrincipal();
        }
        public void llenarDataGridPrincipal()
        {
            MyDBEntity mdb = new MyDBEntity();
            string sql = "select *from cotizacion;";
            DataTable tbl = new DataTable();

            try
            {

                tbl = mdb.CargarTabla(sql);

                //llama al método de la clase para conectar
                //MyDBEntity mienty = new MyDBEntity();
                mdb.conectar();

                OdbcCommand cmd = new OdbcCommand(sql, mdb.conexion);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvtransacciones.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }


        }

        private void idProducto_TextChanged(object sender, EventArgs e)
        {
            if (idProducto.Text == "")
            {
                // don nothing
            }
            else
            {
                String stringpad = "server=192.168.1.10 ;user id=inventariofacturacion; password=Inventariofacturacion1234; database=hotelSanCarlos";
                dllconnectionDataBase.dllconnectionDataBase connection = new dllconnectionDataBase.dllconnectionDataBase(stringpad);

                connection.OpenConnection();
                String cadsql = "select precio from productos where idProducto = " + this.idProducto.Text;
                dataGridView1.DataSource = connection.llenarDataGridView(cadsql);
                connection.CloseConnection();
                if (dataGridView1.Rows.Count - 1 == 0)
                {
                    this.precio.Text = "el producto no existe";
                }
                else
                {
                    this.precio.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                }



            }
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            total.Text = (Int32.Parse(this.cantidad.Text) * Int32.Parse(this.precio.Text)).ToString();
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {

        }
    }
}

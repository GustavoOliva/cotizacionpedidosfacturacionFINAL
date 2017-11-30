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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
            llenarDataGridPrincipal();
        }

        private void Facturacion_TextChanged(object sender, EventArgs e)
        {
            if (idCliente.Text == "")
            {
                // don nothing
            }
            else
            {
                String stringpad = "server=192.168.1.10 ;user id=inventariofacturacion; password=Inventariofacturacion1234; database=hotelSanCarlos";
                dllconnectionDataBase.dllconnectionDataBase connection = new dllconnectionDataBase.dllconnectionDataBase(stringpad);

                connection.OpenConnection();
                String cadsql = "select folio.monto from folio inner join reservacion on reservacion.idReservacion = folio.id_gasto where reservacion.cliente_idCliente = " + this.idCliente.Text;
                dgvtransacciones.DataSource = connection.llenarDataGridView(cadsql);
                connection.CloseConnection();
                if (dgvtransacciones.Rows.Count - 1 == 0)
                {
                    this.totalFactura.Text = "";
                }
                else
                {
                    this.totalFactura.Text = dgvtransacciones.Rows[0].Cells[0].Value.ToString();
                }



            }

        }

        private void insertar_Click(object sender, EventArgs e)
        {

            //esto es de la conexion
            String stringpad = "server=192.168.1.10 ;user id=inventariofacturacion; password=Inventariofacturacion1234; database=hotelSanCarlos";
            dllconnectionDataBase.dllconnectionDataBase connection = new dllconnectionDataBase.dllconnectionDataBase(stringpad);
            //abro la conexion
            connection.OpenConnection();

            //primer insert
            connection.InsertarRegistro("insert into factura ( `fechaFactura`, `fechaVencimiento`,`totalFactura`,  `facturador`, `cliente_idCliente`) VALUES ( '" + this.fechaFactura.Text + "', '" + this.fechaVencimiento.Text + "','" + this.totalFactura.Text + "','" + this.facturador.Text + "','" + this.idCliente.Text + "');");
            //segundo
            connection.InsertarRegistro("INSERT INTO `hotelSanCarlos`.`movimientosCliente` ( `total_cobro`, `saldo`, `fecha`, `Transacciones_cod_transacciones`, `cliente_idCliente``fechaVencimiento`,`actual`) VALUES (0,'" + this.totalFactura.Text + "','" + this.fechaFactura.Text + "',1, '" + this.idCliente.Text + "', '" + this.fechaVencimiento.Text + ",1)");
            connection.CloseConnection();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void insertar_Click_1(object sender, EventArgs e)
        {

        }
        public void llenarDataGridPrincipal()
        {
            MyDBEntity mdb = new MyDBEntity();
            string sql = "select *from factura;";
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

        private void idCliente_TextChanged(object sender, EventArgs e)
        {
            if (idCliente.Text == "")
            {
                // don nothing
            }
            else
            {
                String stringpad = "server=192.168.1.10 ;user id=inventariofacturacion; password=Inventariofacturacion1234; database=hotelSanCarlos";
                dllconnectionDataBase.dllconnectionDataBase connection = new dllconnectionDataBase.dllconnectionDataBase(stringpad);

                connection.OpenConnection();
                String cadsql = "select folio.monto from folio inner join reservacion on reservacion.idReservacion = folio.id_gasto where reservacion.cliente_idCliente = " + this.idCliente.Text;
                dataGridView1.DataSource = connection.llenarDataGridView(cadsql);
                connection.CloseConnection();
                if (dataGridView1.Rows.Count - 1 == 0)
                {
                    this.totalFactura.Text = "";
                }
                else
                {
                    this.totalFactura.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                }
            }
            }
        }
}

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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
            llenarDataGridPrincipal();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

        }
        public void llenarDataGridPrincipal()
        {
            MyDBEntity mdb = new MyDBEntity();
            string sql = "select *from pedido;";
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

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            {

                if (nombre.Text == "")
                {
                    // don nothing
                }
                else
                {
                    String stringpad = "server=192.168.1.10 ;user id=inventariofacturacion; password=Inventariofacturacion1234; database=hotelSanCarlos";
                    dllconnectionDataBase.dllconnectionDataBase connection = new dllconnectionDataBase.dllconnectionDataBase(stringpad);

                    connection.OpenConnection();
                    String cadsql = "select total from cotizacion where cliente_idCliente = " + this.nombre.Text;
                    dataGridView1.DataSource = connection.llenarDataGridView(cadsql);
                    connection.CloseConnection();
                    if (dataGridView1.Rows.Count - 1 == 0)
                    {
                        this.total.Text = "la cotizacion no existe";
                    }
                    else
                    {
                        this.total.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    }



                }
            }
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            //objetos del tipo de la clase referencia
            MyDBEntity mdb = new MyDBEntity();
            //variable para almacenar la consulta sql
            string sql = ("insert into pedido ( `fecha`, `cotizacion_idCotizacion`) VALUES ( '" + this.fechaCotizacion.Text + "'," + this.nombre.Text + ");");

            try
            {
                //se manda como parametro el string con la consulta 
                mdb.EjecutarSQL(sql);
                MessageBox.Show("DATOS ALMACENADOS EN LA BASE DE DATOS");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            llenarDataGridPrincipal();
        }

        private void dgvtransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
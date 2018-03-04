using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario2._0
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private string server = "localhost";
        private string database = "inventario";
        private string uid = "root";
        private string password = "";

        private Database db = null;
        private MySqlDataAdapter mySqlDataAdapter;

        private void Inventario_Load(object sender, EventArgs e)
        {
            db = new Database(server, database, uid, password);


            if (db.openConnection())
            {
                mySqlDataAdapter = db.getMySqlDataAdapter("select * from listar_inventarios");
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                inventariosDGV.DataSource = DS.Tables[0];
            }
        }

        private void edificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edificios edificios = new Edificios();
            edificios.Show();
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salones salones = new Salones();
            salones.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!db.closeConnection()) db.closeConnection();
            Application.Exit();
        }

        private void Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!db.closeConnection()) db.closeConnection();
            Application.Exit();
        }

        private void nuevoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_Inventario detalle_Inventario = new Detalle_Inventario();
            detalle_Inventario.Show();
        }
    }
}

using System;
using System.Data;
using System.IO;
using System.Text;
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
        private MySqlDataAdapter mySqlDataAdapter, mySqlDataAdapter2;
        DataSet DS = new DataSet();

        private void Inventario_Load(object sender, EventArgs e)
        {
            db = new Database(server, database, uid, password);


            if (db.openConnection())
            {
                mySqlDataAdapter = db.getMySqlDataAdapter("select * from listar_inventarios");
                mySqlDataAdapter2 = db.getMySqlDataAdapter("select id_inventario from listar_inventarios");
                DataSet DS2 = new DataSet();
                mySqlDataAdapter.Fill(DS);
                mySqlDataAdapter2.Fill(DS2);
                inventariosDGV.DataSource = DS.Tables[0];

                invBox.Items.Clear();
                foreach (DataRow id_inv in DS2.Tables[0].Rows)
                {
                    invBox.Items.Add(id_inv.ToString());
                }

                this.invBox.SelectedIndexChanged += new EventHandler(invBox_SelectedIndexChanged);
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

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(inventariosDGV, sfd.FileName);
            }
        }

        private void invBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventariosDGV.Rows.Clear();

            mySqlDataAdapter = db.getMySqlDataAdapter("select * from listar_inventarios where id_inventario = " + invBox.SelectedIndex.ToString());
            mySqlDataAdapter.Fill(DS);
            inventariosDGV.DataSource = DS.Tables[0];
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }

            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}

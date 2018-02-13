using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario2._0
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private string server = "localhost";
        private string database = "inventario";
        private string uid = "root";
        private string password = "";
        private MySqlConnection connection;
        string connectionString;
        private MySqlDataAdapter mySqlDataAdapter;



        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from articulos", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

               
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close connection
            this.CloseConnection();
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close connection
            this.CloseConnection();
            Application.Exit();
        }

        private void edificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edificios edif = new Edificios();
            edif.Show();

        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Show();
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_Inventario det_inv = new Detalle_Inventario();
            det_inv.Show();
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salones sal = new Salones();
            sal.Show();
        }
    }
}

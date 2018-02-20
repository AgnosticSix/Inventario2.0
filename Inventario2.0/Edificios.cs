using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Inventario2._0
{
    public partial class Edificios : Form
    {
        public Edificios()
        {
            InitializeComponent();
        }

        private string server = "localhost";
        private string database = "inventario";
        private string uid = "root";
        private string password = "";

        private Database db = null;
        private MySqlDataAdapter mySqlDataAdapter;

        private void Edificios_Load(object sender, EventArgs e)
        {
            db = new Database(server, database, uid, password);


            if (db.openConnection())
            {
                mySqlDataAdapter = db.getMySqlDataAdapter("select * from edificios");
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void Edificios_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.closeConnection();
            this.Hide();
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
    }
}

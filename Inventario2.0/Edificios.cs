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

        private Database db = null;
        private MySqlDataAdapter mySqlDataAdapter;

        private string tableName = "edificios";
        private bool editing = false;
        private int id_edificio_selected =-1;


        private void Edificios_Load(object sender, EventArgs e)
        {
            db = new Database();


            if (db.openConnection())
            {
                this.fillTable();
            }
        }

        private void Edificios_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.closeConnection();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.getFields())
            {
                return;
            }

            string query = "";

            if (!editing)
            {
                query = "insert into " + this.tableName + "(nombre, descripcion) values ('" + this.txtNombre.Text + "', '" + this.txtDescripcion.Text + "')";
            } else
            {
                query = "update " + this.tableName + " set nombre='" + this.txtNombre.Text + "' , descripcion = '" + this.txtDescripcion.Text + "' where id_edificio = " + this.id_edificio_selected;
            }

            int rowsAffected = db.executeNonQuery(query);
            if (rowsAffected <= 0)
            {
                //show error message
                return;
            }
            
            this.resetFields();
            this.fillTable();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.editing = true;
            this.btnGuardar.Text = "Actualizar";
            this.getRowFields();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.resetFields();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(this.editing && this.id_edificio_selected != -1)
            {
                string query = "delete from " + this.tableName + " where id_edificio=" + this.id_edificio_selected;
                int rowsAffected = this.db.executeNonQuery(query);

                if (rowsAffected<=0)
                {
                    //show error message
                    return;
                }

                this.resetFields();
                this.fillTable();
            }
        }

        //class helpers
        private void fillTable()
        {
            mySqlDataAdapter = db.getMySqlDataAdapter("select * from listar_edificios");
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridViewEdificios.DataSource = DS.Tables[0];
        }

        private bool getFields()
        {
            if(! (this.txtNombre.Text.Length>0) ) {
                this.txtNombre.Focus();
                return false;
            }else if( ! (this.txtDescripcion.Text.Length > 0)){
                this.txtDescripcion.Focus();
                return false;
            }
            return true;
        }

        private void getRowFields()
        {
            DataGridViewSelectedRowCollection rows = dataGridViewEdificios.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                DataRow data = (row.DataBoundItem as DataRowView).Row;
                this.id_edificio_selected = data.Field<int>("id_edificio");
                this.txtNombre.Text = data.Field<string>("nombre");
                this.txtDescripcion.Text = data.Field<string>("descripcion");
            }
        }

        private void resetFields()
        {
            this.editing = false;
            this.btnGuardar.Text = "Guardar";
            this.id_edificio_selected = -1;
            this.txtNombre.Clear();
            this.txtDescripcion.Clear();
        }

    }
}

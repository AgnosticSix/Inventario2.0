using System;
using System.Data;
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
                
        private Database db = null;
        private MySqlDataAdapter mySqlDataAdapter;

        private bool editing = false;
        private int id_articulo_selected = -1;
        private string tableName = "articulos";

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Database();
            
            if (db.openConnection())
            {
                this.fillTable();
            }
        }        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close connection
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
            if (!this.editing)
            {
                query = "insert into " + tableName + "(nombre, descripcion) values ('" + this.txtNombre.Text + "', '" + this.txtDescripcion.Text + "')";
            }
            else
            {
                query = "update "+this.tableName+" set nombre = '"+this.txtNombre.Text+"', descripcion = '"+this.txtDescripcion.Text + "' where id_articulo = " + this.id_articulo_selected;
            }

            int rowsAffected = db.executeNonQuery(query);
            if (rowsAffected <= 0)
            {
                //show error message
                return;
            }

            this.fillTable();
            this.resetFields();
            
        }


        //class helpers
        private void fillTable()
        {
            mySqlDataAdapter = db.getMySqlDataAdapter("select * from articulos");
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridViewSalones.DataSource = DS.Tables[0];
        }

        private bool getFields()
        {
            if (!(this.txtNombre.Text.Length > 0))
            {
                this.txtNombre.Focus();
                return false;
            }
            else if (!(this.txtDescripcion.Text.Length > 0))
            {
                this.txtDescripcion.Focus();
                return false;
            }
            return true;
        }

        private void getRowFields()
        {
            DataGridViewSelectedRowCollection rows = dataGridViewSalones.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                DataRow data = (row.DataBoundItem as DataRowView).Row;
                this.id_articulo_selected = data.Field<int>("id_articulo");
                this.txtNombre.Text = data.Field<string>("nombre");
                this.txtDescripcion.Text = data.Field<string>("descripcion");
            }
        }

        private void resetFields()
        {
            this.editing = false;
            this.btnGuardar.Text = "Guardar";
            this.id_articulo_selected = -1;
            this.txtNombre.Clear();
            this.txtDescripcion.Clear();
        }

        private void dataGridViewSalones_MouseDoubleClick(object sender, MouseEventArgs e)
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
            if( this.editing && this.id_articulo_selected != -1)
            {
                string query = "delete from " + this.tableName + " where id_articulo = " + this.id_articulo_selected;
                int rowsAffected =  db.executeNonQuery(query);
                if (rowsAffected <= 0)
                {
                    //show error message
                    return;
                }

                this.resetFields();
                this.fillTable();
            }
        }
    }
}

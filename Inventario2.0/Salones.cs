using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Inventario2._0
{
    public partial class Salones : Form
    {
        public Salones()
        {
            InitializeComponent();
        }

        private Database db = null;
        private MySqlDataAdapter mySqlDataAdapter;

        private string tableName = "salones";
        private bool editing = false;
        private int id_salon_selected = -1;

        private void Salones_Load(object sender, EventArgs e)
        {
            db = new Database();
            if (db.openConnection())
            {
                this.fillTable();
                this.fillCombo();
            }
        }

        private void Salones_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.closeConnection();
            this.Hide();
        }

        private void dataGridViewSalones_DoubleClick(object sender, EventArgs e)
        {
            this.editing = true;
            this.btnGuardar.Text = "Actualizar";
            this.getRowFields();
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
                query = "insert into " + this.tableName + "(id_edificio, nombre, codigo, descripcion) values (" + this.comboEdificios.SelectedValue + ", '" + this.txtNombre.Text + "', '" + this.txtCodigo.Text + "' , '" + this.txtDescripcion.Text + "')";
            }
            else
            {
                query = "update " + this.tableName + " set nombre='" + this.txtNombre.Text + "' , codigo = '"+this.txtCodigo.Text+ "' , descripcion = '" + this.txtDescripcion.Text + "', id_edificio=" + this.comboEdificios.SelectedValue + " where id_salon = " + this.id_salon_selected;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.resetFields();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.editing && this.id_salon_selected != -1)
            {
                string query = "delete from " + this.tableName + " where id_salon=" + this.id_salon_selected;
                int rowsAffected = this.db.executeNonQuery(query);

                if (rowsAffected <= 0)
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
            mySqlDataAdapter = db.getMySqlDataAdapter("select * from listar_salones");
            DataSet dataset = new DataSet();
            mySqlDataAdapter.Fill(dataset);
            dataGridViewSalones.DataSource = dataset.Tables[0];
        }

        private void fillCombo()
        {
            mySqlDataAdapter = db.getMySqlDataAdapter("select id_edificio, nombre from edificios");
            DataSet dataset = new DataSet();
            mySqlDataAdapter.Fill(dataset);

            comboEdificios.ValueMember = "id_edificio";
            comboEdificios.DisplayMember = "nombre";
            comboEdificios.DataSource = dataset.Tables[0].DefaultView;
        }

        private bool getFields()
        {
            if (!(this.txtNombre.Text.Length > 0))
            {
                this.txtNombre.Focus();
                return false;
            }else if (!(this.txtCodigo.Text.Length > 0))
            {
                this.txtCodigo.Focus();
                return false;
            }else if (!(this.txtDescripcion.Text.Length > 0))
            {
                this.txtDescripcion.Focus();
                return false;
            }

            return true;
        }

        private void resetFields()
        {
            this.txtNombre.Clear();
            this.txtCodigo.Clear();
            this.txtDescripcion.Clear();
            this.editing = false;
            this.id_salon_selected = -1;
            this.comboEdificios.SelectedIndex = 0;
            this.btnGuardar.Text = "Guardar";
        }       

        private void getRowFields()
        {
            DataGridViewSelectedRowCollection rows = this.dataGridViewSalones.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                DataRow data = (row.DataBoundItem as DataRowView).Row;
                this.id_salon_selected = data.Field<int>("id_salon");
                this.comboEdificios.SelectedValue = data.Field<int>("id_edificio");
                this.txtNombre.Text = data.Field<string>("nombre");
                this.txtCodigo.Text = data.Field<string>("codigo");
                this.txtDescripcion.Text = data.Field<string>("descripcion");
            }
        }
    }
}

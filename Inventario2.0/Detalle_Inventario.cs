using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario2._0
{
    public partial class Detalle_Inventario : Form
    {
        private ArrayList idsArticulo = new ArrayList();
        private bool editing = false;
        private int id_articulo_selected = -1;
        private int id_inventario_selected = -1;

        private DataGridViewRow selectedRow = null;

        private Database db = null;
        private MySqlDataAdapter mySqlDataAdapter;

        public Detalle_Inventario()
        {
            InitializeComponent();
        }

        public Detalle_Inventario(int id_inventario_selected)
        {
            InitializeComponent();
            this.id_inventario_selected = id_inventario_selected;
            db = new Database();


            if (db.openConnection())
            {
                this.fillTable();
            }
            
        }

        private void Detalle_Inventario_Load(object sender, EventArgs e)
        {
            db = new Database();

            if (db.openConnection())
            {
                if (this.id_inventario_selected != -1)
                {
                    this.fillTable();
                }
                this.fillComboArticulos();
                this.fillComboEdificios();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.selectedRow != null)
            {
                this.dataGridViewDetalle.Rows.Remove(this.selectedRow);
                this.idsArticulo.Remove(Int32.Parse(this.selectedRow.Cells[0].Value.ToString()));
                this.resetFields();
            }
        }

        private void comboEdificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fillComboSalones();
        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {

            if (this.editing)
            {
                this.dataGridViewDetalle.Rows.Remove(selectedRow);
            }
            else
            {
                if (this.comboArticulos.Items.Count <= 0) return;
                if (this.idsArticulo.Contains(Int32.Parse(this.comboArticulos.SelectedValue.ToString()))) return;
            }

            this.dataGridViewDetalle.Rows.Add(new Object[] { this.comboArticulos.SelectedValue, this.comboArticulos.GetItemText(this.comboArticulos.SelectedItem), this.cantidadArticulos.Value });

            if(!editing) this.idsArticulo.Add(Int32.Parse(this.comboArticulos.SelectedValue.ToString()));
            this.resetFields();
        }

        private void dataGridViewDetalle_DoubleClick(object sender, EventArgs e)
        {
            this.getRowFields();
            if (this.selectedRow != null)
            {
                this.btnGuardarArticulo.Text = "Actualizar";
                this.editing = true;
                this.btnCancelarArticulo.Enabled = true;
                this.btnEliminarArticulo.Enabled = true;
            }
        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            this.resetFields();
        }

        //class helpers
        private void fillTable()
        {
            this.mySqlDataAdapter = db.getMySqlDataAdapter("select di.id_articulo, di.cantidad, a.nombre as articulo from detalle_inventario as di inner join articulos as a on di.id_articulo = a.id_articulo where di.id_inventario = " + this.id_inventario_selected );
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            this.dataGridViewDetalle.DataSource = dataSet.Tables[0];    //rellena la tabla del inventario seleccionado


            //añade cada id_articulo existente a un array lista para que no se pueda agregar dos veces
            foreach (DataGridViewRow row in this.dataGridViewDetalle.Rows)
            {
                this.idsArticulo.Add(Int32.Parse(row.Cells[0].Value.ToString()));
            }
        }

        private void fillComboArticulos()
        {
            mySqlDataAdapter = db.getMySqlDataAdapter("select id_articulo, nombre from articulos");
            DataSet dataset = new DataSet();
            mySqlDataAdapter.Fill(dataset);

            comboArticulos.ValueMember = "id_articulo";
            comboArticulos.DisplayMember = "nombre";
            comboArticulos.DataSource = dataset.Tables[0].DefaultView;
        }

        private void fillComboEdificios()
        {
            mySqlDataAdapter = db.getMySqlDataAdapter("select id_edificio, nombre from edificios");
            DataSet dataset = new DataSet();
            mySqlDataAdapter.Fill(dataset);

            comboEdificios.ValueMember = "id_edificio";
            comboEdificios.DisplayMember = "nombre";
            comboEdificios.DataSource = dataset.Tables[0].DefaultView;
        }

        private void fillComboSalones()
        {
            mySqlDataAdapter = db.getMySqlDataAdapter("select id_salon, nombre from salones where id_edificio = "+ this.comboEdificios.SelectedValue);
            DataSet dataset = new DataSet();
            mySqlDataAdapter.Fill(dataset);

            comboSalones.ValueMember = "id_salon";
            comboSalones.DisplayMember = "nombre";
            comboSalones.DataSource = dataset.Tables[0].DefaultView;
        }

        private void getRowFields()
        {
            //extrae los datos de la(s) fila seleccionada 
            DataGridViewSelectedRowCollection rows = this.dataGridViewDetalle.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                this.id_articulo_selected = Int32.Parse(row.Cells[0].Value.ToString()); //id_articulo
                this.comboArticulos.SelectedValue = row.Cells[0].Value.ToString();
                this.cantidadArticulos.Value = Int32.Parse(row.Cells[2].Value.ToString());  //cantidad

                this.selectedRow = row;     //permitira borrar la fila 
            }
        }

        private void resetFields()
        {
            this.btnCancelarArticulo.Enabled = false;
            this.btnEliminarArticulo.Enabled = false;
            this.editing = false;
            this.btnGuardarArticulo.Text = "Guardar";
            this.comboArticulos.SelectedIndex = 0;
            this.cantidadArticulos.Value = 1;
            this.selectedRow = null;
        }

        private void btnGuardarInvetario_Click(object sender, EventArgs e)
        {
            if(this.txtEncargado.Text.Length==0)
            {
                this.txtEncargado.Focus();
                return;
            }

            if (this.dataGridViewDetalle.RowCount <= 0) return;

            db = new Database();
            if (this.db.openConnection())
            {
                int rowsAffected = this.db.executeNonQuery("insert into inventarios(id_salon, encargado, observaciones, fecha_creacion, fecha_actualizado) values("+this.comboSalones.SelectedValue.ToString()+", '"+this.txtEncargado.Text+"' , '"+this.txtObservaciones.Text+"', now() , now())");
                if (rowsAffected > 0)
                {
                    string values = "";

                    foreach (DataGridViewRow row in this.dataGridViewDetalle.SelectedRows)
                    {
                        values += "(@id_inventario, " + row.Cells[0].Value.ToString() + ", " + row.Cells[2].Value.ToString() + "),";
                    }

                    int save = this.db.executeNonQuery("set @id_inventario = (select id_inventario from inventarios order by id_inventario desc limit 1); insert into detalle_inventario(id_inventario, id_articulo, cantidad) values " + values.Substring(0, values.Length-1)+";");

                    if (save > 0)
                    {
                        System.Console.WriteLine("Saved");
                    }
                }
            }
        }

        private void btnCancelarInventario_Click(object sender, EventArgs e)
        {
            if (this.db != null)
            {
                this.db.closeConnection();
            }
            this.Hide();
        }

        private void Detalle_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db != null)
            {
                this.db.closeConnection();
            }
            this.Hide();
        }
    }
}

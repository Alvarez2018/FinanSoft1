using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanSoft.Models.Clientes;

namespace FinanSoft.Forms_Clientes
{
    public partial class Wf_ClienteLista : Form
    {
        public int idClienteEnviar;
        private DB_Context _contexto = new DB_Context();
        public Wf_ClienteLista()
        {
            InitializeComponent();
        }

        //Buscar
        private void button1_Click(object sender, EventArgs e)
        {
            dgv_ListaClientes.Rows.Clear();
            var Nombre = txt_ListCliNombre.Text;
            var Nit = txt_ListCliNit.Text;
            string[] RowUnCliente = new string[4];
            var SocioBusqueda=  _contexto.Socios.Where(c => c.Nombre.Contains(Nombre) && c.NumeroDeTributacion.Contains(Nit));
            //dgv_ListaClientes.Columns.Add("col_IdCliente", "IdClientes");
            //dgv_ListaClientes.Columns[0].Visible = false;
            
            //dgv_ListaClientes.Columns.Add("col_Nombre", "Clientes");
            //dgv_ListaClientes.Columns[1].ReadOnly = true;

            foreach (var socios in SocioBusqueda)
            {                
                RowUnCliente[0] = socios.Id_Socio.ToString();
                RowUnCliente[1] = socios.Nombre;
                dgv_ListaClientes.Rows.Add(RowUnCliente);
               
    }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_ListaClientes.Rows[e.RowIndex];
                idClienteEnviar = Convert.ToInt32(row.Cells["Col_IdCliente"].Value.ToString());
            }

        }

        //Seleccionar
        private void button2_Click(object sender, EventArgs e)
        {
            if (idClienteEnviar == 0)
            {
                MessageBox.Show("Por favor selecciona un cliente");
                this.DialogResult = DialogResult.None;

            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void dgv_ListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_ListaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_ListaClientes.Rows[e.RowIndex];
                idClienteEnviar = Convert.ToInt32(row.Cells["Col_IdCliente"].Value.ToString());
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}

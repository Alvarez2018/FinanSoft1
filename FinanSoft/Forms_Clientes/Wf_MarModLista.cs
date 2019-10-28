using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanSoft.Forms_Clientes
{
    public partial class Wf_MarModLista : Form

    {
        public int IdMarcaEnviar = 0;
        private DB_Context _Context = new DB_Context();
        public Wf_MarModLista()
        {
            InitializeComponent();
        }

        //BOTON SELECCIONAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (IdMarcaEnviar == 0)
            {
                MessageBox.Show("Por favor selecciona una marca ");
                this.DialogResult = DialogResult.None;

            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        //BOTON BUSCAR
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var ListadoMarcas =_Context.Marcas.Where(m => m.Nombre.Contains(textBox1.Text));
            string[] RowMarca = new string[2];

            if(ListadoMarcas.Count()>0)
            {
                foreach (var marca in ListadoMarcas)
                {
                    RowMarca[0] = marca.Id_Marca.ToString();
                    RowMarca[1] = marca.Nombre;
                    dataGridView1.Rows.Add(RowMarca);


                }
            }else
            {
                MessageBox.Show("No existe ninguna marca con la informacion suministrada");
            }
            


        }

        private void MarcasLista_Load(object sender, EventArgs e)
        {

        }

        //BOTON SALIR
        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                IdMarcaEnviar= Convert.ToInt32(row.Cells["IdMarca"].Value.ToString());
            }
        }
    }
}

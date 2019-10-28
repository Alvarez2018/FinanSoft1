using FinanSoft.Forms_Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanSoft
{
    public partial class Wf_Principal : Form
    {
        
        
        public Wf_Principal()
        {
            InitializeComponent();
          
        }

        private void admoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var Wf_Clientes = new WFClientes();
            Wf_Clientes.Show();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void Principal_Formclosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var WF_Marcas = new Marcas();
            WF_Marcas.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using FinanSoft.Models.Clientes;
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
    public partial class Wf_InicioSesion : Form
    {
        public Wf_InicioSesion()
        {
            InitializeComponent();
            /*
            var contexto = new DB_Context();
            
            var Cliente1 = new Cliente {
                Nombres1 = "Leo"
            };

            contexto.Clientes.Add(Cliente1);
            contexto.SaveChanges();
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FormPrincipal = new Wf_Principal();
            this.Hide();
            FormPrincipal.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Principal_Formclosed(object sender, EventArgs e)
        {
            Application.Exit();
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                Application.Exit();
            
        }
    }
}

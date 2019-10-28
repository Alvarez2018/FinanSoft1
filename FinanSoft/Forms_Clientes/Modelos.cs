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
    public partial class Modelos : Form
    {
        public int MarcaEnvio;
        
        public int ModeloEnviado;
        //private int _MarcaEnviada;
        private DB_Context _Contexto = new DB_Context();
        public Modelos()
        {
            
            InitializeComponent();
        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            this.Disable_All_Controls();
            this.Clear_All_Controls();
        }
        
        private void Disable_All_Controls()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;            
            richTextBox1.Enabled = false;
            comboBox1.Enabled = false;
        }
        private void Enable_All_Controls()
        {
            //textBox1.Enabled = true;
            textBox2.Enabled = true;            
            richTextBox1.Enabled = true;
            comboBox1.Enabled = true;
        }
        private void Clear_All_Controls()
        {
            textBox1.Text = "";
            textBox2.Text = "";            
            richTextBox1.Text = "";
            comboBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

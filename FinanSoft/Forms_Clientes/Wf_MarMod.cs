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
using System.Data.Entity;

namespace FinanSoft.Forms_Clientes
{
    public partial class Marcas : Form
    {
        private bool EsMarcaNueva = false;
        private DB_Context _Contexto = new DB_Context();

        public Marcas()
        {
            InitializeComponent();
        }
        //BOTON BUSCAR
        private void button2_Click(object sender, EventArgs e)
        {
            this.Clear_All_Controls();
            this.Disable_All_Controls();

            using (Wf_MarModLista WFML = new Wf_MarModLista())
            {
                if (WFML.ShowDialog() == DialogResult.OK)
                {
                   
                    var Marca = _Contexto.Marcas.Include(m => m.Modelos).FirstOrDefault(m => m.Id_Marca == WFML.IdMarcaEnviar);
                    textBox1.Text = Marca.Id_Marca.ToString();
                    textBox2.Text = Marca.Nombre;

                    
                    richTextBox1.Text = Marca.Descripcion;

                    if (Marca.EstasActivo == true)
                    {
                        comboBox1.Text = "Activo";
                    }else
                    {
                        comboBox1.Text = "Inactivo";
                    }
                    
                    if(Marca.Modelos.Count() >0)
                    {
                        string[] RowModelo = new string[2];
                        foreach(var modelo in Marca.Modelos)
                        {
                            RowModelo[0] = modelo.Id_Modelo.ToString();
                            RowModelo[1] = modelo.Nombre;
                            dataGridView1.Rows.Add(RowModelo);
                        }
                    } else
                    {
                        MessageBox.Show("La marca no posee modelos");
                    }

                }

            }
        }
        //BOTON GRABAR
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.EsMarcaNueva)
            {
                bool _estaActivo ;
                if (comboBox1.Text == "Activo")
                {
                    _estaActivo = true;
                }
                else
                {
                    _estaActivo = false;
                }
                var MarcaGrabar = new Marca
                {
                    Nombre = textBox2.Text,
                    Descripcion = richTextBox1.Text,
                    EstasActivo = _estaActivo
                    
                };
                _Contexto.Marcas.Add(MarcaGrabar);
                _Contexto.SaveChanges();
                MessageBox.Show("Marca NUEVA grabada con exito.");
                this.EsMarcaNueva = false;
            }
            this.Disable_All_Controls();
            this.Clear_All_Controls();
        }

        //BOTON NUEVO
        private void button1_Click(object sender, EventArgs e)
        {
            this.EsMarcaNueva = true;
            this.Clear_All_Controls();
            this.Enable_All_Controls();
        }
        //LOAD DE LA FORMA
        private void Marcas_Load(object sender, EventArgs e)
        {
            this.Disable_All_Controls();
        }
        //BOTON NUEVO MODELO
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor seleccione una Marca");
            }
            else
            {
                using (Modelos WFM = new Modelos())
                {
                    if (WFM.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }

        
    }
    private void Disable_All_Controls()
        {
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.richTextBox1.Enabled = false;
            this.comboBox1.Enabled = false;
        }
        private void Enable_All_Controls()
        {

            this.textBox2.Enabled = true;
            this.richTextBox1.Enabled = true;
            this.comboBox1.Enabled = true;
        }
        private void Clear_All_Controls()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.richTextBox1.Text = "";
            this.comboBox1.Text = "";
        }
    }
}

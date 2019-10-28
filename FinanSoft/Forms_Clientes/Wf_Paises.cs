using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using FinanSoft.Models.Clientes;


namespace FinanSoft.Forms_Clientes
{
    public partial class Wf_Paises : Form
    {
        ///Definicion de Varables
        //Variables Publicas
        public int IdPais;
        public string NombrePais;
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        //Variables Privadas
        bool _PaisNuevo = false;
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private DB_Context _contexto = new DB_Context();
        public Wf_Paises()
        {
            InitializeComponent();
        }

       

        private void Wf_Paises_Load(object sender, EventArgs e)
        {
            this.ClearAll("all");
            this.LoadListaPaises();
            this.DisableAll();
        }
        //Metodos loads por el programador para llenar datagrid de Paises
        //llenar datagridPaises
        private void LoadListaPaises()
        {
            _contexto.Dispose();
            _contexto = new DB_Context();
            var ListaPaises = _contexto.Paises.ToList();
            //= _contexto.Marcas.ToList(m => m.); 

            if (ListaPaises != null)
            {
                string[] item = new string[2];
                foreach (var ListPaises in ListaPaises)
                {
                    item[0] = ListPaises.Id_Pais.ToString();
                    item[1] = ListPaises.Nombre;
                    dgv_ListadoPaises.Rows.Add(item);

                }
            }
        }
        private void ClearAll(string tipo)
        {
            if (tipo == "all")
            {
                txt_IdPais.Text = "";
                txt_NombrePais.Text = "";
                rtb_DesPais.Text = "";
                ckb_EstaAciva.Checked = false;
                string[] ListadoPaises = new string[5];
               dgv_ListadoPaises.Rows.Clear();
                ListadoPaises[0] = "X";
                ListadoPaises[1] = "Agregar Nuevo";
                dgv_ListadoPaises.Rows.Add(ListadoPaises);

            }
            else
            {
                txt_IdPais.Text = "";
                txt_NombrePais.Text = "";
                rtb_DesPais.Text = "";
                ckb_EstaAciva.Checked = false;

            }

        }
       
        //// funciones para habilitar y sehabilitar controles
        private void EnableAll()
        {
            //txt_Id.Enabled = true;
            txt_NombrePais.Enabled = true;
            rtb_DesPais.Enabled = true;
            ckb_EstaAciva.Enabled = true;
            //dgv_ListadoTipos.Rows.Clear();

        }
        private void DisableAll()
        {
            txt_IdPais.Enabled = false;
            txt_NombrePais.Enabled = false;
            rtb_DesPais.Enabled = false;
            ckb_EstaAciva.Enabled = false;


        }
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //Event Controls de Visual

        private void btn_GrabarMarca_Click(object sender, EventArgs e)
        {
            if (_PaisNuevo)
            {
                _contexto.Dispose();
                _contexto = new DB_Context();
                var NuevoPais = new Pais
                {
                    Nombre = txt_NombrePais.Text,
                    Descripcion =rtb_DesPais.Text,
                    EstaActiva = ckb_EstaAciva.Checked
                };
                _contexto.Paises.Add(NuevoPais);
                _contexto.SaveChanges();
                MessageBox.Show(" Pais ha sido creado exitosamente");
                this.ClearAll("all");
                this.LoadListaPaises();


            }
            else

            {
                _contexto.Dispose();
                _contexto = new DB_Context();
                int IdPais = int.Parse(txt_IdPais.Text);
          
                var ModificarPias = _contexto.Paises.FirstOrDefault(p=>p.Id_Pais==IdPais);
               ModificarPias.Nombre = txt_NombrePais.Text;
               ModificarPias.Descripcion = rtb_DesPais.Text;
               ModificarPias.EstaActiva = ckb_EstaAciva.Checked;
                _contexto.SaveChanges();
                MessageBox.Show("Pais ha sido Modificado exitosamente");
                //this.DisableAll();
                this.ClearAll("all");
                this.LoadListaPaises();
            }

        }

        private void dgv_ListadoPaises_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Selecciona un Tipo");

            }
            else
            {
                 this.EnableAll();
                if (dgv_ListadoPaises.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
                {


                  
                    
                    this.txt_NombrePais.Focus();
                    this.EnableAll();
                    this.ClearAll("");
                    _PaisNuevo = true;


                }
                else
                {

                   this.IdPais = int.Parse(dgv_ListadoPaises.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var Pais = _contexto.Paises.FirstOrDefault(p => p.Id_Pais == IdPais);

                    if (Pais != null)
                    {
                        this.DisableAll();
                        txt_IdPais.Text = Pais.Id_Pais.ToString();
                        txt_NombrePais.Text = Pais.Nombre;
                        rtb_DesPais.Text = Pais.Descripcion;
                        ckb_EstaAciva.Checked = Pais.EstaActiva;



                    }
                    this._PaisNuevo = false;

                }


            }
        }

        private void btn_ActualizarPais_Click(object sender, EventArgs e)
        {
            this.EnableAll();
        }

        private void btn_ListadoEstados_Click(object sender, EventArgs e)
        {
            if (txt_IdPais.Text != "")
            {
                using (Wf_Estados WFES = new Wf_Estados())

                {

                    WFES.IdPais = int.Parse(txt_IdPais.Text);
                    WFES.NombrePais =txt_NombrePais.Text;
                    if (WFES.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("OK");
                    }
                };


            }
            else
            {
                MessageBox.Show("Seleccione un Pais");
            }
        }

        private void Wf_Paises_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

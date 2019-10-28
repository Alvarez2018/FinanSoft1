using FinanSoft.Forms_Clientes;
using FinanSoft.Models.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanSoft
{
    public partial class WF_Marcas : Form

    {

        ///Definicion de Varables
        //Variables Publicas
        public int IdTipoArticulo;
        public string NombreTipoArticulo;
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        //Variables Privadas
        bool _MarcaNueva = false;
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::



        private DB_Context _contexto = new DB_Context();
        public WF_Marcas()
        {
            InitializeComponent();
        }

        private void WF_Marcas_Load(object sender, EventArgs e)
        {
            lbl_NombreTipoArticulo.Text = NombreTipoArticulo;
            this.ClearAll("all");
            this.LoadListaMarcas();
            this.DisableAll();
        }
        //Metodos y Funciones Del Programador
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private void ClearAll(string tipo)
        {
            if (tipo == "all")
            {
                txt_IdMarca.Text = "";
                txt_NombreMarca.Text = "";
                rtb_DesMarca.Text = "";
                ckb_EstaAciva.Checked = false;
                string[] ListadoMarcas = new string[5];
                dgv_ListadoMarcas.Rows.Clear();
                ListadoMarcas[0] = "X";
                ListadoMarcas[1] = "Agregar Nuevo";
                dgv_ListadoMarcas.Rows.Add(ListadoMarcas);

            }
            else
            {
                txt_IdMarca.Text = "";
                txt_NombreMarca.Text = "";
                rtb_DesMarca.Text = "";
                ckb_EstaAciva.Checked = false;

                string[] ListadoMarcas = new string[5];

                dgv_ListadoMarcas.Rows.Clear();
                ListadoMarcas[0] = "X";
                ListadoMarcas[1] = "Agregar Nuevo";
            }

        }
        private void EnableAll()
        {
            //txt_Id.Enabled = true;
            txt_NombreMarca.Enabled = true;
            rtb_DesMarca.Enabled = true;
            ckb_EstaAciva.Enabled = true;
            //dgv_ListadoTipos.Rows.Clear();

        }
      private void DisableAll()
        {
            txt_IdMarca.Enabled = false;
            txt_NombreMarca.Enabled = false;
            rtb_DesMarca.Enabled = false;
            ckb_EstaAciva.Enabled = false;


        }


        ///::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private void LoadListaMarcas()
        {
            _contexto.Dispose();
            _contexto = new DB_Context();
            var ListaMarcas = _contexto.Marcas.Include(m => m.TipoArticulo).ToList().Where(m => m.TipoArticulo.Id_TipoArticulo == IdTipoArticulo);
             //= _contexto.Marcas.ToList(m => m.); 

            if (ListaMarcas != null)
            {
                string[] item = new string[2];
                foreach (var ListMarcas in ListaMarcas)
                {
                    item[0] = ListMarcas.Id_Marca.ToString();
                    item[1] = ListMarcas.Nombre;
                    dgv_ListadoMarcas.Rows.Add(item);
                }
            }
        }

        /// Metodos de Visual para los controles 
       //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private void dgv_ListadoMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Selecciona un Tipo");
              
            }
            else
            {
               // this.EnableAll();
                if (dgv_ListadoMarcas.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
                {
                    this.ClearAll("");
                   _MarcaNueva = true;
                    this.txt_NombreMarca.Focus();
                    MessageBox.Show("Creando Marca Nueva Para el Tipo de Articulo : "+NombreTipoArticulo);
                    txt_NombreMarca.Focus();
                    this.EnableAll();
                    this.ClearAll(" ");
                    //this.dgv_ListadoMarcas.Rows.Clear();
                    this.LoadListaMarcas();
              


                }
                else
                {
                   
                    var idMarca = int.Parse(dgv_ListadoMarcas.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var Marca = _contexto.Marcas.FirstOrDefault(M => M.Id_Marca ==idMarca);
                    
                    if (Marca != null)
                    {
                        this.DisableAll();
                        txt_IdMarca.Text = Marca.Id_Marca.ToString();
                        txt_NombreMarca.Text = Marca.Nombre;
                        rtb_DesMarca.Text = Marca.Descripcion;
                        ckb_EstaAciva.Checked = Marca.EstasActivo;
                      
                        

                    }
                    this._MarcaNueva = false;

                }


            }
        }
        //Para ir a la ventana de los Modelos Asociados a la Marca
        private void btn_ListadoModelos_Click(object sender, EventArgs e)
        {
            if (txt_IdMarca.Text != "")
            {
                using (Wf_Modelos WFMO = new Wf_Modelos())

                {

                    WFMO.IDMarca = int.Parse(txt_IdMarca.Text);
                    WFMO.NombreMarcaModelo = txt_NombreMarca.Text;
                    if (WFMO.ShowDialog() == DialogResult.OK)
                    {

                    }
                };


            }
            else
            {
                MessageBox.Show("Seleccione un Tipo de Articulo");
            }

        }
        private void btn_GrabarMarca_Click(object sender, EventArgs e)
        {
         
            if (_MarcaNueva)
            {
                _contexto.Dispose();
                _contexto = new DB_Context();
                var TipoArtiMod = _contexto.TipoArticulos.Include(m => m.Marcas).FirstOrDefault(t => t.Id_TipoArticulo == IdTipoArticulo);
                var NuevaMarca = new Marca
                {
                    Nombre = txt_NombreMarca.Text,
                    Descripcion = rtb_DesMarca.Text,
                    EstasActivo = ckb_EstaAciva.Checked,
                    TipoArticulo = TipoArtiMod

                };
                _contexto.Marcas.Add(NuevaMarca);

                _contexto.SaveChanges();
                MessageBox.Show(" Tipo de Marca ha sido creado exitosamente");
                this.ClearAll("all");
                this.LoadListaMarcas();
            }

            else

            {
                _contexto.Dispose();
                _contexto = new DB_Context();
               
                int IdMarcaArticulo = int.Parse(txt_IdMarca.Text);
                var ModificarMarca = _contexto.Marcas.FirstOrDefault(ma => ma.Id_Marca == IdMarcaArticulo);


                ModificarMarca.Nombre = txt_NombreMarca.Text;
                ModificarMarca.Descripcion = rtb_DesMarca.Text;
                ModificarMarca.EstasActivo = ckb_EstaAciva.Checked;

                _contexto.SaveChanges();
                MessageBox.Show("Marca a  sido Modificado exitosamente :");
                this.ClearAll("all");
                this.LoadListaMarcas();
           
            }
        }

        private void btn_ActualizarMarcas_Click(object sender, EventArgs e)
        {
            this.EnableAll();

        }


        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    }
}

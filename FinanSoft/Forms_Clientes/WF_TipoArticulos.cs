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

namespace FinanSoft.Forms_Clientes
{
    public partial class WF_TipoArticulos : Form
    {
        public int IdMarca;
        private bool _tipoArticulosNueno = false;

        private DB_Context _contexto = new DB_Context();
        public WF_TipoArticulos()
        {
            InitializeComponent();
        }

        private void WF_TipoArticulos_Load(object sender, EventArgs e)
        {
            this.ClearAll("all");
            
            this.LoadListaArticulos();
            this.DisableAll();

        }

        private void ClearAll(string tipo)
        {
            if (tipo == "all")
            {
                txt_Id.Text = "";
                txt_Nombre.Text = "";
                rtb_Descripcion.Text = "";
                ckb_EstaAciva.Checked = false;
                string[] ListadoTiposArticulos = new string[5];
                dgv_ListadoTipos.Rows.Clear();
                ListadoTiposArticulos[0] = "X";
                ListadoTiposArticulos[1] = "Agregar Nuevo";
                dgv_ListadoTipos.Rows.Add(ListadoTiposArticulos);
            }
            else
            {
                txt_Id.Text = "";
                txt_Nombre.Text = "";
                rtb_Descripcion.Text = "";
                ckb_EstaAciva.Checked = false;
                

            }
            
        }
        private void EnableAll()
        {
            //txt_Id.Enabled = true;
            txt_Nombre.Enabled = true;
            rtb_Descripcion.Enabled = true;
            ckb_EstaAciva.Enabled = true;
            //dgv_ListadoTipos.Rows.Clear();
            
        }
        private void DisableAll()
        {
            txt_Id.Enabled = false;
            txt_Nombre.Enabled = false;
            rtb_Descripcion.Enabled = false;
            ckb_EstaAciva.Enabled = false;
            
            
        }
        private void LoadListaArticulos ()
        {
            var ListaTipoArticulos = _contexto.TipoArticulos.ToList();

            if (ListaTipoArticulos != null)
            {
                string[] item = new string[2];
                foreach(var ListaArticulo in ListaTipoArticulos)
                {
                    item[0] = ListaArticulo.Id_TipoArticulo.ToString();
                    item[1] = ListaArticulo.Nombre;
                    dgv_ListadoTipos.Rows.Add(item);
                }
            }
        }

        private void dgv_ListadoTipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Selecciona un Tipo");
            }
            else
            {
                this.EnableAll();
                if (dgv_ListadoTipos.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
                {
                    //this.ClearAll("");
                    _tipoArticulosNueno = true;
                    this.txt_Nombre.Focus();
                    this.EnableAll();
                    this.ClearAll("Solo formulario");
                    //this.dgv_ListadoTipos.Rows.Clear();
                    this._tipoArticulosNueno = true;

                   


                }
                else
                {
                    var idTipoArticulo = int.Parse(dgv_ListadoTipos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var TipoArticulo = _contexto.TipoArticulos.FirstOrDefault(a => a.Id_TipoArticulo == idTipoArticulo);
                    if (TipoArticulo != null)
                    {
                        this.DisableAll();
                        txt_Id.Text = TipoArticulo.Id_TipoArticulo.ToString();
                        txt_Nombre.Text = TipoArticulo.Nombre;
                        rtb_Descripcion.Text = TipoArticulo.Descripcion;
                        ckb_EstaAciva.Checked = TipoArticulo.EstasActivo;
                        
                    }
                    this._tipoArticulosNueno = false;

                }


            }
        }

        private void btn_GrabarTipo_Click(object sender, EventArgs e)
        {
            if (_tipoArticulosNueno)
            {
                _contexto.Dispose();
                _contexto = new DB_Context();
                var NuevoTipoArticulo = new TipoArticulo
                {
                    Nombre = txt_Nombre.Text,
                    Descripcion = rtb_Descripcion.Text,
                    EstasActivo = ckb_EstaAciva.Checked
                };
                _contexto.TipoArticulos.Add(NuevoTipoArticulo);
                _contexto.SaveChanges();
                MessageBox.Show(" Tipo de articulo ha sido creado exitosamente");
                this.ClearAll("all");
                this.LoadListaArticulos();


            }
            else

            {
                _contexto.Dispose();
                _contexto = new DB_Context();
                int IdTipoArticulo = int.Parse(txt_Id.Text);
                var ModificarTipoArticulo = _contexto.TipoArticulos.FirstOrDefault(t => t.Id_TipoArticulo ==IdTipoArticulo);
                ModificarTipoArticulo.Nombre = txt_Nombre.Text;
                ModificarTipoArticulo.Descripcion = rtb_Descripcion.Text;
                ModificarTipoArticulo.EstasActivo = ckb_EstaAciva.Checked;
                _contexto.SaveChanges();
                MessageBox.Show(" Tipo de articulo ha sido Modificado exitosamente");
                this.ClearAll("all");
                this.LoadListaArticulos();
            }
            
        }

        private void WF_TipoArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_ListadoMarcas_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text !="" )
            {
                using (WF_Marcas WFM = new WF_Marcas())

                {

                    WFM.IdTipoArticulo = int.Parse(txt_Id.Text);
                    WFM.NombreTipoArticulo = txt_Nombre.Text;
                    if (WFM.ShowDialog() == DialogResult.OK)
                    {
                      
                    }
                };


            } else
            {
                MessageBox.Show("Seleccione un Tipo de Articulo");
            }




        }

        private void btn_ActualizarArticulo_Click(object sender, EventArgs e)
        {
            this.EnableAll();
        }
    }
}

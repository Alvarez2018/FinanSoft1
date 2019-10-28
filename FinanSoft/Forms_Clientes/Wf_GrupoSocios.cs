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
    public partial class Wf_GrupoSocio : Form
    {
        private bool esGrupoNuevo = false;
        private DB_Context _Contexto = new DB_Context();
        public Wf_GrupoSocio()
        {
            InitializeComponent();
        }



        private void Wf_GruposClientes_Load(object sender, EventArgs e)
        {
            this.disableAll();
            this.ActualizarListadoGruposClientes();



        }



        private void btn_Grabar_Click_1(object sender, EventArgs e)
        {
            if (this.esGrupoNuevo)
            {
                var grupoSocio  = new GrupoSocio{
                    
                    Nombre = txt_Nombre.Text,
                    Descripcion = rtb_Descripcion.Text,
                    EstaActivo = cb_EstaActivo.Checked

                };
                _Contexto.GrupoClientes.Add(grupoSocio);
                _Contexto.SaveChanges();
                this.ActualizarListadoGruposClientes();
                this.disableAll();
                this.clearAll();
            }
            else
            {
                var idGrupo = int.Parse(txt_Id.Text);
                var grupoCliente = _Contexto.GrupoClientes.FirstOrDefault(t => t.Id == idGrupo);
                grupoCliente.Nombre = txt_Nombre.Text;
                grupoCliente.Descripcion = rtb_Descripcion.Text;
                grupoCliente.EstaActivo = cb_EstaActivo.Checked;
                _Contexto.SaveChanges();
                this.ActualizarListadoGruposClientes();
                this.disableAll();
                this.clearAll();
            }


            this.esGrupoNuevo = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.enableAll();
            this.esGrupoNuevo = true;
        }

        private void ActualizarListadoGruposClientes()
        {
            dgv_Grupos.Rows.Clear();
            var listadoGruposSocios = _Contexto.GrupoClientes.ToList();

            string[] listadoDespliega = new string[5];
            if (listadoGruposSocios != null)
            {
                foreach (var Grupo in listadoGruposSocios)
                {
                    listadoDespliega[0] = Grupo.Id.ToString();
                    listadoDespliega[1] = Grupo.Nombre;
                    dgv_Grupos.Rows.Add(listadoDespliega);
                }
            }
        }


        private void disableAll()
        {
            txt_Id.Enabled = false;
            txt_Nombre.Enabled = false;
            rtb_Descripcion.Enabled = false;
            cb_EstaActivo.Enabled = false;

        }

        private void enableAll()
        {

            txt_Nombre.Enabled = true;
            rtb_Descripcion.Enabled = true;
            cb_EstaActivo.Enabled = true;

        }
        private void clearAll()
        {
            txt_Id.Text = "";
            txt_Nombre.Text = "";
            rtb_Descripcion.Text = "";
            cb_EstaActivo.Checked = false;

        }

        private void dgv_Grupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Selecciona un item");
            }
            else
            {
                this.enableAll();
                var IdGrupo = int.Parse(dgv_Grupos.Rows[e.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show(IdGrupo.ToString());
                var GrupoSocio  = _Contexto.GrupoClientes.FirstOrDefault(t => t.Id == IdGrupo);
                txt_Id.Text = GrupoSocio.Id.ToString();
                txt_Nombre.Text = GrupoSocio.Nombre;
                rtb_Descripcion.Text = GrupoSocio.Descripcion;
                cb_EstaActivo.Checked = GrupoSocio.EstaActivo;
            }
        }

        private void Wf_GrupoSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }
    }
}

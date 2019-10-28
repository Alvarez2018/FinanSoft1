namespace FinanSoft.Forms_Clientes
{
    partial class Wf_TiposSocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.dgv_Grupos = new System.Windows.Forms.DataGridView();
            this.id_TipoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_TipoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_EstaActivo = new System.Windows.Forms.CheckBox();
            this.btn_Grabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grupos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(430, 45);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 1;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(430, 71);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(173, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion:";
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Location = new System.Drawing.Point(430, 102);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(173, 96);
            this.rtb_Descripcion.TabIndex = 5;
            this.rtb_Descripcion.Text = "";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(337, 353);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 6;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // dgv_Grupos
            // 
            this.dgv_Grupos.AllowUserToAddRows = false;
            this.dgv_Grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Grupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_TipoSocio,
            this.nombre_TipoSocio});
            this.dgv_Grupos.Location = new System.Drawing.Point(26, 45);
            this.dgv_Grupos.Name = "dgv_Grupos";
            this.dgv_Grupos.Size = new System.Drawing.Size(240, 341);
            this.dgv_Grupos.TabIndex = 7;
            this.dgv_Grupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Grupos_CellDoubleClick);
            // 
            // id_TipoSocio
            // 
            this.id_TipoSocio.HeaderText = "Id";
            this.id_TipoSocio.Name = "id_TipoSocio";
            this.id_TipoSocio.Visible = false;
            // 
            // nombre_TipoSocio
            // 
            this.nombre_TipoSocio.HeaderText = "Nombre";
            this.nombre_TipoSocio.Name = "nombre_TipoSocio";
            this.nombre_TipoSocio.ReadOnly = true;
            this.nombre_TipoSocio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cb_EstaActivo
            // 
            this.cb_EstaActivo.AutoSize = true;
            this.cb_EstaActivo.Location = new System.Drawing.Point(361, 250);
            this.cb_EstaActivo.Name = "cb_EstaActivo";
            this.cb_EstaActivo.Size = new System.Drawing.Size(80, 17);
            this.cb_EstaActivo.TabIndex = 8;
            this.cb_EstaActivo.Text = "Esta Activo";
            this.cb_EstaActivo.UseVisualStyleBackColor = true;
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(430, 353);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar.TabIndex = 9;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click_1);
            // 
            // Wf_TiposSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.cb_EstaActivo);
            this.Controls.Add(this.dgv_Grupos);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.rtb_Descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label1);
            this.Name = "Wf_TiposSocios";
            this.Text = "Tipos Socios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Wf_TiposSocios_FormClosed);
            this.Load += new System.EventHandler(this.Wf_GruposClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridView dgv_Grupos;
        private System.Windows.Forms.CheckBox cb_EstaActivo;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_TipoSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_TipoSocio;
    }
}
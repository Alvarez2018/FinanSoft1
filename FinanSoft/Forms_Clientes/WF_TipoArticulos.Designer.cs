namespace FinanSoft.Forms_Clientes
{
    partial class WF_TipoArticulos
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
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.ckb_EstaAciva = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ListadoTipos = new System.Windows.Forms.DataGridView();
            this.Id_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarArticulo = new System.Windows.Forms.Button();
            this.btn_ListadoMarcas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_NuevoTipo = new System.Windows.Forms.Button();
            this.btn_GrabarTipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoTipos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(95, 20);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 0;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(95, 46);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Location = new System.Drawing.Point(95, 72);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(186, 96);
            this.rtb_Descripcion.TabIndex = 2;
            this.rtb_Descripcion.Text = "";
            // 
            // ckb_EstaAciva
            // 
            this.ckb_EstaAciva.AutoSize = true;
            this.ckb_EstaAciva.Location = new System.Drawing.Point(30, 174);
            this.ckb_EstaAciva.Name = "ckb_EstaAciva";
            this.ckb_EstaAciva.Size = new System.Drawing.Size(80, 17);
            this.ckb_EstaAciva.TabIndex = 3;
            this.ckb_EstaAciva.Text = "Esta Activa";
            this.ckb_EstaAciva.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion:";
            // 
            // dgv_ListadoTipos
            // 
            this.dgv_ListadoTipos.AllowUserToAddRows = false;
            this.dgv_ListadoTipos.AllowUserToDeleteRows = false;
            this.dgv_ListadoTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Tipo,
            this.NombreTipo});
            this.dgv_ListadoTipos.Location = new System.Drawing.Point(24, 68);
            this.dgv_ListadoTipos.Name = "dgv_ListadoTipos";
            this.dgv_ListadoTipos.ReadOnly = true;
            this.dgv_ListadoTipos.Size = new System.Drawing.Size(240, 308);
            this.dgv_ListadoTipos.TabIndex = 7;
            this.dgv_ListadoTipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoTipos_CellDoubleClick);
            // 
            // Id_Tipo
            // 
            this.Id_Tipo.HeaderText = "Id";
            this.Id_Tipo.Name = "Id_Tipo";
            this.Id_Tipo.ReadOnly = true;
            this.Id_Tipo.Visible = false;
            // 
            // NombreTipo
            // 
            this.NombreTipo.HeaderText = "Nombre";
            this.NombreTipo.Name = "NombreTipo";
            this.NombreTipo.ReadOnly = true;
            this.NombreTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ActualizarArticulo);
            this.groupBox1.Controls.Add(this.btn_ListadoMarcas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtb_Descripcion);
            this.groupBox1.Controls.Add(this.ckb_EstaAciva);
            this.groupBox1.Location = new System.Drawing.Point(292, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 272);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Tipo Articulo";
            // 
            // btn_ActualizarArticulo
            // 
            this.btn_ActualizarArticulo.Location = new System.Drawing.Point(83, 219);
            this.btn_ActualizarArticulo.Name = "btn_ActualizarArticulo";
            this.btn_ActualizarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btn_ActualizarArticulo.TabIndex = 8;
            this.btn_ActualizarArticulo.Text = "Actualizar";
            this.btn_ActualizarArticulo.UseVisualStyleBackColor = true;
            this.btn_ActualizarArticulo.Click += new System.EventHandler(this.btn_ActualizarArticulo_Click);
            // 
            // btn_ListadoMarcas
            // 
            this.btn_ListadoMarcas.Location = new System.Drawing.Point(224, 219);
            this.btn_ListadoMarcas.Name = "btn_ListadoMarcas";
            this.btn_ListadoMarcas.Size = new System.Drawing.Size(75, 23);
            this.btn_ListadoMarcas.TabIndex = 7;
            this.btn_ListadoMarcas.Text = "Marcas";
            this.btn_ListadoMarcas.UseVisualStyleBackColor = true;
            this.btn_ListadoMarcas.Click += new System.EventHandler(this.btn_ListadoMarcas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Listado de Tipos de Aticulos";
            // 
            // btn_NuevoTipo
            // 
            this.btn_NuevoTipo.Location = new System.Drawing.Point(72, 415);
            this.btn_NuevoTipo.Name = "btn_NuevoTipo";
            this.btn_NuevoTipo.Size = new System.Drawing.Size(75, 23);
            this.btn_NuevoTipo.TabIndex = 8;
            this.btn_NuevoTipo.Text = "Nuevo Tipo";
            this.btn_NuevoTipo.UseVisualStyleBackColor = true;
            // 
            // btn_GrabarTipo
            // 
            this.btn_GrabarTipo.Location = new System.Drawing.Point(387, 357);
            this.btn_GrabarTipo.Name = "btn_GrabarTipo";
            this.btn_GrabarTipo.Size = new System.Drawing.Size(110, 39);
            this.btn_GrabarTipo.TabIndex = 9;
            this.btn_GrabarTipo.Text = "Grabar";
            this.btn_GrabarTipo.UseVisualStyleBackColor = true;
            this.btn_GrabarTipo.Click += new System.EventHandler(this.btn_GrabarTipo_Click);
            // 
            // WF_TipoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.btn_GrabarTipo);
            this.Controls.Add(this.btn_NuevoTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_ListadoTipos);
            this.Name = "WF_TipoArticulos";
            this.Text = "Tipo Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WF_TipoArticulos_FormClosed);
            this.Load += new System.EventHandler(this.WF_TipoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoTipos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
        private System.Windows.Forms.CheckBox ckb_EstaAciva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ListadoTipos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ListadoMarcas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_NuevoTipo;
        private System.Windows.Forms.Button btn_GrabarTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipo;
        private System.Windows.Forms.Button btn_ActualizarArticulo;
    }
}
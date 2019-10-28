namespace FinanSoft
{
    partial class WF_Marcas
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
            this.dgv_ListadoMarcas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarMarcas = new System.Windows.Forms.Button();
            this.btn_ListadoModelos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_DesMarca = new System.Windows.Forms.RichTextBox();
            this.ckb_EstaAciva = new System.Windows.Forms.CheckBox();
            this.btn_GrabarMarca = new System.Windows.Forms.Button();
            this.lbl_NombreTipoArticulo = new System.Windows.Forms.Label();
            this.lbl_IdTipo = new System.Windows.Forms.Label();
            this.Id_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoMarcas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Marcas";
            // 
            // dgv_ListadoMarcas
            // 
            this.dgv_ListadoMarcas.AllowUserToAddRows = false;
            this.dgv_ListadoMarcas.AllowUserToDeleteRows = false;
            this.dgv_ListadoMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Marca,
            this.Marcas});
            this.dgv_ListadoMarcas.Location = new System.Drawing.Point(39, 69);
            this.dgv_ListadoMarcas.Name = "dgv_ListadoMarcas";
            this.dgv_ListadoMarcas.Size = new System.Drawing.Size(240, 321);
            this.dgv_ListadoMarcas.TabIndex = 1;
            this.dgv_ListadoMarcas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoMarcas_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ActualizarMarcas);
            this.groupBox1.Controls.Add(this.btn_ListadoModelos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_IdMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NombreMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtb_DesMarca);
            this.groupBox1.Controls.Add(this.ckb_EstaAciva);
            this.groupBox1.Location = new System.Drawing.Point(307, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 272);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Marcas";
            // 
            // btn_ActualizarMarcas
            // 
            this.btn_ActualizarMarcas.Location = new System.Drawing.Point(76, 225);
            this.btn_ActualizarMarcas.Name = "btn_ActualizarMarcas";
            this.btn_ActualizarMarcas.Size = new System.Drawing.Size(75, 23);
            this.btn_ActualizarMarcas.TabIndex = 8;
            this.btn_ActualizarMarcas.Text = "Actualizar";
            this.btn_ActualizarMarcas.UseVisualStyleBackColor = true;
            this.btn_ActualizarMarcas.Click += new System.EventHandler(this.btn_ActualizarMarcas_Click);
            // 
            // btn_ListadoModelos
            // 
            this.btn_ListadoModelos.Location = new System.Drawing.Point(218, 225);
            this.btn_ListadoModelos.Name = "btn_ListadoModelos";
            this.btn_ListadoModelos.Size = new System.Drawing.Size(75, 23);
            this.btn_ListadoModelos.TabIndex = 7;
            this.btn_ListadoModelos.Text = "Modelos";
            this.btn_ListadoModelos.UseVisualStyleBackColor = true;
            this.btn_ListadoModelos.Click += new System.EventHandler(this.btn_ListadoModelos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id:";
            // 
            // txt_IdMarca
            // 
            this.txt_IdMarca.Location = new System.Drawing.Point(95, 20);
            this.txt_IdMarca.Name = "txt_IdMarca";
            this.txt_IdMarca.ReadOnly = true;
            this.txt_IdMarca.Size = new System.Drawing.Size(100, 20);
            this.txt_IdMarca.TabIndex = 0;
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
            // txt_NombreMarca
            // 
            this.txt_NombreMarca.Location = new System.Drawing.Point(95, 46);
            this.txt_NombreMarca.Name = "txt_NombreMarca";
            this.txt_NombreMarca.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreMarca.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre:";
            // 
            // rtb_DesMarca
            // 
            this.rtb_DesMarca.Location = new System.Drawing.Point(95, 72);
            this.rtb_DesMarca.Name = "rtb_DesMarca";
            this.rtb_DesMarca.Size = new System.Drawing.Size(186, 96);
            this.rtb_DesMarca.TabIndex = 2;
            this.rtb_DesMarca.Text = "";
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
            // btn_GrabarMarca
            // 
            this.btn_GrabarMarca.Location = new System.Drawing.Point(409, 367);
            this.btn_GrabarMarca.Name = "btn_GrabarMarca";
            this.btn_GrabarMarca.Size = new System.Drawing.Size(146, 40);
            this.btn_GrabarMarca.TabIndex = 11;
            this.btn_GrabarMarca.Text = "Grabar";
            this.btn_GrabarMarca.UseVisualStyleBackColor = true;
            this.btn_GrabarMarca.Click += new System.EventHandler(this.btn_GrabarMarca_Click);
            // 
            // lbl_NombreTipoArticulo
            // 
            this.lbl_NombreTipoArticulo.AutoSize = true;
            this.lbl_NombreTipoArticulo.Location = new System.Drawing.Point(153, 29);
            this.lbl_NombreTipoArticulo.Name = "lbl_NombreTipoArticulo";
            this.lbl_NombreTipoArticulo.Size = new System.Drawing.Size(10, 13);
            this.lbl_NombreTipoArticulo.TabIndex = 12;
            this.lbl_NombreTipoArticulo.Text = ".";
            // 
            // lbl_IdTipo
            // 
            this.lbl_IdTipo.AutoSize = true;
            this.lbl_IdTipo.Location = new System.Drawing.Point(36, 38);
            this.lbl_IdTipo.Name = "lbl_IdTipo";
            this.lbl_IdTipo.Size = new System.Drawing.Size(0, 13);
            this.lbl_IdTipo.TabIndex = 13;
            // 
            // Id_Marca
            // 
            this.Id_Marca.HeaderText = "Id_Marca";
            this.Id_Marca.Name = "Id_Marca";
            this.Id_Marca.ReadOnly = true;
            this.Id_Marca.Visible = false;
            // 
            // Marcas
            // 
            this.Marcas.HeaderText = "Marcas";
            this.Marcas.Name = "Marcas";
            this.Marcas.ReadOnly = true;
            // 
            // WF_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.lbl_IdTipo);
            this.Controls.Add(this.lbl_NombreTipoArticulo);
            this.Controls.Add(this.btn_GrabarMarca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_ListadoMarcas);
            this.Controls.Add(this.label1);
            this.Name = "WF_Marcas";
            this.Text = "WF_Marcas";
            this.Load += new System.EventHandler(this.WF_Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoMarcas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ListadoMarcas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ListadoModelos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_DesMarca;
        private System.Windows.Forms.CheckBox ckb_EstaAciva;
        private System.Windows.Forms.Button btn_GrabarMarca;
        private System.Windows.Forms.Label lbl_NombreTipoArticulo;
        private System.Windows.Forms.Label lbl_IdTipo;
        private System.Windows.Forms.Button btn_ActualizarMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marcas;
    }
}
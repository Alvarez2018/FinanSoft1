namespace FinanSoft.Forms_Clientes
{
    partial class Wf_Paises
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
            this.btn_GrabarMarca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarPais = new System.Windows.Forms.Button();
            this.btn_ListadoEstados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombrePais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_DesPais = new System.Windows.Forms.RichTextBox();
            this.ckb_EstaAciva = new System.Windows.Forms.CheckBox();
            this.dgv_ListadoPaises = new System.Windows.Forms.DataGridView();
            this.Id_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GrabarMarca
            // 
            this.btn_GrabarMarca.Location = new System.Drawing.Point(412, 362);
            this.btn_GrabarMarca.Name = "btn_GrabarMarca";
            this.btn_GrabarMarca.Size = new System.Drawing.Size(146, 40);
            this.btn_GrabarMarca.TabIndex = 17;
            this.btn_GrabarMarca.Text = "Grabar";
            this.btn_GrabarMarca.UseVisualStyleBackColor = true;
            this.btn_GrabarMarca.Click += new System.EventHandler(this.btn_GrabarMarca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ActualizarPais);
            this.groupBox1.Controls.Add(this.btn_ListadoEstados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_IdPais);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NombrePais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtb_DesPais);
            this.groupBox1.Controls.Add(this.ckb_EstaAciva);
            this.groupBox1.Location = new System.Drawing.Point(310, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 272);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Marcas";
            // 
            // btn_ActualizarPais
            // 
            this.btn_ActualizarPais.Location = new System.Drawing.Point(76, 225);
            this.btn_ActualizarPais.Name = "btn_ActualizarPais";
            this.btn_ActualizarPais.Size = new System.Drawing.Size(75, 23);
            this.btn_ActualizarPais.TabIndex = 8;
            this.btn_ActualizarPais.Text = "Actualizar";
            this.btn_ActualizarPais.UseVisualStyleBackColor = true;
            this.btn_ActualizarPais.Click += new System.EventHandler(this.btn_ActualizarPais_Click);
            // 
            // btn_ListadoEstados
            // 
            this.btn_ListadoEstados.Location = new System.Drawing.Point(218, 225);
            this.btn_ListadoEstados.Name = "btn_ListadoEstados";
            this.btn_ListadoEstados.Size = new System.Drawing.Size(75, 23);
            this.btn_ListadoEstados.TabIndex = 7;
            this.btn_ListadoEstados.Text = "Estados";
            this.btn_ListadoEstados.UseVisualStyleBackColor = true;
            this.btn_ListadoEstados.Click += new System.EventHandler(this.btn_ListadoEstados_Click);
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
            // txt_IdPais
            // 
            this.txt_IdPais.Location = new System.Drawing.Point(95, 20);
            this.txt_IdPais.Name = "txt_IdPais";
            this.txt_IdPais.ReadOnly = true;
            this.txt_IdPais.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPais.TabIndex = 0;
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
            // txt_NombrePais
            // 
            this.txt_NombrePais.Location = new System.Drawing.Point(95, 46);
            this.txt_NombrePais.Name = "txt_NombrePais";
            this.txt_NombrePais.Size = new System.Drawing.Size(100, 20);
            this.txt_NombrePais.TabIndex = 1;
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
            // rtb_DesPais
            // 
            this.rtb_DesPais.Location = new System.Drawing.Point(95, 72);
            this.rtb_DesPais.Name = "rtb_DesPais";
            this.rtb_DesPais.Size = new System.Drawing.Size(186, 96);
            this.rtb_DesPais.TabIndex = 2;
            this.rtb_DesPais.Text = "";
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
            // dgv_ListadoPaises
            // 
            this.dgv_ListadoPaises.AllowUserToAddRows = false;
            this.dgv_ListadoPaises.AllowUserToDeleteRows = false;
            this.dgv_ListadoPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Marca,
            this.Marcas});
            this.dgv_ListadoPaises.Location = new System.Drawing.Point(42, 64);
            this.dgv_ListadoPaises.Name = "dgv_ListadoPaises";
            this.dgv_ListadoPaises.Size = new System.Drawing.Size(240, 321);
            this.dgv_ListadoPaises.TabIndex = 15;
            this.dgv_ListadoPaises.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoPaises_CellDoubleClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Listado de Paises";
            // 
            // Wf_Paises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 444);
            this.Controls.Add(this.btn_GrabarMarca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_ListadoPaises);
            this.Controls.Add(this.label1);
            this.Name = "Wf_Paises";
            this.Text = "Wf_Paises";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Wf_Paises_FormClosed);
            this.Load += new System.EventHandler(this.Wf_Paises_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_GrabarMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ActualizarPais;
        private System.Windows.Forms.Button btn_ListadoEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombrePais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_DesPais;
        private System.Windows.Forms.CheckBox ckb_EstaAciva;
        private System.Windows.Forms.DataGridView dgv_ListadoPaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marcas;
        private System.Windows.Forms.Label label1;
    }
}
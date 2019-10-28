namespace FinanSoft.Forms_Clientes
{
    partial class Wf_Modelos
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
            this.lbl_IdTipo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.btn_GrabarTipo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarModelo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.ckb_EstaAciva = new System.Windows.Forms.CheckBox();
            this.dgv_ListadoModelos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IdTipo
            // 
            this.lbl_IdTipo.AutoSize = true;
            this.lbl_IdTipo.Location = new System.Drawing.Point(25, 49);
            this.lbl_IdTipo.Name = "lbl_IdTipo";
            this.lbl_IdTipo.Size = new System.Drawing.Size(0, 13);
            this.lbl_IdTipo.TabIndex = 20;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(139, 20);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(0, 13);
            this.lbl_Marca.TabIndex = 19;
            // 
            // btn_GrabarTipo
            // 
            this.btn_GrabarTipo.Location = new System.Drawing.Point(398, 378);
            this.btn_GrabarTipo.Name = "btn_GrabarTipo";
            this.btn_GrabarTipo.Size = new System.Drawing.Size(179, 38);
            this.btn_GrabarTipo.TabIndex = 18;
            this.btn_GrabarTipo.Text = "Grabar";
            this.btn_GrabarTipo.UseVisualStyleBackColor = true;
            this.btn_GrabarTipo.Click += new System.EventHandler(this.btn_GrabarTipo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ActualizarModelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_IdModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NombreModelo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtb_Descripcion);
            this.groupBox1.Controls.Add(this.ckb_EstaAciva);
            this.groupBox1.Location = new System.Drawing.Point(296, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 272);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Marcas";
            // 
            // btn_ActualizarModelo
            // 
            this.btn_ActualizarModelo.Location = new System.Drawing.Point(220, 217);
            this.btn_ActualizarModelo.Name = "btn_ActualizarModelo";
            this.btn_ActualizarModelo.Size = new System.Drawing.Size(75, 23);
            this.btn_ActualizarModelo.TabIndex = 7;
            this.btn_ActualizarModelo.Text = "Actualizar";
            this.btn_ActualizarModelo.UseVisualStyleBackColor = true;
            this.btn_ActualizarModelo.Click += new System.EventHandler(this.btn_ListadoModelos_Click);
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
            // txt_IdModelo
            // 
            this.txt_IdModelo.Location = new System.Drawing.Point(95, 20);
            this.txt_IdModelo.Name = "txt_IdModelo";
            this.txt_IdModelo.ReadOnly = true;
            this.txt_IdModelo.Size = new System.Drawing.Size(100, 20);
            this.txt_IdModelo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion:";
            // 
            // txt_NombreModelo
            // 
            this.txt_NombreModelo.Location = new System.Drawing.Point(95, 46);
            this.txt_NombreModelo.Name = "txt_NombreModelo";
            this.txt_NombreModelo.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreModelo.TabIndex = 1;
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
            // dgv_ListadoModelos
            // 
            this.dgv_ListadoModelos.AllowUserToAddRows = false;
            this.dgv_ListadoModelos.AllowUserToDeleteRows = false;
            this.dgv_ListadoModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Marca,
            this.Marcas});
            this.dgv_ListadoModelos.Location = new System.Drawing.Point(28, 80);
            this.dgv_ListadoModelos.Name = "dgv_ListadoModelos";
            this.dgv_ListadoModelos.Size = new System.Drawing.Size(240, 321);
            this.dgv_ListadoModelos.TabIndex = 15;
            this.dgv_ListadoModelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoModelos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Listado de Modelos ";
            // 
            // Id_Marca
            // 
            this.Id_Marca.HeaderText = "Id_Modelo";
            this.Id_Marca.Name = "Id_Marca";
            this.Id_Marca.Visible = false;
            // 
            // Marcas
            // 
            this.Marcas.HeaderText = "Modelo";
            this.Marcas.Name = "Marcas";
            this.Marcas.ReadOnly = true;
            // 
            // Wf_Modelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 453);
            this.Controls.Add(this.lbl_IdTipo);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_GrabarTipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_ListadoModelos);
            this.Controls.Add(this.label1);
            this.Name = "Wf_Modelos";
            this.Text = "Wf_Modelos";
            this.Load += new System.EventHandler(this.Wf_Modelos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IdTipo;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Button btn_GrabarTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ActualizarModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
        private System.Windows.Forms.CheckBox ckb_EstaAciva;
        private System.Windows.Forms.DataGridView dgv_ListadoModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marcas;
    }
}
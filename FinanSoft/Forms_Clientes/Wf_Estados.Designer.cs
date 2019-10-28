namespace FinanSoft.Forms_Clientes
{
    partial class Wf_Estados
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
            this.btn_GrabarEstado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarEstado = new System.Windows.Forms.Button();
            this.btn_ListadoEstados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdEstados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_DesEstado = new System.Windows.Forms.RichTextBox();
            this.ckb_EstaEstado = new System.Windows.Forms.CheckBox();
            this.dgv_ListadoEstados = new System.Windows.Forms.DataGridView();
            this.Id_Mestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Pais = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GrabarEstado
            // 
            this.btn_GrabarEstado.Location = new System.Drawing.Point(402, 376);
            this.btn_GrabarEstado.Name = "btn_GrabarEstado";
            this.btn_GrabarEstado.Size = new System.Drawing.Size(146, 40);
            this.btn_GrabarEstado.TabIndex = 21;
            this.btn_GrabarEstado.Text = "Grabar";
            this.btn_GrabarEstado.UseVisualStyleBackColor = true;
            this.btn_GrabarEstado.Click += new System.EventHandler(this.btn_GrabarEstado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ActualizarEstado);
            this.groupBox1.Controls.Add(this.btn_ListadoEstados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_IdEstados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NombreEstado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtb_DesEstado);
            this.groupBox1.Controls.Add(this.ckb_EstaEstado);
            this.groupBox1.Location = new System.Drawing.Point(300, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 272);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Marcas";
            // 
            // btn_ActualizarEstado
            // 
            this.btn_ActualizarEstado.Location = new System.Drawing.Point(76, 225);
            this.btn_ActualizarEstado.Name = "btn_ActualizarEstado";
            this.btn_ActualizarEstado.Size = new System.Drawing.Size(75, 23);
            this.btn_ActualizarEstado.TabIndex = 8;
            this.btn_ActualizarEstado.Text = "Actualizar";
            this.btn_ActualizarEstado.UseVisualStyleBackColor = true;
            this.btn_ActualizarEstado.Click += new System.EventHandler(this.btn_ActualizarEstado_Click);
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
            // txt_IdEstados
            // 
            this.txt_IdEstados.Location = new System.Drawing.Point(95, 20);
            this.txt_IdEstados.Name = "txt_IdEstados";
            this.txt_IdEstados.ReadOnly = true;
            this.txt_IdEstados.Size = new System.Drawing.Size(100, 20);
            this.txt_IdEstados.TabIndex = 0;
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
            // txt_NombreEstado
            // 
            this.txt_NombreEstado.Location = new System.Drawing.Point(95, 46);
            this.txt_NombreEstado.Name = "txt_NombreEstado";
            this.txt_NombreEstado.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreEstado.TabIndex = 1;
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
            // rtb_DesEstado
            // 
            this.rtb_DesEstado.Location = new System.Drawing.Point(95, 72);
            this.rtb_DesEstado.Name = "rtb_DesEstado";
            this.rtb_DesEstado.Size = new System.Drawing.Size(186, 96);
            this.rtb_DesEstado.TabIndex = 2;
            this.rtb_DesEstado.Text = "";
            // 
            // ckb_EstaEstado
            // 
            this.ckb_EstaEstado.AutoSize = true;
            this.ckb_EstaEstado.Location = new System.Drawing.Point(30, 174);
            this.ckb_EstaEstado.Name = "ckb_EstaEstado";
            this.ckb_EstaEstado.Size = new System.Drawing.Size(80, 17);
            this.ckb_EstaEstado.TabIndex = 3;
            this.ckb_EstaEstado.Text = "Esta Activa";
            this.ckb_EstaEstado.UseVisualStyleBackColor = true;
            // 
            // dgv_ListadoEstados
            // 
            this.dgv_ListadoEstados.AllowUserToAddRows = false;
            this.dgv_ListadoEstados.AllowUserToDeleteRows = false;
            this.dgv_ListadoEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Mestado,
            this.Estado});
            this.dgv_ListadoEstados.Location = new System.Drawing.Point(32, 78);
            this.dgv_ListadoEstados.Name = "dgv_ListadoEstados";
            this.dgv_ListadoEstados.Size = new System.Drawing.Size(240, 321);
            this.dgv_ListadoEstados.TabIndex = 19;
            this.dgv_ListadoEstados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoEstados_CellDoubleClick);
            // 
            // Id_Mestado
            // 
            this.Id_Mestado.HeaderText = "Id_Estado";
            this.Id_Mestado.Name = "Id_Mestado";
            this.Id_Mestado.ReadOnly = true;
            this.Id_Mestado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estados";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Listado de Estados para el Pais :";
            // 
            // lbl_Pais
            // 
            this.lbl_Pais.AutoSize = true;
            this.lbl_Pais.Location = new System.Drawing.Point(202, 38);
            this.lbl_Pais.Name = "lbl_Pais";
            this.lbl_Pais.Size = new System.Drawing.Size(13, 13);
            this.lbl_Pais.TabIndex = 22;
            this.lbl_Pais.Text = "..";
            // 
            // Wf_Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 472);
            this.Controls.Add(this.lbl_Pais);
            this.Controls.Add(this.btn_GrabarEstado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_ListadoEstados);
            this.Controls.Add(this.label1);
            this.Name = "Wf_Estados";
            this.Text = "Wf_Estados";
            this.Load += new System.EventHandler(this.Wf_Estados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GrabarEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ActualizarEstado;
        private System.Windows.Forms.Button btn_ListadoEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdEstados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_DesEstado;
        private System.Windows.Forms.CheckBox ckb_EstaEstado;
        private System.Windows.Forms.DataGridView dgv_ListadoEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Mestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lbl_Pais;
    }
}
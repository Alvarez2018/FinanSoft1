namespace FinanSoft.Forms_Clientes
{
    partial class Wf_ClienteLista
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ListCliNit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ListaClientes = new System.Windows.Forms.DataGridView();
            this.col_IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ListCliNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ListCliNit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_ListaClientes);
            this.groupBox1.Controls.Add(this.txt_ListCliNombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE LOS DATOS PARA BUSCAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nit:";
            // 
            // txt_ListCliNit
            // 
            this.txt_ListCliNit.Location = new System.Drawing.Point(66, 52);
            this.txt_ListCliNit.Name = "txt_ListCliNit";
            this.txt_ListCliNit.Size = new System.Drawing.Size(100, 20);
            this.txt_ListCliNit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // dgv_ListaClientes
            // 
            this.dgv_ListaClientes.AllowUserToAddRows = false;
            this.dgv_ListaClientes.AllowUserToDeleteRows = false;
            this.dgv_ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IdCliente,
            this.col_Nombre});
            this.dgv_ListaClientes.Location = new System.Drawing.Point(6, 131);
            this.dgv_ListaClientes.Name = "dgv_ListaClientes";
            this.dgv_ListaClientes.ReadOnly = true;
            this.dgv_ListaClientes.Size = new System.Drawing.Size(487, 150);
            this.dgv_ListaClientes.TabIndex = 5;
            this.dgv_ListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListaClientes_CellContentClick);
            this.dgv_ListaClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListaClientes_CellContentDoubleClick);
            this.dgv_ListaClientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // col_IdCliente
            // 
            this.col_IdCliente.HeaderText = "Id";
            this.col_IdCliente.Name = "col_IdCliente";
            this.col_IdCliente.ReadOnly = true;
            this.col_IdCliente.Visible = false;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Cliente";
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            this.col_Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Nombre.Width = 200;
            // 
            // txt_ListCliNombre
            // 
            this.txt_ListCliNombre.Location = new System.Drawing.Point(66, 28);
            this.txt_ListCliNombre.Name = "txt_ListCliNombre";
            this.txt_ListCliNombre.Size = new System.Drawing.Size(100, 20);
            this.txt_ListCliNombre.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Wf_ClienteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 380);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Wf_ClienteLista";
            this.Text = "ClienteLista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ListCliNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_ListaClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ListCliNit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
    }
}
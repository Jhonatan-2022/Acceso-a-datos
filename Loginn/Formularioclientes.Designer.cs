
namespace Loginn
{
    partial class Formularioclientes
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
            this.txtbuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgclientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnborrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Buscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACCION DE CLIENTES";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Depth = 0;
            this.txtbuscar.Hint = "Buscar Cliente";
            this.txtbuscar.Location = new System.Drawing.Point(73, 87);
            this.txtbuscar.MaxLength = 32767;
            this.txtbuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.SelectionLength = 0;
            this.txtbuscar.SelectionStart = 0;
            this.txtbuscar.Size = new System.Drawing.Size(444, 23);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TabStop = false;
            this.txtbuscar.UseSystemPasswordChar = false;
            // 
            // dgclientes
            // 
            this.dgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CLIENTE,
            this.DOCUMENTO,
            this.TELEFONO,
            this.btnEditar,
            this.btnborrar});
            this.dgclientes.Location = new System.Drawing.Point(47, 34);
            this.dgclientes.Name = "dgclientes";
            this.dgclientes.Size = new System.Drawing.Size(643, 297);
            this.dgclientes.TabIndex = 1;
            this.dgclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgclientes_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Width = 190;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.HeaderText = "DOCUMENTO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnborrar
            // 
            this.btnborrar.HeaderText = "BORRAR";
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Text = "BORRAR";
            this.btnborrar.UseColumnTextForButtonValue = true;
            this.btnborrar.Width = 80;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(523, 82);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(85, 28);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "NUEVO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgclientes);
            this.groupBox1.Location = new System.Drawing.Point(73, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 356);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Formularioclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formularioclientes";
            this.Text = "ormularioclientes";
            this.Load += new System.EventHandler(this.ormularioclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbuscar;
        private System.Windows.Forms.DataGridView dgclientes;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnborrar;
    }
}
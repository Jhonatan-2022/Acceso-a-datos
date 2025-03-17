
namespace Loginn
{
    partial class formulariofacturas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgfacturas = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Buscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMISTRACCION DE FACTURAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgfacturas);
            this.groupBox1.Location = new System.Drawing.Point(21, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 341);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // dgfacturas
            // 
            this.dgfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Column2,
            this.Column3,
            this.Column1,
            this.Column5});
            this.dgfacturas.Location = new System.Drawing.Point(24, 31);
            this.dgfacturas.Name = "dgfacturas";
            this.dgfacturas.Size = new System.Drawing.Size(745, 279);
            this.dgfacturas.TabIndex = 1;
            this.dgfacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfacturas_CellContentClick);
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Nro_Factura";
            this.Id_Producto.Name = "Id_Producto";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Empleado";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Buscar Cliente";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(27, 87);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(551, 23);
            this.materialSingleLineTextField1.TabIndex = 20;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(584, 82);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(85, 28);
            this.Buscar.TabIndex = 21;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "NUEVA FACTURA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfactura
            // 
            this.txtfactura.Location = new System.Drawing.Point(695, 41);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(122, 20);
            this.txtfactura.TabIndex = 23;
            // 
            // formulariofacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.txtfactura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulariofacturas";
            this.Text = "formulariofacturas";
            this.Load += new System.EventHandler(this.formulariofacturas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgfacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgfacturas;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
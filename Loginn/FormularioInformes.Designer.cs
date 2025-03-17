
namespace Loginn
{
    partial class FormularioInformes
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtvalortotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtimpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.datefianl = new System.Windows.Forms.DateTimePicker();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbovendedor = new System.Windows.Forms.ComboBox();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DETALLES = new System.Windows.Forms.GroupBox();
            this.dgfacturasedi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error11 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.DETALLES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfacturasedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error11)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboestado);
            this.groupBox1.Controls.Add(this.txtvalortotal);
            this.groupBox1.Controls.Add(this.txtimpuesto);
            this.groupBox1.Controls.Add(this.txtdescuento);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField3);
            this.groupBox1.Controls.Add(this.txtfactura);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField5);
            this.groupBox1.Controls.Add(this.datefianl);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField4);
            this.groupBox1.Controls.Add(this.cbovendedor);
            this.groupBox1.Controls.Add(this.cbocliente);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField2);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField1);
            this.groupBox1.Location = new System.Drawing.Point(69, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(526, 147);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(141, 21);
            this.cboestado.TabIndex = 16;
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.Depth = 0;
            this.txtvalortotal.Hint = "Valor Total";
            this.txtvalortotal.Location = new System.Drawing.Point(16, 236);
            this.txtvalortotal.MaxLength = 32767;
            this.txtvalortotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.PasswordChar = '\0';
            this.txtvalortotal.SelectedText = "";
            this.txtvalortotal.SelectionLength = 0;
            this.txtvalortotal.SelectionStart = 0;
            this.txtvalortotal.Size = new System.Drawing.Size(130, 23);
            this.txtvalortotal.TabIndex = 15;
            this.txtvalortotal.TabStop = false;
            this.txtvalortotal.UseSystemPasswordChar = false;
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Depth = 0;
            this.txtimpuesto.Hint = "Impuesto";
            this.txtimpuesto.Location = new System.Drawing.Point(16, 193);
            this.txtimpuesto.MaxLength = 32767;
            this.txtimpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.PasswordChar = '\0';
            this.txtimpuesto.SelectedText = "";
            this.txtimpuesto.SelectionLength = 0;
            this.txtimpuesto.SelectionStart = 0;
            this.txtimpuesto.Size = new System.Drawing.Size(130, 23);
            this.txtimpuesto.TabIndex = 14;
            this.txtimpuesto.TabStop = false;
            this.txtimpuesto.UseSystemPasswordChar = false;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Depth = 0;
            this.txtdescuento.Hint = "Nro Descuento";
            this.txtdescuento.Location = new System.Drawing.Point(16, 145);
            this.txtdescuento.MaxLength = 32767;
            this.txtdescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.PasswordChar = '\0';
            this.txtdescuento.SelectedText = "";
            this.txtdescuento.SelectionLength = 0;
            this.txtdescuento.SelectionStart = 0;
            this.txtdescuento.Size = new System.Drawing.Size(130, 23);
            this.txtdescuento.TabIndex = 13;
            this.txtdescuento.TabStop = false;
            this.txtdescuento.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Nro Factura";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(16, 14);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(130, 23);
            this.materialSingleLineTextField3.TabIndex = 12;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // txtfactura
            // 
            this.txtfactura.Location = new System.Drawing.Point(191, 17);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(100, 20);
            this.txtfactura.TabIndex = 11;
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(526, 17);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(141, 23);
            this.materialSingleLineTextField5.TabIndex = 10;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.Text = "Fecha Final";
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // datefianl
            // 
            this.datefianl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefianl.Location = new System.Drawing.Point(526, 57);
            this.datefianl.Name = "datefianl";
            this.datefianl.Size = new System.Drawing.Size(141, 20);
            this.datefianl.TabIndex = 9;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(526, 107);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(141, 23);
            this.materialSingleLineTextField4.TabIndex = 8;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.Text = "Estado Factura";
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // cbovendedor
            // 
            this.cbovendedor.FormattingEnabled = true;
            this.cbovendedor.Location = new System.Drawing.Point(191, 94);
            this.cbovendedor.Name = "cbovendedor";
            this.cbovendedor.Size = new System.Drawing.Size(238, 21);
            this.cbovendedor.TabIndex = 6;
            // 
            // cbocliente
            // 
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(191, 54);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(238, 21);
            this.cbocliente.TabIndex = 4;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Vendedor";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(16, 92);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(141, 23);
            this.materialSingleLineTextField2.TabIndex = 5;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Cliente";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(16, 54);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(141, 23);
            this.materialSingleLineTextField1.TabIndex = 4;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DETALLES
            // 
            this.DETALLES.Controls.Add(this.dgfacturasedi);
            this.DETALLES.Location = new System.Drawing.Point(69, 330);
            this.DETALLES.Name = "DETALLES";
            this.DETALLES.Size = new System.Drawing.Size(800, 303);
            this.DETALLES.TabIndex = 10;
            this.DETALLES.TabStop = false;
            this.DETALLES.Text = "DETALLES FACTURA";
            // 
            // dgfacturasedi
            // 
            this.dgfacturasedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfacturasedi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgfacturasedi.Location = new System.Drawing.Point(16, 23);
            this.dgfacturasedi.Name = "dgfacturasedi";
            this.dgfacturasedi.Size = new System.Drawing.Size(774, 274);
            this.dgfacturasedi.TabIndex = 0;
            this.dgfacturasedi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfacturasedi_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // error11
            // 
            this.error11.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "MODIFICACION DE FACTURAS";
            // 
            // FormularioInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 656);
            this.Controls.Add(this.DETALLES);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioInformes";
            this.Load += new System.EventHandler(this.FormularioInformes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DETALLES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgfacturasedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.ComboBox cbovendedor;
        private System.Windows.Forms.ComboBox cbocliente;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtvalortotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtimpuesto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.DateTimePicker datefianl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox DETALLES;
        private System.Windows.Forms.DataGridView dgfacturasedi;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ErrorProvider error11;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private System.Windows.Forms.Label label1;
    }
}
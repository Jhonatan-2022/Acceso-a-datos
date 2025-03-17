
namespace Loginn
{
    partial class FormularioProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgproducto = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnactuali = new System.Windows.Forms.Button();
            this.btnelimi = new System.Windows.Forms.Button();
            this.txtareferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtpreciocompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtventa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtstock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbocategorias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtimagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdatospro = new System.Windows.Forms.TextBox();
            this.txtproducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtid = new System.Windows.Forms.TextBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgproducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMISTRACCION DE PRODUCTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgproducto
            // 
            this.dgproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproducto.Location = new System.Drawing.Point(21, 33);
            this.dgproducto.Name = "dgproducto";
            this.dgproducto.Size = new System.Drawing.Size(643, 152);
            this.dgproducto.TabIndex = 1;
            this.dgproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgproducto_CellContentClick);
            this.dgproducto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgproducto_CellMouseClick);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(615, 82);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(85, 28);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnactuali
            // 
            this.btnactuali.Location = new System.Drawing.Point(615, 127);
            this.btnactuali.Name = "btnactuali";
            this.btnactuali.Size = new System.Drawing.Size(85, 28);
            this.btnactuali.TabIndex = 7;
            this.btnactuali.Text = "ACTUALIZAR";
            this.btnactuali.UseVisualStyleBackColor = true;
            this.btnactuali.Click += new System.EventHandler(this.btnactuali_Click);
            // 
            // btnelimi
            // 
            this.btnelimi.Location = new System.Drawing.Point(615, 173);
            this.btnelimi.Name = "btnelimi";
            this.btnelimi.Size = new System.Drawing.Size(85, 28);
            this.btnelimi.TabIndex = 8;
            this.btnelimi.Text = "ELIMINAR";
            this.btnelimi.UseVisualStyleBackColor = true;
            this.btnelimi.Click += new System.EventHandler(this.btnelimi_Click);
            // 
            // txtareferencia
            // 
            this.txtareferencia.Depth = 0;
            this.txtareferencia.Hint = "Codigo Referencia";
            this.txtareferencia.Location = new System.Drawing.Point(58, 127);
            this.txtareferencia.MaxLength = 32767;
            this.txtareferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtareferencia.Name = "txtareferencia";
            this.txtareferencia.PasswordChar = '\0';
            this.txtareferencia.SelectedText = "";
            this.txtareferencia.SelectionLength = 0;
            this.txtareferencia.SelectionStart = 0;
            this.txtareferencia.Size = new System.Drawing.Size(241, 23);
            this.txtareferencia.TabIndex = 10;
            this.txtareferencia.TabStop = false;
            this.txtareferencia.UseSystemPasswordChar = false;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Depth = 0;
            this.txtpreciocompra.Hint = "Precio Compra";
            this.txtpreciocompra.Location = new System.Drawing.Point(58, 173);
            this.txtpreciocompra.MaxLength = 32767;
            this.txtpreciocompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.PasswordChar = '\0';
            this.txtpreciocompra.SelectedText = "";
            this.txtpreciocompra.SelectionLength = 0;
            this.txtpreciocompra.SelectionStart = 0;
            this.txtpreciocompra.Size = new System.Drawing.Size(241, 23);
            this.txtpreciocompra.TabIndex = 11;
            this.txtpreciocompra.TabStop = false;
            this.txtpreciocompra.UseSystemPasswordChar = false;
            // 
            // txtventa
            // 
            this.txtventa.Depth = 0;
            this.txtventa.Hint = "Precio Venta";
            this.txtventa.Location = new System.Drawing.Point(58, 218);
            this.txtventa.MaxLength = 32767;
            this.txtventa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtventa.Name = "txtventa";
            this.txtventa.PasswordChar = '\0';
            this.txtventa.SelectedText = "";
            this.txtventa.SelectionLength = 0;
            this.txtventa.SelectionStart = 0;
            this.txtventa.Size = new System.Drawing.Size(241, 23);
            this.txtventa.TabIndex = 12;
            this.txtventa.TabStop = false;
            this.txtventa.UseSystemPasswordChar = false;
            // 
            // txtstock
            // 
            this.txtstock.Depth = 0;
            this.txtstock.Hint = "Cantidad Stock";
            this.txtstock.Location = new System.Drawing.Point(58, 288);
            this.txtstock.MaxLength = 32767;
            this.txtstock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtstock.Name = "txtstock";
            this.txtstock.PasswordChar = '\0';
            this.txtstock.SelectedText = "";
            this.txtstock.SelectionLength = 0;
            this.txtstock.SelectionStart = 0;
            this.txtstock.Size = new System.Drawing.Size(312, 23);
            this.txtstock.TabIndex = 13;
            this.txtstock.TabStop = false;
            this.txtstock.UseSystemPasswordChar = false;
            // 
            // cbocategorias
            // 
            this.cbocategorias.FormattingEnabled = true;
            this.cbocategorias.Items.AddRange(new object[] {
            "Tecnologia",
            "componentes",
            "varios"});
            this.cbocategorias.Location = new System.Drawing.Point(464, 89);
            this.cbocategorias.Name = "cbocategorias";
            this.cbocategorias.Size = new System.Drawing.Size(121, 21);
            this.cbocategorias.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Categorias";
            // 
            // txtimagen
            // 
            this.txtimagen.Depth = 0;
            this.txtimagen.Hint = "Ruta Imagen";
            this.txtimagen.Location = new System.Drawing.Point(381, 132);
            this.txtimagen.MaxLength = 32767;
            this.txtimagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.PasswordChar = '\0';
            this.txtimagen.SelectedText = "";
            this.txtimagen.SelectionLength = 0;
            this.txtimagen.SelectionStart = 0;
            this.txtimagen.Size = new System.Drawing.Size(204, 23);
            this.txtimagen.TabIndex = 16;
            this.txtimagen.TabStop = false;
            this.txtimagen.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Detalles De Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgproducto);
            this.groupBox1.Location = new System.Drawing.Point(58, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 224);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // txtdatospro
            // 
            this.txtdatospro.Location = new System.Drawing.Point(381, 227);
            this.txtdatospro.Multiline = true;
            this.txtdatospro.Name = "txtdatospro";
            this.txtdatospro.Size = new System.Drawing.Size(228, 84);
            this.txtdatospro.TabIndex = 19;
            this.txtdatospro.TextChanged += new System.EventHandler(this.txtdatospro_TextChanged);
            // 
            // txtproducto
            // 
            this.txtproducto.Depth = 0;
            this.txtproducto.Hint = "Nombre Producto";
            this.txtproducto.Location = new System.Drawing.Point(58, 82);
            this.txtproducto.MaxLength = 32767;
            this.txtproducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.PasswordChar = '\0';
            this.txtproducto.SelectedText = "";
            this.txtproducto.SelectionLength = 0;
            this.txtproducto.SelectionStart = 0;
            this.txtproducto.Size = new System.Drawing.Size(281, 23);
            this.txtproducto.TabIndex = 9;
            this.txtproducto.TabStop = false;
            this.txtproducto.UseSystemPasswordChar = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(58, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(42, 20);
            this.txtid.TabIndex = 20;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 772);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdatospro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbocategorias);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtventa);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.txtareferencia);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.btnelimi);
            this.Controls.Add(this.btnactuali);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioProductos";
            this.Text = "FormularioProductos";
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgproducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgproducto;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactuali;
        private System.Windows.Forms.Button btnelimi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtareferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpreciocompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtventa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtstock;
        private System.Windows.Forms.ComboBox cbocategorias;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtimagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdatospro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtproducto;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}

namespace Loginn
{
    partial class formFacturas
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
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtempleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombrecliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.datenuevo = new System.Windows.Forms.DateTimePicker();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboestadodactura = new System.Windows.Forms.ComboBox();
            this.errorProviderr = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtdescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtimpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtvalortotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfactura
            // 
            this.txtfactura.Location = new System.Drawing.Point(42, 50);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(39, 20);
            this.txtfactura.TabIndex = 31;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(81, -20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(145, 13);
            this.lbltitulo.TabIndex = 30;
            this.lbltitulo.Text = "INGRESO NUEVO CLIENTE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(98, 341);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(85, 28);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "ACTUALIZAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtempleado
            // 
            this.txtempleado.Depth = 0;
            this.txtempleado.Hint = "Empleado";
            this.txtempleado.Location = new System.Drawing.Point(42, 209);
            this.txtempleado.MaxLength = 32767;
            this.txtempleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.PasswordChar = '\0';
            this.txtempleado.SelectedText = "";
            this.txtempleado.SelectionLength = 0;
            this.txtempleado.SelectionStart = 0;
            this.txtempleado.Size = new System.Drawing.Size(228, 23);
            this.txtempleado.TabIndex = 25;
            this.txtempleado.TabStop = false;
            this.txtempleado.UseSystemPasswordChar = false;
            // 
            // txtcliente
            // 
            this.txtcliente.Depth = 0;
            this.txtcliente.Hint = "Cliente";
            this.txtcliente.Location = new System.Drawing.Point(42, 163);
            this.txtcliente.MaxLength = 32767;
            this.txtcliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.PasswordChar = '\0';
            this.txtcliente.SelectedText = "";
            this.txtcliente.SelectionLength = 0;
            this.txtcliente.SelectionStart = 0;
            this.txtcliente.Size = new System.Drawing.Size(168, 23);
            this.txtcliente.TabIndex = 24;
            this.txtcliente.TabStop = false;
            this.txtcliente.UseSystemPasswordChar = false;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Depth = 0;
            this.txtnombrecliente.Hint = "Expedicion";
            this.txtnombrecliente.Location = new System.Drawing.Point(42, 86);
            this.txtnombrecliente.MaxLength = 32767;
            this.txtnombrecliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.PasswordChar = '\0';
            this.txtnombrecliente.SelectedText = "";
            this.txtnombrecliente.SelectionLength = 0;
            this.txtnombrecliente.SelectionStart = 0;
            this.txtnombrecliente.Size = new System.Drawing.Size(126, 23);
            this.txtnombrecliente.TabIndex = 23;
            this.txtnombrecliente.TabStop = false;
            this.txtnombrecliente.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "INGRESO NUEVA FACTURA";
            // 
            // datenuevo
            // 
            this.datenuevo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenuevo.Location = new System.Drawing.Point(42, 115);
            this.datenuevo.Name = "datenuevo";
            this.datenuevo.Size = new System.Drawing.Size(141, 20);
            this.datenuevo.TabIndex = 33;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Expedicion";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(42, 249);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(98, 23);
            this.materialSingleLineTextField1.TabIndex = 34;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // cboestadodactura
            // 
            this.cboestadodactura.FormattingEnabled = true;
            this.cboestadodactura.Location = new System.Drawing.Point(42, 278);
            this.cboestadodactura.Name = "cboestadodactura";
            this.cboestadodactura.Size = new System.Drawing.Size(121, 21);
            this.cboestadodactura.TabIndex = 35;
            // 
            // errorProviderr
            // 
            this.errorProviderr.ContainerControl = this;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Depth = 0;
            this.txtdescuento.Hint = "Descuento";
            this.txtdescuento.Location = new System.Drawing.Point(313, 86);
            this.txtdescuento.MaxLength = 32767;
            this.txtdescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.PasswordChar = '\0';
            this.txtdescuento.SelectedText = "";
            this.txtdescuento.SelectionLength = 0;
            this.txtdescuento.SelectionStart = 0;
            this.txtdescuento.Size = new System.Drawing.Size(126, 23);
            this.txtdescuento.TabIndex = 36;
            this.txtdescuento.TabStop = false;
            this.txtdescuento.UseSystemPasswordChar = false;
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Depth = 0;
            this.txtimpuesto.Hint = "impuesto";
            this.txtimpuesto.Location = new System.Drawing.Point(313, 140);
            this.txtimpuesto.MaxLength = 32767;
            this.txtimpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.PasswordChar = '\0';
            this.txtimpuesto.SelectedText = "";
            this.txtimpuesto.SelectionLength = 0;
            this.txtimpuesto.SelectionStart = 0;
            this.txtimpuesto.Size = new System.Drawing.Size(126, 23);
            this.txtimpuesto.TabIndex = 37;
            this.txtimpuesto.TabStop = false;
            this.txtimpuesto.UseSystemPasswordChar = false;
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.Depth = 0;
            this.txtvalortotal.Hint = "Valor total";
            this.txtvalortotal.Location = new System.Drawing.Point(313, 209);
            this.txtvalortotal.MaxLength = 32767;
            this.txtvalortotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.PasswordChar = '\0';
            this.txtvalortotal.SelectedText = "";
            this.txtvalortotal.SelectionLength = 0;
            this.txtvalortotal.SelectionStart = 0;
            this.txtvalortotal.Size = new System.Drawing.Size(126, 23);
            this.txtvalortotal.TabIndex = 38;
            this.txtvalortotal.TabStop = false;
            this.txtvalortotal.UseSystemPasswordChar = false;
            // 
            // formFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 526);
            this.Controls.Add(this.txtvalortotal);
            this.Controls.Add(this.txtimpuesto);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.cboestadodactura);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.datenuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfactura);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtnombrecliente);
            this.Name = "formFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formFacturas";
            this.Load += new System.EventHandler(this.formFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnguardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtempleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombrecliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datenuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.ComboBox cboestadodactura;
        private System.Windows.Forms.ErrorProvider errorProviderr;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtvalortotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtimpuesto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdescuento;
    }
}
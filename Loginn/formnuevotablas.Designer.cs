
namespace Loginn
{
    partial class formnuevotablas
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
            this.txtnombrecliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txttelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtemail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnguardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtiddcliente = new System.Windows.Forms.TextBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Depth = 0;
            this.txtnombrecliente.Hint = "Nombre Cliente";
            this.txtnombrecliente.Location = new System.Drawing.Point(29, 97);
            this.txtnombrecliente.MaxLength = 32767;
            this.txtnombrecliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.PasswordChar = '\0';
            this.txtnombrecliente.SelectedText = "";
            this.txtnombrecliente.SelectionLength = 0;
            this.txtnombrecliente.SelectionStart = 0;
            this.txtnombrecliente.Size = new System.Drawing.Size(244, 23);
            this.txtnombrecliente.TabIndex = 13;
            this.txtnombrecliente.TabStop = false;
            this.txtnombrecliente.UseSystemPasswordChar = false;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Depth = 0;
            this.txtdocumento.Hint = "Documento";
            this.txtdocumento.Location = new System.Drawing.Point(29, 136);
            this.txtdocumento.MaxLength = 32767;
            this.txtdocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.PasswordChar = '\0';
            this.txtdocumento.SelectedText = "";
            this.txtdocumento.SelectionLength = 0;
            this.txtdocumento.SelectionStart = 0;
            this.txtdocumento.Size = new System.Drawing.Size(168, 23);
            this.txtdocumento.TabIndex = 14;
            this.txtdocumento.TabStop = false;
            this.txtdocumento.UseSystemPasswordChar = false;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Hint = "Direccion";
            this.txtdireccion.Location = new System.Drawing.Point(29, 176);
            this.txtdireccion.MaxLength = 32767;
            this.txtdireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.SelectionLength = 0;
            this.txtdireccion.SelectionStart = 0;
            this.txtdireccion.Size = new System.Drawing.Size(228, 23);
            this.txtdireccion.TabIndex = 15;
            this.txtdireccion.TabStop = false;
            this.txtdireccion.UseSystemPasswordChar = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Depth = 0;
            this.txttelefono.Hint = "Telefono";
            this.txttelefono.Location = new System.Drawing.Point(29, 226);
            this.txttelefono.MaxLength = 32767;
            this.txttelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.SelectedText = "";
            this.txttelefono.SelectionLength = 0;
            this.txttelefono.SelectionStart = 0;
            this.txttelefono.Size = new System.Drawing.Size(168, 23);
            this.txttelefono.TabIndex = 16;
            this.txttelefono.TabStop = false;
            this.txttelefono.UseSystemPasswordChar = false;
            // 
            // txtemail
            // 
            this.txtemail.Depth = 0;
            this.txtemail.Hint = "Email";
            this.txtemail.Location = new System.Drawing.Point(29, 271);
            this.txtemail.MaxLength = 32767;
            this.txtemail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.Size = new System.Drawing.Size(244, 23);
            this.txtemail.TabIndex = 17;
            this.txtemail.TabStop = false;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(60, 325);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(85, 28);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "ACTUALIZAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(92, 28);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(145, 13);
            this.lbltitulo.TabIndex = 21;
            this.lbltitulo.Text = "INGRESO NUEVO CLIENTE";
            // 
            // txtiddcliente
            // 
            this.txtiddcliente.Location = new System.Drawing.Point(29, 58);
            this.txtiddcliente.Name = "txtiddcliente";
            this.txtiddcliente.Size = new System.Drawing.Size(39, 20);
            this.txtiddcliente.TabIndex = 22;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // formnuevotablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 365);
            this.Controls.Add(this.txtiddcliente);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.txtnombrecliente);
            this.Name = "formnuevotablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formnuevotablas";
            this.Load += new System.EventHandler(this.formnuevotablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombrecliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txttelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemail;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtiddcliente;
        private System.Windows.Forms.ErrorProvider error1;
    }
}
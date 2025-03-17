
namespace Loginn
{
    partial class formularioSecEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.txtdatos = new System.Windows.Forms.TextBox();
            this.materialSingleLineTextField9 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateretiro = new System.Windows.Forms.DateTimePicker();
            this.dateingre = new System.Windows.Forms.DateTimePicker();
            this.CboRol = new System.Windows.Forms.ComboBox();
            this.materialSingleLineTextField8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtemail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txttelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DTAGRIDEMPLE = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.Button();
            this.materialSingleLineTextField10 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button4 = new System.Windows.Forms.Button();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTAGRIDEMPLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMISTRACCION DE EMPLEADOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidempleado);
            this.groupBox1.Controls.Add(this.txtdatos);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField9);
            this.groupBox1.Controls.Add(this.dateretiro);
            this.groupBox1.Controls.Add(this.dateingre);
            this.groupBox1.Controls.Add(this.CboRol);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField8);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField7);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField6);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtdocumento);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Location = new System.Drawing.Point(41, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 305);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(35, 28);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(53, 20);
            this.txtidempleado.TabIndex = 26;
            // 
            // txtdatos
            // 
            this.txtdatos.Location = new System.Drawing.Point(491, 194);
            this.txtdatos.Multiline = true;
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(237, 89);
            this.txtdatos.TabIndex = 25;
            // 
            // materialSingleLineTextField9
            // 
            this.materialSingleLineTextField9.Depth = 0;
            this.materialSingleLineTextField9.Hint = "";
            this.materialSingleLineTextField9.Location = new System.Drawing.Point(491, 160);
            this.materialSingleLineTextField9.MaxLength = 32767;
            this.materialSingleLineTextField9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField9.Name = "materialSingleLineTextField9";
            this.materialSingleLineTextField9.PasswordChar = '\0';
            this.materialSingleLineTextField9.SelectedText = "";
            this.materialSingleLineTextField9.SelectionLength = 0;
            this.materialSingleLineTextField9.SelectionStart = 0;
            this.materialSingleLineTextField9.Size = new System.Drawing.Size(202, 23);
            this.materialSingleLineTextField9.TabIndex = 24;
            this.materialSingleLineTextField9.TabStop = false;
            this.materialSingleLineTextField9.Text = "DATOS ADICIONALES";
            this.materialSingleLineTextField9.UseSystemPasswordChar = false;
            // 
            // dateretiro
            // 
            this.dateretiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateretiro.Location = new System.Drawing.Point(623, 112);
            this.dateretiro.Name = "dateretiro";
            this.dateretiro.Size = new System.Drawing.Size(105, 20);
            this.dateretiro.TabIndex = 22;
            // 
            // dateingre
            // 
            this.dateingre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateingre.Location = new System.Drawing.Point(623, 70);
            this.dateingre.Name = "dateingre";
            this.dateingre.Size = new System.Drawing.Size(105, 20);
            this.dateingre.TabIndex = 21;
            // 
            // CboRol
            // 
            this.CboRol.FormattingEnabled = true;
            this.CboRol.Location = new System.Drawing.Point(623, 32);
            this.CboRol.Name = "CboRol";
            this.CboRol.Size = new System.Drawing.Size(105, 21);
            this.CboRol.TabIndex = 20;
            // 
            // materialSingleLineTextField8
            // 
            this.materialSingleLineTextField8.Depth = 0;
            this.materialSingleLineTextField8.Hint = "";
            this.materialSingleLineTextField8.Location = new System.Drawing.Point(491, 112);
            this.materialSingleLineTextField8.MaxLength = 32767;
            this.materialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField8.Name = "materialSingleLineTextField8";
            this.materialSingleLineTextField8.PasswordChar = '\0';
            this.materialSingleLineTextField8.SelectedText = "";
            this.materialSingleLineTextField8.SelectionLength = 0;
            this.materialSingleLineTextField8.SelectionStart = 0;
            this.materialSingleLineTextField8.Size = new System.Drawing.Size(126, 23);
            this.materialSingleLineTextField8.TabIndex = 19;
            this.materialSingleLineTextField8.TabStop = false;
            this.materialSingleLineTextField8.Text = "F.Retiro:";
            this.materialSingleLineTextField8.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField7
            // 
            this.materialSingleLineTextField7.Depth = 0;
            this.materialSingleLineTextField7.Hint = "";
            this.materialSingleLineTextField7.Location = new System.Drawing.Point(491, 70);
            this.materialSingleLineTextField7.MaxLength = 32767;
            this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
            this.materialSingleLineTextField7.PasswordChar = '\0';
            this.materialSingleLineTextField7.SelectedText = "";
            this.materialSingleLineTextField7.SelectionLength = 0;
            this.materialSingleLineTextField7.SelectionStart = 0;
            this.materialSingleLineTextField7.Size = new System.Drawing.Size(126, 23);
            this.materialSingleLineTextField7.TabIndex = 18;
            this.materialSingleLineTextField7.TabStop = false;
            this.materialSingleLineTextField7.Text = "F.Ingreso";
            this.materialSingleLineTextField7.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(491, 32);
            this.materialSingleLineTextField6.MaxLength = 32767;
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(126, 23);
            this.materialSingleLineTextField6.TabIndex = 17;
            this.materialSingleLineTextField6.TabStop = false;
            this.materialSingleLineTextField6.Text = "Rol Empleado:";
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // txtemail
            // 
            this.txtemail.Depth = 0;
            this.txtemail.Hint = "Email";
            this.txtemail.Location = new System.Drawing.Point(35, 246);
            this.txtemail.MaxLength = 32767;
            this.txtemail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.Size = new System.Drawing.Size(290, 23);
            this.txtemail.TabIndex = 16;
            this.txtemail.TabStop = false;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Depth = 0;
            this.txttelefono.Hint = "Telefono";
            this.txttelefono.Location = new System.Drawing.Point(35, 194);
            this.txttelefono.MaxLength = 32767;
            this.txttelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.SelectedText = "";
            this.txttelefono.SelectionLength = 0;
            this.txttelefono.SelectionStart = 0;
            this.txttelefono.Size = new System.Drawing.Size(221, 23);
            this.txttelefono.TabIndex = 15;
            this.txttelefono.TabStop = false;
            this.txttelefono.UseSystemPasswordChar = false;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Hint = "Direccion";
            this.txtdireccion.Location = new System.Drawing.Point(35, 150);
            this.txtdireccion.MaxLength = 32767;
            this.txtdireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.SelectionLength = 0;
            this.txtdireccion.SelectionStart = 0;
            this.txtdireccion.Size = new System.Drawing.Size(335, 23);
            this.txtdireccion.TabIndex = 14;
            this.txtdireccion.TabStop = false;
            this.txtdireccion.UseSystemPasswordChar = false;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Depth = 0;
            this.txtdocumento.Hint = "Documento";
            this.txtdocumento.Location = new System.Drawing.Point(35, 109);
            this.txtdocumento.MaxLength = 32767;
            this.txtdocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.PasswordChar = '\0';
            this.txtdocumento.SelectedText = "";
            this.txtdocumento.SelectionLength = 0;
            this.txtdocumento.SelectionStart = 0;
            this.txtdocumento.Size = new System.Drawing.Size(232, 23);
            this.txtdocumento.TabIndex = 13;
            this.txtdocumento.TabStop = false;
            this.txtdocumento.UseSystemPasswordChar = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Depth = 0;
            this.txtnombre.Hint = "Nombre Del Empleado";
            this.txtnombre.Location = new System.Drawing.Point(35, 67);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.SelectedText = "";
            this.txtnombre.SelectionLength = 0;
            this.txtnombre.SelectionStart = 0;
            this.txtnombre.Size = new System.Drawing.Size(378, 23);
            this.txtnombre.TabIndex = 12;
            this.txtnombre.TabStop = false;
            this.txtnombre.UseSystemPasswordChar = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(835, 93);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(112, 28);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(835, 153);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(112, 28);
            this.btnactualizar.TabIndex = 9;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(835, 210);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(112, 28);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DTAGRIDEMPLE);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.materialSingleLineTextField10);
            this.groupBox2.Location = new System.Drawing.Point(41, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 267);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // DTAGRIDEMPLE
            // 
            this.DTAGRIDEMPLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTAGRIDEMPLE.Location = new System.Drawing.Point(49, 89);
            this.DTAGRIDEMPLE.Name = "DTAGRIDEMPLE";
            this.DTAGRIDEMPLE.Size = new System.Drawing.Size(644, 169);
            this.DTAGRIDEMPLE.TabIndex = 23;
            this.DTAGRIDEMPLE.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DTAGRIDEMPLE_CellMouseClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(608, 26);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(85, 28);
            this.txtbuscar.TabIndex = 22;
            this.txtbuscar.Text = "BUSCAR";
            this.txtbuscar.UseVisualStyleBackColor = true;
            this.txtbuscar.Click += new System.EventHandler(this.txtbuscar_Click);
            // 
            // materialSingleLineTextField10
            // 
            this.materialSingleLineTextField10.Depth = 0;
            this.materialSingleLineTextField10.Hint = "";
            this.materialSingleLineTextField10.Location = new System.Drawing.Point(49, 31);
            this.materialSingleLineTextField10.MaxLength = 32767;
            this.materialSingleLineTextField10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField10.Name = "materialSingleLineTextField10";
            this.materialSingleLineTextField10.PasswordChar = '\0';
            this.materialSingleLineTextField10.SelectedText = "";
            this.materialSingleLineTextField10.SelectionLength = 0;
            this.materialSingleLineTextField10.SelectionStart = 0;
            this.materialSingleLineTextField10.Size = new System.Drawing.Size(568, 23);
            this.materialSingleLineTextField10.TabIndex = 21;
            this.materialSingleLineTextField10.TabStop = false;
            this.materialSingleLineTextField10.Text = "Buscar Empleado";
            this.materialSingleLineTextField10.UseSystemPasswordChar = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(835, 566);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "SALIR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // formularioSecEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 683);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularioSecEmpleados";
            this.Text = "formularioSecEmpleados";
            this.Load += new System.EventHandler(this.formularioSecEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTAGRIDEMPLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField8;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField7;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txttelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField9;
        private System.Windows.Forms.DateTimePicker dateretiro;
        private System.Windows.Forms.DateTimePicker dateingre;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField10;
        private System.Windows.Forms.Button txtbuscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DTAGRIDEMPLE;
        private System.Windows.Forms.TextBox txtdatos;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private System.Windows.Forms.TextBox txtidempleado;
    }
}
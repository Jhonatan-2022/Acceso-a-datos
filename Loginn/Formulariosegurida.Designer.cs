
namespace Loginn
{
    partial class Formulariosegurida
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
            this.txtpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtusuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboempleado = new System.Windows.Forms.ComboBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txteliminarseg = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Errormesage1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Errormesage1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMISTRACCION DE USUARIOS DEL SISTEMA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.cboempleado);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField1);
            this.groupBox1.Location = new System.Drawing.Point(65, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.Depth = 0;
            this.txtpass.Hint = "CLAVE";
            this.txtpass.Location = new System.Drawing.Point(205, 123);
            this.txtpass.MaxLength = 32767;
            this.txtpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.Size = new System.Drawing.Size(141, 23);
            this.txtpass.TabIndex = 8;
            this.txtpass.TabStop = false;
            this.txtpass.UseSystemPasswordChar = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Depth = 0;
            this.txtusuario.Hint = "USUARIO";
            this.txtusuario.Location = new System.Drawing.Point(205, 69);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.Size = new System.Drawing.Size(141, 23);
            this.txtusuario.TabIndex = 7;
            this.txtusuario.TabStop = false;
            this.txtusuario.UseSystemPasswordChar = false;
            // 
            // cboempleado
            // 
            this.cboempleado.FormattingEnabled = true;
            this.cboempleado.Location = new System.Drawing.Point(205, 19);
            this.cboempleado.Name = "cboempleado";
            this.cboempleado.Size = new System.Drawing.Size(277, 21);
            this.cboempleado.TabIndex = 4;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(16, 19);
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
            this.materialSingleLineTextField1.Text = "EMPLEADO";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txteliminarseg
            // 
            this.txteliminarseg.Location = new System.Drawing.Point(698, 198);
            this.txteliminarseg.Name = "txteliminarseg";
            this.txteliminarseg.Size = new System.Drawing.Size(112, 28);
            this.txteliminarseg.TabIndex = 11;
            this.txteliminarseg.Text = "ELIMINAR";
            this.txteliminarseg.UseVisualStyleBackColor = true;
            this.txteliminarseg.Click += new System.EventHandler(this.txteliminarseg_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(698, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "SALIR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Errormesage1
            // 
            this.Errormesage1.ContainerControl = this;
            // 
            // Formulariosegurida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txteliminarseg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulariosegurida";
            this.Text = "Formulariosegurida";
            this.Load += new System.EventHandler(this.Formulariosegurida_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Errormesage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusuario;
        private System.Windows.Forms.ComboBox cboempleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txteliminarseg;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider Errormesage1;
    }
}
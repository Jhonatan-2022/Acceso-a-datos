
namespace Loginn
{
    partial class Loggin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loggin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butnlogin = new System.Windows.Forms.Button();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtusuario.Location = new System.Drawing.Point(438, 81);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(269, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.Text = "USUARIO";
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(438, 135);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(269, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(516, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESAR";
            // 
            // butnlogin
            // 
            this.butnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.butnlogin.FlatAppearance.BorderSize = 0;
            this.butnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.butnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnlogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.butnlogin.Location = new System.Drawing.Point(438, 191);
            this.butnlogin.Name = "butnlogin";
            this.butnlogin.Size = new System.Drawing.Size(269, 40);
            this.butnlogin.TabIndex = 3;
            this.butnlogin.Text = "Iniciar sesión";
            this.butnlogin.UseVisualStyleBackColor = false;
            this.butnlogin.Click += new System.EventHandler(this.butnlogin_Click);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.Black;
            this.linkpass.Location = new System.Drawing.Point(489, 261);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(170, 17);
            this.linkpass.TabIndex = 0;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "¿Recuperar Contraseña?";
            this.linkpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkpass_LinkClicked);
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(900, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(29, 36);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 6;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(865, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(29, 36);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 7;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 330);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.butnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loggin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuario";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butnlogin;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


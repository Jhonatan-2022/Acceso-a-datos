
namespace Loginn
{
    partial class formulariocategorias
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
            this.txtnombrecatego = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcodigocatego = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnnuevacatego = new System.Windows.Forms.Button();
            this.btneliminarcate = new System.Windows.Forms.Button();
            this.btnactualizarcat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgcategorias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORIAS DE PRODUCTOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnombrecatego);
            this.groupBox1.Controls.Add(this.txtcodigocatego);
            this.groupBox1.Location = new System.Drawing.Point(79, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtnombrecatego
            // 
            this.txtnombrecatego.Depth = 0;
            this.txtnombrecatego.Hint = "Nombre Categoria";
            this.txtnombrecatego.Location = new System.Drawing.Point(35, 82);
            this.txtnombrecatego.MaxLength = 32767;
            this.txtnombrecatego.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombrecatego.Name = "txtnombrecatego";
            this.txtnombrecatego.PasswordChar = '\0';
            this.txtnombrecatego.SelectedText = "";
            this.txtnombrecatego.SelectionLength = 0;
            this.txtnombrecatego.SelectionStart = 0;
            this.txtnombrecatego.Size = new System.Drawing.Size(258, 23);
            this.txtnombrecatego.TabIndex = 13;
            this.txtnombrecatego.TabStop = false;
            this.txtnombrecatego.UseSystemPasswordChar = false;
            // 
            // txtcodigocatego
            // 
            this.txtcodigocatego.Depth = 0;
            this.txtcodigocatego.Hint = "Codigo Categoria";
            this.txtcodigocatego.Location = new System.Drawing.Point(35, 32);
            this.txtcodigocatego.MaxLength = 32767;
            this.txtcodigocatego.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcodigocatego.Name = "txtcodigocatego";
            this.txtcodigocatego.PasswordChar = '\0';
            this.txtcodigocatego.SelectedText = "";
            this.txtcodigocatego.SelectionLength = 0;
            this.txtcodigocatego.SelectionStart = 0;
            this.txtcodigocatego.Size = new System.Drawing.Size(359, 23);
            this.txtcodigocatego.TabIndex = 12;
            this.txtcodigocatego.TabStop = false;
            this.txtcodigocatego.UseSystemPasswordChar = false;
            // 
            // btnnuevacatego
            // 
            this.btnnuevacatego.Location = new System.Drawing.Point(684, 108);
            this.btnnuevacatego.Name = "btnnuevacatego";
            this.btnnuevacatego.Size = new System.Drawing.Size(85, 28);
            this.btnnuevacatego.TabIndex = 6;
            this.btnnuevacatego.Text = "NUEVO";
            this.btnnuevacatego.UseVisualStyleBackColor = true;
            this.btnnuevacatego.Click += new System.EventHandler(this.btnnuevacatego_Click);
            // 
            // btneliminarcate
            // 
            this.btneliminarcate.Location = new System.Drawing.Point(684, 207);
            this.btneliminarcate.Name = "btneliminarcate";
            this.btneliminarcate.Size = new System.Drawing.Size(85, 28);
            this.btneliminarcate.TabIndex = 9;
            this.btneliminarcate.Text = "ELIMINAR";
            this.btneliminarcate.UseVisualStyleBackColor = true;
            this.btneliminarcate.Click += new System.EventHandler(this.btneliminarcate_Click);
            // 
            // btnactualizarcat
            // 
            this.btnactualizarcat.Location = new System.Drawing.Point(684, 156);
            this.btnactualizarcat.Name = "btnactualizarcat";
            this.btnactualizarcat.Size = new System.Drawing.Size(85, 28);
            this.btnactualizarcat.TabIndex = 10;
            this.btnactualizarcat.Text = "ACTUALIZAR";
            this.btnactualizarcat.UseVisualStyleBackColor = true;
            this.btnactualizarcat.Click += new System.EventHandler(this.btnactualizarcat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgcategorias);
            this.groupBox2.Location = new System.Drawing.Point(79, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 199);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgcategorias
            // 
            this.dgcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgcategorias.Location = new System.Drawing.Point(61, 19);
            this.dgcategorias.Name = "dgcategorias";
            this.dgcategorias.Size = new System.Drawing.Size(442, 162);
            this.dgcategorias.TabIndex = 0;
            this.dgcategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcategorias_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdCategoria";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "StrDescripcion";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DtmModificacion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "StrUsuarioModif";
            this.Column4.Name = "Column4";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(684, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 28);
            this.button4.TabIndex = 14;
            this.button4.Text = "SALIR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // formulariocategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnactualizarcat);
            this.Controls.Add(this.btneliminarcate);
            this.Controls.Add(this.btnnuevacatego);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulariocategorias";
            this.Text = "formulariocategorias";
            this.Load += new System.EventHandler(this.formulariocategorias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnuevacatego;
        private System.Windows.Forms.Button btneliminarcate;
        private System.Windows.Forms.Button btnactualizarcat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombrecatego;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcodigocatego;
        private System.Windows.Forms.DataGridView dgcategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ErrorProvider error2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginn
{
    public partial class Formulariosegurida : Form
    {
        public Formulariosegurida()
        {
            InitializeComponent();
        }

        private void llenarcombo_empleados()

        {

            DataTable dt = new DataTable();

            Acceso_Datos acceso = new Acceso_Datos();
            dt = acceso.Cargaratabla("TBLEMPLEADO", "");


            cboempleado.DataSource = dt;
            cboempleado.DisplayMember = "strNombre";
            cboempleado.ValueMember = "IdEmpleado";
            acceso.CerrarBd();

        }

        public bool Guardar()
        {


            Boolean actualizado = false;

            if (Validar())
            {

               
                try                                                                                                                                                             
                {
                    Acceso_Datos acceso = new Acceso_Datos();
                    string sentencia = $"Exec actualizar_Seguridad'{ Convert.ToInt32(cboempleado.SelectedValue)}' ,'{txtusuario.Text}','{txtpass.Text}','{DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")}','javier'";
                    MessageBox.Show(acceso.Ejecutarcomando(sentencia));
                    actualizado = true;


                }
                catch (Exception)
                {

                    MessageBox.Show("fallo insercion");
                    actualizado = false;



                }

            }

            return actualizado;

        }






        private Boolean Validar()
        {

            Boolean errorcampos = true;

            if (txtusuario.Text == string.Empty)
            {
                Errormesage1.SetError(txtusuario, "debe ingresar un valor de usuario:");
                txtusuario.Focus();
                errorcampos = false;



            }
            else { Errormesage1.SetError(txtusuario, ""); }

            if (txtpass.Text == "")
            {
                Errormesage1.SetError(txtpass, "debe ingresar un valor de cedula");
                txtpass.Focus();
                errorcampos = false;



            }
            else { Errormesage1.SetError(txtpass, ""); }

          


            return errorcampos;


        }


        public void Elimminar()
        {
            Acceso_Datos acceso = new Acceso_Datos();
            string sentencia = $"Exec  Eliminar_Seguridad '{ Convert.ToInt32(cboempleado.SelectedValue)}' ";
            MessageBox.Show(acceso.Ejecutarcomando(sentencia));
            txtusuario.Text = "";
            txtpass.Text = "";




        }



        public void Consultar()
        {

            DataTable dt = new DataTable();
            string sentencia = "select StrUsuario,StrClave from TBLSEGURIDAD where IdEmpleado="+cboempleado.SelectedValue.ToString();
            Acceso_Datos acceso = new Acceso_Datos();
            dt = acceso.EjecutarComandoDatos(sentencia);

            if (dt.Rows.Count>0)
            {

                txtusuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                txtpass.Text = dt.Rows[0]["StrClave"].ToString();


            }
            else
            {
                MessageBox.Show("el usuario no dispone de datos de ingreso");
                txtpass.Text = "";
                txtusuario.Text = "";


            }


        }






        private void Formulariosegurida_Load(object sender, EventArgs e)
        {
            llenarcombo_empleados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void txteliminarseg_Click(object sender, EventArgs e)
        {
            Elimminar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edicion", "MENSAJE DE ADVERTENCIA ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


            if (Rta == DialogResult.OK)
            {

                this.Close();
            }


        }
    }
}

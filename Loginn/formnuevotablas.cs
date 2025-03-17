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
    public partial class formnuevotablas : Form
    {
        public formnuevotablas()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_Datos Acceso = new Acceso_Datos();


        public int IdCliente { get; set; }


        public bool Guardar()
        {

            Boolean actualizado = false;



            if (Validar())
            {

                try
                {

                    Acceso_Datos Acceso = new Acceso_Datos();
                    string sentencia = $"Exec [actualizar_Cliente] {txtiddcliente.Text},'{txtnombrecliente.Text}',{ txtdocumento.Text},'{txtdireccion.Text}','{txttelefono.Text}','{txtemail.Text}','Javier','{DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")}'";
                    MessageBox.Show(Acceso.Ejecutarcomando(sentencia));                 
                    actualizado = true;
                    



                }
                catch (Exception ex)
                {

                    MessageBox.Show("fallo insercion: " + ex);
                    actualizado = false;


                }

            }

            return actualizado;





        }


        private Boolean Validar()
        {

            Boolean errorcampos = true;

            if (txtnombrecliente.Text == string.Empty)
            {
                error1.SetError(txtnombrecliente, "debe ingresar el nombre del empleado");
                txtnombrecliente.Focus();
                errorcampos = false;



            }
            else { error1.SetError(txtnombrecliente, ""); }

            if (txtdocumento.Text == "")
            {
                error1.SetError(txtdocumento, "debe ingresar el documento");
                txtdocumento.Focus();
                errorcampos = false;



            }
            else { error1.SetError(txtdocumento, ""); }

            if (!esnumerico(txtdocumento.Text))
            {

                error1.SetError(txtdocumento, "El documento debe ser numerico");
                txtdocumento.Focus();
                return false;


            }

            error1.SetError(txtdocumento, "");


            return errorcampos;

        }



        private bool esnumerico(string num)
        {

            try
            {

                double x = Convert.ToDouble(num);
                return true;


            }
            catch (Exception)
            {

                return false;
            }

        }




        private void formnuevotablas_Load(object sender, EventArgs e)
        {
            if (IdCliente==0)
            {


                lbltitulo.Text = "INGRESO NUEVO CLIENTE";


            }
            else
            {
                lbltitulo.Text = "EDITAR CLIENTE";

                string sentencia = $"select * from TBLCLIENTES where idCliente = {IdCliente}";
                dt = Acceso.EjecutarComandoDatos(sentencia);


                foreach (DataRow row in dt.Rows)
                {

                   
                    txtiddcliente.Text = row[0].ToString();
                    txtnombrecliente.Text = row[1].ToString();
                    txtdocumento.Text = row[2].ToString();
                    txtdireccion.Text = row[3].ToString();
                    txttelefono.Text = row[4].ToString();
                    txtemail.Text = row[5].ToString();





                }



            }



            
        

        }




        private void button1_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}

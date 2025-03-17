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
    public partial class formFacturas : Form
    {
        public formFacturas()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        Acceso_Datos Acceso = new Acceso_Datos();




        public int IdFactura { get; internal set; }


        private void LLENAR_GRID()
        {


            dt = Acceso.Cargaratabla("TBLESTADO_FACTURA ", "");
            cboestadodactura.DataSource = dt;
            cboestadodactura.DisplayMember = "StrDescripcion";
            cboestadodactura.ValueMember = "IdEstadoFactura";



        }




        private void formFacturas_Load(object sender, EventArgs e)
        {
            if (IdFactura == 0)
            {


                lbltitulo.Text = "NGRESO NUEVA FACTURA";


            }
        

            LLENAR_GRID();



        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }





        public bool Guardar()
        {

            Boolean actualizado = false;



            if (Validar())
            {

                try
                {

                    Acceso_Datos Acceso = new Acceso_Datos();
                    string sentencia = $"Exec actualizar_Factura   {txtfactura.Text},'{datenuevo.Value.ToString("yyyy-MM-dd 00:00:00.000")}','{ txtcliente.Text}','{ txtempleado.Text}','{txtdescuento.Text}','{txtimpuesto.Text}','{txtvalortotal.Text}',{cboestadodactura.SelectedValue},'{DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")}','Javier'";
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
                errorProviderr.SetError(txtnombrecliente, "debe ingresar el nombre del cliente");
                txtnombrecliente.Focus();
                errorcampos = false;



            }
            else { errorProviderr.SetError(txtnombrecliente, ""); }



            if (txtfactura.Text == "")
            {
                errorProviderr.SetError(txtfactura, "debe ingresar la factura");
                txtfactura.Focus();
                errorcampos = false;



            }
            else { errorProviderr.SetError(txtfactura, ""); }

            if (!esnumerico(txtfactura.Text))
            {

                errorProviderr.SetError(txtfactura, "la factura debe ser numerica");
                txtfactura.Focus();
                return false;


            }

            errorProviderr.SetError(txtfactura, "");


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












    }

}

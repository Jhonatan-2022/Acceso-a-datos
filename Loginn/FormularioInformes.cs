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
    public partial class FormularioInformes : Form
    {
        public FormularioInformes()
        {
            InitializeComponent();
        }


        public int IdFactura { get; set; }



        DataTable dt = new DataTable();
        Acceso_Datos Acceso = new Acceso_Datos();

        private void LLENAR_GRID()
        {


            String sentencia = $"SELECT TBLFACTURA.IdFactura AS Nro_Factura, FORMAT(TBLFACTURA.DtmFecha, 'dd/MM/yyyy', 'en-US') AS 'Fecha', TBLCLIENTES.StrNombre AS Cliente, TBLEMPLEADO.strNombre AS Empledo,  TBLESTADO_FACTURA.StrDescripcion AS Estado, TBLFACTURA.NumDescuento, TBLFACTURA.NumImpuesto, TBLFACTURA.NumValorTotal FROM TBLFACTURA INNER JOIN    TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura INNER JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente INNER JOIN TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado ";
            dt = Acceso.EjecutarComandoDatos(sentencia);
            foreach (DataRow row in dt.Rows) { dgfacturasedi.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]); };



            dt = Acceso.Cargaratabla("TBLCLIENTES ", "");
            cbocliente.DataSource = dt;
            cbocliente.DisplayMember = "StrNombre";
            cbocliente.ValueMember = "IdCliente";




            dt = Acceso.Cargaratabla("TBLEMPLEADO ", "");
            cbovendedor.DataSource = dt;
            cbovendedor.DisplayMember = "strNombre";
            cbovendedor.ValueMember = "IdEmpleado";






            dt = Acceso.Cargaratabla("TBLESTADO_FACTURA ", "");
            cboestado.DataSource = dt;
            cboestado.DisplayMember = "StrDescripcion";
            cboestado.ValueMember = "IdEstadoFactura";



        }

        private void FormularioInformes_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void dgfacturasedi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int posactual = 0;

            posactual = dgfacturasedi.CurrentRow.Index;

            txtfactura.Text = dgfacturasedi[0, posactual].Value.ToString();



            txtdescuento.Text = dgfacturasedi[5, posactual].Value.ToString();
            txtvalortotal.Text = dgfacturasedi[7, posactual].Value.ToString();
            txtimpuesto.Text = dgfacturasedi[6, posactual].Value.ToString();


        }

        public bool Guardar()
        {


            Boolean actualizado = false;

            if (Validar())
            {

                try
                {

                    Acceso_Datos Acceso = new Acceso_Datos();


                    string sentencia = $"Exec actualizar_Factura     {txtfactura.Text},'{datefianl.Value.ToString("yyyy-MM-dd 00:00:00.000")}','{ cbocliente.SelectedValue}','{ cbovendedor.SelectedValue}','{txtdescuento.Text}','{txtimpuesto.Text}','{txtvalortotal.Text}',{cboestado.SelectedValue},'{DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")}','Javier'";
                    MessageBox.Show(Acceso.Ejecutarcomando(sentencia));
                    LLENAR_GRID();
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

         

            if (txtfactura.Text == "")
            {
                error11.SetError(txtfactura, "debe ingresar la factura");
                txtfactura.Focus();
                errorcampos = false;



            }
            else { error11.SetError(txtfactura, ""); }



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






        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edicion", "MENSAJE DE ADVERTENCIA ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


            if (Rta == DialogResult.OK)
            {

                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

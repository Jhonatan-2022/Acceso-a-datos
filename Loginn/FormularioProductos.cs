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
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_Datos Acceso = new Acceso_Datos();


        private void LLENAR_GRID()
        {

            DataTable dt = new DataTable();
            Acceso_Datos acceso = new Acceso_Datos();
            dt = acceso.Cargaratabla("TBLPRODUCTO", "");
             dgproducto.DataSource = dt;

            dt = acceso.Cargaratabla("TBLCATEGORIA_PROD ", "");
            cbocategorias.DataSource = dt;
            cbocategorias.DisplayMember = "StrDescripcion";
            cbocategorias.ValueMember = "IdCategoria";


        }


        public void Nuevoregistro()
        {

            txtid.Text = "";
            txtproducto.Text = "";
            txtpreciocompra.Text = "";
            txtimagen.Text = "";
            txtdatospro.Text = "";
            txtareferencia.Text = "";
            txtventa.Text = "";
            txtpreciocompra.Text = "";
            txtstock.Text = "";
            cbocategorias.SelectedIndex = 0;


            MessageBox.Show("LOS CAMPOS HAN SIDO LIMPIADOS CON EXITO:  ", "INFORMACION",
             MessageBoxButtons.OK, MessageBoxIcon.Information);



        }



        public bool Guardar()
        {

            Boolean actualizado = false;

            if (Validar())
            {

                try
                {

                    Acceso_Datos Acceso = new Acceso_Datos();

              
                    string sentencia = $"Exec actualizar_Producto {txtid.Text},'{txtproducto.Text}','{txtareferencia.Text}','{ txtpreciocompra.Text}', '{txtventa.Text}',{ cbocategorias.SelectedValue },'{txtdatospro.Text}','{txtimagen.Text}', {txtstock.Text}, '{DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")}','Javier'";
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

            if (txtareferencia.Text == "")
            {
                MensajeError.SetError(txtareferencia, "debe ingresar la referencia");
                txtareferencia.Focus();
                errorcampos = false;



            }
            else { MensajeError.SetError(txtareferencia, ""); }

            if (!esnumerico(txtareferencia.Text))
            {

                MensajeError.SetError(txtareferencia, "La referencia debe ser numerica");
                txtareferencia.Focus();
                return false;


            }

            MensajeError.SetError(txtareferencia, "");



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













        public void Eliminar()
        {

            Acceso_Datos Acceso = new Acceso_Datos();

            string sentencia = $"Exec Eliminar_Producto  '{  Convert.ToInt32(txtid.Text)}' ";
            MessageBox.Show(Acceso.Ejecutarcomando(sentencia));
            LLENAR_GRID();





        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void dgproducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            int posactual = 0;

            posactual = dgproducto.CurrentRow.Index;


            txtid.Text = dgproducto[0, posactual].Value.ToString();
            txtproducto.Text = dgproducto[1, posactual].Value.ToString();
            txtareferencia.Text = dgproducto[2, posactual].Value.ToString();
            txtpreciocompra.Text = dgproducto[3, posactual].Value.ToString();
            txtventa.Text = dgproducto[4, posactual].Value.ToString();
            cbocategorias.SelectedIndex = Convert.ToInt16(dgproducto[5, posactual].Value.ToString());
            txtdatospro.Text = dgproducto[6, posactual].Value.ToString();
            txtimagen.Text = dgproducto[7, posactual].Value.ToString();    
            txtstock.Text = dgproducto[8, posactual].Value.ToString();
            




        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevoregistro();
        }

        private void btnactuali_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnelimi_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnbuscarr_Click(object sender, EventArgs e)
        {
          


        }

        private void dgproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdatospro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

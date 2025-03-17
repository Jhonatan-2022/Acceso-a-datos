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
    public partial class formularioSecEmpleados : Form
    {
        public formularioSecEmpleados()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_Datos Acceso = new Acceso_Datos();


        private void LLENAR_GRID()
        {

            DataTable dt = new DataTable();
            Acceso_Datos acceso = new Acceso_Datos();
            dt = acceso.Cargaratabla("TBLEMPLEADO", "");
            DTAGRIDEMPLE.DataSource = dt;

            dt = acceso.Cargaratabla("TBLROLES", "");
            CboRol.DataSource = dt;
            CboRol.DisplayMember = "StrDescripcion";
            CboRol.ValueMember = "IdRolEmpleado";


        }

        private Boolean Validar()
        {

            Boolean errorcampos = true;

            if (txtnombre.Text==string.Empty)
            {
                MensajeError.SetError(txtnombre, "debe ingresar el nombre del empleado");
                txtnombre.Focus();
                errorcampos = false;



            }
            else { MensajeError.SetError(txtnombre, ""); }

            if (txtdocumento.Text == "")
            {
                MensajeError.SetError(txtdocumento, "debe ingresar el documento");
                txtdocumento.Focus();
                errorcampos = false;



            }
            else { MensajeError.SetError(txtdocumento, ""); }

            if (!esnumerico(txtdocumento.Text))
            {

                MensajeError.SetError(txtdocumento, "El documento debe ser numerico");
                txtdocumento.Focus();
                return false;


            }

            MensajeError.SetError(txtdocumento, "");


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

            string sentencia = $"Exec Eliminar_Empleado  '{  Convert.ToInt32(txtidempleado.Text)}' ";
            MessageBox.Show(Acceso.Ejecutarcomando(sentencia));
            LLENAR_GRID();


        }



        public bool Guardar()
        {


            Boolean actualizado = false;

            if (Validar())
            {

                try
                {

                    Acceso_Datos Acceso = new Acceso_Datos();

                    if (txtidempleado.Text == "")
                        txtidempleado.Text = "0";
                    string sentencia = $"Exec actualizar_Empleado {txtidempleado.Text},'{txtnombre.Text}',{ txtdocumento.Text},'{txtdireccion.Text}','{txttelefono.Text}','{txtemail.Text}',{ CboRol.SelectedValue},'{dateingre.Value.ToString("yyyy-MM-dd 00:00:00.000")}','{dateretiro.Value.ToString("yyyy-MM-dd 00:00:00.000")}', '{txtdatos.Text}' ,'{DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")}','Javier'";
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


        public void nuevoregistro()
        {

           
            txtidempleado.Text = "";
            txtdatos.Text = "";
            txtdocumento.Text = "";
            txtdireccion.Text = "";
            txtemail.Text = "";
            txttelefono.Text = "";
            txtnombre.Text="";
            CboRol.SelectedIndex = 0;
            dateingre.Value = DateTime.Now;
            dateretiro.Value = Convert.ToDateTime("01/01/1900");


            MessageBox.Show("LOS CAMPOS HAN SIDO LIMPIADOS CON EXITO:  " , "INFORMACION",
               MessageBoxButtons.OK, MessageBoxIcon.Information);



        }




        private void formularioSecEmpleados_Load(object sender, EventArgs e)
        {

            LLENAR_GRID();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edicion", "MENSAJE DE ADVERTENCIA ",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);


            if (Rta==DialogResult.OK)
            {

                this.Close();
            }


            
            
        }

        private void DTAGRIDEMPLE_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int posactual = 0;

            posactual = DTAGRIDEMPLE.CurrentRow.Index;

            txtidempleado.Text = DTAGRIDEMPLE[0, posactual].Value.ToString()            ;
            txtnombre.Text = DTAGRIDEMPLE[1, posactual].Value.ToString();
            txtdocumento.Text= DTAGRIDEMPLE[2, posactual].Value.ToString();
            txtdireccion.Text=DTAGRIDEMPLE[3, posactual].Value.ToString();
            txttelefono.Text= DTAGRIDEMPLE[4, posactual].Value.ToString();
            txtemail.Text= DTAGRIDEMPLE[5, posactual].Value.ToString();
            CboRol.SelectedIndex = Convert.ToInt16(DTAGRIDEMPLE[6, posactual].Value.ToString());
            dateingre.Value = Convert.ToDateTime(DTAGRIDEMPLE[7, posactual].Value.ToString());


            if (DTAGRIDEMPLE[8,posactual].Value.ToString() != "")
            {
                dateretiro.Value = Convert.ToDateTime(DTAGRIDEMPLE[8, posactual].Value.ToString());

            }
            else
            {
                dateretiro.Value = Convert.ToDateTime("01/01/1900");



            }


            txtdatos.Text = DTAGRIDEMPLE[9, posactual].Value.ToString();



        }




        private void btnactualizar_Click(object sender, EventArgs e)
        {
          
            Guardar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nuevoregistro();
        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {

            if (txtbuscar.Text != "")
            {
                DTAGRIDEMPLE.Rows.Clear();
                string sentencia = $"select * from TBLEMPPLEADO where StrNombre like '%{txtbuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows) { DTAGRIDEMPLE.Rows.Add(row[0], row[1], row[2], row[3], 
                    row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11]); }
                txtbuscar.Text = "";


            }
            else
            {
                LLENAR_GRID();
            }



        }
    }
}

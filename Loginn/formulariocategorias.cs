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
    public partial class formulariocategorias : Form
    {
        public formulariocategorias()
        {
            InitializeComponent();
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


        DataTable dt = new DataTable();
        Acceso_Datos Acceso = new Acceso_Datos();





        private void LLENAR_GRID()
        {

           dgcategorias.Rows.Clear();
            String sentencia = $"SELECT IdCategoria, StrDescripcion, DtmFechaModifica, StrUsuarioModifico FROM TBLCATEGORIA_PROD";
            dt = Acceso.EjecutarComandoDatos(sentencia);
            foreach (DataRow row in dt.Rows) { dgcategorias.Rows.Add(row[0], row[1], row[2], row[3]); }

        }


        public void Eliminar()
        {


            Acceso_Datos Acceso = new Acceso_Datos();
            string sentencia = $"Exec Eliminar_Producto  '{  Convert.ToInt32(txtcodigocatego.Text)}' ";
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

                  
                    string sentencia = $"Exec actualizar_CategoriaProd  {txtcodigocatego.Text},'{txtnombrecatego.Text}','{DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")}','Javier'";
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

         

            if (txtcodigocatego.Text == "")
            {
                error2.SetError(txtcodigocatego, "debe ingresar numero categora");
                txtcodigocatego.Focus();
                errorcampos = false;



            }
            else { error2.SetError(txtcodigocatego, ""); }

        


            return errorcampos;

        }



        public void nuevoregistro()
        {


            txtcodigocatego.Text = "";
            txtnombrecatego.Text = "";
        


            MessageBox.Show("LOS CAMPOS HAN SIDO LIMPIADOS CON EXITO:  ", "INFORMACION",
               MessageBoxButtons.OK, MessageBoxIcon.Information);



        }







        private void formulariocategorias_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void dgcategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posactual = 0;

            posactual = dgcategorias.CurrentRow.Index;


            txtcodigocatego.Text = dgcategorias[0, posactual].Value.ToString();
            txtnombrecatego.Text = dgcategorias[1, posactual].Value.ToString();
           
        }

        private void btneliminarcate_Click(object sender, EventArgs e)
        {

            Eliminar();
      
        }

        private void btnactualizarcat_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnnuevacatego_Click(object sender, EventArgs e)
        {
            nuevoregistro();
        }
    }
}

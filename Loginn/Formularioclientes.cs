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
    public partial class Formularioclientes : Form
    {
        public Formularioclientes()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_Datos Acceso = new Acceso_Datos();

        public int IdCliente { get; set; }


        private void Buscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
               dgclientes.Rows.Clear();
                string sentencia = $"select * from TBLCLIENTES where StrNombre like '%{txtbuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows) { dgclientes.Rows.Add(row[0], row[1], row[2], row[3]); }
                txtbuscar.Text = "";


            }
            else
            {
                LLENAR_GRID();
            }




        }





        private void LLENAR_GRID()
        {

            dgclientes.Rows.Clear();
            String sentencia = $"SELECT IdCliente, StrNombre,NumDocumento, StrTelefono FROM TBLCLIENTES";
            dt = Acceso.EjecutarComandoDatos(sentencia);
            foreach(DataRow row in dt.Rows) { dgclientes.Rows.Add(row[0], row[1], row[2], row[3]); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formnuevotablas cliente = new formnuevotablas();
            cliente.IdCliente = 0;
            cliente.ShowDialog();
            LLENAR_GRID();
        }




        private void ormularioclientes_Load(object sender, EventArgs e)
        {


            LLENAR_GRID();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

   

        private void dgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgclientes.Columns[e.ColumnIndex].Name == "btnborrar")
            {

                int posActual = dgclientes.CurrentRow.Index;
                if (MessageBox.Show($"seguro desea borrar el cliente {dgclientes[1, posActual].Value.ToString()}", "CONFIRMACION",MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string sentencia = $"Exec Eliminar_Cliente'{Convert.ToInt32(dgclientes[0, posActual].Value.ToString())}'";
                    MessageBox.Show(Acceso.Ejecutarcomando(sentencia));
                    LLENAR_GRID();

                }
            }
            if (dgclientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgclientes.CurrentRow.Index;
                formnuevotablas cliente = new  formnuevotablas();
                cliente.IdCliente = int.Parse(dgclientes[0, posActual].Value.ToString());
                cliente.ShowDialog();
                LLENAR_GRID();


            }


        }
    }


}

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
    public partial class formulariofacturas : Form
    {
        public formulariofacturas()
        {
            InitializeComponent();
        }

        public int IdFactura { get; set; }


        DataTable dt = new DataTable();
        Acceso_Datos Acceso = new Acceso_Datos();


        private void LLENAR_GRID()
        {


            dgfacturas.Rows.Clear();



            //String sentencia = $" SELECT   TBLFACTURA.IdFactura, TBLFACTURA.DtmFecha, TBLCLIENTES.StrNombre, TBLESTADO_FACTURA.StrDescripcion FROM TBLFACTURA INNER JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente INNER JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura";
            String sentencia = $"SELECT TBLFACTURA.IdFactura as Nro_Factura,  FORMAT( TBLFACTURA.DtmFecha, 'dd/MM/yyyy', 'en-US' ) AS 'Fecha', TBLCLIENTES.StrNombre as Cliente, TBLEMPLEADO.strNombre AS Empledo, TBLESTADO_FACTURA.StrDescripcion as Estado FROM TBLFACTURA INNER JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura INNER JOIN  TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente INNER JOIN TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado";
            dt = Acceso.EjecutarComandoDatos(sentencia);
            foreach (DataRow row in dt.Rows) { dgfacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]); };







        }






        private void formulariofacturas_Load(object sender, EventArgs e)
        {

            LLENAR_GRID();


        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioInformes cliente = new FormularioInformes();


            cliente.IdFactura = 0;
            cliente.ShowDialog();
            LLENAR_GRID();
        }






        private void dgfacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




            if (dgfacturas.Columns[e.ColumnIndex].Name == "btnborrar")
            {

                int posActual = dgfacturas.CurrentRow.Index;
                if (MessageBox.Show($"seguro desea borrar el  {dgfacturas[2, posActual].Value.ToString()}", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string sentencia = $"Exec Eliminar_Cliente'{Convert.ToInt32(dgfacturas[0, posActual].Value.ToString())}'";
                    MessageBox.Show(Acceso.Ejecutarcomando(sentencia));
                    LLENAR_GRID();

                }
            }
            if (dgfacturas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgfacturas.CurrentRow.Index;
                formFacturas cliente = new  formFacturas();
                cliente.IdFactura = int.Parse(dgfacturas[0, posActual].Value.ToString());
                cliente.ShowDialog();
                LLENAR_GRID();


            }






            int posactual = 0;


            posactual = dgfacturas.CurrentRow.Index;
            txtfactura.Text = dgfacturas[0, posactual].Value.ToString();







        }
    }
}

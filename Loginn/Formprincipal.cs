using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Loginn
{
    public partial class Formprincipal :Form
    {
        public Formprincipal()
        {
            InitializeComponent();
            customizedesign();

        }

        private void customizedesign()
        {


            panelsubmenuprin.Visible = false;
            panelsubtablas.Visible = false;  
            panelsubseguridad.Visible = false;
            panelayuda.Visible = false;
            panelSubfacturacion.Visible = false;
          
            

        }

        private void hidesubmenu()
        {

            if (panelsubmenuprin.Visible == true)
                panelsubmenuprin.Visible = false;
            if (panelsubtablas.Visible == true)
                panelsubtablas.Visible = false;
            if (panelsubseguridad.Visible == true)
                panelsubseguridad.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
            if (panelSubfacturacion.Visible == true)
                panelSubfacturacion.Visible = false;
            
           



        }



        private void showsubmenu(Panel submenu)
        {

            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else

                submenu.Visible = false;




        }




        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //private void btnslide_Click(object sender, EventArgs e)
        //{
        //    if (MenuVertical.Width == 250)
        //    {
        //        MenuVertical.Width = 70;


        //    }
        //    else
        //    {
        //        MenuVertical.Width = 250;
        //    }



        //}

        private void iconsalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseas Cerrar la aplicacion?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();


        }

        //private void iconmax_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //    iconrestaurar.Visible = true;
        //    iconmax.Visible = false;
        //}

        //private void iconrestaurar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    iconrestaurar.Visible = false;
        //    iconmax.Visible = true;



        //}

        private void iconmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

          



        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Cerrar la aplicacion?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void bynmneuprinc_Click(object sender, EventArgs e)
        {

            showsubmenu(panelsubmenuprin);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Opcion No Disponible En Desarrollo", "INFORMACION",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseas Cerrar la aplicacion?", "Advertencia",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();

            hidesubmenu();
        }


        private Form activeform = null;


        private void openchildform(Form childform)
        {

            if (activeform != null)
                activeform.Close();

            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelcontenedor.Controls.Add(childform);
            panelcontenedor.Tag = childform;
            childform.BringToFront();
            childform.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            openchildform(new Formularioclientes());
            hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btntablas_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubtablas);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            hidesubmenu();
        }

      

        private void button9_Click(object sender, EventArgs e)
        {
            openchildform(new formulariofacturas());
        
        }

        private void button10_Click(object sender, EventArgs e)
        {

            openchildform(new FormularioInformes());

        }

        private void button11_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnseguri_Click(object sender, EventArgs e)
        {

            showsubmenu(panelsubseguridad);



        }

        private void button8_Click(object sender, EventArgs e)
        {
            openchildform(new formularioSecEmpleados());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            openchildform(new formulariorolemple());
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            showsubmenu(panelayuda);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

      
        private void button7_Click_2(object sender, EventArgs e)
        {

            openchildform(new Formularioayuda());
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            openchildform(new formularioacercade());
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

            showsubmenu(panelSubfacturacion);

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            openchildform(new Formulariosegurida());


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Cerrar la aplicacion?", "Advertencia",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmini.Visible = true; ;


        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmazi.Visible = true;

        }

        private void iconmini_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            openchildform(new Formularioclientes())  ;

          
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            openchildform(new FormularioProductos());
        }

     

   

        private void button6_Click(object sender, EventArgs e)
        {
            openchildform(new formulariocategorias());
        }
    }
}

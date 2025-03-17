using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Loginn
{
     class Acceso_Datos
     {
        SqlConnection Conexion;
        SqlCommand cmd;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;


        public void AbrirBd()
        {

            try
            {

                Conexion = new SqlConnection("Data Source=DESKTOP-7DP78F9;Initial catalog=[DBFACTURAS];Integrated Security=True");
                Conexion.Open();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Fallo Conexion " + ex);

            }



        }


        public void CerrarBd()
        {

            try
            {
                Conexion.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Fallo cerrar conexion" + ex);  


            }
        }


        public string Valirusuario(string StrUsuario, string StrClave)
        {

            try
            {
                string StrEmpleado = "";

                //string sentencia = $"SELECT * FROM TBLSEGURIDAD WHERE StrUsuario='{StrUsuario}'  AND StrClave='{StrClave}'";

                string sentencia = $"select e.strNombre,e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado=e.IdEmpleado where StrUsuario='{StrUsuario}' and StrClave='{StrClave}'";


                 

                AbrirBd();
                cmd = new SqlCommand();
                cmd.Connection = Conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader();


                while (LectorDatos.Read())
                {
                    StrEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }
                if (LectorDatos != null)
                {

                    LectorDatos.Close();
                }


                return StrEmpleado;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla lectura" + ex);
                return "";


            }



        }


        public DataTable Cargaratabla(string tabla,string StrCondicion)
        {

            try
            {
                AbrirBd();
                string sql = "select * from " + tabla + " " + StrCondicion;
                da = new SqlDataAdapter(sql, Conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarBd();
                return dt;



            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR EN LA CONSULTA:" + ex.ToString());
                return null;

            }


        }


        public string Ejecutarcomando(string Sentencia)
        {
            string Salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE!";

            try
            {

                int retornado;
                AbrirBd();
                cmd = new SqlCommand(Sentencia, Conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarBd();

                if (retornado > 0)
                {

                    Salida = "Los datos fueron actualizados";

                }
                else
                {


                    Salida = "Los datos no fueron actualizados";
                }


            }
            catch (Exception ex)
            {

                Salida = "fallo insercion: " + ex;
            }

            return Salida;

        }



        public DataTable EjecutarComandoDatos(string cmd)
        {

            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, Conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;


            }
            catch (Exception ex )
            {

                MessageBox.Show("FALLLO OPERACION " + ex);
                return null;
                 

                
            }


        }



     }
}

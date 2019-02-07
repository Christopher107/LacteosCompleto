using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                //creando la conexion
                SqlConnection miConecion = new SqlConnection("Data Source=.;Initial Catalog=HorasExtrasLacteosOsorno;Integrated Security=True;MultipleActiveResultSets=True;");
                //abriendo conexion
                miConecion.Open();

                SqlCommand comando = new SqlCommand("select Usuario, Clave, Seccion, TipoUsuario from Usuarios where Usuario = '" + txtUsuario.Text + "'And Clave = '" + txtContraseña.Text + "'And Seccion = '" + cbxArea.Text + "'And TipoUsuario = '" + cbxTipoUsuario + "' ", miConecion);

                //ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                //Llenando el dataAdapter
                da.Fill(ds, "HorasExtrasLacteosOsorno");
                //utilizado para representar una fila de la tabla q necesitas en este caso usuario
                DataRow DR;
                DR = ds.Tables["Usuarios"].Rows[0];

                //evaluando que la contraseña,usuario y area sean correctos
                if ((txtUsuario.Text == DR["Usuario"].ToString()) || (txtContraseña.Text == DR["Clave"].ToString()) || (cbxArea.Text == DR["Seccion"].ToString()) || (cbxTipoUsuario.Text == DR["TipoUsuario"].ToString()))
                {
                    //instanciando el formulario principal
                    Home frmPrincipal = new Home();
                    frmPrincipal.Show();//abriendo el formulario principal
                    this.Hide();//esto sirve para ocultar el formulario de login

                }
            }
            catch
            {

                MessageBox.Show("Error! Su usuario o contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autentificacion_Load(object sender, EventArgs e)
        {
            cbxArea.ValueMember = "Seccion";
            cbxTipoUsuario.ValueMember = "TipoUsuario";
            CargarcomboBox();
        }

        private void CargarcomboBox()
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxArea.DataSource = contexto.Usuarios.ToList();
                cbxTipoUsuario.DataSource = contexto.Usuarios.ToList();
            }
        }
    }
}

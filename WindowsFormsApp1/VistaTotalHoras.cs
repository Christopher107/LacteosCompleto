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
    public partial class VistaTotalHoras : Form
    {
        public VistaTotalHoras()
        {
            InitializeComponent();
        }
        
        private void btnVwBuscar_Click(object sender, EventArgs e)
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                dgvVwSumaHoras.Rows.Clear();
                int Rut_trabajador = Convert.ToInt32(cbxVwRut.Text);
                List<VW_suma_horas> listar = contexto.VW_suma_horas.Where(x => x.Rut_trabajador == Rut_trabajador).ToList();
                List<VW_suma_horas> _Resultado = (from VW_suma_horas in listar
                                                  where VW_suma_horas.Mes >= Convert.ToDateTime(dtVwDesde.Text)
                                                  && VW_suma_horas.Mes <= Convert.ToDateTime(dtVwHasta.Text)
                                                  select VW_suma_horas).ToList<VW_suma_horas>();
                foreach (var item in listar)
                {
                    dgvVwSumaHoras.Rows.Add(new object[]
                    {
                        item.Rut_trabajador,
                        item.Nombre_trabajador,
                        item.Apellido_trabajador,
                        item.Nombre_seccion,
                        item.Mes,
                        item.Total_Horas
                    });
                }
            }
        }

        private void VistaTotalHoras_Load(object sender, EventArgs e)
        {
            cbxVwRut.ValueMember = "Rut_trabajador";
            CargarGrilla();
            CargarComboBox();
        }

        private void CargarGrilla()
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities()) 
            {
                dgvVwSumaHoras.Rows.Clear();
                List<VW_suma_horas> sumaHoras = contexto.VW_suma_horas.ToList();
                foreach (VW_suma_horas item in sumaHoras)
                {
                    dgvVwSumaHoras.Rows.Add(new object[]
                    {
                        item.Rut_trabajador,
                        item.Nombre_trabajador,
                        item.Apellido_trabajador,
                        item.Nombre_seccion,
                        item.Mes,
                        item.Total_Horas
                    });
                }
            }
        }

        private void CargarComboBox()
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxVwRut.DataSource = contexto.VW_suma_horas.ToList();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            RegistroHoras RHoras = new RegistroHoras();
            RHoras.Show();//abriendo el formulario principal
            this.Hide();
        }
    }
}

using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegistroPersonal : Form
    {
        Validar v = new Validar();

        private Trabajador _trabajador;

        public RegistroPersonal()
        {
            InitializeComponent();
        }

        private void RegistroPersonal_Load(object sender, EventArgs e)
        {
            cbxRut.ValueMember = "Rut";

            cbxNombre.ValueMember = "Nombre";
            cbxApellido.ValueMember = "Apellido";

            cbxSeccion.ValueMember = "Seccion";

            CargarComboBox();

            CargarTrabajador();

            CargarGrilla();
            Botones(true);
        }

        private void CargarTrabajador()
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxRut.DataSource = contexto.Trabajador.ToList();
                cbxNombre.DataSource = contexto.Trabajador.ToList();
                cbxApellido.DataSource = contexto.Trabajador.ToList();
                cbxSeccion.DataSource = contexto.Trabajador.ToList();
            }
        }

        private void CargarComboBox()
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxRut.DataSource = contexto.Trabajador.ToList();
                cbxNombre.DataSource = contexto.Trabajador.ToList();
                cbxApellido.DataSource = contexto.Trabajador.ToList();
                cbxSeccion.DataSource = contexto.Trabajador.ToList();
            }
        }

        private void Limpiar()
        {
            txtRut.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            Botones(true);
        }
        private void Botones(bool estado)
        {
            btnGuardarPersonal.Enabled = estado;
            btnActualizarPersonal.Enabled = !estado;
            btnBorrarPersonal.Enabled = !estado;
        }

        private void CargarGrilla()
        {
            dgvPersonal.Rows.Clear();
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                List<Trabajador> registroPersonal = contexto.Trabajador.ToList();

                foreach (Trabajador item in registroPersonal)
                {
                    dgvPersonal.Rows.Add(new object[]
                    {
                       item.Rut,
                       item.Nombre,
                       item.Apellido,
                       item.Seccion,
                       item.FechaIngreso,
                    });
                }
            }
        }

        private void Guardar()
        {
            if(txtRut.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || dtIngreso == null || cbxSeccion == null)
            {
                MessageBox.Show("Por favor rellene todos los campos","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else{
                _trabajador = new Trabajador()
                {
                    Rut = Convert.ToInt32(txtRut.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaIngreso = dtIngreso.Value,
                    Seccion = Convert.ToInt32(cbxSeccion.Text),
                };

                using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    contexto.Trabajador.Add(_trabajador);
                    contexto.SaveChanges();
                }
                MessageBox.Show(
                    $"Se guardo el usrio {_trabajador.Nombre} exitosamente",
                    ".: Sistema Horas:.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                CargarComboBox();
                CargarGrilla();
                Limpiar();
            }
            
        }

        private void Editar()
        {
            if (txtRut.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || dtIngreso == null || cbxSeccion == null)
            {
                MessageBox.Show("Por favor rellene todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                _trabajador.Nombre = txtNombre.Text;
                _trabajador.Apellido = txtApellido.Text;
                _trabajador.FechaIngreso = dtIngreso.Value;
                _trabajador.Seccion = Convert.ToInt32(cbxSeccion.Text);


                using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    contexto.Entry(_trabajador).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                }

                MessageBox.Show(
                                $"Se edito la informacion del cliente {_trabajador.Nombre} exitosamente",
                                ".: Sistema Veterinaria:.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                CargarGrilla();
                Limpiar();
                Botones(true);
            }
        }

        private void Eliminar()
        {
            if (txtRut.Text == "")
            {
                MessageBox.Show("Por favor seleccione el Rut del trabajador que desea borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                            "Esta seguro de eliminar a" + Rut + "Del sistema",
                            "Borrar", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                if (resultado == DialogResult.Yes)
                {
                    using (var contexto = new HorasExtrasLacteosOsornoEntities())
                    {
                        contexto.Trabajador.Attach(_trabajador);
                        contexto.Trabajador.Remove(_trabajador);
                        contexto.SaveChanges();
                    }
                    CargarGrilla();
                    Botones(true);
                    MessageBox.Show(
                                   "Se aeliminado a" + Nombre + "Del sistema",
                                   "Borrado exitoso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
                else
                {
                    MessageBox.Show(
                                    "Se cancelo la operacion borrar a" + Nombre + "Del sistema",
                                    "Borrado cancelado", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
            }
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnActualizarPersonal_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnBorrarPersonal_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            if (chkRut.Checked)
            {
                using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    dgvPersonal.Rows.Clear();

                    int Rut = Convert.ToInt32(cbxRut.SelectedValue);
                    List<Trabajador> listar = contexto.Trabajador.Where(x => x.Rut == Rut).ToList();
                    foreach (var item in listar)
                    {
                        dgvPersonal.Rows.Add(new object[] {
                               item.Rut,
                               item.Nombre,
                               item.Apellido,
                               item.FechaIngreso,
                               item.Seccion,
                        });
                    }
                }
            }else if (chkNombre.Checked)
            {
                using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    dgvPersonal.Rows.Clear();
                    String Nombre = Convert.ToString(cbxNombre.Text);
                    List<Trabajador> listar = contexto.Trabajador.Where(x => x.Nombre == Nombre).ToList();
                    foreach (var item in listar)
                    {
                        dgvPersonal.Rows.Add(new object[] {
                               item.Rut,
                               item.Nombre,
                               item.Apellido,
                               item.FechaIngreso,
                               item.Seccion,
                        });
                    }
                }
            }
            else
            {
                using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    dgvPersonal.Rows.Clear();
                    String Apellido = Convert.ToString(cbxApellido.Text);
                    List<Trabajador> listar = contexto.Trabajador.Where(x => x.Apellido == Apellido).ToList();
                    foreach (var item in listar)
                    {
                        dgvPersonal.Rows.Add(new object[] {
                               item.Rut,
                               item.Nombre,
                               item.Apellido,
                               item.FechaIngreso,
                               item.Seccion,
                        });
                    }
                }
            }
        }

        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                int Rut = Convert.ToInt32(
                                        dgvPersonal
                                        .Rows[index]
                                        .Cells[0]
                                        .Value
                                        .ToString()
                                        );
                using (var contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    _trabajador = contexto.Trabajador.Find(Rut);

                    txtRut.Text = _trabajador.Rut.ToString();
                    txtNombre.Text = _trabajador.Nombre;
                    txtApellido.Text = _trabajador.Apellido;
                    dtIngreso.Value = _trabajador.FechaIngreso.GetValueOrDefault();
                    cbxSeccion.SelectedValue = _trabajador.Seccion.ToString();

                    Botones(false);
                }
            }
        }


        private void chkRut_CheckedChanged(object sender, EventArgs e)
        {
            cbxRut.Enabled = true;
            cbxNombre.Enabled = false;
            cbxApellido.Enabled = false;
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            cbxRut.Enabled = false;
            cbxNombre.Enabled = true;
            cbxApellido.Enabled = false;
        }

        private void chkApellido_CheckedChanged(object sender, EventArgs e)
        {
            cbxRut.Enabled = false;
            cbxNombre.Enabled = false;
            cbxApellido.Enabled = true;
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }
    }
}

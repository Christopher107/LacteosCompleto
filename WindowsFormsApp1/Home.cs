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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnIngresoPersonal_Click(object sender, EventArgs e)
        {
            RegistroPersonal registroPersonal = new RegistroPersonal();
            registroPersonal.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void btnIngresoUsuarios_Click(object sender, EventArgs e)
        {
            RegistroUsuarios registroUsuarios = new RegistroUsuarios();
            registroUsuarios.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void btnIngresoHoras_Click(object sender, EventArgs e)
        {
            RegistroHoras registroHoras = new RegistroHoras();
            registroHoras.Show();//abriendo el formulario principal
            this.Hide();
        }
    }
}

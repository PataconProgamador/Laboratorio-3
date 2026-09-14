using System.Collections;

namespace Lab3_1
{
    public partial class Form1 : Form
    {
        ArrayList listaPersonas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador1 = new Persona();

            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Elena Carolina";
            miColaborador1.Apellidos = "Gonzalez Rodríguez";
            miColaborador1.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1990, 5, 15);
            listaPersonas.Add(miColaborador1);
            dgvdatos.DataSource = listaPersonas;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                errorProvider1.SetError(txtId, "Ingrese un ID");
                txtId.Focus();
                return; // <-- Interrumpe y finaliza la ejecución del método actual
            }
            else
            {
                errorProvider1.SetError(txtId, "");
            }


            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Ingrese los nombres del Colaborador");
                txtNombres.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombres, "");
            }


            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese los apellidos del Colaborador");
                txtApellidos.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellidos, "");
            }

            if (Utilidades.EsCorreoValido(txtCorreo.Text) == false)
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo válido");
                txtCorreo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }

            decimal salario1;
            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }


            Persona colaborador1 = new Persona();
            colaborador1.Id = int.Parse(txtId.Text);
            colaborador1.Nombres = txtNombres.Text;
            colaborador1.Apellidos = txtApellidos.Text;
            colaborador1.Correo = txtCorreo.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFechaNacimiento.Value;
            listaPersonas.Add(colaborador1);
            dgvdatos.DataSource = null; // Limpiar el DataSource antes de asignar la nueva lista
            dgvdatos.DataSource = listaPersonas;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtSalario.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
        }
    }
}


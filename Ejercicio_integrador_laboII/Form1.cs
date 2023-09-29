using Entidades;

namespace Ejercicio_integrador_laboII
{
    public partial class FmrCalculadora : Form
    {
        public FmrCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Text = string.Empty;
            txtSegundoOperador.Text = string.Empty;
            lblResultado.Text = "Resultado: ";
            cmbOperacion.SelectedIndex = 0;
            resultado = null;
            rdbBinario.Checked = false;
            rdbDecimal.Checked = false;

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrimerOperador.Text) || string.IsNullOrEmpty(txtSegundoOperador.Text))
            {
                MessageBox.Show("Ingrese el número correspondiente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.SetResultado();
            }

        }
        private void FmrCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperacion.Items.Add("");
            cmbOperacion.Items.Add('+');
            cmbOperacion.Items.Add('-');
            cmbOperacion.Items.Add('*');
            cmbOperacion.Items.Add('/');
        }

        private void FmrCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la calculadora?", "Cerrar calculadora", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in grpSistema.Controls)
            {
                if (control is RadioButton && rdbBinario.Checked && resultado is not null)
                {
                    lblResultado.Text = "Resultado: " + resultado.ConvertirA(Numeracion.ESistema.Binario);
                }
                else if (resultado is null && rdbBinario.Checked)
                {
                    MessageBox.Show("no hay numero para convertir", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdbBinario.Checked = false;
                }
            }
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in grpSistema.Controls)
            {
                if (control is RadioButton && rdbDecimal.Checked && resultado is not null)
                {
                    lblResultado.Text = "Resultado: " + resultado.ConvertirA(Numeracion.ESistema.Decimal);
                }
                else if (resultado is null && rdbDecimal.Checked)
                {
                    MessageBox.Show("no hay numero para convertir", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdbDecimal.Checked = false;

                }
            }
        }

        private void SetResultado()
        {
            calculadora = new Operacion(primerOperando, segundoOperando);

            switch (cmbOperacion.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("seleccione una operación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

                case 1:
                    resultado = calculadora.Operar('+');
                    lblResultado.Text = "Resultado: " + resultado.GetValor();
                    break;

                case 2:
                    resultado = calculadora.Operar('-');
                    lblResultado.Text = "Resultado: " + resultado.GetValor();
                    break;

                case 3:
                    resultado = calculadora.Operar('*');
                    lblResultado.Text = "Resultado: " + resultado.GetValor();
                    break;

                case 4:
                    if (txtSegundoOperador.Text == "0")
                    {
                        MessageBox.Show("No se puede Dividir por cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        resultado = calculadora.Operar('/');
                        lblResultado.Text = "Resultado: " + resultado.GetValor();
                    }
                    break;

                default:
                    MessageBox.Show("seleccione una operación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            primerOperando = new(txtPrimerOperador.Text, Numeracion.ESistema.Decimal);
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            segundoOperando = new(txtSegundoOperador.Text, Numeracion.ESistema.Decimal);
        }


    }
}
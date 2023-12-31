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
                MessageBox.Show("Ingrese el n�mero correspondiente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                calculadora = new Operacion(primerOperando, segundoOperando);

                switch (cmbOperacion.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("seleccione una operaci�n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;

                    case 1:
                        resultado = calculadora.Operar('+');
                        SetResultado();                      
                        break;

                    case 2:
                        resultado = calculadora.Operar('-');
                        SetResultado();
                        break;

                    case 3:
                        resultado = calculadora.Operar('*');
                        SetResultado();
                        break;

                    case 4:
                        if (txtSegundoOperador.Text == "0")
                        {
                            MessageBox.Show("No se puede Dividir por cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            resultado = calculadora.Operar('/');
                            SetResultado();
                        }
                        break;

                    default:
                        MessageBox.Show("seleccione una operaci�n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
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
            DialogResult resultado = MessageBox.Show("�Desea cerrar la calculadora?", "Cerrar calculadora", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in grpSistema.Controls)
            {
                if (control is RadioButton && rdbBinario.Checked)
                {
                    sistema = Numeracion.ESistema.Binario;
                   
                }              
            }
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in grpSistema.Controls)
            {
                if (control is RadioButton && rdbDecimal.Checked)
                {
                    sistema = Numeracion.ESistema.Decimal;
                    
                }
            }
        }

        private void SetResultado()
        {
            
            if(resultado is not null && (rdbDecimal.Checked || rdbBinario.Checked))
            {
                lblResultado.Text = "Resultado: " + resultado.ConvertirA(sistema);
            }
            else
            {
                MessageBox.Show("Seleccione sistema decimal o binario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
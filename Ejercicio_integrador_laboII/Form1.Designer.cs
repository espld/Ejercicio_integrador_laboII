using Entidades;

namespace Ejercicio_integrador_laboII
{
    partial class FmrCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            lblPrimerOperador = new Label();
            lblSegundoOperador = new Label();
            lblOperacion = new Label();
            lblResultado = new Label();
            cmbOperacion = new ComboBox();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.BackColor = SystemColors.Window;
            btnOperar.ForeColor = SystemColors.ControlText;
            btnOperar.Location = new Point(28, 341);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(180, 50);
            btnOperar.TabIndex = 1;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Window;
            btnLimpiar.Location = new Point(297, 341);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 50);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Window;
            btnCerrar.Location = new Point(567, 341);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(180, 50);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(28, 258);
            txtPrimerOperador.Multiline = true;
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(180, 50);
            txtPrimerOperador.TabIndex = 4;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(567, 258);
            txtSegundoOperador.Multiline = true;
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(180, 50);
            txtSegundoOperador.TabIndex = 5;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(28, 224);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(180, 31);
            lblPrimerOperador.TabIndex = 6;
            lblPrimerOperador.Text = "Primer operador:";
            lblPrimerOperador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(567, 224);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(180, 31);
            lblSegundoOperador.TabIndex = 7;
            lblSegundoOperador.Text = "Segundo operador:";
            lblSegundoOperador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOperacion
            // 
            lblOperacion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(297, 224);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(180, 31);
            lblOperacion.TabIndex = 8;
            lblOperacion.Text = "Operacion:";
            lblOperacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(28, 29);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(719, 74);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.BackColor = SystemColors.Window;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.ForeColor = SystemColors.WindowText;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(325, 270);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 10;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(279, 137);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(224, 84);
            grpSistema.TabIndex = 11;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBinario.Location = new Point(136, 37);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(66, 21);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(18, 37);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(72, 21);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // FmrCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 429);
            Controls.Add(grpSistema);
            Controls.Add(cmbOperacion);
            Controls.Add(lblResultado);
            Controls.Add(lblOperacion);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FmrCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de: Lucas Espindola";
            TransparencyKey = Color.Gray;
            FormClosing += FmrCalculadora_FormClosing;
            Load += FmrCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private Label lblPrimerOperador;
        private Label lblSegundoOperador;
        private Label lblOperacion;
        private Label lblResultado;
        private ComboBox cmbOperacion;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;

        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private Numeracion.ESistema sistema;
    }
}

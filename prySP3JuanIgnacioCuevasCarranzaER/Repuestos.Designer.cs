namespace prySP3JuanIgnacioCuevasCarranzaER
{
    partial class frmRepuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbFiltroMarca = new ComboBox();
            tcRegistro = new TabControl();
            tpRegistro = new TabPage();
            btnRegistrar = new Button();
            lblMarca = new Label();
            panel1 = new Panel();
            nudPrecio = new NumericUpDown();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblNumero = new Label();
            txtDescripcion = new TextBox();
            txtNumero = new TextBox();
            gbxOrige = new GroupBox();
            rbImportado = new RadioButton();
            rbNacional = new RadioButton();
            cmbMarca = new ComboBox();
            tpConsulta = new TabPage();
            btnAceptar = new Button();
            lbResultado = new ListBox();
            gbFiltroOrigen = new GroupBox();
            rbImportadoFiltro = new RadioButton();
            rbNacionalFiltro = new RadioButton();
            lblMarcaFiltro = new Label();
            tcRegistro.SuspendLayout();
            tpRegistro.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            gbxOrige.SuspendLayout();
            tpConsulta.SuspendLayout();
            gbFiltroOrigen.SuspendLayout();
            SuspendLayout();
            // 
            // cmbFiltroMarca
            // 
            cmbFiltroMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroMarca.FormattingEnabled = true;
            cmbFiltroMarca.Items.AddRange(new object[] { "(P) - Peugeot", "(F) - Fiat", "(R) - Renault" });
            cmbFiltroMarca.Location = new Point(6, 27);
            cmbFiltroMarca.Name = "cmbFiltroMarca";
            cmbFiltroMarca.Size = new Size(121, 23);
            cmbFiltroMarca.TabIndex = 0;
            // 
            // tcRegistro
            // 
            tcRegistro.Controls.Add(tpRegistro);
            tcRegistro.Controls.Add(tpConsulta);
            tcRegistro.Location = new Point(12, 12);
            tcRegistro.Name = "tcRegistro";
            tcRegistro.SelectedIndex = 0;
            tcRegistro.Size = new Size(296, 341);
            tcRegistro.TabIndex = 2;
            // 
            // tpRegistro
            // 
            tpRegistro.Controls.Add(btnRegistrar);
            tpRegistro.Controls.Add(lblMarca);
            tpRegistro.Controls.Add(panel1);
            tpRegistro.Controls.Add(gbxOrige);
            tpRegistro.Controls.Add(cmbMarca);
            tpRegistro.Location = new Point(4, 24);
            tpRegistro.Name = "tpRegistro";
            tpRegistro.Padding = new Padding(3);
            tpRegistro.Size = new Size(288, 313);
            tpRegistro.TabIndex = 0;
            tpRegistro.Text = "Registro";
            tpRegistro.UseVisualStyleBackColor = true;
            tpRegistro.Click += tabPage1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(205, 281);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(6, 18);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 7;
            lblMarca.Text = "Marca";
            // 
            // panel1
            // 
            panel1.Controls.Add(nudPrecio);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(lblNumero);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtNumero);
            panel1.Location = new Point(6, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 145);
            panel1.TabIndex = 9;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(66, 97);
            nudPrecio.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(14, 99);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(11, 58);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(14, 17);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 5;
            lblNumero.Text = "Número";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(86, 55);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(180, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(86, 14);
            txtNumero.MaxLength = 6;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // gbxOrige
            // 
            gbxOrige.Controls.Add(rbImportado);
            gbxOrige.Controls.Add(rbNacional);
            gbxOrige.Location = new Point(6, 44);
            gbxOrige.Name = "gbxOrige";
            gbxOrige.Size = new Size(142, 80);
            gbxOrige.TabIndex = 8;
            gbxOrige.TabStop = false;
            gbxOrige.Text = "Origen";
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(7, 47);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(95, 19);
            rbImportado.TabIndex = 3;
            rbImportado.TabStop = true;
            rbImportado.Text = "(I) Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(7, 22);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(92, 19);
            rbNacional.TabIndex = 2;
            rbNacional.TabStop = true;
            rbNacional.Text = "(N) Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "(P) - Peugeot", "(F) - Fiat", "(R) - Renault" });
            cmbMarca.Location = new Point(50, 15);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 6;
            // 
            // tpConsulta
            // 
            tpConsulta.Controls.Add(btnAceptar);
            tpConsulta.Controls.Add(lbResultado);
            tpConsulta.Controls.Add(gbFiltroOrigen);
            tpConsulta.Controls.Add(lblMarcaFiltro);
            tpConsulta.Controls.Add(cmbFiltroMarca);
            tpConsulta.Location = new Point(4, 24);
            tpConsulta.Name = "tpConsulta";
            tpConsulta.Padding = new Padding(3);
            tpConsulta.Size = new Size(288, 313);
            tpConsulta.TabIndex = 1;
            tpConsulta.Text = "Consulta";
            tpConsulta.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(7, 60);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lbResultado
            // 
            lbResultado.BackColor = SystemColors.ScrollBar;
            lbResultado.FormattingEnabled = true;
            lbResultado.Location = new Point(7, 93);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(273, 214);
            lbResultado.TabIndex = 6;
            // 
            // gbFiltroOrigen
            // 
            gbFiltroOrigen.Controls.Add(rbImportadoFiltro);
            gbFiltroOrigen.Controls.Add(rbNacionalFiltro);
            gbFiltroOrigen.Location = new Point(133, 9);
            gbFiltroOrigen.Name = "gbFiltroOrigen";
            gbFiltroOrigen.Size = new Size(147, 74);
            gbFiltroOrigen.TabIndex = 5;
            gbFiltroOrigen.TabStop = false;
            gbFiltroOrigen.Text = "Filtro Origen";
            gbFiltroOrigen.Enter += groupBox1_Enter_1;
            // 
            // rbImportadoFiltro
            // 
            rbImportadoFiltro.AutoSize = true;
            rbImportadoFiltro.Location = new Point(6, 47);
            rbImportadoFiltro.Name = "rbImportadoFiltro";
            rbImportadoFiltro.Size = new Size(95, 19);
            rbImportadoFiltro.TabIndex = 4;
            rbImportadoFiltro.TabStop = true;
            rbImportadoFiltro.Text = "(I) Importado";
            rbImportadoFiltro.UseVisualStyleBackColor = true;
            // 
            // rbNacionalFiltro
            // 
            rbNacionalFiltro.AutoSize = true;
            rbNacionalFiltro.Location = new Point(6, 22);
            rbNacionalFiltro.Name = "rbNacionalFiltro";
            rbNacionalFiltro.Size = new Size(92, 19);
            rbNacionalFiltro.TabIndex = 3;
            rbNacionalFiltro.TabStop = true;
            rbNacionalFiltro.Text = "(N) Nacional";
            rbNacionalFiltro.UseVisualStyleBackColor = true;
            // 
            // lblMarcaFiltro
            // 
            lblMarcaFiltro.AutoSize = true;
            lblMarcaFiltro.Location = new Point(6, 9);
            lblMarcaFiltro.Name = "lblMarcaFiltro";
            lblMarcaFiltro.Size = new Size(70, 15);
            lblMarcaFiltro.TabIndex = 1;
            lblMarcaFiltro.Text = "Filtro Marca";
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 352);
            Controls.Add(tcRegistro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repuestos";
            Load += Repuestos_Load;
            tcRegistro.ResumeLayout(false);
            tpRegistro.ResumeLayout(false);
            tpRegistro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            gbxOrige.ResumeLayout(false);
            gbxOrige.PerformLayout();
            tpConsulta.ResumeLayout(false);
            tpConsulta.PerformLayout();
            gbFiltroOrigen.ResumeLayout(false);
            gbFiltroOrigen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbFiltroMarca;
        private TabControl tcRegistro;
        private TabPage tpRegistro;
        private Button btnRegistrar;
        private Label lblMarca;
        private Panel panel1;
        private NumericUpDown nudPrecio;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblNumero;
        private TextBox txtDescripcion;
        private TextBox txtNumero;
        private GroupBox gbxOrige;
        private RadioButton rbImportado;
        private RadioButton rbNacional;
        private ComboBox cmbMarca;
        private TabPage tpConsulta;
        private Label lblMarcaFiltro;
        private GroupBox gbFiltroOrigen;
        private RadioButton rbImportadoFiltro;
        private RadioButton rbNacionalFiltro;
        private ListBox lbResultado;
        private Button btnAceptar;
    }
}
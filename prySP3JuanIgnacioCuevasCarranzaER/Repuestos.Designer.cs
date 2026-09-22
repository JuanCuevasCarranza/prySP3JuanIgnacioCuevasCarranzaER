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
            gbxIngresoDeRepuestos = new GroupBox();
            btnRegistrar = new Button();
            lblMarcaDeRepuesto = new Label();
            plNumeroDescripcionPrecio = new Panel();
            nudPrecio = new NumericUpDown();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblNumero = new Label();
            txtDescripcion = new TextBox();
            txtNumero = new TextBox();
            gbxOrigen = new GroupBox();
            rdbImportado = new RadioButton();
            rdbNacional = new RadioButton();
            crltBoxMarca = new ComboBox();
            gbxConsultaDeRepuestos = new GroupBox();
            comboBox1 = new ComboBox();
            gbxIngresoDeRepuestos.SuspendLayout();
            plNumeroDescripcionPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            gbxOrigen.SuspendLayout();
            gbxConsultaDeRepuestos.SuspendLayout();
            SuspendLayout();
            // 
            // gbxIngresoDeRepuestos
            // 
            gbxIngresoDeRepuestos.Controls.Add(btnRegistrar);
            gbxIngresoDeRepuestos.Controls.Add(lblMarcaDeRepuesto);
            gbxIngresoDeRepuestos.Controls.Add(plNumeroDescripcionPrecio);
            gbxIngresoDeRepuestos.Controls.Add(gbxOrigen);
            gbxIngresoDeRepuestos.Controls.Add(crltBoxMarca);
            gbxIngresoDeRepuestos.Location = new Point(12, 12);
            gbxIngresoDeRepuestos.Name = "gbxIngresoDeRepuestos";
            gbxIngresoDeRepuestos.Size = new Size(272, 326);
            gbxIngresoDeRepuestos.TabIndex = 0;
            gbxIngresoDeRepuestos.TabStop = false;
            gbxIngresoDeRepuestos.Text = "Ingreso De Repuestos";
            gbxIngresoDeRepuestos.Enter += groupBox1_Enter;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(191, 293);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblMarcaDeRepuesto
            // 
            lblMarcaDeRepuesto.AutoSize = true;
            lblMarcaDeRepuesto.Location = new Point(13, 30);
            lblMarcaDeRepuesto.Name = "lblMarcaDeRepuesto";
            lblMarcaDeRepuesto.Size = new Size(40, 15);
            lblMarcaDeRepuesto.TabIndex = 1;
            lblMarcaDeRepuesto.Text = "Marca";
            // 
            // plNumeroDescripcionPrecio
            // 
            plNumeroDescripcionPrecio.Controls.Add(nudPrecio);
            plNumeroDescripcionPrecio.Controls.Add(lblPrecio);
            plNumeroDescripcionPrecio.Controls.Add(lblDescripcion);
            plNumeroDescripcionPrecio.Controls.Add(lblNumero);
            plNumeroDescripcionPrecio.Controls.Add(txtDescripcion);
            plNumeroDescripcionPrecio.Controls.Add(txtNumero);
            plNumeroDescripcionPrecio.Location = new Point(17, 142);
            plNumeroDescripcionPrecio.Name = "plNumeroDescripcionPrecio";
            plNumeroDescripcionPrecio.Size = new Size(255, 145);
            plNumeroDescripcionPrecio.TabIndex = 4;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(86, 99);
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
            lblPrecio.Click += lblPrecio_Click;
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
            txtDescripcion.Size = new Size(160, 23);
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
            // gbxOrigen
            // 
            gbxOrigen.Controls.Add(rdbImportado);
            gbxOrigen.Controls.Add(rdbNacional);
            gbxOrigen.Location = new Point(17, 56);
            gbxOrigen.Name = "gbxOrigen";
            gbxOrigen.Size = new Size(142, 80);
            gbxOrigen.TabIndex = 1;
            gbxOrigen.TabStop = false;
            gbxOrigen.Text = "Origen";
            // 
            // rdbImportado
            // 
            rdbImportado.AutoSize = true;
            rdbImportado.Location = new Point(6, 47);
            rdbImportado.Name = "rdbImportado";
            rdbImportado.Size = new Size(95, 19);
            rdbImportado.TabIndex = 3;
            rdbImportado.TabStop = true;
            rdbImportado.Text = "(I) Importado";
            rdbImportado.UseVisualStyleBackColor = true;
            // 
            // rdbNacional
            // 
            rdbNacional.AutoSize = true;
            rdbNacional.Location = new Point(7, 22);
            rdbNacional.Name = "rdbNacional";
            rdbNacional.Size = new Size(92, 19);
            rdbNacional.TabIndex = 2;
            rdbNacional.TabStop = true;
            rdbNacional.Text = "(N) Nacional";
            rdbNacional.UseVisualStyleBackColor = true;
            // 
            // crltBoxMarca
            // 
            crltBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            crltBoxMarca.FormattingEnabled = true;
            crltBoxMarca.Items.AddRange(new object[] { "(P) - Peugeot", "(F) - Fiat", "(R) - Renault" });
            crltBoxMarca.Location = new Point(57, 27);
            crltBoxMarca.Name = "crltBoxMarca";
            crltBoxMarca.Size = new Size(121, 23);
            crltBoxMarca.TabIndex = 0;
            crltBoxMarca.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // gbxConsultaDeRepuestos
            // 
            gbxConsultaDeRepuestos.Controls.Add(comboBox1);
            gbxConsultaDeRepuestos.Location = new Point(12, 344);
            gbxConsultaDeRepuestos.Name = "gbxConsultaDeRepuestos";
            gbxConsultaDeRepuestos.Size = new Size(272, 274);
            gbxConsultaDeRepuestos.TabIndex = 1;
            gbxConsultaDeRepuestos.TabStop = false;
            gbxConsultaDeRepuestos.Text = "Consulta De Repuestos";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "(P) - Peugeot", "(F) - Fiat", "(R) - Renault" });
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 663);
            Controls.Add(gbxConsultaDeRepuestos);
            Controls.Add(gbxIngresoDeRepuestos);
            Name = "frmRepuestos";
            Text = "Repuestos";
            Load += Repuestos_Load;
            gbxIngresoDeRepuestos.ResumeLayout(false);
            gbxIngresoDeRepuestos.PerformLayout();
            plNumeroDescripcionPrecio.ResumeLayout(false);
            plNumeroDescripcionPrecio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            gbxOrigen.ResumeLayout(false);
            gbxOrigen.PerformLayout();
            gbxConsultaDeRepuestos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxIngresoDeRepuestos;
        private ComboBox crltBoxMarca;
        private GroupBox gbxOrigen;
        private RadioButton rdbImportado;
        private RadioButton rdbNacional;
        private TextBox txtNumero;
        private TextBox txtDescripcion;
        private Label lblMarcaDeRepuesto;
        private Panel plNumeroDescripcionPrecio;
        private Label lblDescripcion;
        private Label lblNumero;
        private Button btnRegistrar;
        private Label lblPrecio;
        private NumericUpDown nudPrecio;
        private GroupBox gbxConsultaDeRepuestos;
        private ComboBox comboBox1;
    }
}
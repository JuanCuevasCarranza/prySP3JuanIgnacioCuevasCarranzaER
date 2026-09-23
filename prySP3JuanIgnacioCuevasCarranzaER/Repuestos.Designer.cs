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
            comboBox1 = new ComboBox();
            tcRegistro = new TabControl();
            tpRegistro = new TabPage();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox2 = new ComboBox();
            tpConsulta = new TabPage();
            tcRegistro.SuspendLayout();
            tpRegistro.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            tpConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "(P) - Peugeot", "(F) - Fiat", "(R) - Renault" });
            comboBox1.Location = new Point(6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // tcRegistro
            // 
            tcRegistro.Controls.Add(tpRegistro);
            tcRegistro.Controls.Add(tpConsulta);
            tcRegistro.Location = new Point(12, 12);
            tcRegistro.Name = "tcRegistro";
            tcRegistro.SelectedIndex = 0;
            tcRegistro.Size = new Size(424, 433);
            tcRegistro.TabIndex = 2;
            // 
            // tpRegistro
            // 
            tpRegistro.Controls.Add(button1);
            tpRegistro.Controls.Add(label1);
            tpRegistro.Controls.Add(panel1);
            tpRegistro.Controls.Add(groupBox1);
            tpRegistro.Controls.Add(comboBox2);
            tpRegistro.Location = new Point(4, 24);
            tpRegistro.Name = "tpRegistro";
            tpRegistro.Padding = new Padding(3);
            tpRegistro.Size = new Size(416, 405);
            tpRegistro.TabIndex = 0;
            tpRegistro.Text = "Registro";
            tpRegistro.UseVisualStyleBackColor = true;
            tpRegistro.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(197, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Marca";
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(23, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 145);
            panel1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(86, 99);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 99);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 58);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 17);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 55);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 14);
            textBox2.MaxLength = 6;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(23, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 80);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Origen";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "(I) Importado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "(N) Nacional";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "(P) - Peugeot", "(F) - Fiat", "(R) - Renault" });
            comboBox2.Location = new Point(63, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // tpConsulta
            // 
            tpConsulta.Controls.Add(comboBox1);
            tpConsulta.Location = new Point(4, 24);
            tpConsulta.Name = "tpConsulta";
            tpConsulta.Padding = new Padding(3);
            tpConsulta.Size = new Size(416, 405);
            tpConsulta.TabIndex = 1;
            tpConsulta.Text = "Consulta";
            tpConsulta.UseVisualStyleBackColor = true;
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 452);
            Controls.Add(tcRegistro);
            Name = "frmRepuestos";
            Text = "Repuestos";
            Load += Repuestos_Load;
            tcRegistro.ResumeLayout(false);
            tpRegistro.ResumeLayout(false);
            tpRegistro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tpConsulta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private TabControl tcRegistro;
        private TabPage tpRegistro;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
        private TabPage tpConsulta;
    }
}
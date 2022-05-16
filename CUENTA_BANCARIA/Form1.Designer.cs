
namespace CUENTA_BANCARIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        protected void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AÑOS = new System.Windows.Forms.Label();
            this.PeriodoBox = new System.Windows.Forms.NumericUpDown();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MontoInicial = new System.Windows.Forms.TextBox();
            this.InteresTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ComposicionBox = new System.Windows.Forms.ComboBox();
            this.CuotaTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Interes_Label = new System.Windows.Forms.Label();
            this.SaldoFinal_Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Incial_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodoBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AÑOS);
            this.groupBox1.Controls.Add(this.PeriodoBox);
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.MontoInicial);
            this.groupBox1.Controls.Add(this.InteresTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ComposicionBox);
            this.groupBox1.Controls.Add(this.CuotaTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTA DE CUENTA DE AHORRO";
            // 
            // AÑOS
            // 
            this.AÑOS.AutoSize = true;
            this.AÑOS.Location = new System.Drawing.Point(226, 94);
            this.AÑOS.Name = "AÑOS";
            this.AÑOS.Size = new System.Drawing.Size(37, 13);
            this.AÑOS.TabIndex = 17;
            this.AÑOS.Text = "AÑOS";
            // 
            // PeriodoBox
            // 
            this.PeriodoBox.Location = new System.Drawing.Point(177, 91);
            this.PeriodoBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PeriodoBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeriodoBox.Name = "PeriodoBox";
            this.PeriodoBox.Size = new System.Drawing.Size(45, 20);
            this.PeriodoBox.TabIndex = 6;
            this.PeriodoBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(80, 30);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(173, 20);
            this.NombreTxt.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "MONTO INICIAL :       $ ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "INTERES ANUAL : ";
            // 
            // MontoInicial
            // 
            this.MontoInicial.Location = new System.Drawing.Point(176, 180);
            this.MontoInicial.Name = "MontoInicial";
            this.MontoInicial.Size = new System.Drawing.Size(89, 20);
            this.MontoInicial.TabIndex = 15;
            this.MontoInicial.Text = "00.00";
            // 
            // InteresTxt
            // 
            this.InteresTxt.Location = new System.Drawing.Point(176, 149);
            this.InteresTxt.Name = "InteresTxt";
            this.InteresTxt.Size = new System.Drawing.Size(89, 20);
            this.InteresTxt.TabIndex = 14;
            this.InteresTxt.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "PERIODO DE AHORRO : ";
            // 
            // ComposicionBox
            // 
            this.ComposicionBox.FormattingEnabled = true;
            this.ComposicionBox.Items.AddRange(new object[] {
            "MENSUAL",
            "SEMESTRAL",
            "ANUAL"});
            this.ComposicionBox.Location = new System.Drawing.Point(176, 118);
            this.ComposicionBox.Name = "ComposicionBox";
            this.ComposicionBox.Size = new System.Drawing.Size(89, 21);
            this.ComposicionBox.TabIndex = 8;
            // 
            // CuotaTxt
            // 
            this.CuotaTxt.Location = new System.Drawing.Point(177, 65);
            this.CuotaTxt.Name = "CuotaTxt";
            this.CuotaTxt.Size = new System.Drawing.Size(88, 20);
            this.CuotaTxt.TabIndex = 7;
            this.CuotaTxt.Text = "00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "COMPOSICION APLICA A: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CUOTA DE DEPOSITO :       $ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "INTERES ANUAL : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MONTO INICIAL :  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Interes_Label);
            this.groupBox2.Controls.Add(this.SaldoFinal_Label);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Incial_Label);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULTADOS";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(90, 40);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(132, 13);
            this.NombreLabel.TabIndex = 6;
            this.NombreLabel.Text = "  NOMBRE DEL CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CLIENTE : ";
            // 
            // Interes_Label
            // 
            this.Interes_Label.AutoSize = true;
            this.Interes_Label.Location = new System.Drawing.Point(181, 70);
            this.Interes_Label.Name = "Interes_Label";
            this.Interes_Label.Size = new System.Drawing.Size(21, 13);
            this.Interes_Label.TabIndex = 4;
            this.Interes_Label.Text = "0%";
            // 
            // SaldoFinal_Label
            // 
            this.SaldoFinal_Label.AutoSize = true;
            this.SaldoFinal_Label.Location = new System.Drawing.Point(173, 130);
            this.SaldoFinal_Label.Name = "SaldoFinal_Label";
            this.SaldoFinal_Label.Size = new System.Drawing.Size(43, 13);
            this.SaldoFinal_Label.TabIndex = 3;
            this.SaldoFinal_Label.Text = "$ 00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "SALDO FINAL:     ";
            // 
            // Incial_Label
            // 
            this.Incial_Label.AutoSize = true;
            this.Incial_Label.Location = new System.Drawing.Point(173, 98);
            this.Incial_Label.Name = "Incial_Label";
            this.Incial_Label.Size = new System.Drawing.Size(43, 13);
            this.Incial_Label.TabIndex = 1;
            this.Incial_Label.Text = "$ 00.00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "BORRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(312, 41);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(455, 403);
            this.dataGV.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(567, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 461);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CUENTA BANCARIA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodoBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComposicionBox;
        private System.Windows.Forms.TextBox CuotaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Interes_Label;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MontoInicial;
        private System.Windows.Forms.TextBox InteresTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SaldoFinal_Label;
        private System.Windows.Forms.Label Incial_Label;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown PeriodoBox;
        private System.Windows.Forms.Label AÑOS;
    }
}


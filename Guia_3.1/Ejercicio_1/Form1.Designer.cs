namespace Ejercicio_1
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
        private void InitializeComponent()
        {
            this.gbDatosV = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabr = new System.Windows.Forms.TextBox();
            this.nudModelo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudAñoACalc = new System.Windows.Forms.NumericUpDown();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.tbTasaDepreciacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.gbDatosV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoACalc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosV
            // 
            this.gbDatosV.Controls.Add(this.nudModelo);
            this.gbDatosV.Controls.Add(this.tbValorFabr);
            this.gbDatosV.Controls.Add(this.tbMarca);
            this.gbDatosV.Controls.Add(this.label3);
            this.gbDatosV.Controls.Add(this.label2);
            this.gbDatosV.Controls.Add(this.label1);
            this.gbDatosV.Location = new System.Drawing.Point(12, 12);
            this.gbDatosV.Name = "gbDatosV";
            this.gbDatosV.Size = new System.Drawing.Size(452, 154);
            this.gbDatosV.TabIndex = 0;
            this.gbDatosV.TabStop = false;
            this.gbDatosV.Text = "Datos del Vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de Fabricacion $";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(251, 40);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 3;
            // 
            // tbValorFabr
            // 
            this.tbValorFabr.Location = new System.Drawing.Point(251, 111);
            this.tbValorFabr.Name = "tbValorFabr";
            this.tbValorFabr.Size = new System.Drawing.Size(100, 20);
            this.tbValorFabr.TabIndex = 4;
            // 
            // nudModelo
            // 
            this.nudModelo.Location = new System.Drawing.Point(251, 74);
            this.nudModelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nudModelo.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudModelo.Name = "nudModelo";
            this.nudModelo.Size = new System.Drawing.Size(100, 20);
            this.nudModelo.TabIndex = 1;
            this.nudModelo.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcularCosto);
            this.groupBox1.Controls.Add(this.rbAnual);
            this.groupBox1.Controls.Add(this.rbLineal);
            this.groupBox1.Controls.Add(this.nudAñoACalc);
            this.groupBox1.Controls.Add(this.tbVidaUtil);
            this.groupBox1.Controls.Add(this.tbTasaDepreciacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 163);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vehiculo";
            // 
            // nudAñoACalc
            // 
            this.nudAñoACalc.Location = new System.Drawing.Point(207, 58);
            this.nudAñoACalc.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nudAñoACalc.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAñoACalc.Name = "nudAñoACalc";
            this.nudAñoACalc.Size = new System.Drawing.Size(100, 20);
            this.nudAñoACalc.TabIndex = 1;
            this.nudAñoACalc.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(207, 128);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 4;
            // 
            // tbTasaDepreciacion
            // 
            this.tbTasaDepreciacion.Location = new System.Drawing.Point(207, 90);
            this.tbTasaDepreciacion.Name = "tbTasaDepreciacion";
            this.tbTasaDepreciacion.Size = new System.Drawing.Size(100, 20);
            this.tbTasaDepreciacion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vida Util (años)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tasa de depreciacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Año a calcular";
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Location = new System.Drawing.Point(54, 28);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(53, 17);
            this.rbLineal.TabIndex = 5;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(191, 28);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(52, 17);
            this.rbAnual.TabIndex = 6;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(359, 102);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(75, 46);
            this.btnCalcularCosto.TabIndex = 7;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatosV);
            this.Name = "Form1";
            this.Text = "Tasacion de motos";
            this.gbDatosV.ResumeLayout(false);
            this.gbDatosV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoACalc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosV;
        private System.Windows.Forms.NumericUpDown nudModelo;
        private System.Windows.Forms.TextBox tbValorFabr;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbLineal;
        private System.Windows.Forms.NumericUpDown nudAñoACalc;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.TextBox tbTasaDepreciacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcularCosto;
    }
}


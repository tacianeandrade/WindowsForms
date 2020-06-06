namespace WinApp
{
    partial class frmFahrenheit
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
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnNovoCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(36, 13);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit.TabIndex = 0;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(142, 13);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(142, 61);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(39, 114);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(40, 13);
            this.lblCelsius.TabIndex = 3;
            this.lblCelsius.Text = "Celsius";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Enabled = false;
            this.txtCelsius.Location = new System.Drawing.Point(142, 114);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 4;
            // 
            // btnNovoCalculo
            // 
            this.btnNovoCalculo.Location = new System.Drawing.Point(142, 171);
            this.btnNovoCalculo.Name = "btnNovoCalculo";
            this.btnNovoCalculo.Size = new System.Drawing.Size(100, 23);
            this.btnNovoCalculo.TabIndex = 5;
            this.btnNovoCalculo.Text = "Novo Cálculo";
            this.btnNovoCalculo.UseVisualStyleBackColor = true;
            this.btnNovoCalculo.Click += new System.EventHandler(this.btnNovoCalculo_Click);
            // 
            // frmFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnNovoCalculo);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblFahrenheit);
            this.Name = "frmFahrenheit";
            this.Text = "Celsius - Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnNovoCalculo;
    }
}
namespace WinApp
{
    partial class frmCambioRadioButton
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
            this.lblValor = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpBoxMoeda = new System.Windows.Forms.GroupBox();
            this.rdbIene = new System.Windows.Forms.RadioButton();
            this.rdbLibra = new System.Windows.Forms.RadioButton();
            this.rdbDollar = new System.Windows.Forms.RadioButton();
            this.rdbSek = new System.Windows.Forms.RadioButton();
            this.grpBoxMoeda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(13, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(57, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor em €";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(13, 30);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(100, 20);
            this.tbxValor.TabIndex = 1;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(16, 87);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(97, 23);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(34, 141);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            // 
            // grpBoxMoeda
            // 
            this.grpBoxMoeda.Controls.Add(this.rdbSek);
            this.grpBoxMoeda.Controls.Add(this.rdbIene);
            this.grpBoxMoeda.Controls.Add(this.rdbLibra);
            this.grpBoxMoeda.Controls.Add(this.rdbDollar);
            this.grpBoxMoeda.Location = new System.Drawing.Point(137, 13);
            this.grpBoxMoeda.Name = "grpBoxMoeda";
            this.grpBoxMoeda.Size = new System.Drawing.Size(200, 121);
            this.grpBoxMoeda.TabIndex = 4;
            this.grpBoxMoeda.TabStop = false;
            this.grpBoxMoeda.Text = "Moeda";
            // 
            // rdbIene
            // 
            this.rdbIene.AutoSize = true;
            this.rdbIene.Location = new System.Drawing.Point(16, 65);
            this.rdbIene.Name = "rdbIene";
            this.rdbIene.Size = new System.Drawing.Size(46, 17);
            this.rdbIene.TabIndex = 2;
            this.rdbIene.TabStop = true;
            this.rdbIene.Text = "Iéne";
            this.rdbIene.UseVisualStyleBackColor = true;
            // 
            // rdbLibra
            // 
            this.rdbLibra.AutoSize = true;
            this.rdbLibra.Location = new System.Drawing.Point(16, 42);
            this.rdbLibra.Name = "rdbLibra";
            this.rdbLibra.Size = new System.Drawing.Size(48, 17);
            this.rdbLibra.TabIndex = 1;
            this.rdbLibra.TabStop = true;
            this.rdbLibra.Text = "Libra";
            this.rdbLibra.UseVisualStyleBackColor = true;
            // 
            // rdbDollar
            // 
            this.rdbDollar.AutoSize = true;
            this.rdbDollar.Location = new System.Drawing.Point(16, 19);
            this.rdbDollar.Name = "rdbDollar";
            this.rdbDollar.Size = new System.Drawing.Size(52, 17);
            this.rdbDollar.TabIndex = 0;
            this.rdbDollar.TabStop = true;
            this.rdbDollar.Text = "Dollar";
            this.rdbDollar.UseVisualStyleBackColor = true;
            // 
            // rdbSek
            // 
            this.rdbSek.AutoSize = true;
            this.rdbSek.Location = new System.Drawing.Point(16, 88);
            this.rdbSek.Name = "rdbSek";
            this.rdbSek.Size = new System.Drawing.Size(46, 17);
            this.rdbSek.TabIndex = 3;
            this.rdbSek.TabStop = true;
            this.rdbSek.Text = "SEK";
            this.rdbSek.UseVisualStyleBackColor = true;
            // 
            // frmCambioRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 172);
            this.Controls.Add(this.grpBoxMoeda);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.lblValor);
            this.Name = "frmCambioRadioButton";
            this.Text = "Câmbio";
            this.grpBoxMoeda.ResumeLayout(false);
            this.grpBoxMoeda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox grpBoxMoeda;
        private System.Windows.Forms.RadioButton rdbDollar;
        private System.Windows.Forms.RadioButton rdbLibra;
        private System.Windows.Forms.RadioButton rdbIene;
        private System.Windows.Forms.RadioButton rdbSek;
    }
}
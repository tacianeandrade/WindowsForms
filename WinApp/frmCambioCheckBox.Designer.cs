namespace WinApp
{
    partial class frmCambioCheckBox
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
            this.grpBoxMoeda = new System.Windows.Forms.GroupBox();
            this.chkDollar = new System.Windows.Forms.CheckBox();
            this.chkLibra = new System.Windows.Forms.CheckBox();
            this.chkIene = new System.Windows.Forms.CheckBox();
            this.chkSek = new System.Windows.Forms.CheckBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpBoxMoeda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(24, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(57, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor em €";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(13, 44);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(100, 20);
            this.tbxValor.TabIndex = 1;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(27, 96);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // grpBoxMoeda
            // 
            this.grpBoxMoeda.Controls.Add(this.chkSek);
            this.grpBoxMoeda.Controls.Add(this.chkIene);
            this.grpBoxMoeda.Controls.Add(this.chkLibra);
            this.grpBoxMoeda.Controls.Add(this.chkDollar);
            this.grpBoxMoeda.Location = new System.Drawing.Point(149, 13);
            this.grpBoxMoeda.Name = "grpBoxMoeda";
            this.grpBoxMoeda.Size = new System.Drawing.Size(131, 115);
            this.grpBoxMoeda.TabIndex = 3;
            this.grpBoxMoeda.TabStop = false;
            this.grpBoxMoeda.Text = "Moeda";
            // 
            // chkDollar
            // 
            this.chkDollar.AutoSize = true;
            this.chkDollar.Location = new System.Drawing.Point(7, 20);
            this.chkDollar.Name = "chkDollar";
            this.chkDollar.Size = new System.Drawing.Size(53, 17);
            this.chkDollar.TabIndex = 0;
            this.chkDollar.Text = "Dollar";
            this.chkDollar.UseVisualStyleBackColor = true;
            // 
            // chkLibra
            // 
            this.chkLibra.AutoSize = true;
            this.chkLibra.Location = new System.Drawing.Point(7, 44);
            this.chkLibra.Name = "chkLibra";
            this.chkLibra.Size = new System.Drawing.Size(49, 17);
            this.chkLibra.TabIndex = 1;
            this.chkLibra.Text = "Libra";
            this.chkLibra.UseVisualStyleBackColor = true;
            // 
            // chkIene
            // 
            this.chkIene.AutoSize = true;
            this.chkIene.Location = new System.Drawing.Point(7, 68);
            this.chkIene.Name = "chkIene";
            this.chkIene.Size = new System.Drawing.Size(47, 17);
            this.chkIene.TabIndex = 2;
            this.chkIene.Text = "Iéne";
            this.chkIene.UseVisualStyleBackColor = true;
            // 
            // chkSek
            // 
            this.chkSek.AutoSize = true;
            this.chkSek.Location = new System.Drawing.Point(7, 92);
            this.chkSek.Name = "chkSek";
            this.chkSek.Size = new System.Drawing.Size(47, 17);
            this.chkSek.TabIndex = 3;
            this.chkSek.Text = "SEK";
            this.chkSek.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(24, 145);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "label1";
            // 
            // frmCambioCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 209);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.grpBoxMoeda);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.lblValor);
            this.Name = "frmCambioCheckBox";
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
        private System.Windows.Forms.GroupBox grpBoxMoeda;
        private System.Windows.Forms.CheckBox chkSek;
        private System.Windows.Forms.CheckBox chkIene;
        private System.Windows.Forms.CheckBox chkLibra;
        private System.Windows.Forms.CheckBox chkDollar;
        private System.Windows.Forms.Label lblResultado;
    }
}
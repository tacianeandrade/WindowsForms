namespace WinApp
{
    partial class frmCambioDropDown
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.cmbxMoeda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor em €";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(13, 48);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(100, 20);
            this.tbxValor.TabIndex = 1;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(25, 102);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(25, 156);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label2";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(154, 12);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(40, 13);
            this.lblMoeda.TabIndex = 4;
            this.lblMoeda.Text = "Moeda";
            // 
            // cmbxMoeda
            // 
            this.cmbxMoeda.FormattingEnabled = true;
            this.cmbxMoeda.Items.AddRange(new object[] {
            "Dollar",
            "Libra",
            "Iéne",
            "SEK"});
            this.cmbxMoeda.Location = new System.Drawing.Point(157, 48);
            this.cmbxMoeda.Name = "cmbxMoeda";
            this.cmbxMoeda.Size = new System.Drawing.Size(121, 21);
            this.cmbxMoeda.TabIndex = 5;
            // 
            // frmCambioDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 192);
            this.Controls.Add(this.cmbxMoeda);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioDropDown";
            this.Text = "Câmbio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.ComboBox cmbxMoeda;
    }
}
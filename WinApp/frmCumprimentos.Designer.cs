namespace WinApp
{
    partial class frmCumprimentos
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
            this.txtCumprimento = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCumprimento = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCumprimento
            // 
            this.txtCumprimento.Location = new System.Drawing.Point(52, 23);
            this.txtCumprimento.Name = "txtCumprimento";
            this.txtCumprimento.Size = new System.Drawing.Size(100, 20);
            this.txtCumprimento.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(190, 45);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Clique";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCumprimento
            // 
            this.lblCumprimento.AutoSize = true;
            this.lblCumprimento.Location = new System.Drawing.Point(52, 131);
            this.lblCumprimento.Name = "lblCumprimento";
            this.lblCumprimento.Size = new System.Drawing.Size(35, 13);
            this.lblCumprimento.TabIndex = 3;
            this.lblCumprimento.Text = "label1";
            this.lblCumprimento.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(52, 176);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCumprimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblCumprimento);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCumprimento);
            this.Name = "frmCumprimentos";
            this.Text = "Cumprimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCumprimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCumprimento;
        private System.Windows.Forms.Button btnLimpar;
    }
}


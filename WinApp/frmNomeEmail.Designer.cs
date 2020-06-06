namespace WinApp
{
    partial class frmNomeEmail
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
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.tbxNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblTxtNome = new System.Windows.Forms.Label();
            this.lblTxtEmail1 = new System.Windows.Forms.Label();
            this.lblTxtEmail2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(13, 57);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // tbxNomeCompleto
            // 
            this.tbxNomeCompleto.Location = new System.Drawing.Point(102, 57);
            this.tbxNomeCompleto.Name = "tbxNomeCompleto";
            this.tbxNomeCompleto.Size = new System.Drawing.Size(551, 20);
            this.tbxNomeCompleto.TabIndex = 1;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(302, 102);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(60, 160);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Location = new System.Drawing.Point(59, 197);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(44, 13);
            this.lblEmail1.TabIndex = 4;
            this.lblEmail1.Text = "E-mail 1";
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(59, 240);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(44, 13);
            this.lblEmail2.TabIndex = 5;
            this.lblEmail2.Text = "E-mail 2";
            // 
            // lblTxtNome
            // 
            this.lblTxtNome.AutoSize = true;
            this.lblTxtNome.Location = new System.Drawing.Point(135, 160);
            this.lblTxtNome.Name = "lblTxtNome";
            this.lblTxtNome.Size = new System.Drawing.Size(35, 13);
            this.lblTxtNome.TabIndex = 6;
            this.lblTxtNome.Text = "label1";
            // 
            // lblTxtEmail1
            // 
            this.lblTxtEmail1.AutoSize = true;
            this.lblTxtEmail1.Location = new System.Drawing.Point(135, 197);
            this.lblTxtEmail1.Name = "lblTxtEmail1";
            this.lblTxtEmail1.Size = new System.Drawing.Size(35, 13);
            this.lblTxtEmail1.TabIndex = 7;
            this.lblTxtEmail1.Text = "label1";
            // 
            // lblTxtEmail2
            // 
            this.lblTxtEmail2.AutoSize = true;
            this.lblTxtEmail2.Location = new System.Drawing.Point(135, 240);
            this.lblTxtEmail2.Name = "lblTxtEmail2";
            this.lblTxtEmail2.Size = new System.Drawing.Size(35, 13);
            this.lblTxtEmail2.TabIndex = 8;
            this.lblTxtEmail2.Text = "label1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(302, 278);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmNomeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 313);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTxtEmail2);
            this.Controls.Add(this.lblTxtEmail1);
            this.Controls.Add(this.lblTxtNome);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.tbxNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Name = "frmNomeEmail";
            this.Text = "Nome e Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox tbxNomeCompleto;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Label lblTxtNome;
        private System.Windows.Forms.Label lblTxtEmail1;
        private System.Windows.Forms.Label lblTxtEmail2;
        private System.Windows.Forms.Button btnLimpar;
    }
}
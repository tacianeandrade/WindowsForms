namespace WinApp
{
    partial class frmArvore
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
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.btnArvore = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblArvore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(13, 13);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 20);
            this.nudValor.TabIndex = 0;
            // 
            // btnArvore
            // 
            this.btnArvore.Location = new System.Drawing.Point(13, 40);
            this.btnArvore.Name = "btnArvore";
            this.btnArvore.Size = new System.Drawing.Size(120, 23);
            this.btnArvore.TabIndex = 1;
            this.btnArvore.Text = "Faz Árvore";
            this.btnArvore.UseVisualStyleBackColor = true;
            this.btnArvore.Click += new System.EventHandler(this.btnArvore_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 70);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblArvore
            // 
            this.lblArvore.AutoSize = true;
            this.lblArvore.Location = new System.Drawing.Point(221, 49);
            this.lblArvore.Name = "lblArvore";
            this.lblArvore.Size = new System.Drawing.Size(35, 13);
            this.lblArvore.TabIndex = 3;
            this.lblArvore.Text = "label1";
            this.lblArvore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmArvore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArvore);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnArvore);
            this.Controls.Add(this.nudValor);
            this.Name = "frmArvore";
            this.Text = "Árvore";
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Button btnArvore;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblArvore;
    }
}
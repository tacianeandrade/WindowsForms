namespace WinApp
{
    partial class frmMeusHobbies
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
            this.rtbHobbies = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkPesca = new System.Windows.Forms.CheckBox();
            this.chkLeitura = new System.Windows.Forms.CheckBox();
            this.chkCinema = new System.Windows.Forms.CheckBox();
            this.chkTeatro = new System.Windows.Forms.CheckBox();
            this.chkCaminhadas = new System.Windows.Forms.CheckBox();
            this.chkBricolage = new System.Windows.Forms.CheckBox();
            this.chkTricot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbHobbies
            // 
            this.rtbHobbies.Location = new System.Drawing.Point(12, 12);
            this.rtbHobbies.Name = "rtbHobbies";
            this.rtbHobbies.Size = new System.Drawing.Size(260, 195);
            this.rtbHobbies.TabIndex = 0;
            this.rtbHobbies.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(106, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkPesca
            // 
            this.chkPesca.AutoSize = true;
            this.chkPesca.Location = new System.Drawing.Point(19, 18);
            this.chkPesca.Name = "chkPesca";
            this.chkPesca.Size = new System.Drawing.Size(56, 17);
            this.chkPesca.TabIndex = 2;
            this.chkPesca.Text = "Pesca";
            this.chkPesca.UseVisualStyleBackColor = true;
            // 
            // chkLeitura
            // 
            this.chkLeitura.AutoSize = true;
            this.chkLeitura.Location = new System.Drawing.Point(19, 41);
            this.chkLeitura.Name = "chkLeitura";
            this.chkLeitura.Size = new System.Drawing.Size(58, 17);
            this.chkLeitura.TabIndex = 3;
            this.chkLeitura.Text = "Leitura";
            this.chkLeitura.UseVisualStyleBackColor = true;
            // 
            // chkCinema
            // 
            this.chkCinema.AutoSize = true;
            this.chkCinema.Location = new System.Drawing.Point(19, 64);
            this.chkCinema.Name = "chkCinema";
            this.chkCinema.Size = new System.Drawing.Size(61, 17);
            this.chkCinema.TabIndex = 4;
            this.chkCinema.Text = "Cinema";
            this.chkCinema.UseVisualStyleBackColor = true;
            // 
            // chkTeatro
            // 
            this.chkTeatro.AutoSize = true;
            this.chkTeatro.Location = new System.Drawing.Point(19, 87);
            this.chkTeatro.Name = "chkTeatro";
            this.chkTeatro.Size = new System.Drawing.Size(57, 17);
            this.chkTeatro.TabIndex = 5;
            this.chkTeatro.Text = "Teatro";
            this.chkTeatro.UseVisualStyleBackColor = true;
            // 
            // chkCaminhadas
            // 
            this.chkCaminhadas.AutoSize = true;
            this.chkCaminhadas.Location = new System.Drawing.Point(19, 110);
            this.chkCaminhadas.Name = "chkCaminhadas";
            this.chkCaminhadas.Size = new System.Drawing.Size(84, 17);
            this.chkCaminhadas.TabIndex = 6;
            this.chkCaminhadas.Text = "Caminhadas";
            this.chkCaminhadas.UseVisualStyleBackColor = true;
            // 
            // chkBricolage
            // 
            this.chkBricolage.AutoSize = true;
            this.chkBricolage.Location = new System.Drawing.Point(19, 133);
            this.chkBricolage.Name = "chkBricolage";
            this.chkBricolage.Size = new System.Drawing.Size(70, 17);
            this.chkBricolage.TabIndex = 7;
            this.chkBricolage.Text = "Bricolage";
            this.chkBricolage.UseVisualStyleBackColor = true;
            // 
            // chkTricot
            // 
            this.chkTricot.AutoSize = true;
            this.chkTricot.Location = new System.Drawing.Point(19, 156);
            this.chkTricot.Name = "chkTricot";
            this.chkTricot.Size = new System.Drawing.Size(53, 17);
            this.chkTricot.TabIndex = 8;
            this.chkTricot.Text = "Tricot";
            this.chkTricot.UseVisualStyleBackColor = true;
            // 
            // frmMeusHobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chkTricot);
            this.Controls.Add(this.chkBricolage);
            this.Controls.Add(this.chkCaminhadas);
            this.Controls.Add(this.chkTeatro);
            this.Controls.Add(this.chkCinema);
            this.Controls.Add(this.chkLeitura);
            this.Controls.Add(this.chkPesca);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rtbHobbies);
            this.Name = "frmMeusHobbies";
            this.Text = "Meus Hobbies";
            this.Load += new System.EventHandler(this.frmMeusHobbies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHobbies;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkPesca;
        private System.Windows.Forms.CheckBox chkLeitura;
        private System.Windows.Forms.CheckBox chkCinema;
        private System.Windows.Forms.CheckBox chkTeatro;
        private System.Windows.Forms.CheckBox chkCaminhadas;
        private System.Windows.Forms.CheckBox chkBricolage;
        private System.Windows.Forms.CheckBox chkTricot;
    }
}
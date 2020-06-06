namespace WinApp
{
    partial class frmHobbies
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
            this.btnHobbies = new System.Windows.Forms.Button();
            this.btnSumario = new System.Windows.Forms.Button();
            this.rtbHobbies = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnHobbies
            // 
            this.btnHobbies.Location = new System.Drawing.Point(12, 13);
            this.btnHobbies.Name = "btnHobbies";
            this.btnHobbies.Size = new System.Drawing.Size(361, 23);
            this.btnHobbies.TabIndex = 0;
            this.btnHobbies.Text = "Carrega Hobbies";
            this.btnHobbies.UseVisualStyleBackColor = true;
            this.btnHobbies.Click += new System.EventHandler(this.btnHobbies_Click);
            // 
            // btnSumario
            // 
            this.btnSumario.Location = new System.Drawing.Point(12, 42);
            this.btnSumario.Name = "btnSumario";
            this.btnSumario.Size = new System.Drawing.Size(361, 23);
            this.btnSumario.TabIndex = 1;
            this.btnSumario.Text = "Ver Sumário";
            this.btnSumario.UseVisualStyleBackColor = true;
            this.btnSumario.Click += new System.EventHandler(this.btnSumario_Click);
            // 
            // rtbHobbies
            // 
            this.rtbHobbies.Location = new System.Drawing.Point(13, 72);
            this.rtbHobbies.Name = "rtbHobbies";
            this.rtbHobbies.Size = new System.Drawing.Size(360, 295);
            this.rtbHobbies.TabIndex = 2;
            this.rtbHobbies.Text = "";
            // 
            // frmHobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 379);
            this.Controls.Add(this.rtbHobbies);
            this.Controls.Add(this.btnSumario);
            this.Controls.Add(this.btnHobbies);
            this.Name = "frmHobbies";
            this.Text = "Hobbies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHobbies;
        private System.Windows.Forms.Button btnSumario;
        private System.Windows.Forms.RichTextBox rtbHobbies;
    }
}
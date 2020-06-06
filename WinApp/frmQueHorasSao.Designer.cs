namespace WinApp
{
    partial class frmQueHorasSao
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
            this.rdbAutomatico = new System.Windows.Forms.RadioButton();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.pgbHoras = new System.Windows.Forms.ProgressBar();
            this.pgbMinutos = new System.Windows.Forms.ProgressBar();
            this.pgbSegundos = new System.Windows.Forms.ProgressBar();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbAutomatico
            // 
            this.rdbAutomatico.AutoSize = true;
            this.rdbAutomatico.Location = new System.Drawing.Point(13, 213);
            this.rdbAutomatico.Name = "rdbAutomatico";
            this.rdbAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rdbAutomatico.TabIndex = 0;
            this.rdbAutomatico.TabStop = true;
            this.rdbAutomatico.Text = "Automático";
            this.rdbAutomatico.UseVisualStyleBackColor = true;
            this.rdbAutomatico.CheckedChanged += new System.EventHandler(this.rdbAutomatico_CheckedChanged);
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.Location = new System.Drawing.Point(13, 237);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(60, 17);
            this.rdbManual.TabIndex = 1;
            this.rdbManual.TabStop = true;
            this.rdbManual.Text = "Manual";
            this.rdbManual.UseVisualStyleBackColor = true;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // pgbHoras
            // 
            this.pgbHoras.Location = new System.Drawing.Point(13, 13);
            this.pgbHoras.Maximum = 23;
            this.pgbHoras.Name = "pgbHoras";
            this.pgbHoras.Size = new System.Drawing.Size(283, 23);
            this.pgbHoras.Step = 1;
            this.pgbHoras.TabIndex = 2;
            // 
            // pgbMinutos
            // 
            this.pgbMinutos.Location = new System.Drawing.Point(13, 56);
            this.pgbMinutos.Maximum = 59;
            this.pgbMinutos.Name = "pgbMinutos";
            this.pgbMinutos.Size = new System.Drawing.Size(575, 23);
            this.pgbMinutos.Step = 1;
            this.pgbMinutos.TabIndex = 3;
            // 
            // pgbSegundos
            // 
            this.pgbSegundos.Location = new System.Drawing.Point(13, 100);
            this.pgbSegundos.Maximum = 59;
            this.pgbSegundos.Name = "pgbSegundos";
            this.pgbSegundos.Size = new System.Drawing.Size(575, 23);
            this.pgbSegundos.Step = 1;
            this.pgbSegundos.TabIndex = 4;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(683, 22);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(35, 13);
            this.lblHoras.TabIndex = 5;
            this.lblHoras.Text = "label1";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(682, 56);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(35, 13);
            this.lblMinutos.TabIndex = 6;
            this.lblMinutos.Text = "label2";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(686, 100);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(35, 13);
            this.lblSegundos.TabIndex = 7;
            this.lblSegundos.Text = "label3";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(361, 364);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmQueHorasSao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.pgbSegundos);
            this.Controls.Add(this.pgbMinutos);
            this.Controls.Add(this.pgbHoras);
            this.Controls.Add(this.rdbManual);
            this.Controls.Add(this.rdbAutomatico);
            this.Name = "frmQueHorasSao";
            this.Text = "Horas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAutomatico;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.ProgressBar pgbHoras;
        private System.Windows.Forms.ProgressBar pgbMinutos;
        private System.Windows.Forms.ProgressBar pgbSegundos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
namespace WinApp
{
    partial class frmQuantoTempoPassou
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
            this.mCalendarMin = new System.Windows.Forms.MonthCalendar();
            this.mCalendarMax = new System.Windows.Forms.MonthCalendar();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblanos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mCalendarMin
            // 
            this.mCalendarMin.Location = new System.Drawing.Point(13, 13);
            this.mCalendarMin.MaxDate = new System.DateTime(2019, 12, 9, 11, 46, 31, 0);
            this.mCalendarMin.Name = "mCalendarMin";
            this.mCalendarMin.TabIndex = 0;
            this.mCalendarMin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendarMin_DateChanged);
            // 
            // mCalendarMax
            // 
            this.mCalendarMax.Location = new System.Drawing.Point(253, 13);
            this.mCalendarMax.Name = "mCalendarMax";
            this.mCalendarMax.TabIndex = 1;
            this.mCalendarMax.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendarMax_DateChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(543, 13);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "0 dias";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(543, 47);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(46, 13);
            this.lblMeses.TabIndex = 3;
            this.lblMeses.Text = "0 meses";
            // 
            // lblanos
            // 
            this.lblanos.AutoSize = true;
            this.lblanos.Location = new System.Drawing.Point(543, 78);
            this.lblanos.Name = "lblanos";
            this.lblanos.Size = new System.Drawing.Size(39, 13);
            this.lblanos.TabIndex = 4;
            this.lblanos.Text = "0 anos";
            // 
            // frmQuantoTempoPassou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblanos);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.mCalendarMax);
            this.Controls.Add(this.mCalendarMin);
            this.Name = "frmQuantoTempoPassou";
            this.Text = "Quanto tempo passou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendarMin;
        private System.Windows.Forms.MonthCalendar mCalendarMax;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblanos;
    }
}
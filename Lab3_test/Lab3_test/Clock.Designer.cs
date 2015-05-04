namespace Lab3_test
{
    partial class Clock
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
            this.Clock_panel = new System.Windows.Forms.Panel();
            this.label_clok = new System.Windows.Forms.Label();
            this.Clock_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clock_panel
            // 
            this.Clock_panel.BackColor = System.Drawing.SystemColors.Menu;
            this.Clock_panel.Controls.Add(this.label_clok);
            this.Clock_panel.Location = new System.Drawing.Point(0, 0);
            this.Clock_panel.Name = "Clock_panel";
            this.Clock_panel.Size = new System.Drawing.Size(260, 260);
            this.Clock_panel.TabIndex = 0;
            // 
            // label_clok
            // 
            this.label_clok.AutoSize = true;
            this.label_clok.BackColor = System.Drawing.SystemColors.Window;
            this.label_clok.Font = new System.Drawing.Font("a_LCDNova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_clok.Location = new System.Drawing.Point(95, 121);
            this.label_clok.Name = "label_clok";
            this.label_clok.Size = new System.Drawing.Size(70, 18);
            this.label_clok.TabIndex = 0;
            this.label_clok.Text = "00:00:00";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 260);
            this.Controls.Add(this.Clock_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock";
            this.Text = "Clock";
            this.Clock_panel.ResumeLayout(false);
            this.Clock_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Clock_panel;
        private System.Windows.Forms.Label label_clok;
    }
}
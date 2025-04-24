namespace S0IPAF.View
{
    partial class NevjegyForm
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
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelNeptun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(12, 23);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(75, 13);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "labelDateTime";
            this.labelDateTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNeptun
            // 
            this.labelNeptun.AutoSize = true;
            this.labelNeptun.Location = new System.Drawing.Point(12, 48);
            this.labelNeptun.Name = "labelNeptun";
            this.labelNeptun.Size = new System.Drawing.Size(43, 13);
            this.labelNeptun.TabIndex = 1;
            this.labelNeptun.Text = "S0IPAF";
            // 
            // NevjegyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 89);
            this.Controls.Add(this.labelNeptun);
            this.Controls.Add(this.labelDateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "NevjegyForm";
            this.Text = "Névjegy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelNeptun;
    }
}
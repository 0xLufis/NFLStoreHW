namespace S0IPAF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlBetöltéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kömyvelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlBetöltéseToolStripMenuItem,
            this.reToolStripMenuItem,
            this.kömyvelésToolStripMenuItem,
            this.névjegyToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlBetöltéseToolStripMenuItem
            // 
            this.fájlBetöltéseToolStripMenuItem.Name = "fájlBetöltéseToolStripMenuItem";
            this.fájlBetöltéseToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.fájlBetöltéseToolStripMenuItem.Text = "Fájl Betöltése...";
            this.fájlBetöltéseToolStripMenuItem.Click += new System.EventHandler(this.fájlBetöltéseToolStripMenuItem_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Enabled = false;
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.reToolStripMenuItem.Text = "Rendelés...";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.OrderFormButton_Click);
            // 
            // kömyvelésToolStripMenuItem
            // 
            this.kömyvelésToolStripMenuItem.Name = "kömyvelésToolStripMenuItem";
            this.kömyvelésToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.kömyvelésToolStripMenuItem.Text = "Könyvelés..";
            this.kömyvelésToolStripMenuItem.Click += new System.EventHandler(this.kömyvelésToolStripMenuItem_Click);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy...";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogLoadData_FileOk);
            // 
            // MainForm
            // 
            this.AccessibleDescription = "NFL Shop Main Windows";
            this.AccessibleName = "NFL Shop";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(943, 560);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "NFL Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlBetöltéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kömyvelésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


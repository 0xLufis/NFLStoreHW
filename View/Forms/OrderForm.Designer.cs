namespace S0IPAF
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.ItemsTable = new System.Windows.Forms.TableLayoutPanel();
            this.labelRendelesOsszege = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonRendeles = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ItemsTable
            // 
            this.ItemsTable.AutoScroll = true;
            this.ItemsTable.ColumnCount = 1;
            this.ItemsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ItemsTable.Location = new System.Drawing.Point(12, 12);
            this.ItemsTable.Name = "ItemsTable";
            this.ItemsTable.RowCount = 1;
            this.ItemsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTable.Size = new System.Drawing.Size(663, 470);
            this.ItemsTable.TabIndex = 0;
            this.ItemsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemsTable_Paint);
            // 
            // labelRendelesOsszege
            // 
            this.labelRendelesOsszege.AutoSize = true;
            this.labelRendelesOsszege.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRendelesOsszege.Location = new System.Drawing.Point(8, 492);
            this.labelRendelesOsszege.Name = "labelRendelesOsszege";
            this.labelRendelesOsszege.Size = new System.Drawing.Size(129, 20);
            this.labelRendelesOsszege.TabIndex = 1;
            this.labelRendelesOsszege.Text = "Rendelés összege:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelTotal.Location = new System.Drawing.Point(143, 488);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(61, 25);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "$0.00";
            // 
            // buttonRendeles
            // 
            this.buttonRendeles.Location = new System.Drawing.Point(600, 492);
            this.buttonRendeles.Name = "buttonRendeles";
            this.buttonRendeles.Size = new System.Drawing.Size(75, 23);
            this.buttonRendeles.TabIndex = 3;
            this.buttonRendeles.Text = "Rendelés";
            this.buttonRendeles.UseVisualStyleBackColor = true;
            this.buttonRendeles.Click += new System.EventHandler(this.buttonRendeles_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 526);
            this.Controls.Add(this.buttonRendeles);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelRendelesOsszege);
            this.Controls.Add(this.ItemsTable);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderForm";
            this.Text = "Rendelés";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemsTable_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrderForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ItemsTable;
        private System.Windows.Forms.Label labelRendelesOsszege;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonRendeles;
        private System.Windows.Forms.Timer timer1;
    }
}
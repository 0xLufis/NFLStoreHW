namespace S0IPAF.View
{
    partial class Konyveles
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
            this.labelNoPurcheses = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRendelesekAmount = new System.Windows.Forms.Label();
            this.labelPurchaseCost = new System.Windows.Forms.Label();
            this.labelNetProfit = new System.Windows.Forms.Label();
            this.labelProfit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNoPurcheses
            // 
            this.labelNoPurcheses.AutoSize = true;
            this.labelNoPurcheses.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoPurcheses.Location = new System.Drawing.Point(12, 19);
            this.labelNoPurcheses.Name = "labelNoPurcheses";
            this.labelNoPurcheses.Size = new System.Drawing.Size(103, 13);
            this.labelNoPurcheses.TabIndex = 0;
            this.labelNoPurcheses.Text = "Rendelések száma:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(12, 49);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(74, 13);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "Beszerzési ár:";
            this.labelCost.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eladási ár:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nyereség:";
            // 
            // labelRendelesekAmount
            // 
            this.labelRendelesekAmount.AutoSize = true;
            this.labelRendelesekAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRendelesekAmount.ForeColor = System.Drawing.Color.Coral;
            this.labelRendelesekAmount.Location = new System.Drawing.Point(121, 13);
            this.labelRendelesekAmount.Name = "labelRendelesekAmount";
            this.labelRendelesekAmount.Size = new System.Drawing.Size(43, 21);
            this.labelRendelesekAmount.TabIndex = 4;
            this.labelRendelesekAmount.Text = "0 db";
            this.labelRendelesekAmount.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labelPurchaseCost
            // 
            this.labelPurchaseCost.AutoSize = true;
            this.labelPurchaseCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchaseCost.ForeColor = System.Drawing.Color.Turquoise;
            this.labelPurchaseCost.Location = new System.Drawing.Point(121, 43);
            this.labelPurchaseCost.Name = "labelPurchaseCost";
            this.labelPurchaseCost.Size = new System.Drawing.Size(43, 21);
            this.labelPurchaseCost.TabIndex = 5;
            this.labelPurchaseCost.Text = "0 db";
            this.labelPurchaseCost.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelNetProfit
            // 
            this.labelNetProfit.AutoSize = true;
            this.labelNetProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetProfit.ForeColor = System.Drawing.Color.Red;
            this.labelNetProfit.Location = new System.Drawing.Point(121, 73);
            this.labelNetProfit.Name = "labelNetProfit";
            this.labelNetProfit.Size = new System.Drawing.Size(43, 21);
            this.labelNetProfit.TabIndex = 6;
            this.labelNetProfit.Text = "0 db";
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfit.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelProfit.Location = new System.Drawing.Point(121, 102);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(43, 21);
            this.labelProfit.TabIndex = 7;
            this.labelProfit.Text = "0 db";
            // 
            // Konyveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 145);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.labelNetProfit);
            this.Controls.Add(this.labelPurchaseCost);
            this.Controls.Add(this.labelRendelesekAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelNoPurcheses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Konyveles";
            this.Text = "Konyveles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoPurcheses;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRendelesekAmount;
        private System.Windows.Forms.Label labelPurchaseCost;
        private System.Windows.Forms.Label labelNetProfit;
        private System.Windows.Forms.Label labelProfit;
    }
}
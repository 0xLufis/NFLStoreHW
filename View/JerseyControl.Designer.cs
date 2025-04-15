namespace S0IPAF
{
    partial class JerseyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxJersey = new System.Windows.Forms.PictureBox();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.checkBoxBuy = new System.Windows.Forms.CheckBox();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJersey)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxJersey
            // 
            this.pictureBoxJersey.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxJersey.Name = "pictureBoxJersey";
            this.pictureBoxJersey.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxJersey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJersey.TabIndex = 0;
            this.pictureBoxJersey.TabStop = false;
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(102, 37);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(77, 13);
            this.labelTeamName.TabIndex = 1;
            this.labelTeamName.Text = "AB Teamname";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(226, 37);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(72, 13);
            this.labelPlayerName.TabIndex = 2;
            this.labelPlayerName.Text = "Lorem Ipsum";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(440, 37);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(36, 13);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "méret";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(508, 37);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "00.00";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCount.Location = new System.Drawing.Point(585, 31);
            this.textBoxCount.MaxLength = 10;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(42, 22);
            this.textBoxCount.TabIndex = 5;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(633, 34);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(21, 13);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "db";
            // 
            // checkBoxBuy
            // 
            this.checkBoxBuy.AutoSize = true;
            this.checkBoxBuy.Location = new System.Drawing.Point(564, 34);
            this.checkBoxBuy.Name = "checkBoxBuy";
            this.checkBoxBuy.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBuy.TabIndex = 7;
            this.checkBoxBuy.UseVisualStyleBackColor = true;
            this.checkBoxBuy.CheckedChanged += new System.EventHandler(this.checkBoxBuy_CheckedChanged);
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.AutoSize = true;
            this.labelPlayerNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerNumber.Location = new System.Drawing.Point(399, 38);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(26, 13);
            this.labelPlayerNumber.TabIndex = 8;
            this.labelPlayerNumber.Text = "#00";
            // 
            // JerseyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelPlayerNumber);
            this.Controls.Add(this.checkBoxBuy);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.pictureBoxJersey);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JerseyControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(663, 78);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJersey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxJersey;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelPlayerNumber;
        internal System.Windows.Forms.TextBox textBoxCount;
        internal System.Windows.Forms.CheckBox checkBoxBuy;
        internal System.Windows.Forms.Label labelPrice;
    }
}

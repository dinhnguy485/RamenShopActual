namespace RamenShop
{
    partial class RamenShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RamenShop));
            this.ramenLabel = new System.Windows.Forms.Label();
            this.classicInput = new System.Windows.Forms.MaskedTextBox();
            this.bobaInput = new System.Windows.Forms.MaskedTextBox();
            this.banhmiInput = new System.Windows.Forms.MaskedTextBox();
            this.bobaLabel = new System.Windows.Forms.Label();
            this.banhmiLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.moneyPayed = new System.Windows.Forms.MaskedTextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Label();
            this.qtydespri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ramenLabel
            // 
            this.ramenLabel.AutoSize = true;
            this.ramenLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramenLabel.Location = new System.Drawing.Point(32, 98);
            this.ramenLabel.Name = "ramenLabel";
            this.ramenLabel.Size = new System.Drawing.Size(82, 19);
            this.ramenLabel.TabIndex = 0;
            this.ramenLabel.Text = "Ramen 🍜";
            // 
            // classicInput
            // 
            this.classicInput.Location = new System.Drawing.Point(130, 99);
            this.classicInput.Name = "classicInput";
            this.classicInput.Size = new System.Drawing.Size(68, 20);
            this.classicInput.TabIndex = 1;
            // 
            // bobaInput
            // 
            this.bobaInput.Location = new System.Drawing.Point(130, 133);
            this.bobaInput.Name = "bobaInput";
            this.bobaInput.Size = new System.Drawing.Size(68, 20);
            this.bobaInput.TabIndex = 3;
            // 
            // banhmiInput
            // 
            this.banhmiInput.Location = new System.Drawing.Point(130, 163);
            this.banhmiInput.Name = "banhmiInput";
            this.banhmiInput.Size = new System.Drawing.Size(68, 20);
            this.banhmiInput.TabIndex = 5;
            // 
            // bobaLabel
            // 
            this.bobaLabel.AutoSize = true;
            this.bobaLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobaLabel.Location = new System.Drawing.Point(32, 132);
            this.bobaLabel.Name = "bobaLabel";
            this.bobaLabel.Size = new System.Drawing.Size(67, 19);
            this.bobaLabel.TabIndex = 4;
            this.bobaLabel.Text = "Boba 🍛";
            // 
            // banhmiLabel
            // 
            this.banhmiLabel.AutoSize = true;
            this.banhmiLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banhmiLabel.Location = new System.Drawing.Point(32, 162);
            this.banhmiLabel.Name = "banhmiLabel";
            this.banhmiLabel.Size = new System.Drawing.Size(92, 19);
            this.banhmiLabel.TabIndex = 6;
            this.banhmiLabel.Text = "Banh Mi 🥖";
            // 
            // shopLabel
            // 
            this.shopLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.shopLabel.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.Location = new System.Drawing.Point(-9, -2);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(568, 77);
            this.shopLabel.TabIndex = 7;
            this.shopLabel.Text = "🥡🍛ASIAN CUISINE 🍲🍘";
            this.shopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(56, 195);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(104, 25);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(32, 238);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(75, 19);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Sub total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(32, 267);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(35, 19);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(32, 296);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(47, 19);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Linen;
            this.subtotalOutput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(129, 238);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(75, 19);
            this.subtotalOutput.TabIndex = 12;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Linen;
            this.taxOutput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(129, 267);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(75, 19);
            this.taxOutput.TabIndex = 13;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Linen;
            this.totalOutput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(129, 296);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(75, 19);
            this.totalOutput.TabIndex = 14;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(32, 336);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(79, 19);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // moneyPayed
            // 
            this.moneyPayed.Location = new System.Drawing.Point(130, 336);
            this.moneyPayed.Name = "moneyPayed";
            this.moneyPayed.Size = new System.Drawing.Size(68, 20);
            this.moneyPayed.TabIndex = 16;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(36, 373);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(151, 30);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(32, 418);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(63, 19);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Linen;
            this.changeOutput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(123, 418);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(81, 19);
            this.changeOutput.TabIndex = 19;
            // 
            // receiptButton
            // 
            this.receiptButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(36, 471);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(140, 25);
            this.receiptButton.TabIndex = 20;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Linen;
            this.titleLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(257, 104);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(234, 23);
            this.titleLabel.TabIndex = 26;
            this.titleLabel.Text = "🥡🍛ASIAN CUISINE 🍲🍘";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Linen;
            this.line.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line.Location = new System.Drawing.Point(233, 205);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(295, 29);
            this.line.TabIndex = 28;
            this.line.Text = "----------------------------------------------------------";
            // 
            // neworderButton
            // 
            this.neworderButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderButton.Location = new System.Drawing.Point(233, 512);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(286, 26);
            this.neworderButton.TabIndex = 37;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = false;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.Color.Linen;
            this.receipt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.Location = new System.Drawing.Point(229, 85);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(299, 424);
            this.receipt.TabIndex = 38;
            // 
            // qtydespri
            // 
            this.qtydespri.BackColor = System.Drawing.Color.Linen;
            this.qtydespri.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtydespri.Location = new System.Drawing.Point(257, 159);
            this.qtydespri.Name = "qtydespri";
            this.qtydespri.Size = new System.Drawing.Size(271, 21);
            this.qtydespri.TabIndex = 22;
            this.qtydespri.Text = "QTY     Item Description           Price";
            // 
            // RamenShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(554, 540);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.line);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.qtydespri);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.moneyPayed);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.banhmiLabel);
            this.Controls.Add(this.banhmiInput);
            this.Controls.Add(this.bobaLabel);
            this.Controls.Add(this.bobaInput);
            this.Controls.Add(this.classicInput);
            this.Controls.Add(this.ramenLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RamenShop";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ramenLabel;
        private System.Windows.Forms.MaskedTextBox classicInput;
        private System.Windows.Forms.MaskedTextBox bobaInput;
        private System.Windows.Forms.MaskedTextBox banhmiInput;
        private System.Windows.Forms.Label bobaLabel;
        private System.Windows.Forms.Label banhmiLabel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.MaskedTextBox moneyPayed;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label receipt;
        private System.Windows.Forms.Label qtydespri;
    }
}


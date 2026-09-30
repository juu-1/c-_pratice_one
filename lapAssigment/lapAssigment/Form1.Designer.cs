namespace lapAssigment
{
    partial class Form1
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
            this.txtnamefood1 = new System.Windows.Forms.TextBox();
            this.txtpricefood2 = new System.Windows.Forms.TextBox();
            this.txtnamefood2 = new System.Windows.Forms.TextBox();
            this.txtpricefood1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.Button();
            this.txtTips = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnamefood1
            // 
            this.txtnamefood1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnamefood1.Location = new System.Drawing.Point(395, 47);
            this.txtnamefood1.Name = "txtnamefood1";
            this.txtnamefood1.Size = new System.Drawing.Size(328, 26);
            this.txtnamefood1.TabIndex = 0;
            // 
            // txtpricefood2
            // 
            this.txtpricefood2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpricefood2.Location = new System.Drawing.Point(395, 167);
            this.txtpricefood2.Name = "txtpricefood2";
            this.txtpricefood2.Size = new System.Drawing.Size(328, 26);
            this.txtpricefood2.TabIndex = 1;
            // 
            // txtnamefood2
            // 
            this.txtnamefood2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnamefood2.Location = new System.Drawing.Point(395, 122);
            this.txtnamefood2.Name = "txtnamefood2";
            this.txtnamefood2.Size = new System.Drawing.Size(328, 26);
            this.txtnamefood2.TabIndex = 2;
            // 
            // txtpricefood1
            // 
            this.txtpricefood1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpricefood1.Location = new System.Drawing.Point(395, 79);
            this.txtpricefood1.Name = "txtpricefood1";
            this.txtpricefood1.Size = new System.Drawing.Size(328, 26);
            this.txtpricefood1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENTER THE NAME FOOD1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "ENTER THE PRICE FOOD1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "ENTER NAME FOOD 2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "ENTER PRICE FOOD2";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(60, 347);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.Size = new System.Drawing.Size(191, 51);
            this.txtSalesTax.TabIndex = 8;
            this.txtSalesTax.Text = "sales text is";
            this.txtSalesTax.UseVisualStyleBackColor = true;
            // 
            // txtTips
            // 
            this.txtTips.Location = new System.Drawing.Point(296, 347);
            this.txtTips.Name = "txtTips";
            this.txtTips.Size = new System.Drawing.Size(191, 51);
            this.txtTips.TabIndex = 10;
            this.txtTips.Text = "tipsamount";
            this.txtTips.UseVisualStyleBackColor = true;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(541, 347);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(191, 51);
            this.txtTotalAmount.TabIndex = 11;
            this.txtTotalAmount.Text = "total amount";
            this.txtTotalAmount.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 51);
            this.button4.TabIndex = 12;
            this.button4.Text = "btn calculate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtTips);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpricefood1);
            this.Controls.Add(this.txtnamefood2);
            this.Controls.Add(this.txtpricefood2);
            this.Controls.Add(this.txtnamefood1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnamefood1;
        private System.Windows.Forms.TextBox txtpricefood2;
        private System.Windows.Forms.TextBox txtnamefood2;
        private System.Windows.Forms.TextBox txtpricefood1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtSalesTax;
        private System.Windows.Forms.Button txtTips;
        private System.Windows.Forms.Button txtTotalAmount;
        private System.Windows.Forms.Button button4;
    }
}


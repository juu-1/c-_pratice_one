namespace example3
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalclulate = new System.Windows.Forms.Button();
            this.lblstringcompare = new System.Windows.Forms.Label();
            this.txtstringtwo = new System.Windows.Forms.TextBox();
            this.txtstringone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(556, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 59);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "close";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(342, 351);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(187, 59);
            this.btnclear.TabIndex = 25;
            this.btnclear.Text = "&clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btncalclulate
            // 
            this.btncalclulate.Location = new System.Drawing.Point(121, 351);
            this.btncalclulate.Name = "btncalclulate";
            this.btncalclulate.Size = new System.Drawing.Size(187, 59);
            this.btncalclulate.TabIndex = 24;
            this.btncalclulate.Text = "string compare";
            this.btncalclulate.UseVisualStyleBackColor = true;
            this.btncalclulate.UseWaitCursor = true;
            this.btncalclulate.Click += new System.EventHandler(this.btncalclulate_Click);
            // 
            // lblstringcompare
            // 
            this.lblstringcompare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstringcompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstringcompare.ForeColor = System.Drawing.SystemColors.Control;
            this.lblstringcompare.Location = new System.Drawing.Point(415, 185);
            this.lblstringcompare.Name = "lblstringcompare";
            this.lblstringcompare.Size = new System.Drawing.Size(302, 68);
            this.lblstringcompare.TabIndex = 23;
            // 
            // txtstringtwo
            // 
            this.txtstringtwo.Location = new System.Drawing.Point(424, 115);
            this.txtstringtwo.Name = "txtstringtwo";
            this.txtstringtwo.Size = new System.Drawing.Size(277, 26);
            this.txtstringtwo.TabIndex = 22;
            // 
            // txtstringone
            // 
            this.txtstringone.Location = new System.Drawing.Point(424, 50);
            this.txtstringone.Name = "txtstringone";
            this.txtstringone.Size = new System.Drawing.Size(277, 26);
            this.txtstringone.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(57, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 55);
            this.label3.TabIndex = 20;
            this.label3.Text = "result string";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 56);
            this.label2.TabIndex = 19;
            this.label2.Text = "enter string two";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 62);
            this.label1.TabIndex = 18;
            this.label1.Text = "enter string one";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalclulate);
            this.Controls.Add(this.lblstringcompare);
            this.Controls.Add(this.txtstringtwo);
            this.Controls.Add(this.txtstringone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalclulate;
        private System.Windows.Forms.Label lblstringcompare;
        private System.Windows.Forms.TextBox txtstringtwo;
        private System.Windows.Forms.TextBox txtstringone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


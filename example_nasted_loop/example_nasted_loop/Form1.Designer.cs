namespace example_nasted_loop
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtyears = new System.Windows.Forms.TextBox();
            this.btnqualification = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the salary :";
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(77, 268);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(646, 65);
            this.lblresult.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter years Exp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Decison result";
            // 
            // txtsalary
            // 
            this.txtsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(480, 51);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(283, 53);
            this.txtsalary.TabIndex = 4;
            // 
            // txtyears
            // 
            this.txtyears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyears.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyears.Location = new System.Drawing.Point(480, 110);
            this.txtyears.Name = "txtyears";
            this.txtyears.Size = new System.Drawing.Size(283, 53);
            this.txtyears.TabIndex = 5;
            this.txtyears.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnqualification
            // 
            this.btnqualification.Location = new System.Drawing.Point(77, 372);
            this.btnqualification.Name = "btnqualification";
            this.btnqualification.Size = new System.Drawing.Size(188, 66);
            this.btnqualification.TabIndex = 6;
            this.btnqualification.Text = "&qualification";
            this.btnqualification.UseVisualStyleBackColor = true;
            this.btnqualification.Click += new System.EventHandler(this.btnqualification_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(281, 372);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(188, 66);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "&clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(498, 372);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(188, 66);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "c&lose";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnqualification);
            this.Controls.Add(this.txtyears);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtyears;
        private System.Windows.Forms.Button btnqualification;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}


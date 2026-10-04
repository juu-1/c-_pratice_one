namespace example2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hourseworkedTexetbox = new System.Windows.Forms.TextBox();
            this.hourspayratetxtbox = new System.Windows.Forms.TextBox();
            this.grosspaylebel1 = new System.Windows.Forms.Label();
            this.btncalclulate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hourse Worked";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourse pay rate";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(40, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gross pay";
            // 
            // hourseworkedTexetbox
            // 
            this.hourseworkedTexetbox.Location = new System.Drawing.Point(350, 48);
            this.hourseworkedTexetbox.Name = "hourseworkedTexetbox";
            this.hourseworkedTexetbox.Size = new System.Drawing.Size(277, 26);
            this.hourseworkedTexetbox.TabIndex = 3;
            // 
            // hourspayratetxtbox
            // 
            this.hourspayratetxtbox.Location = new System.Drawing.Point(350, 113);
            this.hourspayratetxtbox.Name = "hourspayratetxtbox";
            this.hourspayratetxtbox.Size = new System.Drawing.Size(277, 26);
            this.hourspayratetxtbox.TabIndex = 4;
            // 
            // grosspaylebel1
            // 
            this.grosspaylebel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grosspaylebel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosspaylebel1.ForeColor = System.Drawing.SystemColors.Control;
            this.grosspaylebel1.Location = new System.Drawing.Point(341, 183);
            this.grosspaylebel1.Name = "grosspaylebel1";
            this.grosspaylebel1.Size = new System.Drawing.Size(302, 68);
            this.grosspaylebel1.TabIndex = 5;
            // 
            // btncalclulate
            // 
            this.btncalclulate.Location = new System.Drawing.Point(47, 349);
            this.btncalclulate.Name = "btncalclulate";
            this.btncalclulate.Size = new System.Drawing.Size(187, 59);
            this.btncalclulate.TabIndex = 6;
            this.btncalclulate.Text = "c&alculate &gross pay";
            this.btncalclulate.UseVisualStyleBackColor = true;
            this.btncalclulate.UseWaitCursor = true;
            this.btncalclulate.Click += new System.EventHandler(this.btncalclulate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(268, 349);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(187, 59);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "&clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 59);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalclulate);
            this.Controls.Add(this.grosspaylebel1);
            this.Controls.Add(this.hourspayratetxtbox);
            this.Controls.Add(this.hourseworkedTexetbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "the pay roll with over time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hourseworkedTexetbox;
        private System.Windows.Forms.TextBox hourspayratetxtbox;
        private System.Windows.Forms.Label grosspaylebel1;
        private System.Windows.Forms.Button btncalclulate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
    }
}


namespace airlane_ticket_booking_system
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoFirst = new System.Windows.Forms.RadioButton();
            this.rdoBusiness = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtBaggage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(775, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(425, 544);
            this.listBox1.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(259, 103);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 51);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(18, 103);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 51);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(18, 46);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(461, 33);
            this.chkInsurance.TabIndex = 0;
            this.chkInsurance.Text = "Add Travel Insurance($25 per ticket)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Controls.Add(this.chkInsurance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(33, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 176);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "aditional options";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(510, 103);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(259, 68);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(190, 33);
            this.rdoNormal.TabIndex = 2;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "normal Class";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoFirst
            // 
            this.rdoFirst.AutoSize = true;
            this.rdoFirst.Location = new System.Drawing.Point(49, 68);
            this.rdoFirst.Name = "rdoFirst";
            this.rdoFirst.Size = new System.Drawing.Size(148, 33);
            this.rdoFirst.TabIndex = 1;
            this.rdoFirst.TabStop = true;
            this.rdoFirst.Text = "first class";
            this.rdoFirst.UseVisualStyleBackColor = true;
            // 
            // rdoBusiness
            // 
            this.rdoBusiness.AutoSize = true;
            this.rdoBusiness.Location = new System.Drawing.Point(462, 68);
            this.rdoBusiness.Name = "rdoBusiness";
            this.rdoBusiness.Size = new System.Drawing.Size(229, 33);
            this.rdoBusiness.TabIndex = 0;
            this.rdoBusiness.TabStop = true;
            this.rdoBusiness.Text = "Bussiness Class";
            this.rdoBusiness.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNormal);
            this.groupBox2.Controls.Add(this.rdoFirst);
            this.groupBox2.Controls.Add(this.rdoBusiness);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 127);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Class";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "number of Tickets";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passanger age";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Passanger name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtTickets);
            this.groupBox1.Controls.Add(this.txtBaggage);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 269);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personal information";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(54, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "baggage weight(kg)";
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Location = new System.Drawing.Point(352, 98);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(274, 35);
            this.txtAge.TabIndex = 3;
            // 
            // txtTickets
            // 
            this.txtTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTickets.Location = new System.Drawing.Point(352, 139);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(274, 35);
            this.txtTickets.TabIndex = 2;
            // 
            // txtBaggage
            // 
            this.txtBaggage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaggage.Location = new System.Drawing.Point(352, 192);
            this.txtBaggage.Name = "txtBaggage";
            this.txtBaggage.Size = new System.Drawing.Size(274, 35);
            this.txtBaggage.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(352, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 35);
            this.txtName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1233, 652);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoFirst;
        private System.Windows.Forms.RadioButton rdoBusiness;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtBaggage;
        private System.Windows.Forms.TextBox txtName;
    }
}


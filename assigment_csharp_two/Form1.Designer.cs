namespace assigment_csharp_one
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
            this.components = new System.ComponentModel.Container();
            this.textname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textsemester = new System.Windows.Forms.TextBox();
            this.textdepartement = new System.Windows.Forms.TextBox();
            this.textstudentid = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lbldepartement = new System.Windows.Forms.Label();
            this.labstudentid = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textname.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(536, 46);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(304, 39);
            this.textname.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textsemester
            // 
            this.textsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textsemester.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsemester.Location = new System.Drawing.Point(536, 176);
            this.textsemester.Name = "textsemester";
            this.textsemester.Size = new System.Drawing.Size(304, 39);
            this.textsemester.TabIndex = 2;
            // 
            // textdepartement
            // 
            this.textdepartement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textdepartement.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdepartement.Location = new System.Drawing.Point(536, 133);
            this.textdepartement.Name = "textdepartement";
            this.textdepartement.Size = new System.Drawing.Size(304, 39);
            this.textdepartement.TabIndex = 3;
            // 
            // textstudentid
            // 
            this.textstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textstudentid.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textstudentid.Location = new System.Drawing.Point(536, 92);
            this.textstudentid.Name = "textstudentid";
            this.textstudentid.Size = new System.Drawing.Size(304, 39);
            this.textstudentid.TabIndex = 4;
            this.textstudentid.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(568, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(232, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(34, 431);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(232, 43);
            this.btnshowinfo.TabIndex = 6;
            this.btnshowinfo.Text = "Show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(313, 431);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(232, 43);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // lblname
            // 
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblname.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 50);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(358, 30);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Enter the student name";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(259, 231);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(286, 185);
            this.lbloutput.TabIndex = 9;
            // 
            // lbldepartement
            // 
            this.lbldepartement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldepartement.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartement.Location = new System.Drawing.Point(12, 134);
            this.lbldepartement.Name = "lbldepartement";
            this.lbldepartement.Size = new System.Drawing.Size(358, 30);
            this.lbldepartement.TabIndex = 14;
            this.lbldepartement.Text = "Enter the departement";
            // 
            // labstudentid
            // 
            this.labstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labstudentid.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstudentid.Location = new System.Drawing.Point(12, 93);
            this.labstudentid.Name = "labstudentid";
            this.labstudentid.Size = new System.Drawing.Size(358, 30);
            this.labstudentid.TabIndex = 15;
            this.labstudentid.Text = "Enter the student id";
            // 
            // lblsemester
            // 
            this.lblsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsemester.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(12, 177);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(358, 30);
            this.lblsemester.TabIndex = 16;
            this.lblsemester.Text = "Enter the semester";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 540);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.labstudentid);
            this.Controls.Add(this.lbldepartement);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textstudentid);
            this.Controls.Add(this.textdepartement);
            this.Controls.Add(this.textsemester);
            this.Controls.Add(this.textname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textsemester;
        private System.Windows.Forms.TextBox textdepartement;
        private System.Windows.Forms.TextBox textstudentid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lbldepartement;
        private System.Windows.Forms.Label labstudentid;
        private System.Windows.Forms.Label lblsemester;
    }
}


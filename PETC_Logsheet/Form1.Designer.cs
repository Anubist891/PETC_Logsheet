namespace PETC_Logsheet
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActionTaken = new System.Windows.Forms.TextBox();
            this.txtTimeReceived = new System.Windows.Forms.TextBox();
            this.txtDetailsofInquiry = new System.Windows.Forms.TextBox();
            this.txtPetcname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Turquoise;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 13F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(218, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.Location = new System.Drawing.Point(26, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Actions Taken";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(26, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Time Received";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Details of Inquiry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "PETC name";
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.Location = new System.Drawing.Point(26, 302);
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(303, 20);
            this.txtActionTaken.TabIndex = 26;
            // 
            // txtTimeReceived
            // 
            this.txtTimeReceived.Location = new System.Drawing.Point(26, 257);
            this.txtTimeReceived.Name = "txtTimeReceived";
            this.txtTimeReceived.Size = new System.Drawing.Size(303, 20);
            this.txtTimeReceived.TabIndex = 25;
            // 
            // txtDetailsofInquiry
            // 
            this.txtDetailsofInquiry.Location = new System.Drawing.Point(26, 188);
            this.txtDetailsofInquiry.Multiline = true;
            this.txtDetailsofInquiry.Name = "txtDetailsofInquiry";
            this.txtDetailsofInquiry.Size = new System.Drawing.Size(303, 44);
            this.txtDetailsofInquiry.TabIndex = 24;
            // 
            // txtPetcname
            // 
            this.txtPetcname.Location = new System.Drawing.Point(26, 92);
            this.txtPetcname.Name = "txtPetcname";
            this.txtPetcname.Size = new System.Drawing.Size(303, 20);
            this.txtPetcname.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultraLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtActionTaken);
            this.groupBox1.Controls.Add(this.txtTimeReceived);
            this.groupBox1.Controls.Add(this.txtDetailsofInquiry);
            this.groupBox1.Controls.Add(this.txtPetcname);
            this.groupBox1.Location = new System.Drawing.Point(-1, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 608);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraLabel1.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Rounded1;
            this.ultraLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(3, 16);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(366, 26);
            this.ultraLabel1.TabIndex = 40;
            this.ultraLabel1.Text = "JRF (New Item)";
            this.ultraLabel1.WrapText = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Calibri", 13F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(118, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 39;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 590);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActionTaken;
        private System.Windows.Forms.TextBox txtTimeReceived;
        private System.Windows.Forms.TextBox txtDetailsofInquiry;
        private System.Windows.Forms.TextBox txtPetcname;
        private System.Windows.Forms.GroupBox groupBox1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private System.Windows.Forms.Button button1;
    }
}
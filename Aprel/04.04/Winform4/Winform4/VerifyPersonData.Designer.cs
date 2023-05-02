namespace Winform4
{
    partial class VerifyPersonData
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDisDocNumber = new System.Windows.Forms.TextBox();
            this.txtDisDocSerial = new System.Windows.Forms.TextBox();
            this.txtDisSurname = new System.Windows.Forms.TextBox();
            this.txtDisName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(193, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Təsdiqlə";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDisDocNumber
            // 
            this.txtDisDocNumber.Enabled = false;
            this.txtDisDocNumber.Location = new System.Drawing.Point(193, 157);
            this.txtDisDocNumber.Name = "txtDisDocNumber";
            this.txtDisDocNumber.Size = new System.Drawing.Size(100, 20);
            this.txtDisDocNumber.TabIndex = 7;
            // 
            // txtDisDocSerial
            // 
            this.txtDisDocSerial.Enabled = false;
            this.txtDisDocSerial.Location = new System.Drawing.Point(193, 112);
            this.txtDisDocSerial.Name = "txtDisDocSerial";
            this.txtDisDocSerial.Size = new System.Drawing.Size(100, 20);
            this.txtDisDocSerial.TabIndex = 8;
            // 
            // txtDisSurname
            // 
            this.txtDisSurname.Enabled = false;
            this.txtDisSurname.Location = new System.Drawing.Point(193, 78);
            this.txtDisSurname.Name = "txtDisSurname";
            this.txtDisSurname.Size = new System.Drawing.Size(100, 20);
            this.txtDisSurname.TabIndex = 9;
            // 
            // txtDisName
            // 
            this.txtDisName.Enabled = false;
            this.txtDisName.Location = new System.Drawing.Point(193, 36);
            this.txtDisName.Name = "txtDisName";
            this.txtDisName.Size = new System.Drawing.Size(100, 20);
            this.txtDisName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vəsiqənin nömrəsi ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vəsiqənin Seriyası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(193, 235);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 38);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Geri Qayıt";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // VerifyPersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 285);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDisDocNumber);
            this.Controls.Add(this.txtDisDocSerial);
            this.Controls.Add(this.txtDisSurname);
            this.Controls.Add(this.txtDisName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VerifyPersonData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Məlumatların doğrulanması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDisDocNumber;
        private System.Windows.Forms.TextBox txtDisDocSerial;
        private System.Windows.Forms.TextBox txtDisSurname;
        private System.Windows.Forms.TextBox txtDisName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}
namespace FirstFomrApp
{
    partial class FirstForm
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
            this.btnSent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWrute = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(28, 113);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(191, 41);
            this.btnSent.TabIndex = 2;
            this.btnSent.Text = "Ikinci Forma  Keç";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İkinci Forma  Gondermek istediyniz  metni girin ";
            // 
            // txtWrute
            // 
            this.txtWrute.Location = new System.Drawing.Point(28, 54);
            this.txtWrute.Multiline = true;
            this.txtWrute.Name = "txtWrute";
            this.txtWrute.Size = new System.Drawing.Size(475, 39);
            this.txtWrute.TabIndex = 1;
            this.txtWrute.Text = "Mətninizi  girin ";
            this.txtWrute.Enter += new System.EventHandler(this.txtWrute_Enter);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(312, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "App dən Çıxış edun ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FirstForm
            // 
            this.AcceptButton = this.btnSent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(535, 190);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWrute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyFirstApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWrute;
        private System.Windows.Forms.Button btnExit;
    }
}


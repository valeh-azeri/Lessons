namespace Winform4.DynamicFormElementsFolder
{
    partial class DynamicFormElements
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
            this.btnCreatNewButton = new System.Windows.Forms.Button();
            this.btnCreatNewTextbox = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCreatNewButton
            // 
            this.btnCreatNewButton.Location = new System.Drawing.Point(27, 23);
            this.btnCreatNewButton.Name = "btnCreatNewButton";
            this.btnCreatNewButton.Size = new System.Drawing.Size(146, 37);
            this.btnCreatNewButton.TabIndex = 0;
            this.btnCreatNewButton.Text = "Yeni Buton əlavə et";
            this.btnCreatNewButton.UseVisualStyleBackColor = true;
            this.btnCreatNewButton.Click += new System.EventHandler(this.btnCreatNewButton_Click);
            // 
            // btnCreatNewTextbox
            // 
            this.btnCreatNewTextbox.Location = new System.Drawing.Point(27, 193);
            this.btnCreatNewTextbox.Name = "btnCreatNewTextbox";
            this.btnCreatNewTextbox.Size = new System.Drawing.Size(146, 37);
            this.btnCreatNewTextbox.TabIndex = 0;
            this.btnCreatNewTextbox.Text = "Yeni TextBox əlavə et";
            this.btnCreatNewTextbox.UseVisualStyleBackColor = true;
            this.btnCreatNewTextbox.Click += new System.EventHandler(this.btnCreatNewTextbox_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(27, 67);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(748, 120);
            this.buttonsPanel.TabIndex = 1;
            // 
            // textBoxPannel
            // 
            this.textBoxPannel.Location = new System.Drawing.Point(27, 236);
            this.textBoxPannel.Name = "textBoxPannel";
            this.textBoxPannel.Size = new System.Drawing.Size(748, 120);
            this.textBoxPannel.TabIndex = 1;
            // 
            // DynamicFormElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 421);
            this.Controls.Add(this.textBoxPannel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.btnCreatNewTextbox);
            this.Controls.Add(this.btnCreatNewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DynamicFormElements";
            this.Text = "DinamicForm Elementləri ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatNewButton;
        private System.Windows.Forms.Button btnCreatNewTextbox;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel textBoxPannel;
    }
}
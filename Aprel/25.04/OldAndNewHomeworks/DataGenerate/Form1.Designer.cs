namespace DataGenerate
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
            this.dtGridPerson = new System.Windows.Forms.DataGridView();
            this.btnGeneratePerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridPerson
            // 
            this.dtGridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPerson.Location = new System.Drawing.Point(25, 68);
            this.dtGridPerson.Name = "dtGridPerson";
            this.dtGridPerson.Size = new System.Drawing.Size(741, 358);
            this.dtGridPerson.TabIndex = 0;
            // 
            // btnGeneratePerson
            // 
            this.btnGeneratePerson.Location = new System.Drawing.Point(25, 27);
            this.btnGeneratePerson.Name = "btnGeneratePerson";
            this.btnGeneratePerson.Size = new System.Drawing.Size(123, 23);
            this.btnGeneratePerson.TabIndex = 1;
            this.btnGeneratePerson.Text = "Generate Person";
            this.btnGeneratePerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneratePerson.UseVisualStyleBackColor = true;
            this.btnGeneratePerson.Click += new System.EventHandler(this.btnGeneratePerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeneratePerson);
            this.Controls.Add(this.dtGridPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persons";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridPerson;
        private System.Windows.Forms.Button btnGeneratePerson;
    }
}


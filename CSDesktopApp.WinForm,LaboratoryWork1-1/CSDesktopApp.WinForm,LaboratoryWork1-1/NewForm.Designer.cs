namespace CSDesktopApp.WinForm_LaboratoryWork1_1
{
    partial class NewForm
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
            this.checkBoxClose = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxClose
            // 
            this.checkBoxClose.AutoSize = true;
            this.checkBoxClose.Location = new System.Drawing.Point(97, 55);
            this.checkBoxClose.Name = "checkBoxClose";
            this.checkBoxClose.Size = new System.Drawing.Size(165, 24);
            this.checkBoxClose.TabIndex = 0;
            this.checkBoxClose.Text = "Закрыть форму?";
            this.checkBoxClose.UseVisualStyleBackColor = true;
            //            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 144);
            this.Controls.Add(this.checkBoxClose);
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void NewForm_FormClosing1(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxClose;
    }
}
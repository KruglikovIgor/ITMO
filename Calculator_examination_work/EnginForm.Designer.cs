namespace SimpleCalculator
{
    partial class EnginForm
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
            this.KeySqr = new System.Windows.Forms.Button();
            this.KeyHyperbola = new System.Windows.Forms.Button();
            this.KeyParabola = new System.Windows.Forms.Button();
            this.KeyDegree = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // KeySqr
            // 
            this.KeySqr.Font = new System.Drawing.Font("Times New Roman", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeySqr.Location = new System.Drawing.Point(744, 249);
            this.KeySqr.Name = "KeySqr";
            this.KeySqr.Size = new System.Drawing.Size(104, 97);
            this.KeySqr.TabIndex = 23;
            this.KeySqr.Text = "Sqrt (X)";
            this.toolTip1.SetToolTip(this.KeySqr, "Корень числа Х");
            this.KeySqr.UseVisualStyleBackColor = true;
            this.KeySqr.Click += new System.EventHandler(this.KeySqr_Click);
            // 
            // KeyHyperbola
            // 
            this.KeyHyperbola.Font = new System.Drawing.Font("Times New Roman", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyHyperbola.Location = new System.Drawing.Point(744, 363);
            this.KeyHyperbola.Name = "KeyHyperbola";
            this.KeyHyperbola.Size = new System.Drawing.Size(104, 97);
            this.KeyHyperbola.TabIndex = 24;
            this.KeyHyperbola.Text = "1/X";
            this.toolTip1.SetToolTip(this.KeyHyperbola, "Обратная пропорциональность");
            this.KeyHyperbola.UseVisualStyleBackColor = true;
            this.KeyHyperbola.Click += new System.EventHandler(this.KeyHyperbola_Click);
            // 
            // KeyParabola
            // 
            this.KeyParabola.Font = new System.Drawing.Font("Times New Roman", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyParabola.Location = new System.Drawing.Point(744, 478);
            this.KeyParabola.Name = "KeyParabola";
            this.KeyParabola.Size = new System.Drawing.Size(104, 97);
            this.KeyParabola.TabIndex = 25;
            this.KeyParabola.Text = "Х^2";
            this.toolTip1.SetToolTip(this.KeyParabola, "Квадрат числа Х");
            this.KeyParabola.UseVisualStyleBackColor = true;
            this.KeyParabola.Click += new System.EventHandler(this.KeyParabola_Click);
            // 
            // KeyDegree
            // 
            this.KeyDegree.Font = new System.Drawing.Font("Times New Roman", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyDegree.Location = new System.Drawing.Point(744, 592);
            this.KeyDegree.Name = "KeyDegree";
            this.KeyDegree.Size = new System.Drawing.Size(104, 97);
            this.KeyDegree.TabIndex = 26;
            this.KeyDegree.Text = "X^Y";
            this.toolTip1.SetToolTip(this.KeyDegree, "Число Х в степени Y");
            this.KeyDegree.UseVisualStyleBackColor = true;
            this.KeyDegree.Click += new System.EventHandler(this.KeyDegree_Click);
            // 
            // EnginForm
            // 
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(904, 728);
            this.Controls.Add(this.KeyDegree);
            this.Controls.Add(this.KeyParabola);
            this.Controls.Add(this.KeyHyperbola);
            this.Controls.Add(this.KeySqr);
            this.Name = "EnginForm";
            this.Text = "Инженерный калькулятор";
            this.Controls.SetChildIndex(this.OutputDisplay, 0);
            this.Controls.SetChildIndex(this.KeySeven, 0);
            this.Controls.SetChildIndex(this.KeySqr, 0);
            this.Controls.SetChildIndex(this.KeyHyperbola, 0);
            this.Controls.SetChildIndex(this.KeyParabola, 0);
            this.Controls.SetChildIndex(this.KeyDegree, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KeySqr;
        private System.Windows.Forms.Button KeyHyperbola;
        private System.Windows.Forms.Button KeyParabola;
        private System.Windows.Forms.Button KeyDegree;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

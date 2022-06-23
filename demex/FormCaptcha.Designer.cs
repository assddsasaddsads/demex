namespace demex
{
    partial class FormCaptcha
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
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.Location = new System.Drawing.Point(159, 35);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(48, 13);
            this.labelCaptcha.TabIndex = 0;
            this.labelCaptcha.Text = "labelCap";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(148, 94);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Ввести";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(132, 68);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(100, 20);
            this.textBoxCaptcha.TabIndex = 2;
            // 
            // FormCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 171);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCaptcha);
            this.Name = "FormCaptcha";
            this.Text = "FormCaptcha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCaptcha;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCaptcha;
    }
}
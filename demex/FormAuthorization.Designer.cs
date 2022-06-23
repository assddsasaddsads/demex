namespace demex
{
    partial class FormAuthorization
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labellog = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.labelvvod = new System.Windows.Forms.Label();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(120, 100);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(216, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // labellog
            // 
            this.labellog.AutoSize = true;
            this.labellog.Location = new System.Drawing.Point(117, 84);
            this.labellog.Name = "labellog";
            this.labellog.Size = new System.Drawing.Size(38, 13);
            this.labellog.TabIndex = 1;
            this.labellog.Text = "Логин";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(117, 125);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(45, 13);
            this.labelPas.TabIndex = 3;
            this.labelPas.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(120, 141);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(216, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(120, 167);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(103, 33);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Войти";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(229, 167);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(103, 33);
            this.buttonEx.TabIndex = 5;
            this.buttonEx.Text = "Отмена";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // labelvvod
            // 
            this.labelvvod.AutoSize = true;
            this.labelvvod.Location = new System.Drawing.Point(131, 47);
            this.labelvvod.Name = "labelvvod";
            this.labelvvod.Size = new System.Drawing.Size(192, 13);
            this.labelvvod.TabIndex = 6;
            this.labelvvod.Text = "Войдите под своей учетной записью";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(229, 121);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(114, 17);
            this.checkBoxPassword.TabIndex = 7;
            this.checkBoxPassword.Text = "Показать пароль";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.labelvvod);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labellog);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormAuthorization";
            this.Text = "Авторизация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labellog;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Label labelvvod;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Label label1;
    }
}
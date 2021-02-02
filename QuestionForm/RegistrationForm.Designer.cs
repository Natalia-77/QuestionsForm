
namespace QuestionForm
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заповніть, будь ласка, \r\nвсі поля форми реєстрації";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(21, 121);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(99, 25);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Прізвище";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(21, 175);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ім\'я";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(21, 228);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(60, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логін";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(21, 281);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Пароль";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(113, 117);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(220, 27);
            this.tbSurname.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(113, 171);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(220, 27);
            this.tbName.TabIndex = 2;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(113, 224);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(220, 27);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(113, 277);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(220, 27);
            this.tbPassword.TabIndex = 2;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUser.Location = new System.Drawing.Point(66, 364);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(223, 57);
            this.btnSaveUser.TabIndex = 3;
            this.btnSaveUser.Text = "Зареєструватись";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 456);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegistrationForm";
            this.Text = "Реєстрація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSaveUser;
    }
}
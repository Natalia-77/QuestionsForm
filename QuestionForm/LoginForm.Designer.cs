
namespace QuestionForm
{
    partial class LoginForm
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
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSetRegistration = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbllogin.Location = new System.Drawing.Point(43, 80);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(47, 20);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Логін";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpassword.Location = new System.Drawing.Point(43, 122);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(62, 20);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Пароль";
            // 
            // tblogin
            // 
            this.tblogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblogin.Location = new System.Drawing.Point(114, 80);
            this.tblogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(154, 25);
            this.tblogin.TabIndex = 2;
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbpassword.Location = new System.Drawing.Point(114, 122);
            this.tbpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(154, 25);
            this.tbpassword.TabIndex = 3;
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntry.Location = new System.Drawing.Point(58, 165);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(195, 43);
            this.btnEntry.TabIndex = 4;
            this.btnEntry.Text = "Вхід";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(58, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 40);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Якщо Ви вже маєте акаунт,\r\nувійдіть в систему";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetRegistration
            // 
            this.lblSetRegistration.AutoSize = true;
            this.lblSetRegistration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetRegistration.Location = new System.Drawing.Point(83, 232);
            this.lblSetRegistration.Name = "lblSetRegistration";
            this.lblSetRegistration.Size = new System.Drawing.Size(145, 20);
            this.lblSetRegistration.TabIndex = 5;
            this.lblSetRegistration.Text = "або зареєструйтесь";
            this.lblSetRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistration.Location = new System.Drawing.Point(58, 273);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(195, 43);
            this.btnRegistration.TabIndex = 4;
            this.btnRegistration.Text = "Реєстрація";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 342);
            this.Controls.Add(this.lblSetRegistration);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbllogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSetRegistration;
        private System.Windows.Forms.Button btnRegistration;
    }
}
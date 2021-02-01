
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbllogin.Location = new System.Drawing.Point(25, 74);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(59, 25);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpassword.Location = new System.Drawing.Point(25, 133);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(90, 25);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(135, 75);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(175, 27);
            this.tblogin.TabIndex = 2;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(135, 131);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(175, 27);
            this.tbpassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(157, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вхід";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbllogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button button1;
    }
}
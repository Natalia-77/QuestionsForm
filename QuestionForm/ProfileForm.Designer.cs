
namespace QuestionForm
{
    partial class ProfileForm
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
            this.lblSurnameTitle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColStartSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLengthSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSurnameTitle
            // 
            this.lblSurnameTitle.AutoSize = true;
            this.lblSurnameTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurnameTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSurnameTitle.Location = new System.Drawing.Point(11, 13);
            this.lblSurnameTitle.Name = "lblSurnameTitle";
            this.lblSurnameTitle.Size = new System.Drawing.Size(89, 21);
            this.lblSurnameTitle.TabIndex = 0;
            this.lblSurnameTitle.Text = "Прізвище:";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNameTitle.Location = new System.Drawing.Point(11, 38);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(44, 21);
            this.lblNameTitle.TabIndex = 0;
            this.lblNameTitle.Text = "Ім\'я:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(116, 9);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(99, 25);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Прізвище";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(116, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ім\'я";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSession.ForeColor = System.Drawing.Color.Red;
            this.lblSession.Location = new System.Drawing.Point(12, 78);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(172, 21);
            this.lblSession.TabIndex = 0;
            this.lblSession.Text = "Всі сесії користувача:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStartSession,
            this.ColEndSession,
            this.ColLengthSession,
            this.ColMark});
            this.dataGridView1.Location = new System.Drawing.Point(16, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(597, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColStartSession
            // 
            this.ColStartSession.HeaderText = "Початок сесії";
            this.ColStartSession.Name = "ColStartSession";
            this.ColStartSession.Width = 150;
            // 
            // ColEndSession
            // 
            this.ColEndSession.HeaderText = "Кінець сесії";
            this.ColEndSession.Name = "ColEndSession";
            this.ColEndSession.Width = 150;
            // 
            // ColLengthSession
            // 
            this.ColLengthSession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLengthSession.HeaderText = "Тривалість сесії";
            this.ColLengthSession.Name = "ColLengthSession";
            // 
            // ColMark
            // 
            this.ColMark.HeaderText = "Оцінка за іспит";
            this.ColMark.Name = "ColMark";
            this.ColMark.Width = 120;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblSurnameTitle);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Профіль користувача";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurnameTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLengthSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMark;
    }
}
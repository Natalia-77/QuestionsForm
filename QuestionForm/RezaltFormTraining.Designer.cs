
namespace QuestionForm
{
    partial class RezaltFormTraining
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountQuestions = new System.Windows.Forms.Label();
            this.lblRightAnswers = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblStartDateTime = new System.Windows.Forms.Label();
            this.lblEndDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(122, -3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 42);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "\r\nName";
            // 
            // lblCountQuestions
            // 
            this.lblCountQuestions.AutoSize = true;
            this.lblCountQuestions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountQuestions.Location = new System.Drawing.Point(12, 49);
            this.lblCountQuestions.Name = "lblCountQuestions";
            this.lblCountQuestions.Size = new System.Drawing.Size(123, 17);
            this.lblCountQuestions.TabIndex = 1;
            this.lblCountQuestions.Text = "lblCountQuestions";
            // 
            // lblRightAnswers
            // 
            this.lblRightAnswers.AutoSize = true;
            this.lblRightAnswers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRightAnswers.Location = new System.Drawing.Point(12, 75);
            this.lblRightAnswers.Name = "lblRightAnswers";
            this.lblRightAnswers.Size = new System.Drawing.Size(108, 34);
            this.lblRightAnswers.TabIndex = 2;
            this.lblRightAnswers.Text = "\r\nlblRightAnswers";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWrongAnswers.Location = new System.Drawing.Point(12, 111);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(117, 34);
            this.lblWrongAnswers.TabIndex = 3;
            this.lblWrongAnswers.Text = "\r\nlblWrongAnswers";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMark.Location = new System.Drawing.Point(12, 145);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(55, 34);
            this.lblMark.TabIndex = 4;
            this.lblMark.Text = "\r\nlblMark";
            // 
            // lblStartDateTime
            // 
            this.lblStartDateTime.AutoSize = true;
            this.lblStartDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartDateTime.Location = new System.Drawing.Point(12, 188);
            this.lblStartDateTime.Name = "lblStartDateTime";
            this.lblStartDateTime.Size = new System.Drawing.Size(53, 17);
            this.lblStartDateTime.TabIndex = 5;
            this.lblStartDateTime.Text = "lblStart";
            // 
            // lblEndDateTime
            // 
            this.lblEndDateTime.AutoSize = true;
            this.lblEndDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndDateTime.Location = new System.Drawing.Point(12, 220);
            this.lblEndDateTime.Name = "lblEndDateTime";
            this.lblEndDateTime.Size = new System.Drawing.Size(59, 17);
            this.lblEndDateTime.TabIndex = 6;
            this.lblEndDateTime.Text = "lblfinish";
            // 
            // RezaltFormTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 315);
            this.Controls.Add(this.lblEndDateTime);
            this.Controls.Add(this.lblStartDateTime);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblWrongAnswers);
            this.Controls.Add(this.lblRightAnswers);
            this.Controls.Add(this.lblCountQuestions);
            this.Controls.Add(this.lblName);
            this.Name = "RezaltFormTraining";
            this.Text = "Результат проходження тесту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountQuestions;
        private System.Windows.Forms.Label lblRightAnswers;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblStartDateTime;
        private System.Windows.Forms.Label lblEndDateTime;
    }
}
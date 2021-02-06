
namespace QuestionForm
{
    partial class TrainingForm
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
            this.lblNumberQuestion = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.flowLayoutQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.btnFinishTraining = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberQuestion
            // 
            this.lblNumberQuestion.AutoSize = true;
            this.lblNumberQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberQuestion.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNumberQuestion.Location = new System.Drawing.Point(350, 32);
            this.lblNumberQuestion.Name = "lblNumberQuestion";
            this.lblNumberQuestion.Size = new System.Drawing.Size(127, 32);
            this.lblNumberQuestion.TabIndex = 0;
            this.lblNumberQuestion.Text = "Питання 1";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(399, 100);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Текст запитання Текст запитання Текст запитання Текст запитання Текст запитання Т" +
    "екст запитання Текст запитання Текст запитання";
            // 
            // flowLayoutQuestion
            // 
            this.flowLayoutQuestion.Controls.Add(this.lblQuestion);
            this.flowLayoutQuestion.Location = new System.Drawing.Point(23, 84);
            this.flowLayoutQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutQuestion.Name = "flowLayoutQuestion";
            this.flowLayoutQuestion.Size = new System.Drawing.Size(430, 157);
            this.flowLayoutQuestion.TabIndex = 2;
            // 
            // gbAnswers
            // 
            this.gbAnswers.Location = new System.Drawing.Point(23, 268);
            this.gbAnswers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAnswers.Size = new System.Drawing.Size(430, 281);
            this.gbAnswers.TabIndex = 3;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Варіанти відповідей";
            // 
            // pBoxImage
            // 
            this.pBoxImage.Location = new System.Drawing.Point(487, 84);
            this.pBoxImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(303, 353);
            this.pBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImage.TabIndex = 4;
            this.pBoxImage.TabStop = false;
            // 
            // btnFinishTraining
            // 
            this.btnFinishTraining.BackColor = System.Drawing.Color.LightCoral;
            this.btnFinishTraining.Location = new System.Drawing.Point(647, 469);
            this.btnFinishTraining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinishTraining.Name = "btnFinishTraining";
            this.btnFinishTraining.Size = new System.Drawing.Size(143, 80);
            this.btnFinishTraining.TabIndex = 6;
            this.btnFinishTraining.Text = "Завершити";
            this.btnFinishTraining.UseVisualStyleBackColor = false;
            this.btnFinishTraining.Click += new System.EventHandler(this.btnFinishTraining_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(487, 469);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 80);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Наступне запитання";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 577);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFinishTraining);
            this.Controls.Add(this.pBoxImage);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.flowLayoutQuestion);
            this.Controls.Add(this.lblNumberQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренування";
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.flowLayoutQuestion.ResumeLayout(false);
            this.flowLayoutQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutQuestion;
        private System.Windows.Forms.GroupBox gbAnswers;
        private System.Windows.Forms.PictureBox pBoxImage;
        private System.Windows.Forms.Button btnFinishTraining;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
    }
}
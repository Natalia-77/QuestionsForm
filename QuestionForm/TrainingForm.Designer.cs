﻿
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
            this.lblNumberQuestion = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.flowLayoutQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.btnFinishTraining = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.flowLayoutQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberQuestion
            // 
            this.lblNumberQuestion.AutoSize = true;
            this.lblNumberQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberQuestion.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNumberQuestion.Location = new System.Drawing.Point(306, 24);
            this.lblNumberQuestion.Name = "lblNumberQuestion";
            this.lblNumberQuestion.Size = new System.Drawing.Size(103, 25);
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
            this.lblQuestion.Size = new System.Drawing.Size(360, 60);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Текст запитання Текст запитання Текст запитання Текст запитання Текст запитання Т" +
    "екст запитання Текст запитання Текст запитання";
            // 
            // flowLayoutQuestion
            // 
            this.flowLayoutQuestion.Controls.Add(this.lblQuestion);
            this.flowLayoutQuestion.Location = new System.Drawing.Point(20, 63);
            this.flowLayoutQuestion.Name = "flowLayoutQuestion";
            this.flowLayoutQuestion.Size = new System.Drawing.Size(376, 118);
            this.flowLayoutQuestion.TabIndex = 2;
            // 
            // gbAnswers
            // 
            this.gbAnswers.Location = new System.Drawing.Point(20, 201);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(376, 211);
            this.gbAnswers.TabIndex = 3;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Варіанти відповідей";
            // 
            // pBoxImage
            // 
            this.pBoxImage.Location = new System.Drawing.Point(426, 63);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(265, 265);
            this.pBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImage.TabIndex = 4;
            this.pBoxImage.TabStop = false;
            // 
            // btnFinishTraining
            // 
            this.btnFinishTraining.BackColor = System.Drawing.Color.LightCoral;
            this.btnFinishTraining.Location = new System.Drawing.Point(566, 352);
            this.btnFinishTraining.Name = "btnFinishTraining";
            this.btnFinishTraining.Size = new System.Drawing.Size(125, 60);
            this.btnFinishTraining.TabIndex = 6;
            this.btnFinishTraining.Text = "Завершити";
            this.btnFinishTraining.UseVisualStyleBackColor = false;
            this.btnFinishTraining.Click += new System.EventHandler(this.btnFinishTraining_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(426, 352);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 60);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Наступне запитання";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 433);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFinishTraining);
            this.Controls.Add(this.pBoxImage);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.flowLayoutQuestion);
            this.Controls.Add(this.lblNumberQuestion);
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
    }
}
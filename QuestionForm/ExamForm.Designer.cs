
namespace QuestionForm
{
    partial class ExamForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNumberQuestion = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.flowLayoutQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.btnQstNumber1 = new System.Windows.Forms.Button();
            this.btnQstNumber2 = new System.Windows.Forms.Button();
            this.btnQstNumber3 = new System.Windows.Forms.Button();
            this.btnQstNumber4 = new System.Windows.Forms.Button();
            this.btnQstNumber5 = new System.Windows.Forms.Button();
            this.btnQstNumber6 = new System.Windows.Forms.Button();
            this.btnQstNumber7 = new System.Windows.Forms.Button();
            this.btnQstNumber8 = new System.Windows.Forms.Button();
            this.btnQstNumber9 = new System.Windows.Forms.Button();
            this.btnQstNumber10 = new System.Windows.Forms.Button();
            this.btnFinishExam = new System.Windows.Forms.Button();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelTT = new System.Windows.Forms.Label();
            this.labeltimer = new System.Windows.Forms.Label();
            this.flowLayoutQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNumberQuestion
            // 
            this.lblNumberQuestion.AutoSize = true;
            this.lblNumberQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberQuestion.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNumberQuestion.Location = new System.Drawing.Point(131, 20);
            this.lblNumberQuestion.Name = "lblNumberQuestion";
            this.lblNumberQuestion.Size = new System.Drawing.Size(127, 25);
            this.lblNumberQuestion.TabIndex = 0;
            this.lblNumberQuestion.Text = "Питання 1/10";
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
            this.gbAnswers.Size = new System.Drawing.Size(376, 179);
            this.gbAnswers.TabIndex = 3;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Варіанти відповідей";
            // 
            // pBoxImage
            // 
            this.pBoxImage.Location = new System.Drawing.Point(426, 63);
            this.pBoxImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(265, 265);
            this.pBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImage.TabIndex = 4;
            this.pBoxImage.TabStop = false;
            // 
            // btnQstNumber1
            // 
            this.btnQstNumber1.Location = new System.Drawing.Point(183, 407);
            this.btnQstNumber1.Name = "btnQstNumber1";
            this.btnQstNumber1.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber1.TabIndex = 5;
            this.btnQstNumber1.Text = "1";
            this.btnQstNumber1.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber2
            // 
            this.btnQstNumber2.Location = new System.Drawing.Point(234, 407);
            this.btnQstNumber2.Name = "btnQstNumber2";
            this.btnQstNumber2.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber2.TabIndex = 5;
            this.btnQstNumber2.Text = "2";
            this.btnQstNumber2.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber3
            // 
            this.btnQstNumber3.Location = new System.Drawing.Point(285, 407);
            this.btnQstNumber3.Name = "btnQstNumber3";
            this.btnQstNumber3.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber3.TabIndex = 5;
            this.btnQstNumber3.Text = "3";
            this.btnQstNumber3.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber4
            // 
            this.btnQstNumber4.Location = new System.Drawing.Point(336, 407);
            this.btnQstNumber4.Name = "btnQstNumber4";
            this.btnQstNumber4.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber4.TabIndex = 5;
            this.btnQstNumber4.Text = "4";
            this.btnQstNumber4.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber5
            // 
            this.btnQstNumber5.Location = new System.Drawing.Point(387, 407);
            this.btnQstNumber5.Name = "btnQstNumber5";
            this.btnQstNumber5.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber5.TabIndex = 5;
            this.btnQstNumber5.Text = "5";
            this.btnQstNumber5.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber6
            // 
            this.btnQstNumber6.Location = new System.Drawing.Point(438, 407);
            this.btnQstNumber6.Name = "btnQstNumber6";
            this.btnQstNumber6.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber6.TabIndex = 5;
            this.btnQstNumber6.Text = "6";
            this.btnQstNumber6.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber7
            // 
            this.btnQstNumber7.Location = new System.Drawing.Point(489, 407);
            this.btnQstNumber7.Name = "btnQstNumber7";
            this.btnQstNumber7.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber7.TabIndex = 5;
            this.btnQstNumber7.Text = "7";
            this.btnQstNumber7.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber8
            // 
            this.btnQstNumber8.Location = new System.Drawing.Point(540, 407);
            this.btnQstNumber8.Name = "btnQstNumber8";
            this.btnQstNumber8.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber8.TabIndex = 5;
            this.btnQstNumber8.Text = "8";
            this.btnQstNumber8.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber9
            // 
            this.btnQstNumber9.Location = new System.Drawing.Point(591, 407);
            this.btnQstNumber9.Name = "btnQstNumber9";
            this.btnQstNumber9.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber9.TabIndex = 5;
            this.btnQstNumber9.Text = "9";
            this.btnQstNumber9.UseVisualStyleBackColor = true;
            // 
            // btnQstNumber10
            // 
            this.btnQstNumber10.Location = new System.Drawing.Point(642, 407);
            this.btnQstNumber10.Name = "btnQstNumber10";
            this.btnQstNumber10.Size = new System.Drawing.Size(45, 45);
            this.btnQstNumber10.TabIndex = 5;
            this.btnQstNumber10.Text = "10";
            this.btnQstNumber10.UseVisualStyleBackColor = true;
            // 
            // btnFinishExam
            // 
            this.btnFinishExam.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFinishExam.Location = new System.Drawing.Point(20, 393);
            this.btnFinishExam.Name = "btnFinishExam";
            this.btnFinishExam.Size = new System.Drawing.Size(132, 75);
            this.btnFinishExam.TabIndex = 6;
            this.btnFinishExam.Text = "Наступне\r\nпитання";
            this.btnFinishExam.UseVisualStyleBackColor = false;
            this.btnFinishExam.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.BackColor = System.Drawing.Color.Transparent;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSec.Location = new System.Drawing.Point(644, 24);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(29, 20);
            this.labelSec.TabIndex = 0;
            this.labelSec.Text = "00";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMin.Location = new System.Drawing.Point(601, 24);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(29, 20);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "00";
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.BackColor = System.Drawing.Color.Transparent;
            this.labelTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTT.Location = new System.Drawing.Point(630, 24);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(14, 20);
            this.labelTT.TabIndex = 2;
            this.labelTT.Text = ":";
            // 
            // labeltimer
            // 
            this.labeltimer.AutoSize = true;
            this.labeltimer.BackColor = System.Drawing.Color.Transparent;
            this.labeltimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labeltimer.Location = new System.Drawing.Point(442, 23);
            this.labeltimer.Name = "labeltimer";
            this.labeltimer.Size = new System.Drawing.Size(153, 21);
            this.labeltimer.TabIndex = 3;
            this.labeltimer.Text = "Залишилось часу:";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 480);
            this.Controls.Add(this.btnFinishExam);
            this.Controls.Add(this.btnQstNumber10);
            this.Controls.Add(this.btnQstNumber9);
            this.Controls.Add(this.btnQstNumber8);
            this.Controls.Add(this.btnQstNumber7);
            this.Controls.Add(this.btnQstNumber6);
            this.Controls.Add(this.btnQstNumber5);
            this.Controls.Add(this.btnQstNumber4);
            this.Controls.Add(this.btnQstNumber3);
            this.Controls.Add(this.btnQstNumber2);
            this.Controls.Add(this.btnQstNumber1);
            this.Controls.Add(this.pBoxImage);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.flowLayoutQuestion);
            this.Controls.Add(this.lblNumberQuestion);
            this.Controls.Add(this.labeltimer);
            this.Controls.Add(this.labelTT);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelSec);
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Іспит по ПДР";
            this.Load += new System.EventHandler(this.ExamForm_Load);
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
        private System.Windows.Forms.Button btnQstNumber1;
        private System.Windows.Forms.Button btnQstNumber2;
        private System.Windows.Forms.Button btnQstNumber3;
        private System.Windows.Forms.Button btnQstNumber4;
        private System.Windows.Forms.Button btnQstNumber5;
        private System.Windows.Forms.Button btnQstNumber6;
        private System.Windows.Forms.Button btnQstNumber7;
        private System.Windows.Forms.Button btnQstNumber8;
        private System.Windows.Forms.Button btnQstNumber9;
        private System.Windows.Forms.Button btnQstNumber10;
        private System.Windows.Forms.Button btnFinishExam;

        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.Label labeltimer;
    }
}
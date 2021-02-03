﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
        }
        DateTime begin = DateTime.Now.ToUniversalTime();
        int min = 2;//задаем время старта на таймере
        int sec = 0;
        int conter = 0;//счетчик тиков для досчета времени затраченого на сесию
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                conter++;
                labelTT.Visible = true;

                if (sec > 0)
                {

                    sec--;

                    if (sec < 10)
                        labelSec.Text = "0" + sec.ToString();
                    else
                        labelSec.Text = sec.ToString();

                }
                else
                {
                    if (min > 0)
                    {
                        min--;
                        if (min < 10)
                            labelMin.Text = "0" + min.ToString();
                        else
                            labelMin.Text = min.ToString();
                        sec = 59;
                        labelSec.Text = "59";
                    }
                    else
                    {
                        min = 0;
                        labelMin.Text = "00";

                    }

                }
                
            }

            if (min == 0 && sec == 0)
            {
                timer1.Enabled = false;
                if (MessageBox.Show("Відведений час вичерпано.\n Спробуйте наступного разу.") == DialogResult.OK)
                    Application.Exit();
            }
        
        }

        private void btnFinishExam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
              DateTime finish = begin.AddSeconds(conter);
           if( MessageBox.Show($"\nВременное сообщение\nВремя старта {begin}\nВремя финиша {finish} \ntik {conter} ") == DialogResult.OK)
            new RezaltFormTraining().ShowDialog();
            
            

        }
    }
}

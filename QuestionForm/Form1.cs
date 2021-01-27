using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int min = 2;//задаем время старта на таймере
        int sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
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



    }
}

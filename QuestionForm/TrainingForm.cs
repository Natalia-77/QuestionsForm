using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class TrainingForm : Form
    {
        public TrainingForm()
        {
            InitializeComponent();
        }

        private void btnFinishTraining_Click(object sender, EventArgs e)
        {
            new RezaltFormTraining().ShowDialog();
        }
    }
}

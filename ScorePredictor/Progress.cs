using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
            submitProgressBar.Minimum = 0;
            submitProgressBar.Visible = true;
        }

        public void setProgressBarSize(int size)
        {
            submitProgressBar.Maximum = size;
        }

        public void incrementProgressBar(int value)
        {
            submitProgressBar.PerformStep();
        }
    }
}

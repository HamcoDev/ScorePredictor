using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class PredictionUserControl : UserControl
    {
        public PredictionUserControl()
        {
            InitializeComponent();
            
        }

        public void Update(List<Prediction> predictions)
        {
            dataGridView.DataSource = predictions;
            dataGridView.RowTemplate.Height = this.Height / 10;
            dataGridView.Columns[1].HeaderText = "Home Team";
            dataGridView.Columns[2].HeaderText = "";
            dataGridView.Columns[3].HeaderText = "Away Team";
            dataGridView.Columns[4].HeaderText = "";
            dataGridView.Columns[0].Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS_EXAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuantizationAndEncoding form = new QuantizationAndEncoding();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryWeightedDAC form = new BinaryWeightedDAC();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            R2RLadderDAC form = new R2RLadderDAC();
            form.Show();
        }
    }
}

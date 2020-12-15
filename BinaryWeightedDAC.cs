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
    public partial class BinaryWeightedDAC : Form
    {
        public BinaryWeightedDAC()
        {
            InitializeComponent();
        }

        private void in_NumOfBits_ValueChanged(object sender, EventArgs e)
        {
            // Reset digital value
            in_DigitalValue.ResetText();
            in_DigitalValue.MaxLength = (int)in_NumOfBits.Value;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            // Get Input Values
            double Vref = (double)in_Vref.Value;
            double R = (double)in_R.Value;
            double Rf = (double)in_Rf.Value;
            int num_of_bits = (int)in_NumOfBits.Value;
            string digital_value = in_DigitalValue.Text;

            // Check if digital value format is correct
            if (digital_value.Length == num_of_bits)
            {
                // Clear Previous Values
                out_Table.Items.Clear();
                out_AnalogValue.ResetText();

                // Loop though all possible digital values
                for (int level = 0; level < Math.Pow(2, num_of_bits); level++)
                {
                    // Format Binary string
                    string binary = Convert.ToString(level, 2);
                    for (int length = binary.Length; length < num_of_bits; length++)
                        binary = "0" + binary;

                    // Formula
                    double analog_value = 0;
                    int n = 0;
                    foreach (char bit in binary)
                        analog_value += (1 / (Math.Pow(2, n++) * R)) * (bit == '1' ? Vref : 0);
                    analog_value = Math.Round(-Rf * analog_value, 3);

                    // Insert to Table
                    ListViewItem this_tableitem = new ListViewItem(binary);
                    this_tableitem.SubItems.Add(analog_value.ToString());
                    out_Table.Items.Add(this_tableitem);

                    // Output Analog Value
                    if (binary == digital_value)
                        out_AnalogValue.Text = analog_value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Digital Value is not within parameters.");
            }
        }
    }
}
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
    public partial class QuantizationAndEncoding : Form
    {
        public class TableItem
        {
            public int level;
            public string binary;
            public double voltage;
            public double position;
        }

        public QuantizationAndEncoding()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            // Get Input Values
            double v_min = (double)in_Vmin.Value;
            double v_max = (double)in_Vmax.Value;
            int num_of_bits = (int)in_NumOfBits.Value;
            double sampled_value = (double)in_SampledValue.Value;

            // Levels
            int levels = (int)(Math.Pow(2, num_of_bits));
            out_Levels.Text = levels.ToString();

            // Step Size
            double step_size = Math.Round((v_max - v_min) / levels, 3);
            out_StepSize.Text = step_size.ToString();

            // Table
            out_Table.Items.Clear();
            TableItem closestItem = new TableItem();
            for (int level = 0; level < levels; level++)
            {
                // Add leading zeroes to represent an n bit binary
                string binary = Convert.ToString(level, 2);
                for (int length = binary.Length; length < num_of_bits; length++)
                    binary = "0" + binary;

                // Create object
                TableItem this_item = new TableItem();
                this_item.level = level;
                this_item.binary = binary;
                this_item.voltage = Math.Round(v_min + (level * step_size), 3);
                this_item.position = Math.Abs(this_item.voltage - sampled_value);

                // Check if this item is closest to the sampled value
                if (level == 0 || closestItem.position > this_item.position)
                    closestItem = this_item;

                // Insert to Table
                ListViewItem this_tableitem = new ListViewItem(this_item.level.ToString());
                this_tableitem.SubItems.Add(this_item.binary);
                this_tableitem.SubItems.Add(this_item.voltage.ToString());
                out_Table.Items.Add(this_tableitem);
            }

            // Quantized
            out_QuantizedValue.Text = closestItem.voltage.ToString();
            out_DigitalValue.Text = closestItem.binary;
        }
    }
}

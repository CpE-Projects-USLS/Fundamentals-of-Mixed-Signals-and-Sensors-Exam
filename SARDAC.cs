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
    public partial class SARDAC : Form
    {
        public class TableItem
        {
            public int level;
            public string binary;
            public double voltage;
            public double position;
        }

        public SARDAC()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            // Get Input Values
            double Vref = (double)in_Vref.Value;
            double analog_value = (double)in_AnalogValue.Value;
            int num_of_bits = (int)in_NumOfBits.Value;

            // Clear Previous Values
            out_Levels.Clear();
            out_StepSize.Clear();
            out_Table.Items.Clear();
            out_Process.Items.Clear();
            out_BinaryValue.ResetText();

            // Levels
            int levels = (int)(Math.Pow(2, num_of_bits));
            out_Levels.Text = levels.ToString();

            // Step Size
            double step_size = Vref / levels;
            out_StepSize.Text = step_size.ToString();

            // Table
            TableItem[] tableitems = new TableItem[levels + 1];
            for (int level = 0; level < levels; level++)
            {
                // Format Binary string
                string binary = Convert.ToString(level, 2);
                for (int length = binary.Length; length < num_of_bits; length++)
                    binary = "0" + binary;

                // Create object
                TableItem this_item = new TableItem();
                this_item.level = level;
                this_item.binary = binary;
                this_item.voltage = Math.Round(level * step_size, 3);

                // Insert to array
                tableitems[level] = this_item;

                // Insert to Table
                ListViewItem this_tableitem = new ListViewItem(this_item.level.ToString());
                this_tableitem.SubItems.Add(this_item.binary);
                this_tableitem.SubItems.Add(this_item.voltage.ToString());
                out_Table.Items.Add(this_tableitem);
            }

            // Process

            // Set the MSB to 1 and other bits reset to 0
            String digital_value = "1";
            for (int length = digital_value.Length; length < num_of_bits; length++)
                digital_value += "0";

            // the conversion will be completed after num_of_bits clock cycles
            for (int clock = 1; clock <= num_of_bits; clock++)
            {
                // Convert digital value to integer
                int index = Convert.ToInt32(digital_value, 2);

                // Get this item from the array
                TableItem this_item = tableitems[index];

                // Insert to Table
                ListViewItem this_tableitem = new ListViewItem(clock.ToString());
                if (analog_value > this_item.voltage)
                {
                    this_tableitem.SubItems.Add(analog_value + " > " + this_item.voltage);
                    if (clock == num_of_bits)
                        this_tableitem.SubItems.Add("No next bit to set.");
                    else 
                        this_tableitem.SubItems.Add("Set the next bit to 1.");
                } else
                {
                    this_tableitem.SubItems.Add(analog_value + " <= " + this_item.voltage);
                    if (clock == num_of_bits)
                        this_tableitem.SubItems.Add("Reset current bit and no next bit to set.");
                    else
                        this_tableitem.SubItems.Add("Reset current bit and set the next bit to 1.");
                }
                out_Process.Items.Add(this_tableitem);

                // Action
                String temp_digital_value = "";
                int n = 0;
                foreach (char bit in digital_value)
                {
                    if (n == clock)
                        temp_digital_value += '1'; // the next bit will bet set to 1
                    else
                    {
                        if (analog_value <= this_item.voltage && (n + 1) == clock)
                            temp_digital_value += '0'; // current bit will be reset to 0 
                        else
                            temp_digital_value += bit; // copy other bits
                    }
                    n++;
                }
                digital_value = temp_digital_value;
            }

            // Convert digital value to integer
            int final_index = Convert.ToInt32(digital_value, 2);

            // Get this item from the array
            TableItem final_item = tableitems[final_index];

            // Binary
            out_BinaryValue.Text = final_item.binary;
        }
    }
}

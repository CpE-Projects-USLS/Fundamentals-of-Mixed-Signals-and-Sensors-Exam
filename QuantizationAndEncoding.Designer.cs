
namespace MSS_EXAM
{
    partial class QuantizationAndEncoding
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.in_Vmin = new System.Windows.Forms.NumericUpDown();
            this.in_Vmax = new System.Windows.Forms.NumericUpDown();
            this.in_NumOfBits = new System.Windows.Forms.NumericUpDown();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.in_SampledValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.out_Levels = new System.Windows.Forms.TextBox();
            this.out_QuantizedValue = new System.Windows.Forms.TextBox();
            this.out_DigitalValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.out_StepSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.out_Table = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.in_Vmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_Vmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_NumOfBits)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_SampledValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vmin:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vmax:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num. of Bits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // in_Vmin
            // 
            this.in_Vmin.DecimalPlaces = 3;
            this.in_Vmin.Location = new System.Drawing.Point(143, 22);
            this.in_Vmin.Margin = new System.Windows.Forms.Padding(2);
            this.in_Vmin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.in_Vmin.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.in_Vmin.Name = "in_Vmin";
            this.in_Vmin.Size = new System.Drawing.Size(106, 26);
            this.in_Vmin.TabIndex = 3;
            this.in_Vmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // in_Vmax
            // 
            this.in_Vmax.DecimalPlaces = 3;
            this.in_Vmax.Location = new System.Drawing.Point(143, 50);
            this.in_Vmax.Margin = new System.Windows.Forms.Padding(2);
            this.in_Vmax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.in_Vmax.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.in_Vmax.Name = "in_Vmax";
            this.in_Vmax.Size = new System.Drawing.Size(106, 26);
            this.in_Vmax.TabIndex = 4;
            this.in_Vmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // in_NumOfBits
            // 
            this.in_NumOfBits.Location = new System.Drawing.Point(143, 77);
            this.in_NumOfBits.Margin = new System.Windows.Forms.Padding(2);
            this.in_NumOfBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.in_NumOfBits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.in_NumOfBits.Name = "in_NumOfBits";
            this.in_NumOfBits.Size = new System.Drawing.Size(106, 26);
            this.in_NumOfBits.TabIndex = 5;
            this.in_NumOfBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.in_NumOfBits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(254, 22);
            this.btn_Calculate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(93, 107);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.in_SampledValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.in_NumOfBits);
            this.groupBox1.Controls.Add(this.in_Vmin);
            this.groupBox1.Controls.Add(this.in_Vmax);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(351, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // in_SampledValue
            // 
            this.in_SampledValue.DecimalPlaces = 3;
            this.in_SampledValue.Location = new System.Drawing.Point(143, 103);
            this.in_SampledValue.Margin = new System.Windows.Forms.Padding(2);
            this.in_SampledValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.in_SampledValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.in_SampledValue.Name = "in_SampledValue";
            this.in_SampledValue.Size = new System.Drawing.Size(106, 26);
            this.in_SampledValue.TabIndex = 9;
            this.in_SampledValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sampled Value:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.out_Levels);
            this.groupBox2.Controls.Add(this.out_QuantizedValue);
            this.groupBox2.Controls.Add(this.out_DigitalValue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.out_StepSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.out_Table);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 375);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "Levels:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // out_Levels
            // 
            this.out_Levels.Cursor = System.Windows.Forms.Cursors.Default;
            this.out_Levels.Location = new System.Drawing.Point(88, 33);
            this.out_Levels.Name = "out_Levels";
            this.out_Levels.ReadOnly = true;
            this.out_Levels.Size = new System.Drawing.Size(48, 26);
            this.out_Levels.TabIndex = 15;
            this.out_Levels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // out_QuantizedValue
            // 
            this.out_QuantizedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.out_QuantizedValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.out_QuantizedValue.Location = new System.Drawing.Point(166, 334);
            this.out_QuantizedValue.Name = "out_QuantizedValue";
            this.out_QuantizedValue.ReadOnly = true;
            this.out_QuantizedValue.Size = new System.Drawing.Size(179, 26);
            this.out_QuantizedValue.TabIndex = 13;
            this.out_QuantizedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // out_DigitalValue
            // 
            this.out_DigitalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.out_DigitalValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.out_DigitalValue.Location = new System.Drawing.Point(166, 307);
            this.out_DigitalValue.Name = "out_DigitalValue";
            this.out_DigitalValue.ReadOnly = true;
            this.out_DigitalValue.Size = new System.Drawing.Size(179, 26);
            this.out_DigitalValue.TabIndex = 12;
            this.out_DigitalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Location = new System.Drawing.Point(8, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Digital Value:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(8, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantized Value:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // out_StepSize
            // 
            this.out_StepSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.out_StepSize.Location = new System.Drawing.Point(241, 33);
            this.out_StepSize.Name = "out_StepSize";
            this.out_StepSize.ReadOnly = true;
            this.out_StepSize.Size = new System.Drawing.Size(104, 26);
            this.out_StepSize.TabIndex = 9;
            this.out_StepSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(144, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Step Size:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // out_Table
            // 
            this.out_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out_Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.out_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_Table.HideSelection = false;
            this.out_Table.Location = new System.Drawing.Point(9, 73);
            this.out_Table.Name = "out_Table";
            this.out_Table.Size = new System.Drawing.Size(339, 228);
            this.out_Table.TabIndex = 0;
            this.out_Table.UseCompatibleStateImageBehavior = false;
            this.out_Table.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Level";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Binary Value";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Voltage";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 170;
            // 
            // QuantizationAndEncoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 1000);
            this.MinimumSize = new System.Drawing.Size(387, 577);
            this.Name = "QuantizationAndEncoding";
            this.Text = "Quantization And Encoding";
            ((System.ComponentModel.ISupportInitialize)(this.in_Vmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_Vmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_NumOfBits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.in_SampledValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown in_Vmin;
        private System.Windows.Forms.NumericUpDown in_Vmax;
        private System.Windows.Forms.NumericUpDown in_NumOfBits;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView out_Table;
        private System.Windows.Forms.NumericUpDown in_SampledValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox out_StepSize;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox out_QuantizedValue;
        private System.Windows.Forms.TextBox out_DigitalValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox out_Levels;
        private System.Windows.Forms.Label label8;
    }
}
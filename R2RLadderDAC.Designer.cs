
namespace MSS_EXAM
{
    partial class R2RLadderDAC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.in_DigitalValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.in_Rf = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.in_NumOfBits = new System.Windows.Forms.NumericUpDown();
            this.in_Vref = new System.Windows.Forms.NumericUpDown();
            this.in_R = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.out_Table = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.out_AnalogValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_Rf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_NumOfBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_Vref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_R)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.in_DigitalValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.in_Rf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.in_NumOfBits);
            this.groupBox1.Controls.Add(this.in_Vref);
            this.groupBox1.Controls.Add(this.in_R);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(351, 163);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // in_DigitalValue
            // 
            this.in_DigitalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_DigitalValue.Location = new System.Drawing.Point(143, 132);
            this.in_DigitalValue.Name = "in_DigitalValue";
            this.in_DigitalValue.Size = new System.Drawing.Size(106, 24);
            this.in_DigitalValue.TabIndex = 12;
            this.in_DigitalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rf (Ohms):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // in_Rf
            // 
            this.in_Rf.DecimalPlaces = 3;
            this.in_Rf.Location = new System.Drawing.Point(143, 77);
            this.in_Rf.Margin = new System.Windows.Forms.Padding(2);
            this.in_Rf.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.in_Rf.Name = "in_Rf";
            this.in_Rf.Size = new System.Drawing.Size(106, 26);
            this.in_Rf.TabIndex = 11;
            this.in_Rf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Digital Value:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vref:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(254, 22);
            this.btn_Calculate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(93, 133);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "R (Ohms):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num. of Bits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // in_NumOfBits
            // 
            this.in_NumOfBits.Location = new System.Drawing.Point(143, 104);
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
            3,
            0,
            0,
            0});
            this.in_NumOfBits.ValueChanged += new System.EventHandler(this.in_NumOfBits_ValueChanged);
            // 
            // in_Vref
            // 
            this.in_Vref.DecimalPlaces = 3;
            this.in_Vref.Location = new System.Drawing.Point(143, 22);
            this.in_Vref.Margin = new System.Windows.Forms.Padding(2);
            this.in_Vref.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.in_Vref.Name = "in_Vref";
            this.in_Vref.Size = new System.Drawing.Size(106, 26);
            this.in_Vref.TabIndex = 3;
            this.in_Vref.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // in_R
            // 
            this.in_R.DecimalPlaces = 3;
            this.in_R.Location = new System.Drawing.Point(143, 50);
            this.in_R.Margin = new System.Windows.Forms.Padding(2);
            this.in_R.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.in_R.Name = "in_R";
            this.in_R.Size = new System.Drawing.Size(106, 26);
            this.in_R.TabIndex = 4;
            this.in_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.out_Table);
            this.groupBox2.Controls.Add(this.out_AnalogValue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 349);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // out_Table
            // 
            this.out_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.out_Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.out_Table.HideSelection = false;
            this.out_Table.Location = new System.Drawing.Point(6, 25);
            this.out_Table.Name = "out_Table";
            this.out_Table.Size = new System.Drawing.Size(339, 286);
            this.out_Table.TabIndex = 13;
            this.out_Table.UseCompatibleStateImageBehavior = false;
            this.out_Table.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Binary";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Analog";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 240;
            // 
            // out_AnalogValue
            // 
            this.out_AnalogValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.out_AnalogValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.out_AnalogValue.Location = new System.Drawing.Point(130, 317);
            this.out_AnalogValue.Name = "out_AnalogValue";
            this.out_AnalogValue.ReadOnly = true;
            this.out_AnalogValue.Size = new System.Drawing.Size(215, 26);
            this.out_AnalogValue.TabIndex = 12;
            this.out_AnalogValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Location = new System.Drawing.Point(8, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Analog Value:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // R2RLadderDAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(387, 1000);
            this.MinimumSize = new System.Drawing.Size(387, 577);
            this.Name = "R2RLadderDAC";
            this.Text = "R/2R Ladder DAC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_Rf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_NumOfBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_Vref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_R)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox in_DigitalValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown in_Rf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown in_NumOfBits;
        private System.Windows.Forms.NumericUpDown in_Vref;
        private System.Windows.Forms.NumericUpDown in_R;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView out_Table;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox out_AnalogValue;
        private System.Windows.Forms.Label label7;
    }
}
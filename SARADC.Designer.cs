
namespace MSS_EXAM
{
    partial class SARADC
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.in_NumOfBits = new System.Windows.Forms.NumericUpDown();
            this.in_Vref = new System.Windows.Forms.NumericUpDown();
            this.in_AnalogValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.out_Process = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.out_Levels = new System.Windows.Forms.TextBox();
            this.out_BinaryValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.out_StepSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.out_Table = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_NumOfBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_Vref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_AnalogValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.in_NumOfBits);
            this.groupBox1.Controls.Add(this.in_Vref);
            this.groupBox1.Controls.Add(this.in_AnalogValue);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(351, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
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
            this.btn_Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Calculate.Location = new System.Drawing.Point(254, 22);
            this.btn_Calculate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(93, 82);
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
            this.label2.Text = "Analog Value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num. of Bits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // in_NumOfBits
            // 
            this.in_NumOfBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in_NumOfBits.Location = new System.Drawing.Point(143, 78);
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
            // 
            // in_Vref
            // 
            this.in_Vref.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // in_AnalogValue
            // 
            this.in_AnalogValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in_AnalogValue.DecimalPlaces = 3;
            this.in_AnalogValue.Location = new System.Drawing.Point(143, 50);
            this.in_AnalogValue.Margin = new System.Windows.Forms.Padding(2);
            this.in_AnalogValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.in_AnalogValue.Name = "in_AnalogValue";
            this.in_AnalogValue.Size = new System.Drawing.Size(106, 26);
            this.in_AnalogValue.TabIndex = 4;
            this.in_AnalogValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.out_Process);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.out_Levels);
            this.groupBox2.Controls.Add(this.out_BinaryValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.out_StepSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.out_Table);
            this.groupBox2.Location = new System.Drawing.Point(9, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 398);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // out_Process
            // 
            this.out_Process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out_Process.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.out_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_Process.HideSelection = false;
            this.out_Process.Location = new System.Drawing.Point(9, 244);
            this.out_Process.Name = "out_Process";
            this.out_Process.Size = new System.Drawing.Size(339, 107);
            this.out_Process.TabIndex = 17;
            this.out_Process.UseCompatibleStateImageBehavior = false;
            this.out_Process.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Clock";
            this.columnHeader7.Width = 40;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Condition";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Action";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 210;
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
            // out_BinaryValue
            // 
            this.out_BinaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.out_BinaryValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.out_BinaryValue.Location = new System.Drawing.Point(166, 357);
            this.out_BinaryValue.Name = "out_BinaryValue";
            this.out_BinaryValue.ReadOnly = true;
            this.out_BinaryValue.Size = new System.Drawing.Size(179, 26);
            this.out_BinaryValue.TabIndex = 13;
            this.out_BinaryValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(8, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Binary Value:";
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
            this.out_Table.Size = new System.Drawing.Size(339, 165);
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
            // SARADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(387, 577);
            this.Name = "SARADC";
            this.Text = "SAR ADC";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.in_NumOfBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_Vref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_AnalogValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown in_NumOfBits;
        private System.Windows.Forms.NumericUpDown in_Vref;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown in_AnalogValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox out_Levels;
        private System.Windows.Forms.TextBox out_BinaryValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox out_StepSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView out_Table;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView out_Process;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}
namespace DdsPrinciple
{
    partial class frmMain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RefMin = new System.Windows.Forms.NumericUpDown();
            this.RefMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OutMax = new System.Windows.Forms.NumericUpDown();
            this.OutMin = new System.Windows.Forms.NumericUpDown();
            this.RefFreq = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RefShape = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.RefTune = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.OutDisplay = new DdsPrinciple.Components.FreqVisualizer();
            this.MixDisplay = new DdsPrinciple.Components.FreqVisualizer();
            this.InDisplay = new DdsPrinciple.Components.FreqVisualizer();
            this.RefDisplay = new DdsPrinciple.Components.FreqVisualizer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefTune)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.RefTune);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.RefShape);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RefFreq);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(2, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Location = new System.Drawing.Point(2, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MIX";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.listBox3);
            this.groupBox4.Location = new System.Drawing.Point(1, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OUT";
            // 
            // RefMin
            // 
            this.RefMin.Location = new System.Drawing.Point(301, 2);
            this.RefMin.Name = "RefMin";
            this.RefMin.Size = new System.Drawing.Size(86, 20);
            this.RefMin.TabIndex = 8;
            this.RefMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RefMin.ThousandsSeparator = true;
            this.RefMin.ValueChanged += new System.EventHandler(this.RefRange_ValueChanged);
            // 
            // RefMax
            // 
            this.RefMax.Location = new System.Drawing.Point(517, 2);
            this.RefMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.RefMax.Name = "RefMax";
            this.RefMax.Size = new System.Drawing.Size(88, 20);
            this.RefMax.TabIndex = 9;
            this.RefMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RefMax.ThousandsSeparator = true;
            this.RefMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RefMax.ValueChanged += new System.EventHandler(this.RefRange_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(247, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "FMIN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(463, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "FMAX:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(611, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hz";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(393, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hz";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(393, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hz";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(611, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hz";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(463, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "FMAX:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(247, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "FMIN:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutMax
            // 
            this.OutMax.Location = new System.Drawing.Point(517, 363);
            this.OutMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.OutMax.Name = "OutMax";
            this.OutMax.Size = new System.Drawing.Size(88, 20);
            this.OutMax.TabIndex = 15;
            this.OutMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OutMax.ThousandsSeparator = true;
            this.OutMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.OutMax.ValueChanged += new System.EventHandler(this.OutRange_ValueChanged);
            // 
            // OutMin
            // 
            this.OutMin.Location = new System.Drawing.Point(301, 363);
            this.OutMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.OutMin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.OutMin.Name = "OutMin";
            this.OutMin.Size = new System.Drawing.Size(86, 20);
            this.OutMin.TabIndex = 14;
            this.OutMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OutMin.ThousandsSeparator = true;
            this.OutMin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.OutMin.ValueChanged += new System.EventHandler(this.OutRange_ValueChanged);
            // 
            // RefFreq
            // 
            this.RefFreq.Location = new System.Drawing.Point(56, 19);
            this.RefFreq.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RefFreq.Name = "RefFreq";
            this.RefFreq.Size = new System.Drawing.Size(86, 20);
            this.RefFreq.TabIndex = 20;
            this.RefFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RefFreq.ThousandsSeparator = true;
            this.RefFreq.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RefFreq.ValueChanged += new System.EventHandler(this.RefFreq_ValueChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "F:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(148, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hz";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RefShape
            // 
            this.RefShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RefShape.FormattingEnabled = true;
            this.RefShape.Items.AddRange(new object[] {
            "Sine",
            "Square"});
            this.RefShape.Location = new System.Drawing.Point(56, 45);
            this.RefShape.Name = "RefShape";
            this.RefShape.Size = new System.Drawing.Size(86, 21);
            this.RefShape.TabIndex = 23;
            this.RefShape.SelectedIndexChanged += new System.EventHandler(this.RefShape_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(6, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Shape:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(87, 69);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(87, 69);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(7, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.ScrollAlwaysVisible = true;
            this.listBox3.Size = new System.Drawing.Size(87, 69);
            this.listBox3.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(104, 68);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown2.TabIndex = 21;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(196, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Hz";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(101, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Item: 0";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(99, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Item: 0";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(99, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Frequency: 0Hz";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(99, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Phase: 0°";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(100, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Phase: 0°";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(100, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "Frequency: 0Hz";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(100, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "Item: 0";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RefTune
            // 
            this.RefTune.LargeChange = 50;
            this.RefTune.Location = new System.Drawing.Point(56, 72);
            this.RefTune.Maximum = 100;
            this.RefTune.Minimum = -100;
            this.RefTune.Name = "RefTune";
            this.RefTune.Size = new System.Drawing.Size(171, 42);
            this.RefTune.SmallChange = 10;
            this.RefTune.TabIndex = 25;
            this.RefTune.TickFrequency = 50;
            this.RefTune.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RefTune.Scroll += new System.EventHandler(this.RefTune_Scroll);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(6, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 20);
            this.label20.TabIndex = 26;
            this.label20.Text = "Tune:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutDisplay
            // 
            this.OutDisplay.BackColor = System.Drawing.Color.White;
            this.OutDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutDisplay.Location = new System.Drawing.Point(247, 389);
            this.OutDisplay.MaxFreq = 1000D;
            this.OutDisplay.MinFreq = -1000D;
            this.OutDisplay.Name = "OutDisplay";
            this.OutDisplay.Size = new System.Drawing.Size(534, 100);
            this.OutDisplay.TabIndex = 7;
            // 
            // MixDisplay
            // 
            this.MixDisplay.BackColor = System.Drawing.Color.White;
            this.MixDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MixDisplay.Location = new System.Drawing.Point(248, 257);
            this.MixDisplay.MaxFreq = 1000D;
            this.MixDisplay.MinFreq = 0D;
            this.MixDisplay.Name = "MixDisplay";
            this.MixDisplay.Size = new System.Drawing.Size(533, 100);
            this.MixDisplay.TabIndex = 6;
            // 
            // InDisplay
            // 
            this.InDisplay.BackColor = System.Drawing.Color.White;
            this.InDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InDisplay.Location = new System.Drawing.Point(248, 142);
            this.InDisplay.MaxFreq = 1000D;
            this.InDisplay.MinFreq = 0D;
            this.InDisplay.Name = "InDisplay";
            this.InDisplay.Size = new System.Drawing.Size(533, 100);
            this.InDisplay.TabIndex = 5;
            // 
            // RefDisplay
            // 
            this.RefDisplay.BackColor = System.Drawing.Color.White;
            this.RefDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefDisplay.Location = new System.Drawing.Point(247, 28);
            this.RefDisplay.MaxFreq = 1000D;
            this.RefDisplay.MinFreq = 0D;
            this.RefDisplay.Name = "RefDisplay";
            this.RefDisplay.Size = new System.Drawing.Size(534, 100);
            this.RefDisplay.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OutMax);
            this.Controls.Add(this.OutMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefMax);
            this.Controls.Add(this.RefMin);
            this.Controls.Add(this.OutDisplay);
            this.Controls.Add(this.MixDisplay);
            this.Controls.Add(this.InDisplay);
            this.Controls.Add(this.RefDisplay);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefTune)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Components.FreqVisualizer RefDisplay;
        private Components.FreqVisualizer InDisplay;
        private Components.FreqVisualizer MixDisplay;
        private Components.FreqVisualizer OutDisplay;
        private System.Windows.Forms.NumericUpDown RefMin;
        private System.Windows.Forms.NumericUpDown RefMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown OutMax;
        private System.Windows.Forms.NumericUpDown OutMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox RefShape;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown RefFreq;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar RefTune;
    }
}


namespace AGaugeApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.label1 = new System.Windows.Forms.Label();
            this.aGauge8 = new AGaugeApp.AGauge();
            this.aGauge11 = new AGaugeApp.AGauge();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.aGauge4 = new AGaugeApp.AGauge();
            this.aGauge10 = new AGaugeApp.AGauge();
            this.aGauge9 = new AGaugeApp.AGauge();
            this.aGauge12 = new AGaugeApp.AGauge();
            this.aGauge5 = new AGaugeApp.AGauge();
            this.aGauge7 = new AGaugeApp.AGauge();
            this.aGauge3 = new AGaugeApp.AGauge();
            this.aGauge6 = new AGaugeApp.AGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aGauge13 = new AGaugeApp.AGauge();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Black;
            this.trackBar1.Location = new System.Drawing.Point(6, 32);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 217);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "change needle types";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(374, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 86);
            this.label1.TabIndex = 20;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aGauge8
            // 
            this.aGauge8.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge8.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge8.BaseArcRadius = 40;
            this.aGauge8.BaseArcStart = 180;
            this.aGauge8.BaseArcSweep = 90;
            this.aGauge8.BaseArcWidth = 2;
            this.aGauge8.Cap_Idx = ((byte)(1));
            this.aGauge8.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge8.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge8.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge8.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge8.CapText = "";
            this.aGauge8.Center = new System.Drawing.Point(70, 70);
            this.aGauge8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge8.Location = new System.Drawing.Point(509, 167);
            this.aGauge8.MaxValue = 50F;
            this.aGauge8.MinValue = 0F;
            this.aGauge8.Name = "aGauge8";
            this.aGauge8.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Blue;
            this.aGauge8.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aGauge8.NeedleRadius = 40;
            this.aGauge8.NeedleType = 0;
            this.aGauge8.NeedleWidth = 3;
            this.aGauge8.Range_Idx = ((byte)(0));
            this.aGauge8.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge8.RangeEnabled = false;
            this.aGauge8.RangeEndValue = 300F;
            this.aGauge8.RangeInnerRadius = 70;
            this.aGauge8.RangeOuterRadius = 80;
            this.aGauge8.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge8.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge8.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge8.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge8.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge8.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge8.RangeStartValue = -100F;
            this.aGauge8.ScaleLinesInterColor = System.Drawing.Color.RosyBrown;
            this.aGauge8.ScaleLinesInterInnerRadius = 42;
            this.aGauge8.ScaleLinesInterOuterRadius = 50;
            this.aGauge8.ScaleLinesInterWidth = 1;
            this.aGauge8.ScaleLinesMajorColor = System.Drawing.Color.RoyalBlue;
            this.aGauge8.ScaleLinesMajorInnerRadius = 40;
            this.aGauge8.ScaleLinesMajorOuterRadius = 50;
            this.aGauge8.ScaleLinesMajorStepValue = 10F;
            this.aGauge8.ScaleLinesMajorWidth = 2;
            this.aGauge8.ScaleLinesMinorColor = System.Drawing.Color.DarkSalmon;
            this.aGauge8.ScaleLinesMinorInnerRadius = 43;
            this.aGauge8.ScaleLinesMinorNumOf = 1;
            this.aGauge8.ScaleLinesMinorOuterRadius = 50;
            this.aGauge8.ScaleLinesMinorWidth = 1;
            this.aGauge8.ScaleNumbersColor = System.Drawing.Color.RoyalBlue;
            this.aGauge8.ScaleNumbersFormat = null;
            this.aGauge8.ScaleNumbersRadius = 62;
            this.aGauge8.ScaleNumbersRotation = 90;
            this.aGauge8.ScaleNumbersStartScaleLine = 1;
            this.aGauge8.ScaleNumbersStepScaleLines = 2;
            this.aGauge8.Size = new System.Drawing.Size(84, 85);
            this.aGauge8.TabIndex = 16;
            this.aGauge8.Text = "aGauge8";
            this.aGauge8.Value = 22F;
            // 
            // aGauge11
            // 
            this.aGauge11.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge11.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge11.BaseArcRadius = 40;
            this.aGauge11.BaseArcStart = -90;
            this.aGauge11.BaseArcSweep = 360;
            this.aGauge11.BaseArcWidth = 2;
            this.aGauge11.Cap_Idx = ((byte)(1));
            this.aGauge11.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge11.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge11.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge11.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge11.CapText = "";
            this.aGauge11.Center = new System.Drawing.Point(70, 70);
            this.aGauge11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge11.Location = new System.Drawing.Point(57, 17);
            this.aGauge11.MaxValue = 10F;
            this.aGauge11.MinValue = 0F;
            this.aGauge11.Name = "aGauge11";
            this.aGauge11.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge11.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge11.NeedleRadius = 40;
            this.aGauge11.NeedleType = 0;
            this.aGauge11.NeedleWidth = 10;
            this.aGauge11.Range_Idx = ((byte)(0));
            this.aGauge11.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge11.RangeEnabled = false;
            this.aGauge11.RangeEndValue = 300F;
            this.aGauge11.RangeInnerRadius = 70;
            this.aGauge11.RangeOuterRadius = 80;
            this.aGauge11.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge11.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge11.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge11.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge11.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge11.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge11.RangeStartValue = -100F;
            this.aGauge11.ScaleLinesInterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesInterInnerRadius = 42;
            this.aGauge11.ScaleLinesInterOuterRadius = 50;
            this.aGauge11.ScaleLinesInterWidth = 1;
            this.aGauge11.ScaleLinesMajorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesMajorInnerRadius = 40;
            this.aGauge11.ScaleLinesMajorOuterRadius = 50;
            this.aGauge11.ScaleLinesMajorStepValue = 1F;
            this.aGauge11.ScaleLinesMajorWidth = 2;
            this.aGauge11.ScaleLinesMinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesMinorInnerRadius = 43;
            this.aGauge11.ScaleLinesMinorNumOf = 1;
            this.aGauge11.ScaleLinesMinorOuterRadius = 50;
            this.aGauge11.ScaleLinesMinorWidth = 1;
            this.aGauge11.ScaleNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleNumbersFormat = null;
            this.aGauge11.ScaleNumbersRadius = 62;
            this.aGauge11.ScaleNumbersRotation = 0;
            this.aGauge11.ScaleNumbersStartScaleLine = 2;
            this.aGauge11.ScaleNumbersStepScaleLines = 2;
            this.aGauge11.Size = new System.Drawing.Size(149, 148);
            this.aGauge11.TabIndex = 15;
            this.aGauge11.Text = "aGauge11";
            this.aGauge11.Value = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.Color.Black;
            this.aGauge2.BaseArcColor = System.Drawing.Color.DarkRed;
            this.aGauge2.BaseArcRadius = 130;
            this.aGauge2.BaseArcStart = 170;
            this.aGauge2.BaseArcSweep = 200;
            this.aGauge2.BaseArcWidth = 3;
            this.aGauge2.Cap_Idx = ((byte)(2));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(105, 200);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(142, 100),
        new System.Drawing.Point(105, 200),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "Speed",
        "        [Km/h]",
        "",
        ""};
            this.aGauge2.CapText = "        [Km/h]";
            this.aGauge2.Center = new System.Drawing.Point(170, 170);
            this.aGauge2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge2.Location = new System.Drawing.Point(63, 12);
            this.aGauge2.MaxValue = 400F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge2.NeedleRadius = 150;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 5;
            this.aGauge2.Range_Idx = ((byte)(4));
            this.aGauge2.RangeColor = System.Drawing.Color.DarkRed;
            this.aGauge2.RangeEnabled = false;
            this.aGauge2.RangeEndValue = 500F;
            this.aGauge2.RangeInnerRadius = 10;
            this.aGauge2.RangeOuterRadius = 30;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.Color.DarkRed};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        100F,
        100F,
        400F,
        0F,
        500F};
            this.aGauge2.RangesInnerRadius = new int[] {
        100,
        20,
        100,
        70,
        10};
            this.aGauge2.RangesOuterRadius = new int[] {
        130,
        20,
        130,
        80,
        30};
            this.aGauge2.RangesStartValue = new float[] {
        -100F,
        1F,
        290F,
        0F,
        20F};
            this.aGauge2.RangeStartValue = 20F;
            this.aGauge2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge2.ScaleLinesInterInnerRadius = 130;
            this.aGauge2.ScaleLinesInterOuterRadius = 140;
            this.aGauge2.ScaleLinesInterWidth = 2;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge2.ScaleLinesMajorInnerRadius = 130;
            this.aGauge2.ScaleLinesMajorOuterRadius = 145;
            this.aGauge2.ScaleLinesMajorStepValue = 50F;
            this.aGauge2.ScaleLinesMajorWidth = 1;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 130;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 140;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.DarkRed;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 160;
            this.aGauge2.ScaleNumbersRotation = 2;
            this.aGauge2.ScaleNumbersStartScaleLine = 1;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(360, 227);
            this.aGauge2.TabIndex = 3;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            this.aGauge2.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGauge2_ValueInRangeChanged);
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aGauge1.BaseArcColor = System.Drawing.Color.DarkRed;
            this.aGauge1.BaseArcRadius = 70;
            this.aGauge1.BaseArcStart = 160;
            this.aGauge1.BaseArcSweep = 210;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(2));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "";
            this.aGauge1.Center = new System.Drawing.Point(100, 105);
            this.aGauge1.Location = new System.Drawing.Point(818, 71);
            this.aGauge1.MaxValue = 8000F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 3;
            this.aGauge1.Range_Idx = ((byte)(1));
            this.aGauge1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 8000F;
            this.aGauge1.RangeInnerRadius = 50;
            this.aGauge1.RangeOuterRadius = 10;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        300F,
        8000F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        50,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        75,
        10,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        -100F,
        0F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 0F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge1.ScaleLinesInterInnerRadius = 76;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 2000F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 76;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.DarkRed;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 90;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 4;
            this.aGauge1.Size = new System.Drawing.Size(215, 150);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // aGauge4
            // 
            this.aGauge4.BackColor = System.Drawing.Color.Black;
            this.aGauge4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aGauge4.BaseArcColor = System.Drawing.Color.DarkRed;
            this.aGauge4.BaseArcRadius = 150;
            this.aGauge4.BaseArcStart = 190;
            this.aGauge4.BaseArcSweep = 150;
            this.aGauge4.BaseArcWidth = 1;
            this.aGauge4.Cap_Idx = ((byte)(1));
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "";
            this.aGauge4.Center = new System.Drawing.Point(190, 180);
            this.aGauge4.Location = new System.Drawing.Point(12, 12);
            this.aGauge4.MaxValue = 400F;
            this.aGauge4.MinValue = 0F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.DarkRed;
            this.aGauge4.NeedleRadius = 150;
            this.aGauge4.NeedleType = 0;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.Range_Idx = ((byte)(1));
            this.aGauge4.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge4.RangeEnabled = false;
            this.aGauge4.RangeEndValue = 400F;
            this.aGauge4.RangeInnerRadius = 10;
            this.aGauge4.RangeOuterRadius = 40;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        -100F,
        0F,
        0F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = 0F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge4.ScaleLinesInterInnerRadius = 145;
            this.aGauge4.ScaleLinesInterOuterRadius = 150;
            this.aGauge4.ScaleLinesInterWidth = 2;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge4.ScaleLinesMajorInnerRadius = 140;
            this.aGauge4.ScaleLinesMajorOuterRadius = 150;
            this.aGauge4.ScaleLinesMajorStepValue = 50F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGauge4.ScaleLinesMinorInnerRadius = 145;
            this.aGauge4.ScaleLinesMinorNumOf = 9;
            this.aGauge4.ScaleLinesMinorOuterRadius = 150;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.DarkRed;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 162;
            this.aGauge4.ScaleNumbersRotation = 90;
            this.aGauge4.ScaleNumbersStartScaleLine = 1;
            this.aGauge4.ScaleNumbersStepScaleLines = 2;
            this.aGauge4.Size = new System.Drawing.Size(373, 209);
            this.aGauge4.TabIndex = 7;
            this.aGauge4.Text = "aGauge4";
            this.aGauge4.Value = 0F;
            this.aGauge4.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGauge4_ValueInRangeChanged);
            // 
            // aGauge10
            // 
            this.aGauge10.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge10.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge10.BaseArcRadius = 40;
            this.aGauge10.BaseArcStart = 0;
            this.aGauge10.BaseArcSweep = -90;
            this.aGauge10.BaseArcWidth = 2;
            this.aGauge10.Cap_Idx = ((byte)(1));
            this.aGauge10.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge10.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge10.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge10.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge10.CapText = "";
            this.aGauge10.Center = new System.Drawing.Point(15, 70);
            this.aGauge10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge10.Location = new System.Drawing.Point(695, 167);
            this.aGauge10.MaxValue = 100F;
            this.aGauge10.MinValue = 0F;
            this.aGauge10.Name = "aGauge10";
            this.aGauge10.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.aGauge10.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge10.NeedleRadius = 40;
            this.aGauge10.NeedleType = 0;
            this.aGauge10.NeedleWidth = 2;
            this.aGauge10.Range_Idx = ((byte)(0));
            this.aGauge10.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge10.RangeEnabled = false;
            this.aGauge10.RangeEndValue = 300F;
            this.aGauge10.RangeInnerRadius = 70;
            this.aGauge10.RangeOuterRadius = 80;
            this.aGauge10.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge10.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge10.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge10.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge10.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge10.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge10.RangeStartValue = -100F;
            this.aGauge10.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge10.ScaleLinesInterInnerRadius = 45;
            this.aGauge10.ScaleLinesInterOuterRadius = 50;
            this.aGauge10.ScaleLinesInterWidth = 2;
            this.aGauge10.ScaleLinesMajorColor = System.Drawing.Color.SaddleBrown;
            this.aGauge10.ScaleLinesMajorInnerRadius = 40;
            this.aGauge10.ScaleLinesMajorOuterRadius = 50;
            this.aGauge10.ScaleLinesMajorStepValue = 50F;
            this.aGauge10.ScaleLinesMajorWidth = 2;
            this.aGauge10.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGauge10.ScaleLinesMinorInnerRadius = 45;
            this.aGauge10.ScaleLinesMinorNumOf = 9;
            this.aGauge10.ScaleLinesMinorOuterRadius = 50;
            this.aGauge10.ScaleLinesMinorWidth = 2;
            this.aGauge10.ScaleNumbersColor = System.Drawing.Color.Maroon;
            this.aGauge10.ScaleNumbersFormat = null;
            this.aGauge10.ScaleNumbersRadius = 62;
            this.aGauge10.ScaleNumbersRotation = 90;
            this.aGauge10.ScaleNumbersStartScaleLine = 1;
            this.aGauge10.ScaleNumbersStepScaleLines = 2;
            this.aGauge10.Size = new System.Drawing.Size(85, 93);
            this.aGauge10.TabIndex = 14;
            this.aGauge10.Text = "aGauge10";
            this.aGauge10.Value = 0F;
            // 
            // aGauge9
            // 
            this.aGauge9.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge9.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge9.BaseArcRadius = 40;
            this.aGauge9.BaseArcStart = 180;
            this.aGauge9.BaseArcSweep = 90;
            this.aGauge9.BaseArcWidth = 2;
            this.aGauge9.Cap_Idx = ((byte)(1));
            this.aGauge9.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge9.CapPosition = new System.Drawing.Point(20, 75);
            this.aGauge9.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 75),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge9.CapsText = new string[] {
        "",
        "% Fuel",
        "",
        "",
        ""};
            this.aGauge9.CapText = "% Fuel";
            this.aGauge9.Center = new System.Drawing.Point(70, 70);
            this.aGauge9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge9.Location = new System.Drawing.Point(611, 167);
            this.aGauge9.MaxValue = 100F;
            this.aGauge9.MinValue = 0F;
            this.aGauge9.Name = "aGauge9";
            this.aGauge9.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge9.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge9.NeedleRadius = 40;
            this.aGauge9.NeedleType = 0;
            this.aGauge9.NeedleWidth = 2;
            this.aGauge9.Range_Idx = ((byte)(0));
            this.aGauge9.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge9.RangeEnabled = false;
            this.aGauge9.RangeEndValue = 300F;
            this.aGauge9.RangeInnerRadius = 70;
            this.aGauge9.RangeOuterRadius = 80;
            this.aGauge9.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge9.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge9.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge9.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge9.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge9.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge9.RangeStartValue = -100F;
            this.aGauge9.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge9.ScaleLinesInterInnerRadius = 42;
            this.aGauge9.ScaleLinesInterOuterRadius = 50;
            this.aGauge9.ScaleLinesInterWidth = 2;
            this.aGauge9.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge9.ScaleLinesMajorInnerRadius = 40;
            this.aGauge9.ScaleLinesMajorOuterRadius = 50;
            this.aGauge9.ScaleLinesMajorStepValue = 50F;
            this.aGauge9.ScaleLinesMajorWidth = 2;
            this.aGauge9.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge9.ScaleLinesMinorInnerRadius = 43;
            this.aGauge9.ScaleLinesMinorNumOf = 9;
            this.aGauge9.ScaleLinesMinorOuterRadius = 50;
            this.aGauge9.ScaleLinesMinorWidth = 2;
            this.aGauge9.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge9.ScaleNumbersFormat = null;
            this.aGauge9.ScaleNumbersRadius = 62;
            this.aGauge9.ScaleNumbersRotation = 90;
            this.aGauge9.ScaleNumbersStartScaleLine = 1;
            this.aGauge9.ScaleNumbersStepScaleLines = 2;
            this.aGauge9.Size = new System.Drawing.Size(91, 108);
            this.aGauge9.TabIndex = 13;
            this.aGauge9.Text = "aGauge9";
            this.aGauge9.Value = 0F;
            // 
            // aGauge12
            // 
            this.aGauge12.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge12.BaseArcRadius = 40;
            this.aGauge12.BaseArcStart = 180;
            this.aGauge12.BaseArcSweep = 330;
            this.aGauge12.BaseArcWidth = 2;
            this.aGauge12.Cap_Idx = ((byte)(1));
            this.aGauge12.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge12.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge12.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge12.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge12.CapText = "";
            this.aGauge12.Center = new System.Drawing.Point(70, 70);
            this.aGauge12.Location = new System.Drawing.Point(611, 266);
            this.aGauge12.MaxValue = 100F;
            this.aGauge12.MinValue = 0F;
            this.aGauge12.Name = "aGauge12";
            this.aGauge12.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge12.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge12.NeedleRadius = 45;
            this.aGauge12.NeedleType = 0;
            this.aGauge12.NeedleWidth = 3;
            this.aGauge12.Range_Idx = ((byte)(1));
            this.aGauge12.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge12.RangeEnabled = false;
            this.aGauge12.RangeEndValue = 400F;
            this.aGauge12.RangeInnerRadius = 10;
            this.aGauge12.RangeOuterRadius = 40;
            this.aGauge12.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge12.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge12.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge12.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge12.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge12.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge12.RangeStartValue = 300F;
            this.aGauge12.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge12.ScaleLinesInterInnerRadius = 42;
            this.aGauge12.ScaleLinesInterOuterRadius = 50;
            this.aGauge12.ScaleLinesInterWidth = 1;
            this.aGauge12.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge12.ScaleLinesMajorInnerRadius = 40;
            this.aGauge12.ScaleLinesMajorOuterRadius = 50;
            this.aGauge12.ScaleLinesMajorStepValue = 10F;
            this.aGauge12.ScaleLinesMajorWidth = 2;
            this.aGauge12.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge12.ScaleLinesMinorInnerRadius = 43;
            this.aGauge12.ScaleLinesMinorNumOf = 1;
            this.aGauge12.ScaleLinesMinorOuterRadius = 50;
            this.aGauge12.ScaleLinesMinorWidth = 1;
            this.aGauge12.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge12.ScaleNumbersFormat = null;
            this.aGauge12.ScaleNumbersRadius = 62;
            this.aGauge12.ScaleNumbersRotation = 0;
            this.aGauge12.ScaleNumbersStartScaleLine = 1;
            this.aGauge12.ScaleNumbersStepScaleLines = 2;
            this.aGauge12.Size = new System.Drawing.Size(150, 142);
            this.aGauge12.TabIndex = 18;
            this.aGauge12.Text = "aGauge12";
            this.aGauge12.Value = 0F;
            // 
            // aGauge5
            // 
            this.aGauge5.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge5.BaseArcRadius = 40;
            this.aGauge5.BaseArcStart = 0;
            this.aGauge5.BaseArcSweep = -90;
            this.aGauge5.BaseArcWidth = 2;
            this.aGauge5.Cap_Idx = ((byte)(1));
            this.aGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge5.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge5.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge5.CapText = "";
            this.aGauge5.Center = new System.Drawing.Point(30, 70);
            this.aGauge5.Location = new System.Drawing.Point(695, 411);
            this.aGauge5.MaxValue = 50F;
            this.aGauge5.MinValue = 0F;
            this.aGauge5.Name = "aGauge5";
            this.aGauge5.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Violet;
            this.aGauge5.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge5.NeedleRadius = 40;
            this.aGauge5.NeedleType = 0;
            this.aGauge5.NeedleWidth = 4;
            this.aGauge5.Range_Idx = ((byte)(1));
            this.aGauge5.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge5.RangeEnabled = false;
            this.aGauge5.RangeEndValue = 400F;
            this.aGauge5.RangeInnerRadius = 10;
            this.aGauge5.RangeOuterRadius = 40;
            this.aGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge5.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge5.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge5.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge5.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge5.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge5.RangeStartValue = 300F;
            this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesInterInnerRadius = 42;
            this.aGauge5.ScaleLinesInterOuterRadius = 50;
            this.aGauge5.ScaleLinesInterWidth = 1;
            this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesMajorInnerRadius = 40;
            this.aGauge5.ScaleLinesMajorOuterRadius = 50;
            this.aGauge5.ScaleLinesMajorStepValue = 10F;
            this.aGauge5.ScaleLinesMajorWidth = 2;
            this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge5.ScaleLinesMinorInnerRadius = 43;
            this.aGauge5.ScaleLinesMinorNumOf = 1;
            this.aGauge5.ScaleLinesMinorOuterRadius = 50;
            this.aGauge5.ScaleLinesMinorWidth = 1;
            this.aGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleNumbersFormat = null;
            this.aGauge5.ScaleNumbersRadius = 62;
            this.aGauge5.ScaleNumbersRotation = 90;
            this.aGauge5.ScaleNumbersStartScaleLine = 1;
            this.aGauge5.ScaleNumbersStepScaleLines = 2;
            this.aGauge5.Size = new System.Drawing.Size(106, 95);
            this.aGauge5.TabIndex = 8;
            this.aGauge5.Text = "aGauge5";
            this.aGauge5.Value = 0F;
            // 
            // aGauge7
            // 
            this.aGauge7.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge7.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge7.BaseArcRadius = 40;
            this.aGauge7.BaseArcStart = 180;
            this.aGauge7.BaseArcSweep = 180;
            this.aGauge7.BaseArcWidth = 2;
            this.aGauge7.Cap_Idx = ((byte)(1));
            this.aGauge7.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge7.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge7.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge7.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge7.CapText = "";
            this.aGauge7.Center = new System.Drawing.Point(70, 70);
            this.aGauge7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge7.Location = new System.Drawing.Point(547, 411);
            this.aGauge7.MaxValue = 50F;
            this.aGauge7.MinValue = 0F;
            this.aGauge7.Name = "aGauge7";
            this.aGauge7.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge7.NeedleColor2 = System.Drawing.Color.GreenYellow;
            this.aGauge7.NeedleRadius = 40;
            this.aGauge7.NeedleType = 0;
            this.aGauge7.NeedleWidth = 2;
            this.aGauge7.Range_Idx = ((byte)(0));
            this.aGauge7.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge7.RangeEnabled = false;
            this.aGauge7.RangeEndValue = 300F;
            this.aGauge7.RangeInnerRadius = 70;
            this.aGauge7.RangeOuterRadius = 80;
            this.aGauge7.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge7.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge7.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge7.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge7.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge7.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge7.RangeStartValue = -100F;
            this.aGauge7.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge7.ScaleLinesInterInnerRadius = 42;
            this.aGauge7.ScaleLinesInterOuterRadius = 50;
            this.aGauge7.ScaleLinesInterWidth = 1;
            this.aGauge7.ScaleLinesMajorColor = System.Drawing.Color.Red;
            this.aGauge7.ScaleLinesMajorInnerRadius = 40;
            this.aGauge7.ScaleLinesMajorOuterRadius = 50;
            this.aGauge7.ScaleLinesMajorStepValue = 10F;
            this.aGauge7.ScaleLinesMajorWidth = 2;
            this.aGauge7.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGauge7.ScaleLinesMinorInnerRadius = 43;
            this.aGauge7.ScaleLinesMinorNumOf = 1;
            this.aGauge7.ScaleLinesMinorOuterRadius = 50;
            this.aGauge7.ScaleLinesMinorWidth = 1;
            this.aGauge7.ScaleNumbersColor = System.Drawing.Color.Red;
            this.aGauge7.ScaleNumbersFormat = null;
            this.aGauge7.ScaleNumbersRadius = 62;
            this.aGauge7.ScaleNumbersRotation = 90;
            this.aGauge7.ScaleNumbersStartScaleLine = 1;
            this.aGauge7.ScaleNumbersStepScaleLines = 2;
            this.aGauge7.Size = new System.Drawing.Size(142, 85);
            this.aGauge7.TabIndex = 11;
            this.aGauge7.Text = "aGauge7";
            this.aGauge7.Value = 0F;
            // 
            // aGauge3
            // 
            this.aGauge3.BackColor = System.Drawing.Color.Black;
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 40;
            this.aGauge3.BaseArcStart = 180;
            this.aGauge3.BaseArcSweep = 90;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Cap_Idx = ((byte)(1));
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "";
            this.aGauge3.Center = new System.Drawing.Point(70, 70);
            this.aGauge3.Location = new System.Drawing.Point(120, 16);
            this.aGauge3.MaxValue = 10F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.White;
            this.aGauge3.NeedleRadius = 30;
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 3;
            this.aGauge3.Range_Idx = ((byte)(1));
            this.aGauge3.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge3.RangeEnabled = false;
            this.aGauge3.RangeEndValue = 400F;
            this.aGauge3.RangeInnerRadius = 20;
            this.aGauge3.RangeOuterRadius = 30;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        70,
        20,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        80,
        30,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 300F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge3.ScaleLinesInterInnerRadius = 42;
            this.aGauge3.ScaleLinesInterOuterRadius = 50;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge3.ScaleLinesMajorInnerRadius = 40;
            this.aGauge3.ScaleLinesMajorOuterRadius = 50;
            this.aGauge3.ScaleLinesMajorStepValue = 2F;
            this.aGauge3.ScaleLinesMajorWidth = 3;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGauge3.ScaleLinesMinorInnerRadius = 43;
            this.aGauge3.ScaleLinesMinorNumOf = 1;
            this.aGauge3.ScaleLinesMinorOuterRadius = 50;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.DarkRed;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 62;
            this.aGauge3.ScaleNumbersRotation = 90;
            this.aGauge3.ScaleNumbersStartScaleLine = 1;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(120, 108);
            this.aGauge3.TabIndex = 6;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 6F;
            // 
            // aGauge6
            // 
            this.aGauge6.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge6.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge6.BaseArcRadius = 500;
            this.aGauge6.BaseArcStart = 180;
            this.aGauge6.BaseArcSweep = 90;
            this.aGauge6.BaseArcWidth = 0;
            this.aGauge6.Cap_Idx = ((byte)(1));
            this.aGauge6.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge6.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge6.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge6.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge6.CapText = "";
            this.aGauge6.Center = new System.Drawing.Point(70, 70);
            this.aGauge6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge6.Location = new System.Drawing.Point(82, 266);
            this.aGauge6.MaxValue = 50F;
            this.aGauge6.MinValue = 0F;
            this.aGauge6.Name = "aGauge6";
            this.aGauge6.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Blue;
            this.aGauge6.NeedleColor2 = System.Drawing.Color.RoyalBlue;
            this.aGauge6.NeedleRadius = 48;
            this.aGauge6.NeedleType = 1;
            this.aGauge6.NeedleWidth = 3;
            this.aGauge6.Range_Idx = ((byte)(0));
            this.aGauge6.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge6.RangeEnabled = false;
            this.aGauge6.RangeEndValue = 300F;
            this.aGauge6.RangeInnerRadius = 70;
            this.aGauge6.RangeOuterRadius = 80;
            this.aGauge6.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge6.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge6.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge6.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge6.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge6.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge6.RangeStartValue = -100F;
            this.aGauge6.ScaleLinesInterColor = System.Drawing.Color.RosyBrown;
            this.aGauge6.ScaleLinesInterInnerRadius = 42;
            this.aGauge6.ScaleLinesInterOuterRadius = 55;
            this.aGauge6.ScaleLinesInterWidth = 1;
            this.aGauge6.ScaleLinesMajorColor = System.Drawing.Color.Gray;
            this.aGauge6.ScaleLinesMajorInnerRadius = 40;
            this.aGauge6.ScaleLinesMajorOuterRadius = 55;
            this.aGauge6.ScaleLinesMajorStepValue = 10F;
            this.aGauge6.ScaleLinesMajorWidth = 2;
            this.aGauge6.ScaleLinesMinorColor = System.Drawing.Color.DarkSalmon;
            this.aGauge6.ScaleLinesMinorInnerRadius = 43;
            this.aGauge6.ScaleLinesMinorNumOf = 1;
            this.aGauge6.ScaleLinesMinorOuterRadius = 50;
            this.aGauge6.ScaleLinesMinorWidth = 1;
            this.aGauge6.ScaleNumbersColor = System.Drawing.Color.RoyalBlue;
            this.aGauge6.ScaleNumbersFormat = null;
            this.aGauge6.ScaleNumbersRadius = 62;
            this.aGauge6.ScaleNumbersRotation = 90;
            this.aGauge6.ScaleNumbersStartScaleLine = 1;
            this.aGauge6.ScaleNumbersStepScaleLines = 2;
            this.aGauge6.Size = new System.Drawing.Size(84, 85);
            this.aGauge6.TabIndex = 12;
            this.aGauge6.Text = "aGauge6";
            this.aGauge6.Value = 22F;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(882, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "[1/min x 1000]";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(737, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 69);
            this.listBox1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(391, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 288);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(164, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 33);
            this.label11.TabIndex = 6;
            this.label11.Text = "0 [km/h]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AGaugeApp.Properties.Resources.Tesla;
            this.pictureBox3.Location = new System.Drawing.Point(134, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(187, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Clock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(138, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(187, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Battery %";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 206);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.aGauge13);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.aGauge3);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1021, 255);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Oil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "rpm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "x1000";
            // 
            // aGauge13
            // 
            this.aGauge13.BackColor = System.Drawing.Color.Black;
            this.aGauge13.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge13.BaseArcRadius = 40;
            this.aGauge13.BaseArcStart = 180;
            this.aGauge13.BaseArcSweep = 90;
            this.aGauge13.BaseArcWidth = 2;
            this.aGauge13.Cap_Idx = ((byte)(1));
            this.aGauge13.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge13.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge13.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge13.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge13.CapText = "";
            this.aGauge13.Center = new System.Drawing.Point(70, 70);
            this.aGauge13.Location = new System.Drawing.Point(253, 19);
            this.aGauge13.MaxValue = 1F;
            this.aGauge13.MinValue = 0F;
            this.aGauge13.Name = "aGauge13";
            this.aGauge13.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge13.NeedleColor2 = System.Drawing.Color.White;
            this.aGauge13.NeedleRadius = 30;
            this.aGauge13.NeedleType = 0;
            this.aGauge13.NeedleWidth = 3;
            this.aGauge13.Range_Idx = ((byte)(1));
            this.aGauge13.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge13.RangeEnabled = false;
            this.aGauge13.RangeEndValue = 400F;
            this.aGauge13.RangeInnerRadius = 20;
            this.aGauge13.RangeOuterRadius = 30;
            this.aGauge13.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge13.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge13.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge13.RangesInnerRadius = new int[] {
        70,
        20,
        70,
        70,
        70};
            this.aGauge13.RangesOuterRadius = new int[] {
        80,
        30,
        80,
        80,
        80};
            this.aGauge13.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge13.RangeStartValue = 300F;
            this.aGauge13.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge13.ScaleLinesInterInnerRadius = 42;
            this.aGauge13.ScaleLinesInterOuterRadius = 50;
            this.aGauge13.ScaleLinesInterWidth = 1;
            this.aGauge13.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge13.ScaleLinesMajorInnerRadius = 40;
            this.aGauge13.ScaleLinesMajorOuterRadius = 50;
            this.aGauge13.ScaleLinesMajorStepValue = 0.5F;
            this.aGauge13.ScaleLinesMajorWidth = 3;
            this.aGauge13.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGauge13.ScaleLinesMinorInnerRadius = 43;
            this.aGauge13.ScaleLinesMinorNumOf = 1;
            this.aGauge13.ScaleLinesMinorOuterRadius = 50;
            this.aGauge13.ScaleLinesMinorWidth = 1;
            this.aGauge13.ScaleNumbersColor = System.Drawing.Color.DarkRed;
            this.aGauge13.ScaleNumbersFormat = null;
            this.aGauge13.ScaleNumbersRadius = 62;
            this.aGauge13.ScaleNumbersRotation = 90;
            this.aGauge13.ScaleNumbersStartScaleLine = 1;
            this.aGauge13.ScaleNumbersStepScaleLines = 1;
            this.aGauge13.Size = new System.Drawing.Size(120, 108);
            this.aGauge13.TabIndex = 24;
            this.aGauge13.Text = "aGauge13";
            this.aGauge13.Value = 0F;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(409, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 71);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AGaugeApp.Properties.Resources.oil;
            this.pictureBox6.Location = new System.Drawing.Point(221, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(84, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AGaugeApp.Properties.Resources.engine;
            this.pictureBox5.Location = new System.Drawing.Point(140, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(74, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AGaugeApp.Properties.Resources.buttery;
            this.pictureBox4.Location = new System.Drawing.Point(67, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AGaugeApp.Properties.Resources.abs;
            this.pictureBox2.Location = new System.Drawing.Point(7, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Speed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(127, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Speed [Km/h]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(331, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "ENGINE STATUS:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(509, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 24);
            this.label13.TabIndex = 29;
            this.label13.Text = "STOP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1045, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.aGauge4);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Location = new System.Drawing.Point(10, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AGauge Test Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private AGauge aGauge2;
        private System.Windows.Forms.Timer timer1;
        private AGauge aGauge4;
        private System.Windows.Forms.Button button1;
        private AGauge aGauge11;
        private AGauge aGauge8;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label1;
        private AGauge aGauge5;
        private AGauge aGauge3;
        private AGauge aGauge12;
        private AGauge aGauge7;
        private AGauge aGauge10;
        private AGauge aGauge9;
        private AGauge aGauge6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private AGauge aGauge13;
        public AGauge aGauge1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}


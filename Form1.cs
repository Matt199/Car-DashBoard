using System;
using System.Drawing;
using System.Windows.Forms;

using System.Speech.Recognition;
using System.Speech.Synthesis;




// Speech reacognition


namespace AGaugeApp
{

    

    // Declare delegate to store trackbar values 
    public delegate void delegateValue(TrackBar valueChanged);

    

    public partial class Form1 : Form
    {

        private bool engineStart = false;

        private string engineText = "STOP";

        Timer t = new Timer();
        Random rnd = new Random();


        Form2 form2 = new Form2();
        public Form2 Form2
        {
            get { return form2; }
        }
        public Form1()
        {
            InitializeComponent();
            


        }

        
        private void aGauge1_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
            if (e.valueInRange == 0)
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void aGauge2_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
            if (e.valueInRange == 1)
            {
                label1.Text="WARNING";
            }
            else if (e.valueInRange==2)
            {
                label1.Text="SLOW DOWN";
            }
            else
            {
                label1.Text = "";
            }
        }

        



        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            

            aGauge1.Value = trackBar1.Value;
            aGauge2.Value = trackBar1.Value;

            if (engineStart)
            {
                label11.Text = trackBar1.Value.ToString() + " [km/h]";
            }
            else if (!engineStart)
            {
                label11.Text ="0 [km/h]";
            }

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
           aGauge4.Value = (float)(Form2.valBar);
           progressBar1.Value = (int) Form2.batteryCapacity; //batteryCapacity * valBar * 0.0001
           aGauge1.Value = (float)(Form2.momentum);
           //aGauge3.Value = 6F;
            aGauge13.Value = 0.5F;

            
               


            if (aGauge3.Value >= 10000)
            {
                aGauge3.Value = 0;
            }

            if (aGauge4.Value >= 400)
            {
                aGauge4.Value = 400;
            }

            

            aGauge5.Value = aGauge3.Value;
            aGauge6.Value = (Single)(((Int32)aGauge6.Value + 49) % 50);
            aGauge7.Value = (Single)(((Int32)aGauge7.Value + 49) % 50);
            aGauge8.Value = (Single)(((Int32)aGauge8.Value + 51) % 50);
            aGauge11.Value = (Single)(((Int32)aGauge11.Value + 9) % 10);
            aGauge9.Value = (Single)(((Int32)aGauge9.Value + 99) % 100);
            aGauge10.Value = (Single)(((Int32)aGauge10.Value + 99) % 100);
            aGauge12.Value = (Single)(((Int32)aGauge12.Value + 99) % 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (aGauge1.NeedleType == 0)
            {
                aGauge1.NeedleType = 1;
            }
            else
            {
                aGauge1.NeedleType = 0;
            }

            if (aGauge2.NeedleType == 0)
            {
                aGauge2.NeedleType = 1;
            }
            else
            {
                aGauge2.NeedleType = 0;
            }

            if (aGauge3.NeedleType == 0)
            {
                aGauge3.NeedleType = 1;
            }
            else
            {
                aGauge3.NeedleType = 0;
            }

            if (aGauge4.NeedleType == 0)
            {
                aGauge4.NeedleType = 1;
            }
            else
            {
                aGauge4.NeedleType = 0;
            }

            if (aGauge5.NeedleType == 0)
            {
                aGauge5.NeedleType = 1;
            }
            else
            {
                aGauge5.NeedleType = 0;
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Form2 app = new Form2();

            if (engineStart)
            {

                delegateValue delegat = new delegateValue(form2.changeData);
                delegat(this.trackBar1);
            }
            else if (!engineStart) {

                //

            }
            
            
        }

        private void aGauge4_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
            //aGauge4.ValueInRangeChanged += (float)Form2.batteryCapacity;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            RecognizeSpeech();
            // Time interval 
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer_tick);
            t.Start();

            

        }


        // Speach Recognition 

        static SpeechRecognitionEngine _recognizer = null;
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        void RecognizeSpeech()
        {
            _recognizer = new SpeechRecognitionEngine();
            _recognizer.LoadGrammar(new DictationGrammar());
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("activate")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("deactivate")));
            _recognizer.SpeechRecognized += _recognizeSpeech_SpeechRecognized;
            _recognizer.SpeechRecognitionRejected += _recognizeSpeech_SpeechRecognitionRejected;
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
        void _recognizeSpeech_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "start")
            {
                this.listBox1.Items.Add(">SpeechRecognitionEngine: ENGINE START!");
                speechSynthesizer.Speak("Engine Start");
                engineStart = true;
                engineText = "START";
                label13.Text = engineText;
            }
            else if (e.Result.Text == "stop")
            {

                if (trackBar1.Value == 0)
                {
                    this.listBox1.Items.Add(">SpeechRecognitionEngine: ENGINE STOP!");
                    speechSynthesizer.Speak("Deactivating Engine");
                    engineStart = false;
                    engineText = "STOP";
                    label13.Text = engineText;
                }
                else
                {
                    this.listBox1.Items.Add(">SpeechRecognitionEngine: YOU ARE STILL DRIVING!");
                    speechSynthesizer.Speak("You must stop the car to deactivate engine");
                }
            }
            else
            {
                this.listBox1.Items.Add(">SpeechRecognitionEngine: " + e.Result.Text);
            }
        }
        void _recognizeSpeech_SpeechRecognitionRejected(object sender,
        SpeechRecognitionRejectedEventArgs e)
        {
            this.listBox1.Items.Add(">SpeechRecognitionEngine: Unrecognized command...");
        }




        // Handler 

        private void timer_tick(object sender, EventArgs e) {

            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            int tourqe = rnd.Next(1, 7);
            double oil = rnd.NextDouble();
            aGauge3.Value = tourqe;
            aGauge13.Value = (float) oil;

            string time = "";


            if (hh < 10)
            {

                time += "0" + hh;

            }
            else {

                time += hh;
            }

            time += ":";

            if (mm < 10)
            {

                time += "0" + mm;
            }
            else {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {

                time += "0" + ss;
            }
            else {

                time += ss;
            }

            label5.Text = time;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.Red)
            {
                pictureBox2.BackColor = Color.White;
            }
            else {
                pictureBox2.BackColor = Color.Red;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.Red)
            {
                pictureBox4.BackColor = Color.White;
            }
            else
            {
                pictureBox4.BackColor = Color.Red;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackColor == Color.Red)
            {
                pictureBox5.BackColor = Color.White;
            }
            else
            {
                pictureBox5.BackColor = Color.Red;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.Red)
            {
                pictureBox6.BackColor = Color.White;
            }
            else
            {
                pictureBox6.BackColor = Color.Red;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
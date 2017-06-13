using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;

namespace AGaugeApp
{
    public partial class Form2 : Form
    {

        

        private Thread speedThread;
        private int[] speedArray = new int[100];
        private double[] batteryArray = new double[100];
        public double batteryCapacity = 100;
        public int valBar = 0;
        public int momentum;


        public Form2()
        {
            InitializeComponent();
            Console.WriteLine("Loading...");

            speedThread = new Thread(new ThreadStart(this.getSpeedCount));
            speedThread.IsBackground = true;
            speedThread.Start();


        }


        private void getSpeedCount()
        {

        

            while (true) {

                speedArray[speedArray.Length - 1] = valBar;
                Array.Copy(speedArray, 1, speedArray, 0, speedArray.Length - 1);

                batteryArray[batteryArray.Length - 1] = batteryCapacity;
                Array.Copy(batteryArray, 1, batteryArray, 0, batteryArray.Length - 1);

                batteryCapacity -= batteryCapacity * valBar * 0.0001;


                

                momentum = valBar * 25;

                if (chart1.IsHandleCreated)
                {

                    this.Invoke((MethodInvoker)delegate { updateChart(); });
                }
                else
                {

                    //...

                }

                

                Thread.Sleep(100);
            }

        }

    

        private void updateChart()
        {

            chart1.Series["Speed"].Points.Clear();
            chart2.Series["Cappacity"].Points.Clear();

            


            for (int i = 0; i < speedArray.Length; i++)
            {

                chart1.Series["Speed"].Points.AddY(speedArray[i]);
                chart2.Series["Cappacity"].Points.AddY(batteryArray[i]);
            }

            if (batteryCapacity < 1.0)
            {
                const string message =
                    "You are out of buttery!!!";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    batteryCapacity = 100;
                    this.Close();

                    

                }

            }
        }


        public void changeData(TrackBar value) {


            label1.Text =  value.Value.ToString() + " Km/h";

            valBar = value.Value;

            

            
        }





    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;




namespace AGaugeApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form1 = new Form1();
            var form2 = new Form2();

            Application.Run(new MultiFormContext(form1.Form2, form1));

            
        }
    }

    public class MultiFormContext : ApplicationContext
    {
        private int openForms;
        public MultiFormContext(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
   
                form.Show();
            }
        }
    }
}
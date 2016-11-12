using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void Statistics(int[] array)
        {
            VictoryX.Text = Convert.ToString(array[0]);
            VictoryO.Text = Convert.ToString(array[1]);
            Draw.Text = Convert.ToString(array[2]);
            InputFile();
        }
        public void InputFile()
        {
            string VictoryXS = "Побед X: " + VictoryX.Text;
            File.AppendAllText(@"Log.txt", "Побед Х: " + VictoryX.Text + "\n");
            File.AppendAllText(@"Log.txt", "Побед O: " + VictoryO.Text + "\n");
            File.AppendAllText(@"Log.txt", "Ничья: " + Draw.Text + "\n");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

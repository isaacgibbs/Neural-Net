/*
    Isaac A. Gibbs
    3/25/2014
    Neural Net
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Net
{
    public partial class Form1 : Form
    {
        public static Globals globals;
        public Globals.onefunc oofunc;
        public Globals.twofunc tofunc;

        public Form1()
        {
            InitializeComponent();
            globals = new Globals();
            functionType.DataSource = globals.OtOFunctions;
            this.netType.SelectedIndex = 0;
            this.functionType.SelectedIndex = 0;
            initializeProgram();
        }

        public void initializeProgram()
        {
            globals = new Globals();
            double number = 0;
            if (double.TryParse(learningText.Text, out number))
            {
                globals.learnrate = number;
            }
            else
            {
                globals.learnrate = 0.01;
            }
            globals.annealchecked = annealingBox.Checked;
            globals.learnRateCount = globals.learnrate;
            globals.mediarynum = neuronSlider.Value;
            int number2 = 0;
            if (int.TryParse(neuronBox.Text, out number2))
            {
                globals.mediarynum = number2;
            }
            else
            {
                globals.mediarynum = 20;
            }
            if (double.TryParse(errorGoal.Text, out number))
            {
                globals.errorGoal = number;
            }
            else
            {
                globals.errorGoal = 0.01;
            }
            globals.noise = noiseSlider.Value;
            globals.xaxis = new Point[2] { new Point(0, pictureBox1.Height / 2), new Point(pictureBox1.Width, pictureBox1.Height / 2) };
            globals.yaxis = new Point[2] { new Point(pictureBox1.Width / 2, 0), new Point(pictureBox1.Width / 2, pictureBox1.Height) };
            globals.worldx = pictureBox1.Width;
            globals.worldy = pictureBox1.Height;

            functionType.ValueMember = "function";
            functionType.DisplayMember = "name";
            if (netType.SelectedIndex == 0)
            {
                //DataRowView test = functionType.SelectedItem as DataRowView;
                //String val = test.Row["function"] as string;
                String val = functionType.SelectedValue.ToString();
                if(val == "sinfunc")
                {
                    oofunc = globals.sinfunc;
                }
                if (val == "cosfunc")
                {
                    oofunc = globals.cosfunc;
                }
                globals.net = new OneOneNet(oofunc, globals.mediarynum, globals.learnrate, globals.ar);
                globals.net.createnet();
            }
            else
            {
                DataRowView test = functionType.SelectedItem as DataRowView;
                String val = test.Row["function"] as string;
                if (val == "conefunc")
                {
                    tofunc = globals.conefunc;
                }
                globals.net = new TwoOneNet(tofunc, globals.mediarynum, globals.learnrate, globals.ar);
                globals.net.createnet();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            globals.net.display(g);
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            if (globals.continuing)
            {
                pictureBox1.Refresh();
                trainingCount.Text = globals.numtrains.ToString();
                errorCount.Text = globals.errorNum.ToString();
                learnRateCount.Text = globals.learnRateCount.ToString();
                annealCount.Text = globals.annealRateCount.ToString();
            }
            else
            {
                pictureBox1.Refresh();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            initializeProgram();
            displayTimer.Start();
            logicTimer.Start();
        }    

        private void logicTimer_Tick(object sender, EventArgs e)
        {
            if (globals.continuing)
            {
                globals.net.trainnet();
            }
            else
            {
                finalError.Text = globals.errorGoal.ToString();
                markTrainings.Text = globals.finaltrainings.ToString();
            }
        }

        private void speedSlider_Scroll(object sender, ScrollEventArgs e)
        {
            displayTimer.Interval = speedSlider.Value;
        }

        private void netType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (globals != null)
            {
                if (netType.SelectedIndex == 0)
                {
                    functionType.DataSource = globals.OtOFunctions;
                }
                else
                {
                    functionType.DataSource = globals.TtOFunctions;
                }
                functionType.ValueMember = "function";
                functionType.DisplayMember = "name";
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            logicTimer.Start();
            displayTimer.Start();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            logicTimer.Stop();
            displayTimer.Stop();
        }

        private void learningText_TextChanged(object sender, EventArgs e)
        {

        }

        private void functionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (netType.SelectedIndex == 0)
            {
                functionType.DataSource = globals.OtOFunctions;
            }
            else
            {
                functionType.DataSource = globals.TtOFunctions;
            }
        }

        private void neuronSlider_Scroll(object sender, ScrollEventArgs e)
        {
            neuronBox.Text = neuronSlider.Value.ToString();
        }
    }
}

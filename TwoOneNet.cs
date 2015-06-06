using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Neural_Net
{
    public class TwoOneNet : NetInterface
    {
        public Globals.twofunc f;
        public Neural_Net net;
        public int medials;
        public double lrate;
        public double[] output;
        public Random rgen;
        public double xdom;
        public double ydom;
        public double[,] dom;
        public SolidBrush b;
        public Rectangle r;
        public double points;
        public int psize;
        public Color c;
        public List<double[,]> synonehist;
        public List<double[,]> syntwohist;
        public List<double> errorhist;
        public double lrateinterval;
        public int correctionInterval;
        public int correctionTimer;

        public TwoOneNet(Globals.twofunc function, int meds, double learnrate, double[,] domain)
        {
            synonehist = new List<double[,]>();
            syntwohist = new List<double[,]>();
            errorhist = new List<double>();
            lrateinterval = Form1.globals.annealingInterval;
            correctionInterval = Form1.globals.correctionInterval;
            correctionTimer = 0;
            psize = 4;
            points = 0;
            f = function;
            medials = meds;
            lrate = learnrate;
            rgen = new Random();
            xdom = Math.Abs(domain[0,0]-domain[0,1]);
            ydom = Math.Abs(domain[1,0]-domain[1,1]);
            dom = domain;
            b = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
            r = new Rectangle(0, 0, 0, 0);
            output = new double[10];
            c = Color.Red;
            net = new Neural_Net(1, 1, medials, lrate);
        }

        public void display(Graphics g)
        {
            double x;
            double y;
            double z;
            double conecolor;
            double neuralcolor;
            double[] neuralinput;
            double[] neuraloutput;
            Rectangle r;
            SolidBrush b;
            for (double i = 0; i < Form1.globals.worldx; i++)
            {
                for (double j = 0; j < Form1.globals.worldy; j++)
                {
                    x = Form1.globals.worldx;
                    x = i / Form1.globals.worldx;
                    y = j / Form1.globals.worldy;
                    r = new Rectangle((int)i, (int)j, 2, 2);
                    z = f(x, y);
                    neuralinput = new double[2] { x, y };
                    neuraloutput = net.evaluate(neuralinput);
                    conecolor = Math.Abs(255 - (z * 255));
                    neuralcolor = Math.Abs(255 - (neuraloutput[0] * 255));
                    b = new SolidBrush(Color.FromArgb(255, (int)neuralcolor % 255, 0, (int)conecolor % 255));

                    g.FillRectangle(b, r);
                }
            }
        }
        public void createnet()
        {
            net = new Neural_Net(2, 1, medials, lrate);
        }
        public void trainnet()
        {
            double[] input = new double[2];
            double[] output = new double[1];
            evaluateerror();
            if (Form1.globals.annealchecked)
            {
                if (correctionTimer > correctionInterval)
                {
                    correctnet();
                    correctionTimer = 0;
                }
                else
                {
                    correctionTimer++;
                }
            }
            for (int i = 0; i < Form1.globals.trainNum; i++)
            {
                input[0] = (rgen.NextDouble());
                input[1] = (rgen.NextDouble());
                output[0] = f(input[0], input[1]);
                net.train(input, output);
                Form1.globals.numtrains++;
            }
        }
        public void correctnet()
        {
            int bestNet = 0;
            for (int i = 0; i < errorhist.Count; i++)
            {
                if (errorhist[i] < errorhist[bestNet])
                {
                    bestNet = i;
                }
            }
            //double adjust = 1-(Form1.globals.errorGoal/errorhist[bestNet]);
            if (Form1.globals.initialerror == 0)
            {
                Form1.globals.initialerror = errorhist[bestNet];
            }
            double adjust = Form1.globals.learnrate * Math.Sqrt((errorhist[bestNet] / Form1.globals.initialerror));
            net.synone = synonehist[bestNet];
            net.syntwo = syntwohist[bestNet];
            synonehist.Clear();
            syntwohist.Clear();
            errorhist.Clear();
            if (adjust < Form1.globals.learnrate)
            {
                lrate = adjust;
                setnetrate();
                Form1.globals.learnRateCount = net.rate;
                Form1.globals.annealRateCount = adjust;
            }
        }

        public void evaluateerror()
        {
            double pointspacingx = Form1.globals.worldx / Form1.globals.fpoints;
            double pointspacingy = Form1.globals.worldy / Form1.globals.fpoints;
            List<double> errors = new List<double>();
            double sum = 0;
            double x;
            double y;
            double[] y1;
            double y2;
            double[] neuralinput;
            for (double i = 0; i < Form1.globals.worldx; i = i + pointspacingx)
            {
                for (double j = 0; j < Form1.globals.worldy; j = j + pointspacingy)
                {
                    x = Form1.globals.worldx;
                    x = i / Form1.globals.worldx;
                    y = j / Form1.globals.worldy;
                    y2 = f(x, y);
                    neuralinput = new double[2] { x, y };
                    y1 = net.evaluate(neuralinput);
                    errors.Add(Math.Pow((y1[0] - y2), 2));
                }
            }
            sum = errors.Average();
            Form1.globals.errorNum = sum;
            if (sum < Form1.globals.errorGoal)
            {
                Form1.globals.errorGoal = sum;
                Form1.globals.continuing = false;
                Form1.globals.finaltrainings = Form1.globals.numtrains;
            }
            errorhist.Add(sum);
            synonehist.Add(net.synone);
            syntwohist.Add(net.syntwo);
        }
        public void setnetrate()
        {
            net.rate = lrate;
        }
        public void setmedial(int m)
        {
            medials = m;
            createnet();
        }
    }
}

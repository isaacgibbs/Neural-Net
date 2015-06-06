using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Neural_Net
{
    public class OneOneNet : NetInterface
    {
        public Globals.onefunc f;
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
        public Pen fcolor;
        public Pen ncolor;
        public Pen axisc;
        public Point[] xaxis;
        public Point[] yaxis;
        public List<double[,]> synonehist;
        public List<double[,]> syntwohist;
        public List<double> errorhist;
        public double lrateinterval;
        public int correctionInterval;
        public int correctionTimer;

        public OneOneNet(Globals.onefunc function, int meds, double learnrate, double[,] domain)
        {
            synonehist = new List<double[,]>();
            syntwohist = new List<double[,]>();
            errorhist = new List<double>();
            lrateinterval = Form1.globals.annealingInterval;
            correctionInterval = Form1.globals.correctionInterval;
            correctionTimer = 0;
            xaxis = Form1.globals.xaxis;
            yaxis = Form1.globals.yaxis;
            axisc = new Pen(Color.Black);
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
            fcolor = new Pen(Color.Blue);
            ncolor = new Pen(Color.Red);
            net = new Neural_Net(1, 1, medials, lrate);
        }
        public void display(Graphics g)
        {
            drawAxis(g);
            drawFunction(g);
            drawNN(g);
        }

        private void drawAxis(Graphics g)
        {
            g.DrawLine(axisc, xaxis[0], xaxis[1]);
            g.DrawLine(axisc, yaxis[0], yaxis[1]);
        }

        private void drawFunction(Graphics g)
        {
            double pointspacing = (xdom * 2) / Form1.globals.fpoints;
            double y;
            for (double x = dom[0, 0]; x < dom[0, 1]; x = x + pointspacing)
            {
                y = f(x);
                drawPoint(g, x, y, fcolor);
            }
        }

        private void drawPoint(Graphics g, double x, double y, Pen p)
        {
            double dx, dy;
            dx = (x + xdom/2) * Form1.globals.worldx / xdom;
            dy = (y + ydom / 2) * Form1.globals.worldx / ydom;
            g.DrawEllipse(p, new Rectangle((int)(dx - (psize / 2)), (int)(dy - (psize / 2)), psize, psize));
        }

        private void drawNN(Graphics g)
        {
            double pointspacing = (xdom * 2) / Form1.globals.fpoints;
            double[] y;
            double[] temp;
            for (double x = dom[0, 0]; x < dom[0, 1]; x = x + pointspacing)
            {
                temp = new double[1] { x };
                y = net.evaluate(temp);
                drawPoint(g, x, y[0], ncolor);
            }
        }

        public void createnet()
        {
            net = new Neural_Net(1, 1, medials, lrate);
        }
        public void trainnet()
        {
            double[] input = new double[1];
            evaluateerror();
            if (correctionTimer > correctionInterval)
            {
                correctnet();
                correctionTimer = 0;
            }
            else
            {
                correctionTimer++;
            }
            for (int i = 0; i < Form1.globals.trainNum; i++)
            {
                input[0] = ((rgen.NextDouble() * xdom) + dom[0, 0]);
                output[0] = f(input[0]);
                net.train(input, output);
                Form1.globals.numtrains++;
            }
        }

        public void correctnet()
        {
            int bestNet = 0;
            double adjustment;
            for (int i = 0; i < errorhist.Count; i++)
            {
                if (errorhist[i] < errorhist[bestNet])
                {
                    bestNet = i;
                }
            }
            net.synone = synonehist[bestNet];
            net.syntwo = syntwohist[bestNet];
            
            if (lrate - lrateinterval > 0)
            {
                lrate = lrate - lrateinterval;
                setnetrate();
                Form1.globals.learnRateCount = net.rate;
            }
            synonehist.Clear();
            syntwohist.Clear();
            errorhist.Clear();
        }

        public void evaluateerror()
        {
            double pointspacing = (xdom * 2) / Form1.globals.fpoints;
            double[] y;
            double y2;
            double[] temp;
            List<double> errors = new List<double>();
            int errorcount = 0;
            double sum = 0;
            for (double x = dom[0, 0]; x < dom[0, 1]; x = x + pointspacing)
            {
                temp = new double[1] { x };
                y = net.evaluate(temp);
                y2 = f(x);
                errors.Add(Math.Pow((y[0] - y2),2));
            }
            sum = errors.Average();
            Form1.globals.errorNum = sum;
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

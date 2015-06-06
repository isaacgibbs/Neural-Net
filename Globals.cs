using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Neural_Net
{
    public class Globals
    {
        public static double sinFunct(double x)
        {
            return Math.Sin(x);
        }

        public static double cosFunct(double x)
        {
            return Math.Cos(x);
        }

        private static double coneFunct(double x, double y)
        {
            double rad = 0.25;
            double x1 = 0.5;
            double y1 = 0.5;
            double h = 1;
            double dist = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));
            double temp = -Math.Sqrt(((Math.Pow(x - x1, 2)) + Math.Pow(y - y1, 2)) / Math.Pow((rad / h), 2));
            return temp;
        }

        public delegate double onefunc(double x);
        public delegate double twofunc(double x, double y);
        public onefunc sinfunc = sinFunct;
        public onefunc cosfunc = cosFunct;
        public twofunc conefunc = coneFunct;

        public int fpoints; //function point density
        public Pen fcolor; //function point color
        public int fsize;
        public int npoints; //neural point density
        public Pen ncolor; //neural point color
        public int nsize;
        public Pen axisc;
        public Point[] xaxis;
        public Point[] yaxis;
        public int axissize;
        public double xdomain; //function x domain
        public double ydomain;
        public double xscale;
        public double yscale;
        public double learnrate;
        public int mediarynum;
        public double bias;
        public Random rgen;
        public int numtrains;
        public int worldx;
        public int worldy;
        public double noise;
        public DataTable OtOFunctions;
        public DataTable TtOFunctions;
        public NetInterface net;
        public int trainNum;
        public double errorNum;
        public double learnRateCount;
        public double[,] ar = new double[,] { { -Math.PI, Math.PI }, { -1, 1 } };
        public double annealingInterval;
        public int correctionInterval;
        public double annealRateCount;
        public bool annealchecked;
        public bool continuing;
        public double errorGoal;
        public int finaltrainings;
        public double initialerror;
        public Globals()
        {
            initialerror = 0;
            continuing = true;
            annealRateCount = 0;
            trainNum = 50;
            annealingInterval = 0.001;
            correctionInterval = 10;
            noise = 1;
            numtrains = 0;
            fpoints = 50;
            fcolor = new Pen(Color.Blue);
            fsize = 4;
            npoints = 20;
            ncolor = new Pen(Color.Red);
            nsize = 4;
            axisc = new Pen(Color.Black);
            axissize = 1;
            xdomain = Math.PI;
            ydomain = 1;
            OtOFunctions = new DataTable();
            OtOFunctions.Columns.Add("name");
            OtOFunctions.Columns.Add("function");
            OtOFunctions.Rows.Add("Sin Function", "sinfunc");
            OtOFunctions.Rows.Add("Cos Function", "cosfunc");

            TtOFunctions = new DataTable();
            TtOFunctions.Columns.Add("name");
            TtOFunctions.Columns.Add("function");
            TtOFunctions.Rows.Add("Cone Function", "conefunc");

            learnrate = 0.01;
            mediarynum = 20;
            bias = 0.1;

            rgen = new Random();
        }
    }
}

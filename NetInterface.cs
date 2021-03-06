/*
    Isaac A. Gibbs
    3/25/2014
    Neural Net
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Neural_Net
{
    public interface NetInterface
    {
        void display(Graphics g);
        void createnet();
        void trainnet();
        void evaluateerror();
        void setnetrate();
        void setmedial(int m);
    }
}

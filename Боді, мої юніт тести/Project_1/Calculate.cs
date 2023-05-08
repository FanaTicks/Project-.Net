using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class Calculate
    {
        public double Sum_Profit(int pr1, int pr2)
        {
            return pr1 + pr2;
        }

        public double Sum_Sp(double sp1, double sp2)
        {
            return sp1 + sp2;
        }

        public double Res(double pr, double sp)
        {
            return pr - sp;
        }
    }
}

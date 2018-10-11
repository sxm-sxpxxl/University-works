using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLaboratory
{
    enum EnType
    {
        Value,
        FuncValue
    }

    class Function
    {
        private const double MIN = 0;
        private const double MAX = 10.0;
        private const double STEP = 0.01;
        private const double Y_DEFAULT = 5.0;
        private const double Z_DEFAULT = 8.0;

        private double x_min;
        private double x_max;
        private double step;
        private int countOfPoints;
        private double y;
        private double z;

        private double[] x;
        private double[] psi;

        public Function()
        {

            x_min = MIN;
            x_max = MAX;
            step = STEP;
            countOfPoints = (int)Math.Ceiling((x_max - x_min) / step);
            y = Y_DEFAULT;
            z = Z_DEFAULT;

            x = new double[countOfPoints];
            psi = new double[countOfPoints];
        }

        public Function(double x_min, double x_max, double step, double y, double z)
        {
            this.x_min = x_min;
            this.x_max = x_max;
            this.step = step;
            countOfPoints = (int)Math.Ceiling((x_max - x_min) / step);
            this.y = y;
            this.z = z;

            x = new double[countOfPoints];
            psi = new double[countOfPoints];
        }

        public double this[int index, EnType type = EnType.FuncValue]
        {
            get
            {
                if (type == EnType.Value) return x[index];
                if (type == EnType.FuncValue) return psi[index];
                return 0.0;
            }
            set
            {
                if (type == EnType.Value) x[index] = value;
                if (type == EnType.FuncValue) psi[index] = value;
            }
        }

        public double X_Min
        {
            get { return x_min; }
        }

        public double X_Max
        {
            get { return x_max; }
        }

        public double Step
        {
            get { return step; }
        }

        public double[] X
        {
            get { return x; }
        }

        public double[] PSI
        {
            get { return psi; }
        }

        public double YParam
        {
            get { return y; }
        }

        public double ZParam
        {
            get { return z; }
        }

        public void CalcFunction()
        {
            for(int i = 0; i < countOfPoints; i++)
            {
                x[i] = x_min + step * i;
                psi[i] = Func(x[i]);
            }
        }

        private double Func(double x)
        {
            return Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1 / 3)) + (y - x) * (Math.Cos(y) - z / (y - x)) / (1 + Math.Pow( (y - x), 2));
        }
    }
}

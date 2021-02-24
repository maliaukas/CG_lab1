using System;

namespace WindowsFormsApp1
{
    public class LabColor : ColorModel
    {
        private double L;
        private double a;
        private double b;

        public double L1 { get => L; set => L = value; }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        public LabColor(double l, double a, double b)
        {
            L = l;
            this.a = a;
            this.b = b;
        }

        public CMYKColor ToCMYK()
        {
            return this.ToRGB().ToCMYK();
        }

        public LabColor ToLab()
        {
            return this;
        }

        public RGBColor ToRGB()
        {
            return this.ToXYZ().ToRGB();
        }

        public XYZColor ToXYZ()
        {
            return new XYZColor(
                fLab(a / 500d + (L + 16d) / 116d) * 95.047,
                fLab((L + 16d) / 116d) * 100d,
                fLab((L + 16d) / 116d - b / 200d) * 108.883
                );
        }

        private double fLab(double x)
        {
            double delta = (6d / 29d);
            if (x >= delta)
            {
                return Math.Pow(x, 3);
            }
            return 3d * Math.Pow(delta, 2) * (x - 4d / 29d);
        }
    }
}
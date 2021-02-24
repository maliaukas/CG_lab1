using System;

namespace WindowsFormsApp1
{
    public class CMYKColor : ColorModel
    {
        private double c;
        private double m;
        private double y;
        private double k;

        public CMYKColor(double c, double m, double y, double k)
        {
            this.c = c;
            this.m = m;
            this.y = y;
            this.k = k;
        }

        public double C { get => c; set => c = value; }
        public double M { get => m; set => m = value; }
        public double Y { get => y; set => y = value; }
        public double K { get => k; set => k = value; }

        public CMYKColor ToCMYK()
        {
            return this;
        }

        public LabColor ToLab()
        {
            return this.ToRGB().ToLab();
        }

        public RGBColor ToRGB()
        {
            return new RGBColor(
                Convert.ToInt32(255.0 * (1 - c) * (1 - k)),
                Convert.ToInt32(255.0 * (1 - m) * (1 - k)),
                Convert.ToInt32(255.0 * (1 - y) * (1 - k)));
        }
    }
}
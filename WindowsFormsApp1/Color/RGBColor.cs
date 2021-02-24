using System;

namespace WindowsFormsApp1
{
    public class RGBColor : ColorModel
    {
        private int r;
        private int g;
        private int b;

        public int R { get => r; set => r = value; }
        public int G { get => g; set => g = value; }
        public int B { get => b; set => b = value; }

        public RGBColor(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public CMYKColor ToCMYK()
        {
            double rf = r / 255d;
            double gf = g / 255d;
            double bf = b / 255d;

            double k = ClampCmyk(1 - Math.Max(Math.Max(rf, gf), bf));
            double c = ClampCmyk((1 - rf - k) / (1 - k));
            double m = ClampCmyk((1 - gf - k) / (1 - k));
            double y = ClampCmyk((1 - bf - k) / (1 - k));
            return new CMYKColor(c, m, y, k);
        }

        private double ClampCmyk(double value)
        {
            if (value < 0 || double.IsNaN(value))
            {
                value = 0;
            }

            return value;
        }

        public LabColor ToLab()
        {
            return this.ToXYZ().ToLab();
        }

        public RGBColor ToRGB()
        {
            return this;
        }

        public XYZColor ToXYZ()
        {
            double rn = fRGB(r / 255d) * 100d;
            double gn = fRGB(g / 255d) * 100d;
            double bn = fRGB(b / 255d) * 100d;

            return new XYZColor(
                0.412453 * rn + 0.357580 * gn + 0.180423 * bn, // x
                0.212671 * rn + 0.715160 * gn + 0.072169 * bn, // y
                0.019334 * rn + 0.119193 * gn + 0.950227 * bn  // z
                );
        }

        private double fRGB(double x)
        {
            if (x >= 0.04045)
            {
                return Math.Pow((x + 0.055) / 1.055, 2.4);
            }
            else
            {
                return x / 12.92;
            }
        }
    }
}
using System;

namespace WindowsFormsApp1
{
    public class XYZColor : ColorModel
    {
        private double x;
        private double y;
        private double z;

        public XYZColor(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public CMYKColor ToCMYK()
        {
            return this.ToRGB().ToCMYK();
        }

        public LabColor ToLab()
        {
            double x_ = x / 95.047;
            double y_ = y / 100d;
            double z_ = z / 108.883;

            return new LabColor(
                116d * fXYZLab(y_) - 16,
                500d * (fXYZLab(x_) - fXYZLab(y_)),
                200d * (fXYZLab(y_) - fXYZLab(z_))
                );
        }

        private double fXYZLab(double x)
        {
            if (x >= 0.008856)
            {
                return Math.Pow(x, 1d / 3d);
            }
            else
            {
                return 7.787 * x + 16d / 116d;
            }
        }

        private double Clamp(double min, double max, double value)
        {
            if (min <= value && value <= max)
            {
                return value;
            }
            if (value < min)
            {
                return min;
            }
            return max;
        }

        public RGBColor ToRGB()
        {
            double x_ = x / 100d;
            double y_ = y / 100d;
            double z_ = z / 100d;

            double rn = 3.2406 * x_ - 1.5372 * y_ - 0.4986 * z_;
            double gn = -0.9689 * x_ + 1.8758 * y_ + 0.0415 * z_;
            double bn = 0.0557 * x_ - 0.2040 * y_ + 1.0570 * z_;

            rn = fXYZRGB(Clamp(0.0, 1.0, rn));
            gn = fXYZRGB(Clamp(0.0, 1.0, gn));
            bn = fXYZRGB(Clamp(0.0, 1.0, bn));

            return new RGBColor(
                Convert.ToInt32((rn) * 255.0),
                Convert.ToInt32((gn) * 255.0),
                Convert.ToInt32((bn) * 255.0)
                );
        }

        private double fXYZRGB(double x)
        {
            if (x >= 0.0031308)
            {
                return 1.055 * Math.Pow(x, 1d / 2.4d) - 0.055;
            }
            else
            {
                return 12.92 * x;
            }
        }

    }
}

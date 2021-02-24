using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorDialog1.FullOpen = true;
            colorDialog1.Color = labelColor.BackColor;
        }

        private bool changing = false;

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            labelColor.BackColor = labelColor.ForeColor = colorDialog1.Color;
        }


        private void updateColor(object sender, EventArgs e)
        {
            changing = true;

            int r = labelColor.ForeColor.R;
            int g = labelColor.ForeColor.G;
            int b = labelColor.ForeColor.B;

            RGBColor rgb = new RGBColor(r, g, b);

            updateRGB(rgb);
            updateCMYK(rgb.ToCMYK());
            updateLAB(rgb.ToLab());

            changing = false;
        }

        private void updateRGB(RGBColor color)
        {
            tboxRGBR.Text = color.R.ToString();
            tboxRGBG.Text = color.G.ToString();
            tboxRGBB.Text = color.B.ToString();

            trackBarRGBR.Value = color.R;
            trackBarRGBG.Value = color.G;
            trackBarRGBB.Value = color.B;
        }

        private void updateCMYK(CMYKColor color)
        {
            tboxCMYKC.Text = (color.C * 100).ToString();
            tboxCMYKM.Text = (color.M * 100).ToString();
            tboxCMYKY.Text = (color.Y * 100).ToString();
            tboxCMYKK.Text = (color.K * 100).ToString();

            trackBarCMYKC.Value = Convert.ToInt32(color.C * 100);
            trackBarCMYKM.Value = Convert.ToInt32(color.M * 100);
            trackBarCMYKY.Value = Convert.ToInt32(color.Y * 100);
            trackBarCMYKK.Value = Convert.ToInt32(color.K * 100);
        }

        private void updateLAB(LabColor color)
        {
            tboxLABL.Text = color.L1.ToString();
            tboxLABA.Text = color.A.ToString();
            tboxLABB.Text = color.B.ToString();

            trackBarLABL.Value = Convert.ToInt32(color.L1);
            trackBarLABA.Value = Convert.ToInt32(color.A);
            trackBarLABB.Value = Convert.ToInt32(color.B);
        }

        private void tboxRGB_TextChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            try
            {
                labelColor.BackColor = labelColor.ForeColor =
                    Color.FromArgb(
                        Convert.ToInt32(tboxRGBR.Text),
                        Convert.ToInt32(tboxRGBG.Text),
                        Convert.ToInt32(tboxRGBB.Text)
                        );
            }
            catch (Exception ex)
            {
                MessageBox.Show("AArrrr!!! " + ex.Message);
            }
        }

        private void trackBarRGBR_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxRGBR.Text = trackBarRGBR.Value.ToString();
        }

        private void trackBarRGBG_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxRGBG.Text = trackBarRGBG.Value.ToString();
        }

        private void trackBarRGBB_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxRGBB.Text = trackBarRGBB.Value.ToString();
        }

        private void tboxLAB_TextChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            try
            {
                RGBColor rGBColor = new LabColor(
                    Convert.ToDouble(tboxLABL.Text),
                    Convert.ToDouble(tboxLABA.Text),
                    Convert.ToDouble(tboxLABB.Text)
                    ).ToRGB();

                labelColor.BackColor = labelColor.ForeColor =
                    Color.FromArgb(
                        rGBColor.R,
                        rGBColor.G,
                        rGBColor.B
                        );
            }
            catch (Exception ex)
            {
                MessageBox.Show("AArrrr!!! " + ex.Message);
            }
        }

        private void tboxCMYKC_TextChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            try
            {
                RGBColor rGB = new CMYKColor(
                    Convert.ToDouble(tboxCMYKC.Text) / 100d,
                    Convert.ToDouble(tboxCMYKM.Text) / 100d,
                    Convert.ToDouble(tboxCMYKY.Text) / 100d,
                    Convert.ToDouble(tboxCMYKK.Text) / 100d
                    ).ToRGB();

                labelColor.BackColor = labelColor.ForeColor =
                    Color.FromArgb(
                        rGB.R,
                        rGB.G,
                        rGB.B
                        );
            }
            catch (Exception ex)
            {
                MessageBox.Show("AArrrr!!! " + ex.Message);
            }
        }

        private void trackBarLABL_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxLABL.Text = trackBarLABL.Value.ToString();
        }

        private void trackBarLABA_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxLABA.Text = trackBarLABA.Value.ToString();
        }

        private void trackBarLABB_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxLABB.Text = trackBarLABB.Value.ToString();
        }

        private void trackBarCMYKC_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxCMYKC.Text = trackBarCMYKC.Value.ToString();
        }

        private void trackBarCMYKM_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxCMYKM.Text = trackBarCMYKM.Value.ToString();
        }
        private void trackBarCMYKY_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxCMYKY.Text = trackBarCMYKY.Value.ToString();
        }
        private void trackBarCMYKK_ValueChanged(object sender, EventArgs e)
        {
            if (changing)
                return;
            tboxCMYKK.Text = trackBarCMYKK.Value.ToString();
        }
    }
}

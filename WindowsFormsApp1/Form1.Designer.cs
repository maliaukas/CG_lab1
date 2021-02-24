
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRGBR = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarRGBG = new System.Windows.Forms.TrackBar();
            this.trackBarRGBB = new System.Windows.Forms.TrackBar();
            this.tboxRGBR = new System.Windows.Forms.TextBox();
            this.tboxRGBB = new System.Windows.Forms.TextBox();
            this.tboxRGBG = new System.Windows.Forms.TextBox();
            this.tboxLABA = new System.Windows.Forms.TextBox();
            this.tboxLABB = new System.Windows.Forms.TextBox();
            this.tboxLABL = new System.Windows.Forms.TextBox();
            this.trackBarLABB = new System.Windows.Forms.TrackBar();
            this.trackBarLABA = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarLABL = new System.Windows.Forms.TrackBar();
            this.tboxCMYKM = new System.Windows.Forms.TextBox();
            this.tboxCMYKY = new System.Windows.Forms.TextBox();
            this.tboxCMYKC = new System.Windows.Forms.TextBox();
            this.trackBarCMYKY = new System.Windows.Forms.TrackBar();
            this.trackBarCMYKM = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarCMYKC = new System.Windows.Forms.TrackBar();
            this.tboxCMYKK = new System.Windows.Forms.TextBox();
            this.trackBarCMYKK = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelColor = new System.Windows.Forms.Label();
            this.btnPalette = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLABB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLABA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLABL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCMYKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCMYKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCMYKC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCMYKK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RGB";
            // 
            // trackBarRGBR
            // 
            this.trackBarRGBR.Location = new System.Drawing.Point(61, 58);
            this.trackBarRGBR.Maximum = 255;
            this.trackBarRGBR.Name = "trackBarRGBR";
            this.trackBarRGBR.Size = new System.Drawing.Size(123, 56);
            this.trackBarRGBR.TabIndex = 1;
            this.trackBarRGBR.ValueChanged += new System.EventHandler(this.trackBarRGBR_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "LAB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "CMYK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "B";
            // 
            // trackBarRGBG
            // 
            this.trackBarRGBG.Location = new System.Drawing.Point(61, 139);
            this.trackBarRGBG.Maximum = 255;
            this.trackBarRGBG.Name = "trackBarRGBG";
            this.trackBarRGBG.Size = new System.Drawing.Size(123, 56);
            this.trackBarRGBG.TabIndex = 7;
            this.trackBarRGBG.ValueChanged += new System.EventHandler(this.trackBarRGBG_ValueChanged);
            // 
            // trackBarRGBB
            // 
            this.trackBarRGBB.Location = new System.Drawing.Point(61, 216);
            this.trackBarRGBB.Maximum = 255;
            this.trackBarRGBB.Name = "trackBarRGBB";
            this.trackBarRGBB.Size = new System.Drawing.Size(123, 56);
            this.trackBarRGBB.TabIndex = 8;
            this.trackBarRGBB.ValueChanged += new System.EventHandler(this.trackBarRGBB_ValueChanged);
            // 
            // tboxRGBR
            // 
            this.tboxRGBR.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tboxRGBR.Location = new System.Drawing.Point(190, 58);
            this.tboxRGBR.Name = "tboxRGBR";
            this.tboxRGBR.Size = new System.Drawing.Size(58, 22);
            this.tboxRGBR.TabIndex = 9;
            this.tboxRGBR.Text = "0";
            this.tboxRGBR.TextChanged += new System.EventHandler(this.tboxRGB_TextChanged);
            // 
            // tboxRGBB
            // 
            this.tboxRGBB.Location = new System.Drawing.Point(190, 216);
            this.tboxRGBB.Name = "tboxRGBB";
            this.tboxRGBB.Size = new System.Drawing.Size(58, 22);
            this.tboxRGBB.TabIndex = 10;
            this.tboxRGBB.Text = "0";
            this.tboxRGBB.TextChanged += new System.EventHandler(this.tboxRGB_TextChanged);
            // 
            // tboxRGBG
            // 
            this.tboxRGBG.Location = new System.Drawing.Point(190, 139);
            this.tboxRGBG.Name = "tboxRGBG";
            this.tboxRGBG.Size = new System.Drawing.Size(58, 22);
            this.tboxRGBG.TabIndex = 11;
            this.tboxRGBG.Text = "0";
            this.tboxRGBG.TextChanged += new System.EventHandler(this.tboxRGB_TextChanged);
            // 
            // tboxLABA
            // 
            this.tboxLABA.Location = new System.Drawing.Point(449, 139);
            this.tboxLABA.Name = "tboxLABA";
            this.tboxLABA.Size = new System.Drawing.Size(58, 22);
            this.tboxLABA.TabIndex = 20;
            this.tboxLABA.Text = "0";
            this.tboxLABA.TextChanged += new System.EventHandler(this.tboxLAB_TextChanged);
            // 
            // tboxLABB
            // 
            this.tboxLABB.Location = new System.Drawing.Point(449, 216);
            this.tboxLABB.Name = "tboxLABB";
            this.tboxLABB.Size = new System.Drawing.Size(58, 22);
            this.tboxLABB.TabIndex = 19;
            this.tboxLABB.Text = "0";
            this.tboxLABB.TextChanged += new System.EventHandler(this.tboxLAB_TextChanged);
            // 
            // tboxLABL
            // 
            this.tboxLABL.Location = new System.Drawing.Point(449, 58);
            this.tboxLABL.Name = "tboxLABL";
            this.tboxLABL.Size = new System.Drawing.Size(58, 22);
            this.tboxLABL.TabIndex = 18;
            this.tboxLABL.Text = "0";
            this.tboxLABL.TextChanged += new System.EventHandler(this.tboxLAB_TextChanged);
            // 
            // trackBarLABB
            // 
            this.trackBarLABB.Location = new System.Drawing.Point(320, 216);
            this.trackBarLABB.Maximum = 127;
            this.trackBarLABB.Minimum = -128;
            this.trackBarLABB.Name = "trackBarLABB";
            this.trackBarLABB.Size = new System.Drawing.Size(123, 56);
            this.trackBarLABB.TabIndex = 17;
            this.trackBarLABB.ValueChanged += new System.EventHandler(this.trackBarLABB_ValueChanged);
            // 
            // trackBarLABA
            // 
            this.trackBarLABA.Location = new System.Drawing.Point(320, 139);
            this.trackBarLABA.Maximum = 127;
            this.trackBarLABA.Minimum = -128;
            this.trackBarLABA.Name = "trackBarLABA";
            this.trackBarLABA.Size = new System.Drawing.Size(123, 56);
            this.trackBarLABA.TabIndex = 16;
            this.trackBarLABA.ValueChanged += new System.EventHandler(this.trackBarLABA_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "L";
            // 
            // trackBarLABL
            // 
            this.trackBarLABL.Location = new System.Drawing.Point(320, 58);
            this.trackBarLABL.Maximum = 100;
            this.trackBarLABL.Name = "trackBarLABL";
            this.trackBarLABL.Size = new System.Drawing.Size(123, 56);
            this.trackBarLABL.TabIndex = 12;
            this.trackBarLABL.ValueChanged += new System.EventHandler(this.trackBarLABL_ValueChanged);
            // 
            // tboxCMYKM
            // 
            this.tboxCMYKM.Location = new System.Drawing.Point(715, 102);
            this.tboxCMYKM.Name = "tboxCMYKM";
            this.tboxCMYKM.Size = new System.Drawing.Size(58, 22);
            this.tboxCMYKM.TabIndex = 29;
            this.tboxCMYKM.Text = "0";
            this.tboxCMYKM.TextChanged += new System.EventHandler(this.tboxCMYKC_TextChanged);
            // 
            // tboxCMYKY
            // 
            this.tboxCMYKY.Location = new System.Drawing.Point(715, 158);
            this.tboxCMYKY.Name = "tboxCMYKY";
            this.tboxCMYKY.Size = new System.Drawing.Size(58, 22);
            this.tboxCMYKY.TabIndex = 28;
            this.tboxCMYKY.Text = "0";
            this.tboxCMYKY.TextChanged += new System.EventHandler(this.tboxCMYKC_TextChanged);
            // 
            // tboxCMYKC
            // 
            this.tboxCMYKC.Location = new System.Drawing.Point(716, 46);
            this.tboxCMYKC.Name = "tboxCMYKC";
            this.tboxCMYKC.Size = new System.Drawing.Size(58, 22);
            this.tboxCMYKC.TabIndex = 27;
            this.tboxCMYKC.Text = "0";
            this.tboxCMYKC.TextChanged += new System.EventHandler(this.tboxCMYKC_TextChanged);
            // 
            // trackBarCMYKY
            // 
            this.trackBarCMYKY.Location = new System.Drawing.Point(586, 159);
            this.trackBarCMYKY.Maximum = 100;
            this.trackBarCMYKY.Name = "trackBarCMYKY";
            this.trackBarCMYKY.Size = new System.Drawing.Size(123, 56);
            this.trackBarCMYKY.TabIndex = 26;
            this.trackBarCMYKY.ValueChanged += new System.EventHandler(this.trackBarCMYKY_ValueChanged);
            // 
            // trackBarCMYKM
            // 
            this.trackBarCMYKM.Location = new System.Drawing.Point(586, 100);
            this.trackBarCMYKM.Maximum = 100;
            this.trackBarCMYKM.Name = "trackBarCMYKM";
            this.trackBarCMYKM.Size = new System.Drawing.Size(123, 56);
            this.trackBarCMYKM.TabIndex = 25;
            this.trackBarCMYKM.ValueChanged += new System.EventHandler(this.trackBarCMYKM_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "M";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "C";
            // 
            // trackBarCMYKC
            // 
            this.trackBarCMYKC.Location = new System.Drawing.Point(587, 41);
            this.trackBarCMYKC.Maximum = 100;
            this.trackBarCMYKC.Name = "trackBarCMYKC";
            this.trackBarCMYKC.Size = new System.Drawing.Size(123, 56);
            this.trackBarCMYKC.TabIndex = 21;
            this.trackBarCMYKC.ValueChanged += new System.EventHandler(this.trackBarCMYKC_ValueChanged);
            // 
            // tboxCMYKK
            // 
            this.tboxCMYKK.Location = new System.Drawing.Point(715, 214);
            this.tboxCMYKK.Name = "tboxCMYKK";
            this.tboxCMYKK.Size = new System.Drawing.Size(58, 22);
            this.tboxCMYKK.TabIndex = 32;
            this.tboxCMYKK.Text = "100";
            this.tboxCMYKK.TextChanged += new System.EventHandler(this.tboxCMYKC_TextChanged);
            // 
            // trackBarCMYKK
            // 
            this.trackBarCMYKK.Location = new System.Drawing.Point(586, 218);
            this.trackBarCMYKK.Maximum = 100;
            this.trackBarCMYKK.Name = "trackBarCMYKK";
            this.trackBarCMYKK.Size = new System.Drawing.Size(123, 56);
            this.trackBarCMYKK.TabIndex = 31;
            this.trackBarCMYKK.Value = 100;
            this.trackBarCMYKK.ValueChanged += new System.EventHandler(this.trackBarCMYKK_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(554, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "K";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Black;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.Color.Black;
            this.labelColor.Location = new System.Drawing.Point(12, 278);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(591, 137);
            this.labelColor.TabIndex = 33;
            this.labelColor.Text = "The color ";
            this.labelColor.ForeColorChanged += new System.EventHandler(this.updateColor);
            // 
            // btnPalette
            // 
            this.btnPalette.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalette.Location = new System.Drawing.Point(624, 278);
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Size = new System.Drawing.Size(149, 135);
            this.btnPalette.TabIndex = 34;
            this.btnPalette.Text = "Pick a color";
            this.btnPalette.UseVisualStyleBackColor = true;
            this.btnPalette.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 437);
            this.Controls.Add(this.btnPalette);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.tboxCMYKK);
            this.Controls.Add(this.trackBarCMYKK);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tboxCMYKM);
            this.Controls.Add(this.tboxCMYKY);
            this.Controls.Add(this.tboxCMYKC);
            this.Controls.Add(this.trackBarCMYKY);
            this.Controls.Add(this.trackBarCMYKM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trackBarCMYKC);
            this.Controls.Add(this.tboxLABA);
            this.Controls.Add(this.tboxLABB);
            this.Controls.Add(this.tboxLABL);
            this.Controls.Add(this.trackBarLABB);
            this.Controls.Add(this.trackBarLABA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBarLABL);
            this.Controls.Add(this.tboxRGBG);
            this.Controls.Add(this.tboxRGBB);
            this.Controls.Add(this.tboxRGBR);
            this.Controls.Add(this.trackBarRGBB);
            this.Controls.Add(this.trackBarRGBG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarRGBR);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ColorConverter";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLABB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLABA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLABL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCMYKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCMYKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCMYKC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCMYKK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarRGBR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarRGBG;
        private System.Windows.Forms.TrackBar trackBarRGBB;
        private System.Windows.Forms.TextBox tboxRGBR;
        private System.Windows.Forms.TextBox tboxRGBB;
        private System.Windows.Forms.TextBox tboxRGBG;
        private System.Windows.Forms.TextBox tboxLABA;
        private System.Windows.Forms.TextBox tboxLABB;
        private System.Windows.Forms.TextBox tboxLABL;
        private System.Windows.Forms.TrackBar trackBarLABB;
        private System.Windows.Forms.TrackBar trackBarLABA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarLABL;
        private System.Windows.Forms.TextBox tboxCMYKM;
        private System.Windows.Forms.TextBox tboxCMYKY;
        private System.Windows.Forms.TextBox tboxCMYKC;
        private System.Windows.Forms.TrackBar trackBarCMYKY;
        private System.Windows.Forms.TrackBar trackBarCMYKM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarCMYKC;
        private System.Windows.Forms.TextBox tboxCMYKK;
        private System.Windows.Forms.TrackBar trackBarCMYKK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button btnPalette;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


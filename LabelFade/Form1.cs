using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelFade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] targetColor = { 255,255,255}; //white
        int[] fadeRGB = new int[3];

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter>500)
                fadeIn();
        }

        void fadeOut()
        {
            fadeRGB[0] = label1.ForeColor.R;
            fadeRGB[1] = label1.ForeColor.G;
            fadeRGB[2] = label1.ForeColor.B;

            if (fadeRGB[0] > this.BackColor.R)
                fadeRGB[0]--;
            else if (fadeRGB[0] < this.BackColor.R)
                fadeRGB[0]++;
            if (fadeRGB[1] > this.BackColor.G)
                fadeRGB[1]--;
            else if (fadeRGB[1] < this.BackColor.G)
                fadeRGB[1]++;
            if (fadeRGB[2] > this.BackColor.B)
                fadeRGB[2]--;
            else if (fadeRGB[2] < this.BackColor.B)
                fadeRGB[2]++;
            if (fadeRGB[0] == this.BackColor.R && fadeRGB[1] == this.BackColor.G && fadeRGB[2] == this.BackColor.B)
                timer1.Stop();

            label1.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }

        void fadeIn()
        {
            fadeRGB[0] = label1.ForeColor.R;
            fadeRGB[1] = label1.ForeColor.G;
            fadeRGB[2] = label1.ForeColor.B;

            if (fadeRGB[0] > targetColor[0])
                fadeRGB[0]--;
            else if (fadeRGB[0] < targetColor[0])
                fadeRGB[0]++;
            if (fadeRGB[1] > targetColor[1])
                fadeRGB[1]--;
            else if (fadeRGB[1] < targetColor[1])
                fadeRGB[1]++;
            if (fadeRGB[2] > targetColor[2])
                fadeRGB[2]--;
            else if (fadeRGB[2] < targetColor[2])
                fadeRGB[2]++;
            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == targetColor[1] && fadeRGB[2] == targetColor[2])
                timer1.Stop();

            label1.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
        }
    }
}

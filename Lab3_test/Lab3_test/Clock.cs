using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_test
{
    public partial class Clock : Form
    {
        readonly Timer tik;
        public int hours { get; set; }
        public int minutes { get; set; }
        public int second { get; set; }
        double x_sec;
        double y_sec;
        double x_min;
        double y_min;
        double x_hour;
        double y_hour;
        double x_min1;
        double y_min1;
        double x_min2;
        double y_min2;

        public Clock()
        {
            tik = new Timer();
            second = DateTime.Now.Second;
            minutes = DateTime.Now.Minute;
            hours = DateTime.Now.Hour;
            InitializeComponent();
            timer();
        }

        public void timer()
        {
            tik.Interval = 1000;
            tik.Tick += tmrShow_Tick;
            tik.Enabled = true;
            tik.Start();
        }

        public void tmrShow_Tick(object sender, EventArgs e)
        {
            Draw(Graphics.FromHwnd(Clock_panel.Handle));
            second++;
            if (second == 60)
            {
                second = 0;
                minutes++;
            }
            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }
            if (hours == 24)
                hours = 0;
            label_clok.Text = hours + " : " + minutes + " : " + second; 
        }

        public void Draw(Graphics g)
        {
            g.Clear(Color.White);
            g.DrawEllipse(new Pen(Color.Black,2), 0, 0, Clock_panel.Width, Clock_panel.Height);

            double angle_sec = (((double)second / 60) * 360 - 90) * Math.PI / 180;

            int r = Clock_panel.Height / 2;
            double sin = Math.Sin(angle_sec);
            double cos = Math.Cos(angle_sec);

            x_sec = r * cos * 0.9;
            y_sec = r * sin * 0.9;

            double angle_min = (((double)minutes / 60) * 360 - 90) * Math.PI / 180;
            sin = Math.Sin(angle_min);
            cos = Math.Cos(angle_min);

            x_min = r * cos * 0.8;
            y_min = r * sin * 0.8;

            double angle_hour = (((double)hours / 24) * 360 - 90) * Math.PI / 180;
            sin = Math.Sin(angle_hour);
            cos = Math.Cos(angle_hour);

            x_hour = r * cos * 0.7;
            y_hour = r * sin * 0.7;

            for (int i = 0; i < 60; i++)
            {
                double angle_min1 = (((double)i / 60) * 360 - 90) * Math.PI / 180;
                sin = Math.Sin(angle_min1);
                cos = Math.Cos(angle_min1);

                x_min1 = r * cos;
                y_min1 = r * sin;
                if (i == 0 || i == 15 || i == 30 || i == 45)
                {
                    x_min2 = r * cos * 0.8;
                    y_min2 = r * sin * 0.8;
                }
                else
                {
                    x_min2 = r * cos * 0.95;
                    y_min2 = r * sin * 0.95;
                }

                g.DrawLine(new Pen(Color.Blue), (int)x_min2 + Clock_panel.Width / 2, (int)y_min2 + Clock_panel.Width / 2, (int)x_min1 + Clock_panel.Width / 2, (int)y_min1 + Clock_panel.Width / 2);
            }

            g.DrawLine(new Pen(Color.Red, 3), Clock_panel.Width / 2, Clock_panel.Height / 2, (int)x_hour + Clock_panel.Width / 2, (int)y_hour + Clock_panel.Width / 2);
            g.DrawLine(new Pen(Color.Gold, 2), Clock_panel.Width / 2, Clock_panel.Height / 2, (int)x_min + Clock_panel.Width / 2, (int)y_min + Clock_panel.Width / 2);
            g.DrawLine(new Pen(Color.Green, 1), Clock_panel.Width / 2, Clock_panel.Height / 2, (int)x_sec + Clock_panel.Width / 2, (int)y_sec + Clock_panel.Width / 2);
        }
    }
}

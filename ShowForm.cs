using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using 补丁;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 补丁
{
    public partial class ShowForm : Form
    {
        public int valuef = 10;
        public int statef = 2;
        public List<Color> ColorsListf = new List<Color>();
        public List<PointF> PointListf = new List<PointF>();
        public List<int> SizeListf = new List<int>();

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int vKey);

        public ShowForm()
        {
            InitializeComponent();
        }


        private void ShowForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void draw()
        {
            Graphics g = this.CreateGraphics();

            for (int i = 0; i < PointListf.Count; i++)
            {
                //画圆
                SolidBrush brush = new SolidBrush(ColorsListf[i]);
                Rectangle rect = new Rectangle((int)PointListf[i].X - SizeListf[i] / 2, (int)PointListf[i].Y - SizeListf[i] / 2
                    , SizeListf[i], SizeListf[i]);
                g.FillEllipse(brush, rect);
            }
        }

        private void ShowForm_Shown(object sender, EventArgs e)
        {
            draw();
        }

        private void ShowForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (statef)
            {
                case 3:
                    ColorsListf.Add(Color.Red);
                    SizeListf.Add(valuef);
                    PointListf.Add(new PointF(e.X, e.Y));
                    draw();
                    break;
                case 4:
                    ColorsListf.Add(Color.White);
                    SizeListf.Add(valuef);
                    PointListf.Add(new PointF(e.X, e.Y));
                    draw();
                    break;
            }
        }
    }
}

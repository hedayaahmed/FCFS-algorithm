using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS
{

    public partial class Form1 : Form
    {
        public class Cnode
        {
            public int count = 0;
            public int process;
            public int X, Y;
        }

        Bitmap Start_point;

        int x = 0;
        int y = 90;
        String Value;
        String[] Split;
        int numVal;
        int width = 430;
        int hight = 50;
        int result = 0;

        List<Cnode> L1 = new List<Cnode>();
        List<Cnode> L2 = new List<Cnode>();

        Cnode pnn, ptrav;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubbleBuffer(e.Graphics);
        }

        void DrawScene(Graphics g)
        {
            g.Clear(Color.SkyBlue);

            Color cl1 = Color.Blue;
            Color cl = Color.Red;

            Pen p = new Pen(Color.White, 4);
            Pen p1 = new Pen(Color.Black, 4);

            Font f = new System.Drawing.Font("System", 15);
            Font f2 = new System.Drawing.Font("System", 15);

            SolidBrush br = new SolidBrush(cl1);
            SolidBrush br1 = new SolidBrush(cl);

            for (int i = 0; i < L2.Count; i++)
            {
                ptrav = L2[i];
                g.DrawString("" + ptrav.process, f, Brushes.Black, ptrav.X, ptrav.Y);
                if (i == 0)
                {
                    g.DrawLine(p, 420, 85, 1130, 85);
                }

            }

            if (FCFS_Button.Checked == true)
            {
                if (L1.Count > 1)
                {
                    g.FillEllipse(Brushes.Yellow, x, y, 10, 10);

                    g.DrawLine(p1, x, y, L1[0].X, y + 30);

                    g.FillEllipse(Brushes.Yellow, L1[0].X, y + 30, 10, 10);

                    y += 30;
                }


                for (int i = 0; i < L1.Count; i++)
                {

                    ptrav = L1[i];

                    if (i < L1.Count - 1)
                    {
                        pnn = L1[i + 1];
                    }

                    g.FillEllipse(Brushes.Yellow, ptrav.X, y, 10, 10);

                    g.DrawLine(p1, ptrav.X, y, pnn.X, y + 30);

                    y += 30;
                }
            }


        }
        void DrawDubbleBuffer(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(Start_point);
            DrawScene(g2);
            g.DrawImage(Start_point, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start_point = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void RUN_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;

            L1 = new List<Cnode>();
            L2 = new List<Cnode>();

            x = 0;
            numVal = 0;
            result = 0;
            y = 90;

            Value = Array.Text;

            Split = Value.Split(' ');

            for (int i = 0; i < Split.Length; i++)
            {
                pnn = new Cnode();
                pnn.process = Int32.Parse(Split[i]);
                L1.Add(pnn);
            }

            numVal = Int32.Parse(Head_Starts.Text);


            for (int i = 0; i < L1.Count; i++)
            {
                ptrav = L1[i];
                pnn = new Cnode();
                pnn.process = ptrav.process;
                L2.Add(pnn);
            }

            pnn = new Cnode();
            pnn.process = numVal;
            L2.Add(pnn);

            pnn = new Cnode();
            pnn.process = 0;
            L2.Add(pnn);

            pnn = new Cnode();
            pnn.process = 199;
            L2.Add(pnn);


            for (int i = 0; i < L2.Count; i++)
            {
                for (int j = 0; j < L2.Count - 1; j++)
                {
                    if (L2[j].process > L2[j + 1].process)
                    {
                        int temp = L2[j].process;
                        L2[j].process = L2[j + 1].process;
                        L2[j + 1].process = temp;
                    }
                }
            }

            for (int i = 0; i < L2.Count; i++)
            {
                ptrav = L2[i];
                if (ptrav.process == numVal)
                {
                    x = width;
                }
                ptrav.X = width;
                ptrav.Y = hight;
                width += 50;

                ptrav.count = i;
            }

            for (int i = 0; i < L2.Count; i++)
            {
                pnn = L2[i];

                for (int j = 0; j < L1.Count; j++)
                {
                    ptrav = L1[j];

                    if (ptrav.process == pnn.process)
                    {
                        ptrav.X = pnn.X;
                        ptrav.Y = pnn.Y;
                    }
                }
            }

            ///////////////////////////////////////////////////Algorithm//////////////////////////////////////////////////////
            if (FCFS_Button.Checked == true)
            {

                for (int i = 0; i < L1.Count; i++)
                {
                    ptrav = L1[i];
                    if (i < L1.Count - 1)
                    {
                        pnn = L1[i + 1];
                    }
                    if (i == 0)
                    {
                        if (numVal >= L1[0].process)
                        {
                            result +=  (numVal - L1[0].process);
                        }
                        else
                        {
                            result +=  (L1[0].process - numVal);
                        }

                        if (ptrav.process >= pnn.process)
                        {
                            result += (ptrav.process - pnn.process);
                        }
                        else
                        {
                            result += (pnn.process - ptrav.process);
                        }
                    }
                    else
                    {
                        if (ptrav.process >= pnn.process)
                        {
                            result += (ptrav.process - pnn.process);
                        }
                        else
                        {
                            result += (pnn.process - ptrav.process);
                        }
                    }
                }
                textBox1.AppendText(" " + " " + " " + " " + "\n" + " " + " " + " " + " " + " " + " " + result);

            }

            DrawDubbleBuffer(this.CreateGraphics());
        }
    }
}

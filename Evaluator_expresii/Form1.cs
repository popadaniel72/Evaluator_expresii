using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluator_expresii
{
    
    

    public unsafe partial class Form1 : Form
    {
        unsafe class Nod
        {
            public char op;
            public int x;
            public Nod st;
            public Nod dr;
            public Nod(char o, int vx, Nod s, Nod d)
            {
                op = o; x = vx; st = s; dr = d;
            }
            public Nod()
            {
                op = ' '; x = 0; st = null; dr = null;
            }
        }       
        int nrm = 100, rx = 20, ry = 10, dx = 160, dy = 30;
        string[] atomi;
        string semne = "+-/%*()";
        int nrAtomi, poz;
        Nod rad;
        Graphics ptDesen;
        Pen cLinii;
        Font font = new Font("Arial", 12);

        SolidBrush culOp = new SolidBrush(Color.Red);
        SolidBrush culVal = new SolidBrush(Color.Blue);
        public Form1()
        {
            InitializeComponent();
            atomi = new string[nrm];
            nrAtomi = 0;
            dx = pentruDesen.Width / 4;
            ptDesen = pentruDesen.CreateGraphics();
            cLinii = new Pen(Color.Black,1);

        }
        private void atomizeaza(string s)
        {
            int i = 0;
            string at;
            nrAtomi = 0; poz = 1;
            while(i<s.Length)
            {
                if (semne.IndexOf(s[i]) != -1) atomi[++nrAtomi] = s[i++].ToString();
                else
                {
                    at = "";
                    while (i < s.Length && semne.IndexOf(s[i]) == -1)
                        at += s[i++].ToString();
                    atomi[++nrAtomi] = at;
                }

            }
        }
        Nod termen()
        {
            Nod b=null, c=null; char o;
            b = factor();
            while (atomi[poz] == "*" || atomi[poz] == "/" || atomi[poz] == "%")
            {
                o = atomi[poz][0];
                poz++;
                c = factor();
                b = new Nod(o, 0, b, c);
            }
            return b;
        }
        Nod factor()
        {
            Nod f=null; int x=0; 
            if(atomi[poz]=="(")
            {
                poz++;
                f = expresie();
                if (atomi[poz] != ")") MessageBox.Show("Lipseste )");
                poz++;
            }
            else
            {
                x = Convert.ToInt32(atomi[poz]);
                poz++;
                f = new Nod(' ', x, null, null);
            }
            return f;
        }
        Nod expresie()
        {
            Nod b, c; char o;
            b = termen();
            while(atomi[poz]=="+" || atomi[poz]=="-")
            {
                o = atomi[poz][0];
                poz++;
                c = termen();
                b = new Nod(o, 0, b, c);
            }
            return b;
        }
        void kaput(Nod x)
        {
            if(x!=null)
            {
                kaput(x.st);
                kaput(x.dr);
                x = null;
            }
        }
        void afis(Nod c, int n, int x, int y)
        {
            if (c == null) return;
            ptDesen.DrawEllipse(cLinii, x-rx, y, 2 * rx, 2 * ry);
            if (c.op != ' ') ptDesen.DrawString(c.op.ToString(), font,culOp , x- c.op.ToString().Length*4, y);
              else
                ptDesen.DrawString(c.x.ToString(), font, culOp, x - c.x.ToString().Length * 4, y);
            /// de scris in elipsa
            if (c.st!=null)
            {
                ptDesen.DrawLine(cLinii, x, y, x - dx / n, y + dy);
                afis(c.st, n + 1, x - dx / n, y + dy);
            }
            if(c.dr!=null)
            {
                ptDesen.DrawLine(cLinii, x, y, x + dx / n, y + dy);
                afis(c.dr, n + 1, x + dx / n, y + dy);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            atomizeaza(expr.Text);
            rad = null;
            rad = expresie();
            afis(rad, 1, pentruDesen.Width / 2, 2 * ry);
            lb.Items.Clear();
            for (int i = 1; i <= nrAtomi; i++)
                lb.Items.Add(atomi[i]);
        }
    }
}

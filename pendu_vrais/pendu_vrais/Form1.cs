using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pendu_vrais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<string> t = new List<string> { "manger", "donner", "acheter" };
        static List<string> t2 = new List<string> { "je vais manger" };
        List<char> tt = new List<char>();
        static int it = 0;
        static string aa=t[it];
        string aa2 = aa[0].ToString() + aa[aa.Length - 1];
        string aa3 = "";
        int faute = 0;
        int point = 0;
        int pp = 1;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

            tt.Add(aa[0]);
            for (int n = aa2.Length; n < aa.Length; n++)
            {
                aa3 = aa3 + "_";
                tt.Add('_');
            }
            tt.Add(aa[aa.Length - 1]);
            aa2 = aa[0] + aa3 + aa[aa.Length - 1];
            label1.Text = aa2;

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
            char l = char.Parse(textBox1.Text);
            string tien = "";
            string db = "";
            for (int i = 0; i < aa.Length; i++)
            {
                if (l == aa[i])
                {
                    tt.RemoveAt(i);
                    tt.Insert(i, l);
                    db = db + "_";
                }
                else
                {
                    db = db + aa[i];
                }
            }
            for(int i2 = 0; i2 < tt.Count; i2++)
            {
                tien = tien + tt[i2];
            }
            label1.Text = tien;
            Console.WriteLine(db);
            if (db == aa)
            {
                faute = faute + 1;
                MessageBox.Show(faute + " " + "faute");
            }
            if (faute > 4)
            {
                MessageBox.Show("perdu");
                label1.Text = "perdu";
                textBox1.Enabled = false;
                button3.Visible = true;
            }
            if (tien == aa)
            {
                point = point + 1;
            }
            if (point == pp)
            {
                MessageBox.Show("gagner");
                pp = pp + 1;
                tt.Clear();
                if (checkBox1.Checked)
                {
                    it = r.Next(t.Count);
                    aa = t[it];
                }
                else if(checkBox2.Checked){
                    it = r.Next(t2.Count);
                    aa = t2[it];
                }
                else
                {
                    it = r.Next(t.Count);
                    aa = t[it];
                }
                aa3 = "";
                aa2 = aa[0].ToString() + aa[aa.Length - 1];
                tt.Add(aa[0]);
                for (int n2 = aa2.Length; n2 < aa.Length; n2++)
                {
                    aa3 = aa3 + "_";
                    tt.Add('_');
                }
                tt.Add(aa[aa.Length - 1]);
                aa2 = aa[0] + aa3 + aa[aa.Length - 1];
                label1.Text = aa2;
            }
            textBox1.Clear();

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            tt.Clear();
           
            aa3 = "";
            if (checkBox1.Checked)
            {
                it = r.Next(t.Count);
                aa = t[it];
            }
            else if (checkBox2.Checked)
            {
                it = r.Next(t2.Count);
                aa = t2[it];
            }
            else
            {
                it = r.Next(t.Count);
                aa = t[it];
            }
            aa2 = aa[0].ToString() + aa[aa.Length - 1];
            tt.Add(aa[0]);
            for (int n2 = aa2.Length; n2 < aa.Length; n2++)
            {
                aa3 = aa3 + "_";
                tt.Add('_');
            }
            tt.Add(aa[aa.Length - 1]);
            aa2 = aa[0] + aa3 + aa[aa.Length - 1];
            label1.Text = aa2;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Enabled = true;
            button3.Visible = false;
            tt.Add(aa[0]);
            for (int n = aa2.Length; n < aa.Length; n++)
            {
                aa3 = aa3 + "_";
                tt.Add('_');
            }
            tt.Add(aa[aa.Length - 1]);
            aa2 = aa[0] + aa3 + aa[aa.Length - 1];
            label1.Text = aa2;

        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 rep =new Form2();
            rep.ShowDialog();
            t.Add(rep.rer);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

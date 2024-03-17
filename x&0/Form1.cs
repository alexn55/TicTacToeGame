using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xsi0
{
    public partial class Form1 : Form
    {
        int x, a, b;
        Button[,] matr = new Button[3, 3];

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        void init()
        {
            x = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    matr[i, j].Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void verifica()
        {
            if (matr[0, 0].Text == matr[1, 0].Text && matr[1, 0].Text == matr[2, 0].Text)
                if (matr[0, 0].Text == "X")
                {
                    a++;
                    label3.Text = a.ToString();
                    MessageBox.Show("Castiga player 1");
                    init();
                }
                else if (matr[0, 0].Text == "0")
                {
                    b++;
                    label4.Text = b.ToString();
                    MessageBox.Show("Castiga player 2");
                    init();
                }
            if (matr[0, 1].Text == matr[1, 1].Text && matr[1, 1].Text == matr[2, 1].Text)
                if (matr[0, 1].Text == "X")
                {
                    a++;
                    label3.Text = a.ToString();
                    MessageBox.Show("Castiga player 1");
                    init();
                }
                else if (matr[0, 1].Text == "0")
                {
                    b++;
                    label4.Text = b.ToString();
                    MessageBox.Show("Castiga player 2");
                    init();
                }
            if (matr[0, 2].Text == matr[1, 2].Text && matr[1, 2].Text == matr[2, 2].Text)
                if (matr[0, 2].Text == "X")
                {
                    a++;
                    label3.Text = a.ToString();
                    MessageBox.Show("Castiga player 1");
                    init();
                }
                else if (matr[0, 2].Text == "0")
                {
                    b++;
                    label4.Text = b.ToString();
                    MessageBox.Show("Castiga player 2");
                    init();
                }
            if (matr[0, 0].Text == matr[0, 1].Text && matr[0, 1].Text == matr[0, 2].Text)
                if (matr[0, 0].Text == "X")
                {
                    a++;
                    label3.Text = a.ToString();
                    MessageBox.Show("Castiga player 1");
                    init();
                }
                else if (matr[0, 0].Text == "0")
                {
                    b++;
                    label4.Text = b.ToString();
                    MessageBox.Show("Castiga player 2");
                    init();
                }
            if (matr[1, 0].Text == matr[1, 1].Text && matr[1, 1].Text == matr[1, 2].Text)
                if (matr[1, 0].Text == "X")
                {
                    a++;
                    label3.Text = a.ToString();
                    MessageBox.Show("Castiga player 1");
                    init();
                }
                else if (matr[1, 0].Text == "0")
                {
                    b++;
                    label4.Text = b.ToString();
                    MessageBox.Show("Castiga player 2");
                    init();
                }
            if (matr[2, 0].Text == matr[2, 1].Text && matr[2, 1].Text == matr[2, 2].Text)
                if (matr[2, 0].Text == "X")
                {
                    a++;
                    label3.Text = a.ToString();
                    MessageBox.Show("Castiga player 1");
                    init();
                }
                else if (matr[2, 0].Text == "0")
                {
                    b++;
                    label4.Text = b.ToString();
                    MessageBox.Show("Castiga player 2");
                    init();
                }
            if (matr[0, 0].Text == matr[1, 1].Text && matr[1, 1].Text == matr[2, 2].Text)
                if (matr[0, 0].Text == "X")
                {
                    a++;
                    label3.Text = a.ToString();
                    MessageBox.Show("Castiga player 1");
                    init();
                }
                else if (matr[0, 0].Text == "0")
                {
                    b++;
                    label4.Text = b.ToString();
                    MessageBox.Show("Castiga player 2");
                    init();
                }
            if (matr[2, 0].Text == matr[1, 1].Text && matr[1, 1].Text == matr[0, 2].Text)
                if (matr[2, 0].Text == "X")
                {
                    a++;
                    label3.Text = a.ToString();
                    MessageBox.Show("Castiga player 1");
                    init();
                }
                else if (matr[2, 0].Text == "0")
                {
                    b++;
                    label4.Text = b.ToString();
                    MessageBox.Show("Castiga player 2");
                    init();
                }
        }
        private void matr_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Name.ToString();
            bool sem = false;
            if (s.Equals("matr00"))
            {
                sem = true;
                if (x == 1)
                    matr[0, 0].Text = "X";
                else
                    matr[0, 0].Text = "0";
            }
            else
                if (s.Equals("matr10"))
            {
                if (matr[1, 0].Text == "")
                {
                    sem = true;
                    if (x == 1)
                        matr[1, 0].Text = "X";
                    else
                        matr[1, 0].Text = "0";
                }
            }
            else
                if (s.Equals("matr20"))
            {
                if (matr[2, 0].Text == "")
                {
                    sem = true;
                    if (x == 1) matr[2, 0].Text = "X";
                    else matr[2, 0].Text = "0";
                }
            }
            else
            if (s.Equals("matr01"))
            {
                if (matr[0, 1].Text == "")
                {
                    sem = true;
                    if (x == 1)
                        matr[0, 1].Text = "X";
                    else matr[0, 1].Text = "0";
                }
            }
            else
        if (s.Equals("matr11"))
            {
                if (matr[1, 1].Text == "")
                {
                    sem = true;
                    if (x == 1) matr[1, 1].Text = "X";
                    else matr[1, 1].Text = "0";
                }
            }
            else
                if (s.Equals("matr21"))
            {
                if (matr[2, 1].Text == "")
                {
                    sem = true;
                    if (x == 1) matr[2, 1].Text = "X";
                    else matr[2, 1].Text = "0";
                }
            }
            else
                if (s.Equals("matr02"))
            {
                if (matr[0, 2].Text == "")
                {
                    sem = true;
                    if (x == 1) matr[0, 2].Text = "X";
                    else matr[0, 2].Text = "0";
                }
            }
            else
                if (s.Equals("matr12"))
            {
                if (matr[1, 2].Text == "")
                {
                    sem = true;
                    if (x == 1) matr[1, 2].Text = "X";
                    else matr[1, 2].Text = "0";
                }
            }
            else
                if (s.Equals("matr22"))
            {
                if (matr[2, 2].Text == "")
                {
                    sem = true;
                    if (x == 1) matr[2, 2].Text = "X";
                    else matr[2, 2].Text = "0";
                }
            }
            if (sem == true)
            {
                x = x * (-1);
                verifica();
            }
        }
    
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                x = 1;
                a = 0;
                b = 0;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label3.Text = "0";
                label4.Text = "0";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matr[i, j] = new Button();
                        matr[i, j].Parent = this;
                        matr[i, j].Left = i * 70 + 70;
                        matr[i, j].Top = j * 70 + 70;
                        matr[i, j].Width = 70;
                        matr[i, j].Height = 70;
                        matr[i, j].BackColor = System.Drawing.Color.DarkCyan;
                        matr[i, j].FlatStyle = FlatStyle.Flat;
                        matr[i, j].FlatAppearance.BorderSize = 3;
                        matr[i, j].FlatAppearance.BorderColor = Color.Pink;
                        matr[i, j].ForeColor = System.Drawing.Color.Cyan;
                        matr[i, j].Font= new Font("Arial Black",24)  ;
                        matr[i, j].Text = "";
                        matr[i, j].Visible = true;
                        matr[i, j].Name = "matr" + i.ToString() + j.ToString();
                        matr[i, j].Click += new EventHandler(matr_Click);
                    }
                    button1.Enabled = false;
                }
            }
        }
    }


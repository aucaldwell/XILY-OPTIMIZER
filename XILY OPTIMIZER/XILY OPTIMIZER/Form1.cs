using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XILY_OPTIMIZER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Mov;
        int MovX, MovY;

        private void Form1_Load(object sender, EventArgs e)
        {

            panel10.Controls.Clear();
            Home page = new Home();
            page.MdiParent = this;
            panel10.Controls.Add(page);
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel10.Controls.Clear();
            Home page = new Home();
            page.MdiParent = this;
            panel10.Controls.Add(page);
            page.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            panel10.Controls.Clear();
            Download page = new Download();
            page.MdiParent = this;
            panel10.Controls.Add(page);
            page.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            panel10.Controls.Clear();
            Apps page = new Apps();
            page.MdiParent = this;
            panel10.Controls.Add(page);
            page.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {

            panel10.Controls.Clear();
            Clean_up page = new Clean_up();
            page.MdiParent = this;
            panel10.Controls.Add(page);
            page.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            Tweak page = new Tweak();
            page.MdiParent = this;
            panel10.Controls.Add(page);
            page.Show();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov==true)
            {
                this.Left = Cursor.Position.X - MovX;
                this.Top = Cursor.Position.Y - MovY;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
            MovX = 0;
            MovY = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = Cursor.Position.X - this.Left;
            MovY = Cursor.Position.Y - this.Top;
        }
    }
}

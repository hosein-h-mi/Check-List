using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasFBI
{
    public partial class EditTaskForm : Form
    {
        public EditTaskForm()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Width = 563;
            this.Height = 637;
        }

        Form1 form1;
        public string NewTitle { get; set; }
        public string NewAbout { get; set; }

        public EditTaskForm(string title, string about)
        {
            InitializeComponent();
            textBoxTitle.Text = title;
            textBoxAbout.Text = about;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            NewTitle = textBoxTitle.Text;
            NewAbout = textBoxAbout.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        int colortxt = 30;
        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            textBoxAbout.BackColor = Color.FromArgb(colortxt, colortxt, colortxt);
            textBoxTitle.BackColor = Color.FromArgb(colortxt, colortxt, colortxt);
        }
        int r = 255; int b = 0; int g = 0;
        int direction = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(r, g, b);
            switch (direction)
            {
                case 0: // سبز بالا، قرمز پایین
                    g++; r--;
                    if (g >= 255) direction = 1;
                    break;
                case 1: // آبی بالا، سبز پایین
                    b++; g--;
                    if (b >= 255) direction = 2;
                    break;
                case 2: // قرمز بالا، آبی پایین
                    r++; b--;
                    if (r >= 255) direction = 0;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

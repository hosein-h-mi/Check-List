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

    public partial class FrmAddTask : Form
    {
        public FrmAddTask()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Width = 563;
            this.Height = 637;
        }
        Form1 frm1;
        public FrmAddTask(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void FrmAddTask_Load(object sender, EventArgs e)
        {
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
                if (txtAout.Text == "" || txtTitle.Text == "")
                MessageBox.Show("Enter Title or About");
                frm1.AddingTask(txtTitle, txtAout);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) pnlOption.Visible = false;
            else pnlOption.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAout_TextChanged(object sender, EventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

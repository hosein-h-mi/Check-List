namespace TasFBI
{
    partial class FrmAddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAddTask = new Button();
            txtTitle = new TextBox();
            txtAout = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            datnow = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dattarget = new DateTimePicker();
            label5 = new Label();
            txtname = new TextBox();
            label6 = new Label();
            txtinformation = new TextBox();
            pnlOption = new Panel();
            button1 = new Button();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlOption.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(30, 30, 30);
            btnAddTask.FlatAppearance.BorderSize = 0;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.ForeColor = Color.FromArgb(0, 192, 0);
            btnAddTask.Location = new Point(126, 489);
            btnAddTask.Margin = new Padding(3, 4, 3, 4);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(276, 80);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = " Save";
            btnAddTask.TextAlign = ContentAlignment.TopCenter;
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(20, 20, 20);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(126, 147);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(276, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtAout
            // 
            txtAout.BackColor = Color.FromArgb(20, 20, 20);
            txtAout.BorderStyle = BorderStyle.FixedSingle;
            txtAout.ForeColor = Color.White;
            txtAout.Location = new Point(126, 199);
            txtAout.Margin = new Padding(3, 4, 3, 4);
            txtAout.Multiline = true;
            txtAout.Name = "txtAout";
            txtAout.Size = new Size(276, 273);
            txtAout.TabIndex = 3;
            txtAout.TextChanged += txtAout_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 139);
            label1.Name = "label1";
            label1.Size = new Size(61, 35);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 199);
            label2.Name = "label2";
            label2.Size = new Size(83, 35);
            label2.TabIndex = 5;
            label2.Text = "About";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(162, 229);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(138, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "advanced mode";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // datnow
            // 
            datnow.CalendarForeColor = Color.White;
            datnow.CalendarMonthBackground = Color.Black;
            datnow.CalendarTitleBackColor = Color.Black;
            datnow.CalendarTitleForeColor = Color.White;
            datnow.Location = new Point(239, 11);
            datnow.Margin = new Padding(3, 4, 3, 4);
            datnow.Name = "datnow";
            datnow.Size = new Size(276, 27);
            datnow.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(135, 27);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 8;
            label3.Text = "Time Now";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(125, 64);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 10;
            label4.Text = "Target Time";
            // 
            // dattarget
            // 
            dattarget.CalendarTitleBackColor = SystemColors.ControlText;
            dattarget.CalendarTitleForeColor = Color.White;
            dattarget.Location = new Point(239, 49);
            dattarget.Margin = new Padding(3, 4, 3, 4);
            dattarget.Name = "dattarget";
            dattarget.Size = new Size(276, 27);
            dattarget.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(105, 105);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 11;
            label5.Text = "Worker Name";
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(20, 20, 20);
            txtname.BorderStyle = BorderStyle.FixedSingle;
            txtname.ForeColor = Color.White;
            txtname.Location = new Point(239, 88);
            txtname.Margin = new Padding(3, 4, 3, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(276, 27);
            txtname.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(55, 195);
            label6.Name = "label6";
            label6.Size = new Size(192, 28);
            label6.TabIndex = 13;
            label6.Text = "Detailed explanation";
            label6.Click += label6_Click;
            // 
            // txtinformation
            // 
            txtinformation.BackColor = Color.FromArgb(20, 20, 20);
            txtinformation.BorderStyle = BorderStyle.FixedSingle;
            txtinformation.ForeColor = Color.White;
            txtinformation.Location = new Point(239, 127);
            txtinformation.Margin = new Padding(3, 4, 3, 4);
            txtinformation.Multiline = true;
            txtinformation.Name = "txtinformation";
            txtinformation.Size = new Size(276, 134);
            txtinformation.TabIndex = 14;
            // 
            // pnlOption
            // 
            pnlOption.BackColor = Color.Transparent;
            pnlOption.Controls.Add(dattarget);
            pnlOption.Controls.Add(txtinformation);
            pnlOption.Controls.Add(datnow);
            pnlOption.Controls.Add(label6);
            pnlOption.Controls.Add(label3);
            pnlOption.Controls.Add(txtname);
            pnlOption.Controls.Add(label5);
            pnlOption.Controls.Add(label4);
            pnlOption.Location = new Point(-10, 263);
            pnlOption.Margin = new Padding(3, 4, 3, 4);
            pnlOption.Name = "pnlOption";
            pnlOption.Size = new Size(795, 10);
            pnlOption.TabIndex = 15;
            pnlOption.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(440, 489);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(84, 80);
            button1.TabIndex = 16;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(162, 86);
            label7.Name = "label7";
            label7.Size = new Size(206, 44);
            label7.TabIndex = 17;
            label7.Text = "New Task";
            // 
            // FrmAddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(545, 590);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(pnlOption);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAout);
            Controls.Add(txtTitle);
            Controls.Add(btnAddTask);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAddTask";
            Text = "FrmAddTask";
            Load += FrmAddTask_Load;
            pnlOption.ResumeLayout(false);
            pnlOption.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTitle;
        private Button btnAddTask;
        private TextBox txtTitle;
        private TextBox txtAout;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private DateTimePicker datnow;
        private Label label3;
        private Label label4;
        private DateTimePicker dattarget;
        private Label label5;
        private TextBox txtname;
        private Label label6;
        private TextBox txtinformation;
        private Panel pnlOption;
        private Button button1;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}
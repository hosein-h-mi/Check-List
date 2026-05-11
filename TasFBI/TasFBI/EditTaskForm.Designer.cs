

namespace TasFBI
{
    partial class EditTaskForm
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
            textBoxTitle = new TextBox();
            textBoxAbout = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = Color.FromArgb(20, 20, 20);
            textBoxTitle.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitle.ForeColor = Color.White;
            textBoxTitle.Location = new Point(126, 147);
            textBoxTitle.Margin = new Padding(3, 4, 3, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(276, 27);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxAbout
            // 
            textBoxAbout.BackColor = Color.FromArgb(20, 20, 20);
            textBoxAbout.BorderStyle = BorderStyle.FixedSingle;
            textBoxAbout.ForeColor = Color.White;
            textBoxAbout.Location = new Point(126, 201);
            textBoxAbout.Margin = new Padding(3, 4, 3, 4);
            textBoxAbout.Multiline = true;
            textBoxAbout.Name = "textBoxAbout";
            textBoxAbout.Size = new Size(276, 273);
            textBoxAbout.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 147);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 2;
            label1.Text = "New Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 201);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 3;
            label2.Text = "New About";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(149, 9);
            label3.Name = "label3";
            label3.Size = new Size(253, 62);
            label3.TabIndex = 4;
            label3.Text = "MaHooApp";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(126, 489);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(276, 80);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 30, 30);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(440, 489);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(84, 80);
            button2.TabIndex = 6;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(162, 86);
            label7.Name = "label7";
            label7.Size = new Size(213, 44);
            label7.TabIndex = 18;
            label7.Text = "Edit Task";
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(545, 590);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAbout);
            Controls.Add(textBoxTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditTaskForm";
            Text = "EditTaskForm";
            Load += EditTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxAbout;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Label label7;
    }
}
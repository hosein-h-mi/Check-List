namespace TasFBI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnaddpage = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnRemovePage = new Button();
            btnnewtask = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            btnaddController = new Button();
            txttabname = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnaddpage
            // 
            btnaddpage.BackColor = Color.FromArgb(30, 30, 30);
            btnaddpage.FlatAppearance.BorderSize = 0;
            btnaddpage.FlatStyle = FlatStyle.Flat;
            btnaddpage.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddpage.ForeColor = Color.White;
            btnaddpage.Location = new Point(355, 177);
            btnaddpage.Margin = new Padding(3, 4, 3, 4);
            btnaddpage.Name = "btnaddpage";
            btnaddpage.Size = new Size(133, 47);
            btnaddpage.TabIndex = 1;
            btnaddpage.Text = "Add Page";
            btnaddpage.UseVisualStyleBackColor = false;
            btnaddpage.Click += btnaddpage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(759, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.Location = new Point(0, 35);
            label3.Name = "label3";
            label3.Size = new Size(294, 52);
            label3.TabIndex = 8;
            label3.Text = "CHECK LIST";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(315, 139);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(371, 107);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 10;
            label4.Text = "Page Name";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // btnRemovePage
            // 
            btnRemovePage.BackColor = Color.Maroon;
            btnRemovePage.FlatAppearance.BorderSize = 0;
            btnRemovePage.FlatStyle = FlatStyle.Flat;
            btnRemovePage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemovePage.ForeColor = Color.Red;
            btnRemovePage.ImageAlign = ContentAlignment.TopCenter;
            btnRemovePage.Location = new Point(536, 123);
            btnRemovePage.Margin = new Padding(3, 4, 3, 4);
            btnRemovePage.Name = "btnRemovePage";
            btnRemovePage.Size = new Size(99, 69);
            btnRemovePage.TabIndex = 13;
            btnRemovePage.Text = "Remove Page";
            btnRemovePage.TextAlign = ContentAlignment.TopCenter;
            btnRemovePage.UseVisualStyleBackColor = false;
            btnRemovePage.Click += btnRemovePage_Click;
            // 
            // btnnewtask
            // 
            btnnewtask.BackColor = Color.FromArgb(30, 30, 30);
            btnnewtask.BackgroundImageLayout = ImageLayout.Center;
            btnnewtask.FlatAppearance.BorderSize = 0;
            btnnewtask.FlatStyle = FlatStyle.Flat;
            btnnewtask.ForeColor = Color.White;
            btnnewtask.Location = new Point(181, 135);
            btnnewtask.Margin = new Padding(3, 4, 3, 4);
            btnnewtask.Name = "btnnewtask";
            btnnewtask.Size = new Size(128, 41);
            btnnewtask.TabIndex = 14;
            btnnewtask.Text = "NewTask";
            btnnewtask.UseVisualStyleBackColor = false;
            btnnewtask.Click += btnnewtask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 135);
            label1.Name = "label1";
            label1.Size = new Size(184, 41);
            label1.TabIndex = 15;
            label1.Text = "Creat Task : ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1002, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnaddController
            // 
            btnaddController.BackColor = Color.FromArgb(30, 30, 30);
            btnaddController.FlatAppearance.BorderSize = 0;
            btnaddController.FlatStyle = FlatStyle.Flat;
            btnaddController.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddController.ForeColor = Color.White;
            btnaddController.Location = new Point(714, 171);
            btnaddController.Margin = new Padding(3, 4, 3, 4);
            btnaddController.Name = "btnaddController";
            btnaddController.Size = new Size(133, 47);
            btnaddController.TabIndex = 17;
            btnaddController.Text = "Add Tab";
            btnaddController.UseVisualStyleBackColor = false;
            btnaddController.Click += btnaddController_Click;
            // 
            // txttabname
            // 
            txttabname.BackColor = Color.Black;
            txttabname.BorderStyle = BorderStyle.FixedSingle;
            txttabname.ForeColor = Color.White;
            txttabname.Location = new Point(679, 133);
            txttabname.Margin = new Padding(3, 4, 3, 4);
            txttabname.Name = "txttabname";
            txttabname.Size = new Size(213, 27);
            txttabname.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(735, 101);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 18;
            label2.Text = "Tab Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(898, 123);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(99, 69);
            button1.TabIndex = 20;
            button1.Text = "Remove Tab";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(1002, 805);
            Controls.Add(button1);
            Controls.Add(txttabname);
            Controls.Add(label2);
            Controls.Add(btnaddController);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnnewtask);
            Controls.Add(btnRemovePage);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnaddpage);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "CheckList";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnaddpage;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Button btnRemovePage;
        private Button btnnewtask;
        private Label label1;
        private MenuStrip menuStrip1;
        private Button btnaddController;
        private TextBox txttabname;
        private Label label2;
        private Button button1;
    }
}

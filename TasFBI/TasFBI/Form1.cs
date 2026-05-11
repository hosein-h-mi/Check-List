using System.Text.Json;

namespace TasFBI
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Width = 1020;
            this.Height = 852;
        }




        private void btnaddpage_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("نام پیج را وارد کنید");
                return;
            }
            else
            {
                string newPageTitle = textBox1.Text;
                TabPage newPage = new TabPage(newPageTitle);
                newPage.BackColor = Color.Black;
                newPage.ForeColor = Color.White;
                newPage.Text = newPageTitle;
                textBox1.Clear();
                FlowLayoutPanel todoPanel = new FlowLayoutPanel();
                todoPanel.Dock = DockStyle.Fill;
                todoPanel.AutoScroll = true;
                todoPanel.Name = "todoPanel";
                todoPanel.FlowDirection = FlowDirection.TopDown;
                todoPanel.WrapContents = false;
                newPage.Controls.Add(todoPanel);
                activeTabControl.TabPages.Add(newPage);
                activeTabControl.SelectedTab = newPage;
            }


        }

        public void AddingTask(TextBox title, TextBox About)
        {
            FlowLayoutPanel currentPanel = activeTabControl.SelectedTab.Controls.Find("todoPanel", true).FirstOrDefault() as FlowLayoutPanel;
            if (currentPanel != null && !string.IsNullOrWhiteSpace(title.Text))
            {
                // فراخوانی متد ساخت تسک
                AddTaskToPanel(currentPanel, title.Text, About.Text);
                title.Clear();
                About.Clear();
            }
        }
        private void AddTaskToPanel(FlowLayoutPanel panel, string title, string about)
        {
            Panel taskContainer = new Panel();
            taskContainer.Size = new Size(this.Width - 40, 80);
            taskContainer.BorderStyle = BorderStyle.FixedSingle;
            taskContainer.Margin = new Padding(5);
            taskContainer.RightToLeft = RightToLeft.Yes;
            CheckBox chk = new CheckBox();
            chk.Text = title;
            chk.Location = new Point(10, 5);
            chk.AutoSize = true;
            chk.Font = new Font(chk.Font, FontStyle.Bold);
            Label lblAbout = new Label();
            lblAbout.Text = "توضیحات: " + about;
            lblAbout.Location = new Point(25, 30);
            lblAbout.Size = new Size(500, 30);
            lblAbout.AutoSize = true;
            lblAbout.ForeColor = Color.LightGray;
            taskContainer.AutoSize = true;
            lblAbout.Location = new Point(200, 30);
            Button btnDelete = new Button();
            btnDelete.Text = "حذف";
            btnDelete.Size = new Size(60, 30);
            btnDelete.Location = new Point(taskContainer.Width - 70, 5);
            btnDelete.Click += (s, e) =>
            {
                panel.Controls.Remove(taskContainer);
            };
            Button btnEdit = new Button();
            btnEdit.Text = "ویرایش";
            btnEdit.Size = new Size(60, 30);
            btnEdit.Location = new Point(taskContainer.Width - 140, 5);
            btnEdit.Click += (s, e) =>
            {
                EditTaskForm editForm = new EditTaskForm(chk.Text, lblAbout.Text.Replace("توضیحات: ", ""));
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    chk.Text = editForm.NewTitle;
                    lblAbout.Text = "توضیحات: " + editForm.NewAbout;
                }
            };
            taskContainer.Controls.Add(chk);
            taskContainer.Controls.Add(lblAbout); // اضافه کردن لیبل به پنل
            taskContainer.Controls.Add(btnDelete);
            taskContainer.Controls.Add(btnEdit);
            panel.Controls.Add(taskContainer);
        }
        public void AddingTask_Pro(TextBox title, TextBox About, string timeNow, string TargetTime, string WorkerName, string information)
        {
            // FlowLayoutPanel currentPanel = tabControl1.SelectedTab.Controls.Find("todoPanel", true).FirstOrDefault() as FlowLayoutPanel;
            if (activeTabControl != null && !string.IsNullOrWhiteSpace(title.Text))
            {
                // فراخوانی متد ساخت تسک
                //  AddTaskToPanel_Pro(currentPanel, title.Text, About.Text, timeNow, TargetTime, WorkerName, information);
                title.Clear();
                About.Clear();
            }
        }
        private void AddTaskToPanel_Pro(FlowLayoutPanel panel, string title, string about, string timeNow, string TargetTime, string WorkerName, string information)
        {
            Panel taskContainer = new Panel();
            taskContainer.Size = new Size(panel.Width - 30, 80); // کمی ارتفاع را بیشتر کردیم (مثلاً ۸۰)
            taskContainer.BorderStyle = BorderStyle.FixedSingle;
            taskContainer.Margin = new Padding(5);
            taskContainer.RightToLeft = RightToLeft.Yes;
            CheckBox chk = new CheckBox();
            chk.Text = title;
            chk.Location = new Point(10, 5);
            chk.AutoSize = true;
            chk.Font = new Font(chk.Font, FontStyle.Bold); // عنوان را بولد کنیم
            Label lblAbout = new Label();
            lblAbout.Text = "توضیحات: " + about;
            lblAbout.Location = new Point(-15, 15); // کمی پایین‌تر از تایتل
            lblAbout.Size = new Size(500, 30); // سایز مناسب برای متن
            lblAbout.ForeColor = Color.LightGray;
            Button btnDelete = new Button();
            btnDelete.Text = "حذف";
            btnDelete.Size = new Size(60, 30);
            btnDelete.Location = new Point(taskContainer.Width - 70, 5);
            btnDelete.Click += (s, e) =>
            {
                panel.Controls.Remove(taskContainer);
            };

            Button btnEdit = new Button();
            btnEdit.Text = "ویرایش";
            btnEdit.Size = new Size(60, 30);
            btnEdit.Location = new Point(taskContainer.Width - 140, 5);
            btnEdit.Click += (s, e) =>
            {
                EditTaskForm editForm = new EditTaskForm(chk.Text, lblAbout.Text.Replace("توضیحات: ", ""));
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    chk.Text = editForm.NewTitle;
                    lblAbout.Text = "توضیحات: " + editForm.NewAbout;
                }
            };
            Button btnInformation = new Button();
            btnInformation.Text = "اطلاعات";
            btnInformation.Size = new Size(70, 30);
            btnInformation.TextAlign = ContentAlignment.MiddleCenter;
            btnInformation.Location = new Point(taskContainer.Width - 220, 5);
            btnInformation.Click += (s, e) =>
            {
                MessageBox.Show("when it was : " + timeNow + "\n" + "Target time : " + TargetTime + "\n" + "Worker Name : "
                    + WorkerName + "\n" + "Additional information : " + information, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            taskContainer.Controls.Add(chk);
            taskContainer.Controls.Add(btnInformation);
            taskContainer.Controls.Add(lblAbout); // اضافه کردن لیبل به پنل
            taskContainer.Controls.Add(btnDelete);
            taskContainer.Controls.Add(btnEdit);
            panel.Controls.Add(taskContainer);
        }
        public class TodoPageData
        {
            public string PageTitle { get; set; }
            public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        }

        public class TaskItem
        {
            public string Title { get; set; }
            public string About { get; set; }
            public bool IsChecked { get; set; }
        }


        public class SaveFileModel
        {
            public List<SavedTabControl> TabControls { get; set; } = new List<SavedTabControl>();
        }

        public class SavedTabControl
        {
            public string TabControlName { get; set; }
            public string MenuItemText { get; set; } // اسم منو که به این تب ربط دارد
            public List<TodoPageData> Pages { get; set; } = new List<TodoPageData>();
        }

        private void SaveAllTabs()
        {
            SaveFileModel fileModel = new SaveFileModel();
            for (int i = 0; i < tblist.Count; i++)
            {
                TabControl tbc = tblist[i];
                ToolStripMenuItem menuItem = menuStrip1.Items[i] as ToolStripMenuItem;
                SavedTabControl saved = new SavedTabControl
                {
                    TabControlName = tbc.Name,
                    MenuItemText = menuItem.Text
                };
                foreach (TabPage tab in tbc.TabPages)
                {
                    TodoPageData pageData = new TodoPageData { PageTitle = tab.Text };

                    FlowLayoutPanel pnl = tab.Controls.Find("todoPanel", true).FirstOrDefault() as FlowLayoutPanel;

                    if (pnl != null)
                    {
                        foreach (Panel taskPnl in pnl.Controls)
                        {
                            var chk = taskPnl.Controls.OfType<CheckBox>().FirstOrDefault();
                            var lbl = taskPnl.Controls.OfType<Label>().FirstOrDefault();
                            if (chk != null && lbl != null)
                            {
                                pageData.Tasks.Add(new TaskItem
                                {
                                    Title = chk.Text,
                                    About = lbl.Text.Replace("توضیحات: ", ""),
                                    IsChecked = chk.Checked
                                });
                            }
                        }
                        saved.Pages.Add(pageData);
                    }
                }

                fileModel.TabControls.Add(saved);
            }
            string json = JsonSerializer.Serialize(fileModel, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("data.json", json);
            MessageBox.Show("همه چیز ذخیره شد!");
        }
        private void LoadAllTabs()
        {
            if (!File.Exists("data.json")) return;
            string json = File.ReadAllText("data.json");
            var fileModel = JsonSerializer.Deserialize<SaveFileModel>(json);
            menuStrip1.Items.Clear();
            foreach (var tbc in tblist)
                this.Controls.Remove(tbc);
            tblist.Clear();
            activeTabControl = null;
            foreach (var saved in fileModel.TabControls)
            {
               var menuItem = new ToolStripMenuItem(saved.MenuItemText);
                menuItem.ForeColor = Color.White;
                menuStrip1.Items.Add(menuItem);
                TabControl tbc = new TabControl();
                tbc.Name = saved.TabControlName;
                tbc.Dock = DockStyle.Bottom;
                tbc.Location = new Point(684, 110);
                tbc.Size = new Size(250, 450);
                tbc.Visible = false;
                                this.Controls.Add(tbc);
                tblist.Add(tbc);
                int index = tblist.Count - 1;
                menuItem.Click += (s, ev) =>
                {
                    foreach (var x in tblist)
                        x.Visible = false;

                    tbc.Visible = true;
                    activeTabControl = tbc;
                };
                foreach (var pageData in saved.Pages)
                {
                    TabPage newPage = new TabPage(pageData.PageTitle);
                    newPage.BackColor = Color.Black;
                    newPage.ForeColor = Color.White;

                    FlowLayoutPanel todoPanel = new FlowLayoutPanel();
                    todoPanel.Dock = DockStyle.Fill;
                    todoPanel.AutoScroll = true;
                    todoPanel.Name = "todoPanel";
                    todoPanel.FlowDirection = FlowDirection.TopDown;
                    todoPanel.WrapContents = false;

                    newPage.Controls.Add(todoPanel);
                    tbc.TabPages.Add(newPage);

                    foreach (var t in pageData.Tasks)
                    {

                        AddTaskToPanel(todoPanel, t.Title, t.About);
                        // پیدا کردن چک‌باکس آخر و تنظیم وضعیت
                        CheckBox chk = todoPanel.Controls[todoPanel.Controls.Count - 1].Controls.OfType<CheckBox>().First();
                        chk.Checked = t.IsChecked;
                    }
                    //    LoadAllTabse();
                }
            }
            if (tblist.Count > 0)
            {
                tblist[0].Visible = true;
                activeTabControl = tblist[0];
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAllTabs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(this.Width - 1020, this.Height - 717);
            btnnewtask.Location = new Point(this.Width - 840, this.Height - 717);
            LoadAllTabs();
            btnnewtask.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void btnRemovePage_Click(object sender, EventArgs e)
        {
            if (activeTabControl.TabPages.Count != 0)
                activeTabControl.TabPages.Remove(activeTabControl.SelectedTab);
            else MessageBox.Show("Dont Page Selcted");

        }

        private void btnnewtask_Click(object sender, EventArgs e)
        {

            if (activeTabControl.TabPages.Count > 0)
            {
                FrmAddTask frmAddTask = new FrmAddTask(this);
                frmAddTask.Show();
            }
            else
            {
                MessageBox.Show("Enter One Page");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public List<TabControl> tblist = new List<TabControl>();

        public TabControl activeTabControl = null;
        private void btnaddController_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttabname.Text))
            {
                MessageBox.Show("Enter the tab Name");
                return;
            }

            // اگر قبلاً آیتم‌ها هستن، فقط همه تب‌ها رو مخفی کن (نه حذف)
            for (int i = 0; i < tblist.Count; i++)
                tblist[i].Visible = false;

            // آیتم منوی جدید بساز
            var item = new ToolStripMenuItem(txttabname.Text);
            item.ForeColor = Color.White;
            menuStrip1.Items.Add(item);

            // TabControl جدید بساز
            TabControl tbc = new TabControl();
            tbc.Location = new Point(684, 110);
            tbc.Size = new Size(250, 450);
            tbc.Dock = DockStyle.Bottom;
            tbc.Name = txttabname.Text;
            tbc.Visible = true;

            this.Controls.Add(tbc);
            tblist.Add(tbc);
            activeTabControl = tbc;

            // این آیتم منو را به یک کلیک وصل کن
            // اندیس آیتم در tblist همان ترتیب اضافه شدن است
            int index = tblist.Count - 1;

            item.Click += (s, ev) =>
            {
                // همه را خاموش کن
                for (int j = 0; j < tblist.Count; j++)
                    tblist[j].Visible = false;

                // فقط همون یکی روشن
                tblist[index].Visible = true;
            };

            txttabname.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeTabControl == null)
            {
                MessageBox.Show("هیچ تب فعالی برای حذف وجود ندارد.");
                return;
            }

            // پیدا کردن ایندکس تب فعال در لیست
            int index = tblist.IndexOf(activeTabControl);
            if (index < 0)
            {  
                MessageBox.Show("تب فعال در لیست یافت نشد!");
                return;
            }

            // تأیید از کاربر (اختیاری)
            var result = MessageBox.Show("Remove Tab " + activeTabControl.Name + " ?",  "Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            // حذف آیتم منوی مربوط به تب
            if (index < menuStrip1.Items.Count)
                menuStrip1.Items.RemoveAt(index);

            // حذف کنترل از فرم
            this.Controls.Remove(activeTabControl);

            // حذف از لیست
            tblist.RemoveAt(index);

            // برو روی تب بعدی (در صورت وجود)
            if (tblist.Count > 0)
            {
                activeTabControl = tblist[Math.Max(0, index - 1)];
                activeTabControl.Visible = true;
            }
            else
            {
                activeTabControl = null;
            }


        }
    }


}




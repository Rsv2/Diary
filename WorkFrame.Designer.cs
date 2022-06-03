namespace Daily_Planner
{
    partial class WorkFrame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.files = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.appendFile = new System.Windows.Forms.ToolStripMenuItem();
            this.importByDates = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewNote = new System.Windows.Forms.ToolStripMenuItem();
            this.toSort = new System.Windows.Forms.ToolStripMenuItem();
            this.byDates = new System.Windows.Forms.ToolStripMenuItem();
            this.byNames = new System.Windows.Forms.ToolStripMenuItem();
            this.allDates = new System.Windows.Forms.ToolStripMenuItem();
            this.StartDate = new System.Windows.Forms.ToolStripComboBox();
            this.EndDate = new System.Windows.Forms.ToolStripComboBox();
            this.searchText = new System.Windows.Forms.ToolStripTextBox();
            this.getFindOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.panelView = new System.Windows.Forms.Panel();
            this.importPanel = new System.Windows.Forms.Panel();
            this.importOut = new System.Windows.Forms.ComboBox();
            this.importBtn = new System.Windows.Forms.Button();
            this.importIn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MesNum = new System.Windows.Forms.Label();
            this.searchingOptions = new System.Windows.Forms.CheckedListBox();
            this.helpbox = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.importPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.files,
            this.AddNewNote,
            this.toSort,
            this.allDates,
            this.searchText,
            this.getFindOptions,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // files
            // 
            this.files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewFile,
            this.loadFile,
            this.appendFile,
            this.importByDates,
            this.saveToFile,
            this.saveVisible});
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(48, 23);
            this.files.Text = "Файл";
            // 
            // CreateNewFile
            // 
            this.CreateNewFile.Name = "CreateNewFile";
            this.CreateNewFile.Size = new System.Drawing.Size(234, 22);
            this.CreateNewFile.Text = "Новый файл";
            this.CreateNewFile.Click += new System.EventHandler(this.CreateNewList);
            // 
            // loadFile
            // 
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(234, 22);
            this.loadFile.Text = "Загрузить файл";
            this.loadFile.Click += new System.EventHandler(this.LoadFullFile);
            // 
            // appendFile
            // 
            this.appendFile.Name = "appendFile";
            this.appendFile.Size = new System.Drawing.Size(234, 22);
            this.appendFile.Text = "Догрузить файл";
            this.appendFile.Click += new System.EventHandler(this.AppendFile);
            // 
            // importByDates
            // 
            this.importByDates.Name = "importByDates";
            this.importByDates.Size = new System.Drawing.Size(234, 22);
            this.importByDates.Text = "Импорт по датам";
            this.importByDates.Click += new System.EventHandler(this.ImportFromFile);
            // 
            // saveToFile
            // 
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(234, 22);
            this.saveToFile.Text = "Сохранить всё";
            this.saveToFile.Visible = false;
            this.saveToFile.Click += new System.EventHandler(this.SaveToFileAll);
            // 
            // saveVisible
            // 
            this.saveVisible.Name = "saveVisible";
            this.saveVisible.Size = new System.Drawing.Size(234, 22);
            this.saveVisible.Text = "Сохранить данные на экране";
            this.saveVisible.Visible = false;
            this.saveVisible.Click += new System.EventHandler(this.SaveVisibleData);
            // 
            // AddNewNote
            // 
            this.AddNewNote.Name = "AddNewNote";
            this.AddNewNote.Size = new System.Drawing.Size(111, 23);
            this.AddNewNote.Text = "Добавить запись";
            this.AddNewNote.Click += new System.EventHandler(this.AddNewMessage);
            // 
            // toSort
            // 
            this.toSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byDates,
            this.byNames});
            this.toSort.Name = "toSort";
            this.toSort.Size = new System.Drawing.Size(90, 23);
            this.toSort.Text = "Сортировать";
            // 
            // byDates
            // 
            this.byDates.Name = "byDates";
            this.byDates.Size = new System.Drawing.Size(179, 22);
            this.byDates.Text = "По дате изменения";
            this.byDates.Click += new System.EventHandler(this.SortByDates);
            // 
            // byNames
            // 
            this.byNames.Name = "byNames";
            this.byNames.Size = new System.Drawing.Size(179, 22);
            this.byNames.Text = "По имени";
            this.byNames.Click += new System.EventHandler(this.SortByNames);
            // 
            // allDates
            // 
            this.allDates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartDate,
            this.EndDate});
            this.allDates.Name = "allDates";
            this.allDates.Size = new System.Drawing.Size(92, 23);
            this.allDates.Text = "Диапазон дат";
            this.allDates.Click += new System.EventHandler(this.CreateSortDatesMassive);
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = false;
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(150, 23);
            this.StartDate.SelectedIndexChanged += new System.EventHandler(this.StartDateChanged);
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = false;
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(150, 23);
            this.EndDate.SelectedIndexChanged += new System.EventHandler(this.EndDateChanged);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(200, 23);
            this.searchText.TextChanged += new System.EventHandler(this.LookingForText);
            // 
            // getFindOptions
            // 
            this.getFindOptions.Name = "getFindOptions";
            this.getFindOptions.Size = new System.Drawing.Size(121, 23);
            this.getFindOptions.Text = "Настройки поиска";
            this.getFindOptions.Click += new System.EventHandler(this.ShowOptions);
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(24, 23);
            this.help.Text = "?";
            this.help.ToolTipText = "Помощь";
            this.help.MouseEnter += new System.EventHandler(this.ShowHelp);
            this.help.MouseLeave += new System.EventHandler(this.HideHelp);
            // 
            // panelView
            // 
            this.panelView.AutoScroll = true;
            this.panelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 27);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(824, 576);
            this.panelView.TabIndex = 1;
            // 
            // importPanel
            // 
            this.importPanel.BackColor = System.Drawing.SystemColors.Info;
            this.importPanel.Controls.Add(this.importOut);
            this.importPanel.Controls.Add(this.importBtn);
            this.importPanel.Controls.Add(this.importIn);
            this.importPanel.Controls.Add(this.label1);
            this.importPanel.Location = new System.Drawing.Point(140, 149);
            this.importPanel.Name = "importPanel";
            this.importPanel.Size = new System.Drawing.Size(520, 153);
            this.importPanel.TabIndex = 2;
            this.importPanel.Visible = false;
            // 
            // importOut
            // 
            this.importOut.FormattingEnabled = true;
            this.importOut.Location = new System.Drawing.Point(271, 66);
            this.importOut.Name = "importOut";
            this.importOut.Size = new System.Drawing.Size(165, 21);
            this.importOut.TabIndex = 3;
            this.importOut.SelectedIndexChanged += new System.EventHandler(this.EndImportChange);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(223, 107);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 23);
            this.importBtn.TabIndex = 1;
            this.importBtn.Text = "Импорт";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.ImportStart);
            // 
            // importIn
            // 
            this.importIn.FormattingEnabled = true;
            this.importIn.Location = new System.Drawing.Point(85, 66);
            this.importIn.Name = "importIn";
            this.importIn.Size = new System.Drawing.Size(165, 21);
            this.importIn.TabIndex = 2;
            this.importIn.SelectedIndexChanged += new System.EventHandler(this.StartImportChange);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите диапазон дат импортируемого файла\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MesNum
            // 
            this.MesNum.AutoSize = true;
            this.MesNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MesNum.Location = new System.Drawing.Point(699, 4);
            this.MesNum.Name = "MesNum";
            this.MesNum.Size = new System.Drawing.Size(63, 17);
            this.MesNum.TabIndex = 3;
            this.MesNum.Text = "Записей: ";
            // 
            // searchingOptions
            // 
            this.searchingOptions.FormattingEnabled = true;
            this.searchingOptions.Items.AddRange(new object[] {
            "Искать в именах",
            "Искать в логинах",
            "Искать в паролях",
            "Искать в ссылках",
            "Искать в примечаниях",
            "Учитывать регистр"});
            this.searchingOptions.Location = new System.Drawing.Point(555, 30);
            this.searchingOptions.Name = "searchingOptions";
            this.searchingOptions.Size = new System.Drawing.Size(150, 106);
            this.searchingOptions.TabIndex = 0;
            this.searchingOptions.Visible = false;
            // 
            // helpbox
            // 
            this.helpbox.AutoSize = true;
            this.helpbox.BackColor = System.Drawing.SystemColors.Info;
            this.helpbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpbox.Location = new System.Drawing.Point(315, 32);
            this.helpbox.Name = "helpbox";
            this.helpbox.Size = new System.Drawing.Size(503, 63);
            this.helpbox.TabIndex = 0;
            this.helpbox.Text = "Редактирование записи - ПКМ на поле или кнопке перехода на сайт.\r\nЗавершение реда" +
    "ктирования - Двойной клик на поле или *Enter.\r\n*Кроме примечаний.";
            this.helpbox.Visible = false;
            // 
            // WorkFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 603);
            this.Controls.Add(this.helpbox);
            this.Controls.Add(this.searchingOptions);
            this.Controls.Add(this.MesNum);
            this.Controls.Add(this.importPanel);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkFrame";
            this.Text = "Ежедневник";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.importPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem files;
        private System.Windows.Forms.ToolStripMenuItem loadFile;
        private System.Windows.Forms.ToolStripMenuItem appendFile;
        private System.Windows.Forms.ToolStripMenuItem importByDates;
        private System.Windows.Forms.ToolStripMenuItem saveToFile;
        private System.Windows.Forms.ToolStripMenuItem AddNewNote;
        public System.Windows.Forms.Panel panelView;
        public System.Windows.Forms.Panel importPanel;
        private System.Windows.Forms.ComboBox importOut;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.ComboBox importIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem CreateNewFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toSort;
        private System.Windows.Forms.ToolStripMenuItem byDates;
        private System.Windows.Forms.ToolStripMenuItem byNames;
        private System.Windows.Forms.ToolStripMenuItem allDates;
        private System.Windows.Forms.ToolStripComboBox StartDate;
        private System.Windows.Forms.ToolStripComboBox EndDate;
        private System.Windows.Forms.Label MesNum;
        private System.Windows.Forms.ToolStripTextBox searchText;
        private System.Windows.Forms.ToolStripMenuItem getFindOptions;
        private System.Windows.Forms.CheckedListBox searchingOptions;
        private System.Windows.Forms.ToolStripMenuItem saveVisible;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.Label helpbox;
    }
}


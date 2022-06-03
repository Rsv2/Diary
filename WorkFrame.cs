using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Daily_Planner
{
    public partial class WorkFrame : Form
    {
        #region Глобальные переменные.
        SitesData sites = new SitesData();
        List<SitesData> sitesData = new List<SitesData>();
        List<SitesData> tempsitesData = new List<SitesData>();
        List<SitesData> saveData = new List<SitesData>();
        List<string> ComboDates = new List<string>();
        List<string> ImportDates = new List<string>();
        List<string> ComboNames = new List<string>();
        Template InPanMessage = new Template();
        List<Template> InPanArray = new List<Template>();
        bool SaveAll = true;
        int VisibleMesseges = 0;
        int ShowType = 0;
        int TempFirstIndex = 0;
        int ImportFirstIndex = 0;
        bool ByDates = true;
        bool ByNames = true;
        int sd = 0;
        int DateIn = 0;
        int DateOut = 0;
        int ImportDateIn = 0;
        int ImportDateOut = 0;
        bool ComboFlag = false;
        bool ImportFlag = false;
        bool Import = false;
        #endregion

        /// <summary>
        /// Монтажный кадр, инициализация формы.
        /// </summary>
        public WorkFrame()
        {
            InitializeComponent();
            MesNum.Text = $"Записей: {GetVisibleMessagesCount()} из {sitesData.Count}";
            searchingOptions.SetItemChecked(0, true);
            searchingOptions.SetItemChecked(1, true);
            searchingOptions.SetItemChecked(2, true);
            searchingOptions.SetItemChecked(3, true);
            searchingOptions.SetItemChecked(4, true);
        }

        #region Методы обработки и вывода данных на экран.
        /// <summary>
        /// Добавление новой записи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewMessage(object sender, EventArgs e)
        {
            InPanMessage = new Template();
            InPanMessage.TopLevel = false;
            InPanMessage.siteName.TextChanged += new EventHandler(MessageChanged);
            InPanMessage.login.TextChanged += new EventHandler(MessageChanged);
            InPanMessage.password.TextChanged += new EventHandler(MessageChanged);
            InPanMessage.editLink.MouseDoubleClick += new MouseEventHandler(MessageChangedClick);
            InPanMessage.editLink.KeyPress += new KeyPressEventHandler(MessageChangedEnter);
            InPanMessage.notes.TextChanged += new EventHandler(MessageChanged);
            DateTime CurDate = new DateTime();
            CurDate = DateTime.Now;
            string formatDays = "yyyy/MM/dd";
            string formatHours = "HH:mm:ss";
            InPanMessage.addeddate.Text = CurDate.ToString(formatDays);
            InPanMessage.addedtime.Text = CurDate.ToString(formatHours);
            panelView.SuspendLayout();
            InPanArray.Add(InPanMessage);
            panelView.Controls.Add(InPanArray[InPanArray.Count - 1]);
            panelView.ResumeLayout();
            MessageChanges();
            ByDates = false;
            ShowType = 0;
            DateOut = sitesData.Count - 1;
            DateIn = 0;
            UpdateMassive();
            EndDate.SelectedIndex = DateOut;
            StartDate.SelectedIndex = 0;
            ShowListData();
            saveToFile.Visible = true;
            saveVisible.Visible = true;
        }
        /// <summary>
        /// Удалить текущий и создать новый файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewList(object sender, EventArgs e)
        {
            ClearPanel();
            sitesData.Clear();
            ComboFlag = false;
            StartDate.Items.Clear();
            StartDate.SelectedIndex = -1;
            StartDate.DropDownHeight = 106;
            StartDate.Text = "";
            EndDate.Items.Clear();
            EndDate.SelectedIndex = -1;
            EndDate.DropDownHeight = 106;
            EndDate.Text = "";
            DateIn = 0;
            DateOut = 0;
            saveToFile.Visible = false;
            saveVisible.Visible = false;
            MessageChanges();
        }
        /// <summary>
        /// Переход на MessageChanged при изменении поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageChanged(object sender, EventArgs e)
        {
            Control[] notesAr = panelView.Controls.Find("notes", true);
            for (int i = 0; i < InPanArray.Count; i++)
            {                
                if (notesAr[i].Text == "Jjwy389KIUJOIuw23789IKUH2iohj8Oklw21")
                {
                    InPanArray[i].siteName.TextChanged -= new EventHandler(MessageChanged);
                    InPanArray[i].login.TextChanged -= new EventHandler(MessageChanged);
                    InPanArray[i].password.TextChanged -= new EventHandler(MessageChanged);
                    InPanArray[i].editLink.MouseDoubleClick -= new MouseEventHandler(MessageChangedClick);
                    InPanArray[i].editLink.KeyPress -= new KeyPressEventHandler(MessageChangedEnter);
                    InPanArray[i].notes.TextChanged -= new EventHandler(MessageChanged);
                    InPanArray[i].siteName.Text = "Delete";
                    notesAr[i].Text = "Delete";
                    InPanArray.RemoveAt(i);
                }
            }
            MessageChanges();
            if (sitesData.Count != 0)
            {
                UpdateMassive();
                ShowListData();
            }
            else
            {
                DateIn = -1;
                DateOut = -1;
                ComboFlag = false;
                StartDate.SelectedIndex = -1;
                EndDate.SelectedIndex = -1;
                ComboFlag = true;
                StartDate.Items.Clear();
                EndDate.Items.Clear();
                ClearPanel();
                saveToFile.Visible = false;
                saveVisible.Visible = false;
            }
            MesNum.Text = $"Записей: {GetVisibleMessagesCount()} из {sitesData.Count}";
        }
        /// <summary>
        /// Переход на MessageChanged по двойному клику.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageChangedClick(object sender, MouseEventArgs e)
        {
            MessageChanges();
        }
        /// <summary>
        /// Переход на MessageChanged по нажатию Enter.
        /// </summary>
        /// <param name="e"></param>
        private void MessageChangedEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                MessageChanges();                
            }
        }
        /// <summary>
        /// Запись данных из панели в массив структур.
        /// </summary>
        private void MessageChanges()
        {
            sitesData.Clear();
            for (int i = 0; i < InPanArray.Count; i++)
            {
                sites.Date = InPanArray[i].addeddate.Text;
                sites.Time = InPanArray[i].addedtime.Text;
                sites.Site = InPanArray[i].siteName.Text;
                sites.Login = InPanArray[i].login.Text;
                sites.Pass = InPanArray[i].password.Text;
                sites.Notes = InPanArray[i].notes.Text;
                sites.Link = InPanArray[i].linklable.Text;
                sitesData.Add(sites);
            }
            MesNum.Text = $"Записей: {GetVisibleMessagesCount()} из {sitesData.Count}";
        }
        /// <summary>
        /// Вывод данных на экран после загрузки.
        /// </summary>
        private void ShowSitesData()
        {
            ComboFlag = false;
            ComboDates.Clear();
            ComboNames.Clear();
            for (int i = 0; i < sitesData.Count; i++)
            {
                ComboDates.Add(sitesData[i].Date + " | " + sitesData[i].Time);
                ComboNames.Add(sitesData[i].Site);
            }
            ComboDates.Sort();
            ComboNames.Sort();
            StartDate.Items.Clear();
            EndDate.Items.Clear();
            string[] datestrings = ComboDates.ToArray();
            string[] namestrings = ComboNames.ToArray();
            StartDate.Items.AddRange(datestrings);
            StartDate.SelectedIndex = 0;
            DateIn = StartDate.SelectedIndex;
            EndDate.Items.AddRange(datestrings);
            EndDate.SelectedIndex = EndDate.Items.Count - 1;
            DateOut = EndDate.SelectedIndex;
            ClearPanel();
            for (sd = 0; sd < sitesData.Count; sd++)
            {
                FillForm();
                panelView.SuspendLayout();
                InPanArray.Add(InPanMessage);
                panelView.Controls.Add(InPanArray[InPanArray.Count - 1]);
                panelView.ResumeLayout();
            }
            MessageChanges();
            UpdateMassive();
            ShowListData();
            saveToFile.Visible = true;
            saveVisible.Visible = true;
        }
        /// <summary>
        /// Сортировать данные на экране по дате последнего изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByDates(object sender, EventArgs e)
        {
            ShowType = 0;
            if (ByDates)
            {
                ByDates = false;
            }
            else
            {
                ByDates = true;
            }
            if (sitesData.Count > 0)
            {
                UpdateMassive();
                ShowListData();
            }
        }
        /// <summary>
        /// Сортировать данные на экране по названию сайта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByNames(object sender, EventArgs e)
        {
            ShowType = 1;
            if (ByNames)
            {
                ByNames = false;
            }
            else
            {
                ByNames = true;
            }
            if (sitesData.Count > 0)
            {
                UpdateMassive();
                ShowListData();
            }
        }
        /// <summary>
        /// Скомпоновать данные при нажатии на Диапазон дат.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateSortDatesMassive(object sender, EventArgs e)
        {
            if (sitesData.Count > 0)
            {
                UpdateMassive();
            }
        }
        /// <summary>
        /// Обновить даты в комбобоксах.
        /// </summary>
        private void UpdateMassive()
        {
            ComboFlag = false;
            ComboDates.Clear();
            for (int i = 0; i < sitesData.Count; i++)
            {
                ComboDates.Add(sitesData[i].Date + " | " + sitesData[i].Time);
            }
            ComboDates.Sort();
            StartDate.Items.Clear();
            EndDate.Items.Clear();
            string[] datestrings = ComboDates.ToArray();
            StartDate.Items.AddRange(datestrings);
            if (DateIn > StartDate.Items.Count - 1)
            {
                StartDate.SelectedIndex = 0;
                DateIn = StartDate.SelectedIndex;
            }
            StartDate.SelectedIndex = DateIn;
            EndDate.Items.AddRange(datestrings);
            if (DateOut > EndDate.Items.Count - 1)
            {
                EndDate.SelectedIndex = EndDate.Items.Count - 1;
                DateOut = EndDate.SelectedIndex;
            }
            if (DateOut < DateIn)
            {
                StartDate.SelectedIndex = 0;
                EndDate.SelectedIndex = EndDate.Items.Count - 1;
                DateIn = 0;
                DateOut = EndDate.Items.Count - 1;
            }
            else
            {
                EndDate.SelectedIndex = DateOut;
            }
            ComboFlag = true;
        }
        /// <summary>
        /// Установка верхнего предела дат.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartDateChanged(object sender, EventArgs e)
        {
            if (ComboFlag)
            {
                ComboFlag = false;
                TempFirstIndex = StartDate.SelectedIndex;
                EndDate.Items.Clear();
                for (int i = StartDate.SelectedIndex; i < ComboDates.Count; i++)
                {
                    EndDate.BeginUpdate();
                    EndDate.Items.Add(ComboDates[i]);
                    EndDate.EndUpdate();
                }
                if (StartDate.SelectedIndex != -1)
                {
                    DateIn = StartDate.SelectedIndex;
                }
                ShowListData();
            }
        }
        /// <summary>
        /// Установка нижнего предела дат.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndDateChanged(object sender, EventArgs e)
        {
            if (ComboFlag)
            {
                ComboFlag = false;
                StartDate.Items.Clear();
                for (int i = 0; i <= EndDate.SelectedIndex + TempFirstIndex; i++)
                {
                    StartDate.BeginUpdate();
                    StartDate.Items.Add(ComboDates[i]);
                    StartDate.EndUpdate();
                }
                if (EndDate.SelectedIndex != -1)
                {
                    DateOut = EndDate.SelectedIndex + TempFirstIndex;
                }
                ShowListData();
            }
        }
        /// <summary>
        /// Вывод данных на экран.
        /// </summary>
        private void ShowListData()
        {
            ClearPanel();
            ComboNames.Clear();
            bool ST;                                            //Видимость элемента при поиске текста.
            int invisibleCount = 0;                             //Счётчик невидимых элементов.
            List<int> NSD = new List<int>();                    //Массив для сортировки по именам.
            for (int i = 0; i < ComboDates.Count; i++)
            {
                for (sd = 0; sd < ComboDates.Count; sd++)
                {
                    if (ComboDates[i] == sitesData[sd].Date + " | " + sitesData[sd].Time)
                    {
                        FillForm();
                        InPanArray.Add(InPanMessage);
                        panelView.Controls.Add(InPanArray[InPanArray.Count - 1]);
                        //Поиск текста.
                        ST = false;
                        if (searchingOptions.GetItemChecked(0))
                        {
                            if (searchingOptions.GetItemChecked(5))
                            {
                                ST = ST || InPanMessage.siteName.Text.IndexOf(searchText.Text) != -1;
                            }
                            else
                            {
                                ST = ST || InPanMessage.siteName.Text.ToLower().IndexOf(searchText.Text.ToLower()) != -1;
                            }
                        }
                        if (searchingOptions.GetItemChecked(1))
                        {
                            if (searchingOptions.GetItemChecked(5))
                            {
                                ST = ST || InPanMessage.login.Text.IndexOf(searchText.Text) != -1;
                            }
                            else
                            {
                                ST = ST || InPanMessage.login.Text.ToLower().IndexOf(searchText.Text.ToLower()) != -1;
                            }
                        }
                        if (searchingOptions.GetItemChecked(2))
                        {
                            if (searchingOptions.GetItemChecked(5))
                            {
                                ST = ST || InPanMessage.password.Text.IndexOf(searchText.Text) != -1;
                            }
                            else
                            {
                                ST = ST || InPanMessage.password.Text.ToLower().IndexOf(searchText.Text.ToLower()) != -1;
                            }
                        }
                        if (searchingOptions.GetItemChecked(3))
                        {
                            if (searchingOptions.GetItemChecked(5))
                            {
                                ST = ST || InPanMessage.editLink.Text.IndexOf(searchText.Text) != -1;
                            }
                            else
                            {
                                ST = ST || InPanMessage.editLink.Text.ToLower().IndexOf(searchText.Text.ToLower()) != -1;
                            }
                        }
                        if (searchingOptions.GetItemChecked(4))
                        {
                            if (searchingOptions.GetItemChecked(5))
                            {
                                ST = ST || InPanMessage.notes.Text.IndexOf(searchText.Text) != -1;
                            }
                            else
                            {
                                ST = ST || InPanMessage.notes.Text.ToLower().IndexOf(searchText.Text.ToLower()) != -1;
                            }
                        }
                        InPanMessage.Visible = ST;
                        if (!ST)
                        {
                            invisibleCount++;
                        }
                        //Тип вывода.
                        if (ShowType == 0)
                        {
                            panelView.SuspendLayout();
                            InPanArray.Add(InPanMessage);
                            panelView.Controls.Add(InPanArray[InPanArray.Count - 1]);
                            panelView.ResumeLayout();
                        }
                        else if (ShowType == 1)
                        {
                            if (i >= DateIn && i <= DateOut && ST)
                            {
                                ComboNames.Add(sitesData[sd].Site);
                                NSD.Add(sd);
                            }
                            else
                            {
                                panelView.SuspendLayout();
                                InPanArray.Add(InPanMessage);
                                panelView.Controls.Add(InPanArray[InPanArray.Count - 1]);
                                panelView.Controls[panelView.Controls.Count - 1].Location = new Point(0, 0);
                                panelView.Controls[panelView.Controls.Count - 1].Visible = false;                                
                                panelView.ResumeLayout();
                            }
                        }
                        if (i + 1 <= ComboDates.Count - 1 && ComboDates[i + 1] == ComboDates[i])
                        {
                            i++;
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            if (ShowType == 1)
            {
                ComboNames.Sort();
                for (int i = 0; i < NSD.Count; i++)
                {
                    for (int j = 0; j < NSD.Count; j++)
                    {
                        sd = NSD[j];
                        if (ComboNames[i] == sitesData[sd].Site)
                        {
                            FillForm();
                            panelView.SuspendLayout();
                            InPanArray.Add(InPanMessage);
                            panelView.Controls.Add(InPanArray[InPanArray.Count - 1]);
                            panelView.ResumeLayout();
                            if (i + 1 <= ComboNames.Count - 1 && ComboNames[i + 1] == ComboNames[i])
                            {
                                i++;
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            int pos;//Позиция Y вывода элемента.
            if (ShowType == 0 && !ByDates || ShowType == 1 && !ByNames)
            {
                pos = DateOut - DateIn - invisibleCount;
            }
            else
            {
                pos = 0;
            }
            bool bc = true;//Background Color.
            for (int i = 0; i < panelView.Controls.Count; i++)
            {
                if (ShowType == 0)
                {
                    if (i < DateIn || i > DateOut || !panelView.Controls[i].Visible)
                    {
                        panelView.SuspendLayout();
                        panelView.Controls[i].Location = new Point(0, 0);
                        panelView.Controls[i].Visible = false;
                        panelView.ResumeLayout();
                    }
                    else
                    {
                        panelView.SuspendLayout();
                        if (bc)
                        {
                            bc = false;
                            panelView.Controls[i].BackColor = SystemColors.Control;
                        }
                        else
                        {
                            bc = true;
                            panelView.Controls[i].BackColor = SystemColors.ControlLightLight;
                        }
                        panelView.Controls[i].Location = new Point(0, (pos * 146));
                        if (!ByDates)
                        {
                            pos--;
                        }
                        else
                        {
                            pos++;
                        }
                        panelView.ResumeLayout();
                    }
                }
                else if (ShowType == 1)
                {
                    if (i >= panelView.Controls.Count - NSD.Count)
                    {
                        panelView.SuspendLayout();
                        if (bc)
                        {
                            bc = false;
                            panelView.Controls[i].BackColor = SystemColors.Control;
                        }
                        else
                        {
                            bc = true;
                            panelView.Controls[i].BackColor = SystemColors.ControlLightLight;
                        }
                        panelView.Controls[i].Location = new Point(0, (pos * 146));
                        if (!ByNames)
                        {
                            pos--;
                        }
                        else
                        {
                            pos++;
                        }
                        panelView.ResumeLayout();
                    }
                }
                MesNum.Text = $"Записей: {GetVisibleMessagesCount()} из {sitesData.Count}";
                saveToFile.Visible = true;
            }
            ComboFlag = true;
        }
        /// <summary>
        /// Заполнение формы сообщения.
        /// </summary>
        private void FillForm()
        {
            InPanMessage = new Template();
            InPanMessage.TopLevel = false;
            InPanMessage.TopLevel = false;
            InPanMessage.Visible = true;
            InPanMessage.siteName.Text = sitesData[sd].Site;
            InPanMessage.siteName.TextChanged += new EventHandler(MessageChanged);
            InPanMessage.login.Text = sitesData[sd].Login;
            InPanMessage.login.TextChanged += new EventHandler(MessageChanged);
            InPanMessage.password.Text = sitesData[sd].Pass;
            InPanMessage.password.TextChanged += new EventHandler(MessageChanged);
            InPanMessage.editLink.Text = sitesData[sd].Link;
            InPanMessage.editLink.MouseDoubleClick += new MouseEventHandler(MessageChangedClick);
            InPanMessage.editLink.KeyPress += new KeyPressEventHandler(MessageChangedEnter);
            InPanMessage.notes.Text = sitesData[sd].Notes;
            InPanMessage.notes.TextChanged += new EventHandler(MessageChanged);
            InPanMessage.addeddate.Text = sitesData[sd].Date;
            InPanMessage.addedtime.Text = sitesData[sd].Time;
        }
        /// <summary>
        /// Показать панель настроек поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowOptions(object sender, EventArgs e)
        {
            if (searchingOptions.Visible)
            {
                searchingOptions.Visible = false;
            }
            else
            {
                searchingOptions.Visible = true;
            }
            if (sitesData.Count > 0)
            {
                ShowListData();
            }
        }
        /// <summary>
        /// Поиск текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LookingForText(object sender, EventArgs e)
        {
            if (sitesData.Count > 0)
            {
                ShowListData();
            }
        }
        /// <summary>
        /// Подсчёт видимых эелементов на экране.
        /// </summary>
        private int GetVisibleMessagesCount()
        {
            VisibleMesseges = 0;
            for (int i = 0; i < panelView.Controls.Count; i++)
            {
                if (panelView.Controls[i].Visible)
                {
                    VisibleMesseges++;
                }
            }
            if (VisibleMesseges <= 0)
            {
                saveVisible.Visible = false;
            }
            else
            {
                saveVisible.Visible = true;
            }
            return (VisibleMesseges);
        }
        /// <summary>
        /// Очистка панели.
        /// </summary>
        private void ClearPanel()
        {
            panelView.SuspendLayout();
            while (panelView.Controls.Count > 0)
            {
                InPanArray.Clear();
                foreach (Control ctrl in panelView.Controls) ctrl.Visible = true;
                foreach (Control ctrl in panelView.Controls) ctrl.Dispose();
            }
             for (int i = 0; i < InPanArray.Count; i++)
            {
                InPanArray[i].siteName.TextChanged -= new EventHandler(MessageChanged);
                InPanArray[i].login.TextChanged -= new EventHandler(MessageChanged);
                InPanArray[i].password.TextChanged -= new EventHandler(MessageChanged);
                InPanArray[i].editLink.MouseDoubleClick -= new MouseEventHandler(MessageChangedClick);
                InPanArray[i].editLink.KeyPress -= new KeyPressEventHandler(MessageChangedEnter);
                InPanArray[i].notes.TextChanged -= new EventHandler(MessageChanged);
                InPanArray.RemoveAt(i);
            }
           panelView.ResumeLayout();
        }
        #endregion

        #region Методы загрузки файлов.
        /// <summary>
        /// Загрузить файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFullFile(object sender, EventArgs e)
        {
            Import = false;
            sitesData.Clear();
            LoadFile();
        }
        /// <summary>
        /// Догрузить файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppendFile(object sender, EventArgs e)
        {
            Import = false;
            LoadFile();
        }
        /// <summary>
        /// Импортировать из файла по датам.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFromFile(object sender, EventArgs e)
        {
            ImportFlag = false;
            Import = true;
            tempsitesData.Clear();
            LoadFile();
            importPanel.Visible = true;
            importIn.Items.Clear();
            importOut.Items.Clear();
            ImportDates.Clear();
            for (int i = 0; i < tempsitesData.Count; i++)
            {
                ImportDates.Add(tempsitesData[i].Date + " | " + tempsitesData[i].Time);
            }
            ImportDates.Sort();
            string[] datestrings = ImportDates.ToArray();
            importIn.Items.AddRange(datestrings);
            importIn.SelectedIndex = 0;
            ImportDateIn = 0;
            importOut.Items.AddRange(datestrings);
            importOut.SelectedIndex = importOut.Items.Count - 1;
            ImportDateOut = importOut.SelectedIndex;
        }
        /// <summary>
        /// Загрузка файла.
        /// </summary>
        private void LoadFile()
        {
            int cnt = 0;
            byte[] GetFile = new byte[0];
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Выберите файл.";
            openFileDialog1.Filter = "Файл базы данных .sdb|*.sdb";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var Info = new FileInfo(openFileDialog1.FileName);
                using (BinaryReader reader = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open)))
                {
                    GetFile = reader.ReadBytes(Convert.ToInt32(Info.Length));
                }
                //Дешифровка
                for (int i = 0; i < GetFile.Length; i++)
                {
                    byte code = GetFile[i];
                    code -= 0x80;
                    GetFile[i] = code;
                }
                while (cnt < GetFile.Length)
                {
                    sites.Date = ByteToString();
                    sites.Time = ByteToString();
                    sites.Site = ByteToString();
                    sites.Link = ByteToString();
                    sites.Login = ByteToString();
                    sites.Pass = ByteToString();
                    sites.Notes = ByteToString();
                    if (!Import)
                    {
                        sitesData.Add(sites);
                    }
                    else
                    {
                        tempsitesData.Add(sites);
                    }
                }
                string ByteToString()
                {
                    string output = "";
                    cnt++;
                    List<byte> bar = new List<byte>();
                    while (cnt < GetFile.Length && GetFile[cnt] > 0x06)
                    {
                        bar.Add(GetFile[cnt]);
                        cnt++;
                    }
                    byte[] arout = bar.ToArray();
                    output = Encoding.UTF8.GetString(arout, 0, arout.Length);
                    return (output);
                }
                if (!Import)
                {
                    ShowSitesData();
                    MesNum.Text = $"Записей: {GetVisibleMessagesCount()} из {sitesData.Count}";
                }
            }
            openFileDialog1.Dispose();
        }
        /// <summary>
        /// Верхний предел дат импорта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartImportChange(object sender, EventArgs e)
        {
            if (ImportFlag)
            {
                ImportFirstIndex = importIn.SelectedIndex;
                importOut.Items.Clear();
                for (int i = importIn.SelectedIndex; i < ImportDates.Count; i++)
                {
                    importOut.Items.Add(ImportDates[i]);
                }
                if (importIn.SelectedIndex != -1)
                {
                    ImportDateIn = importIn.SelectedIndex;
                }
            }
            //ImportFlag = true;
        }
        /// <summary>
        /// Нижний предел дат импорта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndImportChange(object sender, EventArgs e)
        {
            if (ImportFlag)
            {
                importIn.Items.Clear();
                for (int i = 0; i <= importOut.SelectedIndex + ImportFirstIndex; i++)
                {
                    importIn.Items.Add(ImportDates[i]);
                }
                if (importOut.SelectedIndex != -1)
                {
                    ImportDateOut = importOut.SelectedIndex + ImportFirstIndex;
                }
            }
            ImportFlag = true;
        }
        /// <summary>
        /// Импорт данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportStart(object sender, EventArgs e)
        {
            for (int i = ImportDateIn; i <= ImportDateOut; i++)
            {
                sitesData.Add(tempsitesData[i]);
            }
            UpdateMassive();
            DateOut = EndDate.Items.Count - 1;
            ShowListData();
            importPanel.Visible = false;
            ImportFlag = false;
        }
        #endregion

        #region Методы сохранения файлов.
        /// <summary>
        /// Сохранить все данные в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToFileAll(object sender, EventArgs e)
        {
            SaveAll = true;
            SaveFile();
        }
        /// <summary>
        /// Сохранить данные видимые на экране в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveVisibleData(object sender, EventArgs e)
        {
            Control[] datePan = panelView.Controls.Find("addeddate", true);
            Control[] timePan = panelView.Controls.Find("addedtime", true);
            Control[] sitePan = panelView.Controls.Find("siteName", true);
            Control[] loginPan = panelView.Controls.Find("login", true);
            Control[] passwordPan = panelView.Controls.Find("password", true);
            Control[] notePan = panelView.Controls.Find("notes", true);
            Control[] linkPan = panelView.Controls.Find("editLink", true);
            tempsitesData.Clear();
            for (int i = 0; i < datePan.Length; i++)
            {
                if (panelView.Controls[i].Visible)
                {
                    sites.Date = datePan[i].Text;
                    sites.Time = timePan[i].Text;
                    sites.Site = sitePan[i].Text;
                    sites.Login = loginPan[i].Text;
                    sites.Pass = passwordPan[i].Text;
                    sites.Notes = notePan[i].Text;
                    sites.Link = linkPan[i].Text;
                    tempsitesData.Add(sites);
                }
            }
            SaveAll = false;
            SaveFile();
        }
        /// <summary>
        /// Сохранение данных в файл.
        /// </summary>
        private void SaveFile()
        {
            saveData.Clear();
            if (SaveAll)
            {
                saveData.AddRange(sitesData);
            }
            else
            {
                saveData.AddRange(tempsitesData);
            }
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            List<byte> SaveList = new List<byte>();
            for (int i = 0; i < saveData.Count; i++)
            {
                SaveList.Add(0x00);//Конкретизация типа данных по коду в данном случае не понадобилась, но всё равно оставил на случай обновлений.
                byte[] BAR = Encoding.UTF8.GetBytes(saveData[i].Date);
                SaveList.AddRange(BAR);
                SaveList.Add(0x01);
                BAR = Encoding.UTF8.GetBytes(saveData[i].Time);
                SaveList.AddRange(BAR);
                SaveList.Add(0x02);
                BAR = Encoding.UTF8.GetBytes(saveData[i].Site);
                SaveList.AddRange(BAR);
                SaveList.Add(0x03);
                BAR = Encoding.UTF8.GetBytes(saveData[i].Link);
                SaveList.AddRange(BAR);
                SaveList.Add(0x04);
                BAR = Encoding.UTF8.GetBytes(saveData[i].Login);
                SaveList.AddRange(BAR);
                SaveList.Add(0x05);
                BAR = Encoding.UTF8.GetBytes(saveData[i].Pass);
                SaveList.AddRange(BAR);
                SaveList.Add(0x06);
                BAR = Encoding.UTF8.GetBytes(saveData[i].Notes);
                SaveList.AddRange(BAR);
            }
            saveFileDialog1.Title = "Сохранение файла.";
            saveFileDialog1.Filter = "Файл базы данных .sdb|*.sdb";
            saveFileDialog1.RestoreDirectory = true;
            byte[] SaveArray = SaveList.ToArray();
            //Примитивная шифровка записей, чтобы нельзя было прочесть в блокноте.
            for (int i = 0; i < SaveArray.Length; i++)
            {
                byte code = SaveArray[i];
                code += 0x80;
                SaveArray[i] = code;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Write(SaveArray, 0, SaveList.Count);
                    myStream.Close();
                }
            }
            saveFileDialog1.Dispose();
        }
        #endregion

        #region Прочее.
        /// <summary>
        /// Показать подсказку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowHelp(object sender, EventArgs e)
        {
            helpbox.Visible = true;
        }
        /// <summary>
        /// Спрятать подсказку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideHelp(object sender, EventArgs e)
        {
            helpbox.Visible = false;
        }
        #endregion

    }
}
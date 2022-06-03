namespace Daily_Planner
{
    struct SitesData
    {
        #region Конструкторы
        public SitesData(string Date, string Time, string Site, string Link, string Login, string Pass, string Notes)
        {
            this.date = Date;
            this.time = Time;
            this.site = Site;
            this.link = Link;
            this.login = Login;
            this.pass = Pass;
            this.notes = Notes;
        }
        #endregion

        #region Свойства
        public string Date { get { return this.date; } set { this.date = value; } }
        public string Time { get { return this.time; } set { this.time = value; } }
        public string Site { get { return this.site; } set { this.site = value; } }
        public string Link { get { return this.link; } set { this.link = value; } }
        public string Login { get { return this.login; } set { this.login = value; } }
        public string Pass { get { return this.pass; } set { this.pass = value; } }
        public string Notes { get { return this.notes; } set { this.notes = value; } }
        #endregion

        #region Поля
        private string date;
        private string time;
        private string site;
        private string link;
        private string login;
        private string pass;
        private string notes;
        #endregion
    }
}

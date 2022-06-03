using System.Diagnostics;
using System.Windows.Forms;
using System;

namespace Daily_Planner
{
    /// <summary>
    /// Методы работы с отдельной формой.
    /// </summary>
    public partial class Template : Form
    {
        /// <summary>
        /// Форма для ввода и отображения записей.
        /// </summary>
        public Template()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Завершить изменение названия сайта по двойному клику.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditSiteNameByMouse(object sender, MouseEventArgs e)
        {
            CloseEditSiteName();
        }
        /// <summary>
        /// Завершить изменение логина по двойному клику.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditLoginByMouse(object sender, MouseEventArgs e)
        {
            CloseEditLogin();
        }
        /// <summary>
        /// Завершить изменение пароля по двойному клику.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditPasswordByMouse(object sender, MouseEventArgs e)
        {
            CloseEditPassword();
        }
        /// <summary>
        /// Завершить измение ссылки по двойному клику.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditLinkByMouse(object sender, MouseEventArgs e)
        {
            CloseEditLink();
        }
        /// <summary>
        /// Завершить изменения примечаний.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditNotes(object sender, MouseEventArgs e)
        {
            notes.Text = editeNotes.Text;
            editeNotes.Visible = false;
            notes.Visible = true;
            LastEditionDate();
        }
        /// <summary>
        /// Послать код на удаление формы из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove(object sender, MouseEventArgs e)
        {
            notes.Text = "Jjwy389KIUJOIuw23789IKUH2iohj8Oklw21";
            editSitename.KeyPress -= new KeyPressEventHandler (CloseEditSiteNameByEnter);
            editSitename.MouseDoubleClick -= new MouseEventHandler(CloseEditSiteNameByMouse);
            editLogin.KeyPress -= new KeyPressEventHandler(CloseEditLoginByEnter);
            editLogin.MouseDoubleClick -= new MouseEventHandler(CloseEditLoginByMouse);
            editPassword.KeyPress -= new KeyPressEventHandler(CloseEditPasswordByEnter);
            editPassword.MouseDoubleClick -= new MouseEventHandler(CloseEditPasswordByMouse);
            editLink.KeyPress -= new KeyPressEventHandler(CloseEditLinkByEnter);
            editLink.MouseDoubleClick -= new MouseEventHandler(CloseEditLinkByMouse);
            editeNotes.MouseDoubleClick -= new MouseEventHandler(CloseEditNotes);
            getLogin.MouseClick -= new MouseEventHandler(CopyLogin);
            getPassword.MouseClick -= new MouseEventHandler(CopyPassword);
            gotosite.MouseClick -= new MouseEventHandler(GoToSite);
            siteName.MouseClick -= new MouseEventHandler(EditSiteName);
            login.MouseClick -= new MouseEventHandler(EditLogin);
            password.MouseClick -= new MouseEventHandler(EditPassword);
            notes.MouseClick -= new MouseEventHandler(EditNotes);
        }
        /// <summary>
        /// Копировать логин в буфер обмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyLogin(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
            if (login.Text != "")
            {
                Clipboard.SetText(login.Text);
            }
        }
        /// <summary>
        /// Копировать пароль в буфер обмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyPassword(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
            if (password.Text != "")
            {
                Clipboard.SetText(password.Text);
            }
        }
        /// <summary>
        /// Переход по ссылке на сайт по ЛКМ, либо редактирование ссылки по ПКМ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToSite(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                editLink.Visible = true;
                linklable.Visible = true;
                gotosite.Visible = false;
            }
            else
            {
                if ((editLink.Text.Length > 7 && editLink.Text.Substring(0, 7) == "http://") || (editLink.Text.Length > 8 && editLink.Text.Substring(0, 8) == "https://") || (editLink.Text.Length > 4 && editLink.Text.Substring(0, 4) == "www."))
                {
                    Process.Start(editLink.Text);
                }
            }
        }
        /// <summary>
        /// Редактировать имя сайта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditSiteName(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                editSitename.Text = siteName.Text;
                siteName.Visible = false;
                editSitename.Visible = true;
            }
        }
        /// <summary>
        /// Редактировать Логин.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditLogin(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                editLogin.Text = login.Text;
                login.Visible = false;
                editLogin.Visible = true;
            }
        }
        /// <summary>
        /// Редактировать пароль.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPassword(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                editPassword.Text = password.Text;
                password.Visible = false;
                editPassword.Visible = true;
            }
        }
        /// <summary>
        /// Редактировать поле примечаний.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNotes(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                editeNotes.Text = notes.Text;
                notes.Visible = false;
                editeNotes.Visible = true;
            }
        }
        /// <summary>
        /// Обновить время редактирования записи.
        /// </summary>
        private void LastEditionDate()
        {
            DateTime CurDate = new DateTime();
            CurDate = DateTime.Now;
            string formatDays = "yyyy/MM/dd";
            string formatHours = "HH:mm:ss";
            addeddate.Text = CurDate.ToString(formatDays);
            addedtime.Text = CurDate.ToString(formatHours);
        }
        /// <summary>
        /// Завершить изменение названия сайта по нажатию Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditSiteNameByEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CloseEditSiteName();
            }
        }
        /// <summary>
        /// Завершить изменение названия сайта.
        /// </summary>
        private void CloseEditSiteName()
        {
            siteName.Text = editSitename.Text;
            editSitename.Visible = false;
            siteName.Visible = true;
            LastEditionDate();
        }
        /// <summary>
        /// Завершить изменение логина по нажатию Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditLoginByEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CloseEditLogin();
            }
        }
        /// <summary>
        /// Завершить изменение логина.
        /// </summary>
        private void CloseEditLogin()
        {
            login.Text = editLogin.Text;
            editLogin.Visible = false;
            login.Visible = true;
            LastEditionDate();
        }
        /// <summary>
        /// Завершить изменение пароля по нажатию Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditPasswordByEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CloseEditPassword();
            }
        }
        /// <summary>
        /// Завершить измение ссылки по нажатию Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEditLinkByEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CloseEditLink();
            }
        }
        /// <summary>
        /// Завершить изменение пароля.
        /// </summary>
        private void CloseEditPassword()
        {
            password.Text = editPassword.Text;
            editPassword.Visible = false;
            password.Visible = true;
            LastEditionDate();
        }
        /// <summary>
        /// Завершить измение ссылки.
        /// </summary>
        private void CloseEditLink()
        {
            editLink.Visible = false;
            linklable.Visible = false;
            gotosite.Visible = true;
            LastEditionDate();
        }
    }
}
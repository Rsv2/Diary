namespace Daily_Planner
{
    partial class Template
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
            this.label1 = new System.Windows.Forms.Label();
            this.siteName = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editSitename = new System.Windows.Forms.TextBox();
            this.editLogin = new System.Windows.Forms.TextBox();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.gotosite = new System.Windows.Forms.Button();
            this.getLogin = new System.Windows.Forms.Button();
            this.getPassword = new System.Windows.Forms.Button();
            this.editLink = new System.Windows.Forms.TextBox();
            this.removeAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.editeNotes = new System.Windows.Forms.TextBox();
            this.addeddate = new System.Windows.Forms.Label();
            this.addedtime = new System.Windows.Forms.Label();
            this.linklable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сайта";
            // 
            // siteName
            // 
            this.siteName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteName.Location = new System.Drawing.Point(2, 35);
            this.siteName.Name = "siteName";
            this.siteName.Size = new System.Drawing.Size(260, 26);
            this.siteName.TabIndex = 1;
            this.siteName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditSiteName);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(2, 76);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(260, 26);
            this.login.TabIndex = 3;
            this.login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditLogin);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(2, 117);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(260, 26);
            this.password.TabIndex = 5;
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditPassword);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пароль";
            // 
            // editSitename
            // 
            this.editSitename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSitename.Location = new System.Drawing.Point(2, 35);
            this.editSitename.Name = "editSitename";
            this.editSitename.Size = new System.Drawing.Size(260, 26);
            this.editSitename.TabIndex = 6;
            this.editSitename.Visible = false;
            this.editSitename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CloseEditSiteNameByEnter);
            this.editSitename.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CloseEditSiteNameByMouse);
            // 
            // editLogin
            // 
            this.editLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLogin.Location = new System.Drawing.Point(2, 76);
            this.editLogin.Name = "editLogin";
            this.editLogin.Size = new System.Drawing.Size(260, 26);
            this.editLogin.TabIndex = 7;
            this.editLogin.Visible = false;
            this.editLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CloseEditLoginByEnter);
            this.editLogin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CloseEditLoginByMouse);
            // 
            // editPassword
            // 
            this.editPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPassword.Location = new System.Drawing.Point(2, 117);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(260, 26);
            this.editPassword.TabIndex = 8;
            this.editPassword.Visible = false;
            this.editPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CloseEditPasswordByEnter);
            this.editPassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CloseEditPasswordByMouse);
            // 
            // gotosite
            // 
            this.gotosite.Location = new System.Drawing.Point(268, 38);
            this.gotosite.Name = "gotosite";
            this.gotosite.Size = new System.Drawing.Size(150, 23);
            this.gotosite.TabIndex = 9;
            this.gotosite.Text = "Перейти на сайт";
            this.gotosite.UseVisualStyleBackColor = true;
            this.gotosite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GoToSite);
            // 
            // getLogin
            // 
            this.getLogin.Location = new System.Drawing.Point(268, 77);
            this.getLogin.Name = "getLogin";
            this.getLogin.Size = new System.Drawing.Size(150, 23);
            this.getLogin.TabIndex = 10;
            this.getLogin.Text = "Копировать в буфер";
            this.getLogin.UseVisualStyleBackColor = true;
            this.getLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CopyLogin);
            // 
            // getPassword
            // 
            this.getPassword.Location = new System.Drawing.Point(268, 117);
            this.getPassword.Name = "getPassword";
            this.getPassword.Size = new System.Drawing.Size(150, 23);
            this.getPassword.TabIndex = 11;
            this.getPassword.Text = "Копировать в буфер";
            this.getPassword.UseVisualStyleBackColor = true;
            this.getPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CopyPassword);
            // 
            // editLink
            // 
            this.editLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLink.Location = new System.Drawing.Point(268, 35);
            this.editLink.Name = "editLink";
            this.editLink.Size = new System.Drawing.Size(449, 26);
            this.editLink.TabIndex = 12;
            this.editLink.Text = "https://";
            this.editLink.Visible = false;
            this.editLink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CloseEditLinkByEnter);
            this.editLink.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CloseEditLinkByMouse);
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(723, 36);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(75, 23);
            this.removeAll.TabIndex = 13;
            this.removeAll.Text = "Удалить";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Remove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(427, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Примечания";
            // 
            // notes
            // 
            this.notes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notes.Location = new System.Drawing.Point(424, 77);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(374, 58);
            this.notes.TabIndex = 15;
            this.notes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditNotes);
            // 
            // editeNotes
            // 
            this.editeNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editeNotes.Location = new System.Drawing.Point(424, 78);
            this.editeNotes.Multiline = true;
            this.editeNotes.Name = "editeNotes";
            this.editeNotes.Size = new System.Drawing.Size(374, 58);
            this.editeNotes.TabIndex = 16;
            this.editeNotes.Visible = false;
            this.editeNotes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CloseEditNotes);
            // 
            // addeddate
            // 
            this.addeddate.AutoSize = true;
            this.addeddate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addeddate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addeddate.Location = new System.Drawing.Point(4, 5);
            this.addeddate.Name = "addeddate";
            this.addeddate.Size = new System.Drawing.Size(30, 13);
            this.addeddate.TabIndex = 17;
            this.addeddate.Text = "дата";
            // 
            // addedtime
            // 
            this.addedtime.AutoSize = true;
            this.addedtime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addedtime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addedtime.Location = new System.Drawing.Point(74, 5);
            this.addedtime.Name = "addedtime";
            this.addedtime.Size = new System.Drawing.Size(40, 13);
            this.addedtime.TabIndex = 18;
            this.addedtime.Text = "время";
            // 
            // linklable
            // 
            this.linklable.AutoSize = true;
            this.linklable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linklable.Location = new System.Drawing.Point(271, 22);
            this.linklable.Name = "linklable";
            this.linklable.Size = new System.Drawing.Size(87, 13);
            this.linklable.TabIndex = 19;
            this.linklable.Text = "Ссылка на сайт";
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 146);
            this.Controls.Add(this.linklable);
            this.Controls.Add(this.addedtime);
            this.Controls.Add(this.addeddate);
            this.Controls.Add(this.editeNotes);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.editLink);
            this.Controls.Add(this.getPassword);
            this.Controls.Add(this.getLogin);
            this.Controls.Add(this.gotosite);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.editLogin);
            this.Controls.Add(this.editSitename);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.siteName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template";
            this.ShowIcon = false;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox editSitename;
        public System.Windows.Forms.Button gotosite;
        public System.Windows.Forms.Button getLogin;
        public System.Windows.Forms.Button getPassword;
        public System.Windows.Forms.TextBox editLink;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox editeNotes;
        public System.Windows.Forms.Label addeddate;
        public System.Windows.Forms.Label addedtime;
        public System.Windows.Forms.Label siteName;
        public System.Windows.Forms.TextBox editLogin;
        public System.Windows.Forms.TextBox editPassword;
        public System.Windows.Forms.Label notes;
        public System.Windows.Forms.Label linklable;
        public System.Windows.Forms.Button removeAll;
    }
}
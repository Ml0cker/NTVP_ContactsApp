using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ContactsAppBLL;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private Project _project = new Project();
        /// <summary>
        /// Проект используемый программой
        /// </summary>
        public Project Project
        {
            get => _project;
            set => _project = value;
        }

        /// <summary>
        /// Лист отображаемых контактов
        /// </summary>
        private List<Contact> _vievsContacts;
        public MainForm()
        {
            InitializeComponent();
            Project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            _vievsContacts = Project.Contacts;
            FindAndUpdateListBox();
        }

        /// <summary>
        /// Метод вызова окна добавления контакта
        /// </summary>
        private void AddContactForm()
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Contact = new Contact();
            contactForm.ShowDialog();
            if (contactForm.DialogResult == DialogResult.OK)
            {
                var updatedContact = contactForm.Contact;
                Project.Contacts.Add(updatedContact);
                controlContactMain.Contact = updatedContact;
                FindAndUpdateListBox();
                ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
            }
        }

        /// <summary>
        /// Метод вызова окна изменения контакта
        /// </summary>
        private void EditNewContact()
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }

            ContactForm contactForm = new ContactForm();
            contactForm.Contact = new Contact();
            contactForm.Contact = Project.Contacts[listBoxContact.SelectedIndex];
            contactForm.ShowDialog();
            if (contactForm.DialogResult == DialogResult.OK)
            {
                var updatedContact = contactForm.Contact;
                Project.Contacts[listBoxContact.SelectedIndex] = updatedContact;
                controlContactMain.Contact = updatedContact;
                FindAndUpdateListBox();
                ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
            }
        }

        /// <summary>
        /// Метод удаления контакта 
        /// </summary>
        private void DeleteContact()
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }

            DialogResult deleteResult =
                MessageBox.Show("Удалить контакт " + listBoxContact.Text + "?", "Удалить контакт",
                    MessageBoxButtons.OKCancel);
            if (deleteResult == DialogResult.OK)
            {
                Project.Contacts.RemoveAt(listBoxContact.SelectedIndex);
                FindAndUpdateListBox();
                ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
            }
        }

        /// <summary>
        /// Кнопка вызова окна изменения данных контакта
        /// </summary>
        private void buttonChangeContact_Click(object sender, EventArgs e)
        {
            EditNewContact();
        }

        /// <summary>
        /// Эвент выбора и показа контакта в mainForm
        /// </summary>
        private void listBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }
            var tempContact = _vievsContacts[listBoxContact.SelectedIndex];
            controlContactMain.Contact = tempContact;
        }

        /// <summary>
        /// Кнопка удаления контакта
        /// </summary>
        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        /// <summary>
        /// Закрытие главной формы
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
        }

        private void toolStripMenuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Добавить контакт по нажатию кнопки в тулбаре
        /// </summary>
        private void toolStripMenuEditAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm();
        }

        /// <summary>
        /// Редактировать контакт по нажатию кнопки в тулбаре
        /// </summary>
        private void toolStripMenuEditChange_Click(object sender, EventArgs e)
        {
            EditNewContact();
        }

        /// <summary>
        ///  Удалить контакт по нажатию кнопки в тулбаре
        /// </summary>
        private void toolStripMenuEditDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        /// <summary>
        ///  Выход из программы по нажатию кнопки в тулбаре
        /// </summary>
        private void toolStripMenuFileExit_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
            Application.Exit();
        }

        /// <summary>
        /// Событие по изменению значения в строке поиска
        /// </summary>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FindAndUpdateListBox();
        }

        /// <summary>
        /// Метод обновления лист бокса, включающий себя поиск
        /// </summary>
        private void FindAndUpdateListBox()
        {
            Project.Contacts = Project.Contacts.OrderBy(o => o.Surname).ToList();
            listBoxContact.Items.Clear();
            _vievsContacts = ProjectManager.FindInProject(textBoxSearch.Text, Project.Contacts);
            foreach (var finded in _vievsContacts)
            {
                listBoxContact.Items.Add(finded.Surname + " " + finded.Name);
            }
        }

        /// <summary>
        /// Кнопка создания нового контакта
        /// </summary>
        private void ButtonСreateNewContact_Click(object sender, EventArgs e)
        {
            AddContactForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

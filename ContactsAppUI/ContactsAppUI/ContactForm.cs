using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsAppBLL;

namespace ContactsAppUI
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// обьявление класса для передачи данных в другую форму
        /// </summary>
        private Contact _contact;

        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
            }
        }
        public ContactForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Подтверждение введенных данных
        /// Закроет окно и передаст информацию в случае отсутствия ошибок в введенных данных
        /// </summary>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (controlContactAdd.CheckCorrectnessData())
            {
                this.Close();
                Contact = controlContactAdd.Contact;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            controlContactAdd.Contact = new Contact();
            controlContactAdd.Contact = Contact;
        }
    }
}

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
    public partial class ControlContact : UserControl
    {
        private Contact _contact;
        ToolTip surNameToolTip = new ToolTip();
        ToolTip nameToolTip = new ToolTip();
        private System.Windows.Forms.ErrorProvider dateErrorProvider;
        ToolTip dateToolTip = new ToolTip();
        ToolTip phoneToolTip = new ToolTip();
        ToolTip eMailToolTip = new ToolTip();
        ToolTip vkToolTip = new ToolTip();
        private Size _dateSize;
        private bool _sizeLess = true;

        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                if (value != null)
                {
                    if (!string.IsNullOrEmpty(Contact.Surname))
                    {

                        textBoxSurname.Text = Contact.Surname;
                        textBoxName.Text = Contact.Name;
                        dateTimeBirthDate.Value = Contact.BirthDate;
                        textBoxPhoneNumber.Text = Contact.PhoneNumber.Number;
                        textBoxEmail.Text = Contact.Email;
                        textBoxVkId.Text = Contact.idVK;
                    }
                }
            }
        }
        public ControlContact()
        {
            InitializeComponent();
            dateErrorProvider = new ErrorProvider();
        }

        /// <summary>
        /// Проверить корректность данных в полях
        /// </summary>
        public bool CheckCorrectnessData()
        {
            var correct = true;
            try
            {
                Contact.Surname = textBoxSurname.Text;                              //SURNAME
            }
            catch (ArgumentException exception)
            {
                surNameToolTip.SetToolTip(textBoxSurname, exception.Message);
                textBoxSurname.BackColor = Color.LightCoral;
                correct = false;
            }
            try
            {
                Contact.Name = textBoxName.Text;                                    //Name
            }
            catch (ArgumentException exception)
            {
                nameToolTip.SetToolTip(textBoxName, exception.Message);
                textBoxName.BackColor = Color.LightCoral;
                correct = false;
            }
            try
            {
                _dateSize = dateTimeBirthDate.ClientSize;
                Contact.BirthDate = dateTimeBirthDate.Value;                           //BirthDate
            }
            catch (ArgumentException exception)
            {
                if (_sizeLess)
                {
                    _dateSize = Size.Subtract(_dateSize, new Size(20, 0));
                    _sizeLess = false;
                }
                dateTimeBirthDate.Size = _dateSize;
                dateErrorProvider.SetIconAlignment(dateTimeBirthDate, ErrorIconAlignment.MiddleRight);
                dateErrorProvider.SetIconPadding(dateTimeBirthDate, 2);
                dateErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                dateErrorProvider.SetError(dateTimeBirthDate, exception.Message);
                correct = false;
            }
            try
            {
                Contact.PhoneNumber.Number = textBoxPhoneNumber.Text;                              //Phone
            }
            catch (ArgumentException exception)
            {
                phoneToolTip.SetToolTip(textBoxPhoneNumber, exception.Message);
                textBoxPhoneNumber.BackColor = Color.LightCoral;
                correct = false;
            }
            try
            {
                Contact.Email = textBoxEmail.Text;                              //Email
            }
            catch (ArgumentException exception)
            {
                eMailToolTip.SetToolTip(textBoxEmail, exception.Message);
                textBoxEmail.BackColor = Color.LightCoral;
                correct = false;
            }
            try
            {
                Contact.idVK = textBoxVkId.Text;                              //VkPage
            }
            catch (ArgumentException exception)
            {
                vkToolTip.SetToolTip(textBoxVkId, exception.Message);
                textBoxVkId.BackColor = Color.LightCoral;
                correct = false;
            }
            return correct;
        }
        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

            string exceptionText = "";
            surNameToolTip.Hide(textBoxSurname);
            surNameToolTip.ReshowDelay = 0;
            surNameToolTip.InitialDelay = 10;
            try
            {
                Contact.Surname = textBoxSurname.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxSurname.BackColor = Color.White;
                surNameToolTip.RemoveAll();
            }
            else
            {
                surNameToolTip.SetToolTip(textBoxSurname, exceptionText);
                textBoxSurname.BackColor = Color.LightCoral;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

            string exceptionText = "";
            nameToolTip.ReshowDelay = 0;
            nameToolTip.InitialDelay = 10;
            try
            {
                Contact.Name = textBoxName.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxName.BackColor = Color.White;

            }
            else
            {
                nameToolTip.SetToolTip(textBoxName, exceptionText);
                textBoxName.BackColor = Color.LightCoral;
            }
        }

        private void dateTimeBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string exceptionText = "";
            phoneToolTip.ReshowDelay = 0;
            phoneToolTip.InitialDelay = 10;
            try
            {
                Contact.PhoneNumber.Number = textBoxPhoneNumber.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxPhoneNumber.BackColor = Color.White;

            }
            else
            {
                phoneToolTip.SetToolTip(textBoxPhoneNumber, exceptionText);
                textBoxPhoneNumber.BackColor = Color.LightCoral;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string exceptionText = "";
            eMailToolTip.ReshowDelay = 0;
            eMailToolTip.InitialDelay = 10;
            try
            {
                Contact.Email = textBoxEmail.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxEmail.BackColor = Color.White;

            }
            else
            {
                eMailToolTip.SetToolTip(textBoxEmail, exceptionText);
                textBoxEmail.BackColor = Color.LightCoral;
            }
        }

        private void textBoxVkId_TextChanged(object sender, EventArgs e)
        {
            string exceptionText = "";
            vkToolTip.ReshowDelay = 0;
            vkToolTip.InitialDelay = 10;
            try
            {
                Contact.idVK = textBoxVkId.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxVkId.BackColor = Color.White;

            }
            else
            {
                vkToolTip.SetToolTip(textBoxVkId, exceptionText);
                textBoxVkId.BackColor = Color.LightCoral;
            }
        }
    }
}

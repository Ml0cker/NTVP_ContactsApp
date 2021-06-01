using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppBLL
{
    /// <summary>
    /// Класс контакты, содежить информацию о фамилии, имени, номере телефона, дате рождения, e-mail и ID Вконтакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Дата рождения
        /// </summary>
        private DateTime _birthDate;

        /// <summary>
        /// Электронная почта
        /// </summary>
        private string _email;

        /// <summary>
        /// Страница в социальной сети
        /// </summary>
        private string _idVK;


        /// <summary>
        /// Проверяет строку на правильность регистра букв, создан для полей имени и фамилии
        /// </summary>
        /// <param name="inComming">Входящая строка для проверки регистра</param>
        /// <returns>отправляет true если строка не подходит</returns>
        private bool UpperSymbolsUnCorrect(string inComming)
        {
            if (inComming != null)
            {
                for (var i = 0; i < inComming.Length; i++)
                {
                    if (i == 0)
                    {
                        if (char.IsLower(inComming[i]))
                        {
                            return true;
                        }
                    }

                    if (i >= 1)
                    {
                        if (char.IsUpper(inComming[i]))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        /// <summary>
        /// Возвращает и задает фамилию
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Заполните Фамилию");
                }
                else if (UpperSymbolsUnCorrect(value))
                {
                    throw new ArgumentException("Первая буква должна быть заглавной");
                }
                else
                {
                    _surname = value;
                }

            }
        }

        /// <summary>
        /// Возвращает и задает имя
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Заполните Имя");
                }
                else if (UpperSymbolsUnCorrect(value))
                {
                    throw new ArgumentException("Первая буква должна быть заглавной");
                }
                else
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона
        /// </summary>
        public PhoneNumber PhoneNumber { get; set; } = new PhoneNumber();

        /// <summary>
        /// Возвращает и задает дату рождения
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (DateTime.Today <= value)
                {
                    throw new ArgumentException("Дата рождения должна быть не позже сегодняшнего дня");
                }
                else
                {
                    _birthDate = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает страницу вк
        /// </summary>
        public string idVK
        {
            get { return _idVK; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Заполните страницу Вконтакте");
                }
                else
                {
                    _idVK = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Заполните Email");
                }
                else
                {
                    _email = value;
                }
            }
        }
    }
}

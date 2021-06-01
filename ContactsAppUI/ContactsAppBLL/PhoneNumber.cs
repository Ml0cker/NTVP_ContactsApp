using System;

namespace ContactsAppBLL
{
    /// <summary>
    /// Класс номер телефона, хранящий информацию о номере телефона. Создан для возможного дальнейшего разширения: 
    /// разделение номера телеона на составляющие.
    /// </summary>
    public class PhoneNumber
    {
        private string _number;
        public PhoneNumber() { }
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Введите номер телефона");
                }
                else if (IsSymbolContains(value))
                {
                    throw new ArgumentException("Номер телефона может содержать только цифры");
                }
                else if (value.Length == 11)
                {
                    if (value[0] == '7' && value[1] == '9')
                    {
                        _number = value;
                    }
                    else throw new ArgumentException("Номер телефона должен начинаться на  79...");
                }

                else
                {
                    throw new ArgumentException("Номер телефона должен иметь длину 11 символов");
                }
            }
        }

        /// <summary>
        /// Метод проверки строки на наличие в ней букв
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private Boolean IsSymbolContains(string input)
        {
            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {

                    if (char.IsLetter(input[i]))
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
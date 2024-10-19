using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    internal class User
    {
        private string _login;
        private string _password;
        

        public string Login { get => _login; }
        public string Password
        {
            get => _password;
            set
            {
                if (value.Length > 5) _password = value;
                else throw new ArgumentException("длина пароля не соответствует");
            }
        }

        public User(string login, string password, IState state)
        {
            _login = login;
            Password = password;
            _state=state;
        }

        public override string ToString()
        {
            return $"{Login}: находится в состоянии: {_state}";
        }

        #region реализация паттерна
        private IState _state; //интерфейсная внутрення переменная состояния
        /// <summary>
        /// метод передачи сообщения пользователя делегирует выполнение методу 
        /// конкретного состояния
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(string message)
        {
            _state.SendMessage(message);
        }
        public void ChangeState(IState state)
        {
            _state = state;
        }
        #endregion
    }
}

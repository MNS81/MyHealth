Программа для отслеживания показаний тонометра.
Данные пользователей сохраняются в базе SQL.
Добавлена форма входа и регистрации пользователей.

Пример Key.cs

namespace MyHealth\n
{
    internal class Key
    {
        public const string SERVER = "localhost";
        public const string PORT = "3306";
        public const string USER = "root";
        public const string PASS = "root";
        public const string BASE = "baseName";
    }
}
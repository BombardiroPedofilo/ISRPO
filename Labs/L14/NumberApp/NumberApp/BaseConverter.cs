using System;

namespace NumberApp
{
    class BaseConverter
    {
        public static int ToDecimal(string number, int fromBase)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Число не может быть пустым");

            number = number.ToUpper().Trim();
            try
            {
                return Convert.ToInt32(number, fromBase);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Ошибка преобразования: {ex.Message}");
            }
        }

        public static string FromDecimal(int decimalValue, int toBase)
        {
            if (toBase < 2 || toBase > 16)
                throw new ArgumentException("Основание должно быть от 2 до 16");

            try
            {
                return Convert.ToString(decimalValue, toBase).ToUpper();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Ошибка преобразования: {ex.Message}");
            }
        }
    }
}
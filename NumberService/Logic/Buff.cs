using System;

namespace NumberService.Logic
{
    /// <summary>
    /// Структура отвечает за логику добавления и вывода данных
    /// </summary>
    /// <typeparam name="T">тип данных массива</typeparam>
    public struct Buff<T>
    {
        /// <summary>
        /// Массив хранящий данные
        /// </summary>
        private readonly T[] BufferS;

        /// <summary>
        /// Номер текущего элемента,куда добавляем данные
        /// </summary>
        private int _curr;

        /// <summary>
        /// Размер массива
        /// </summary>
        private readonly int _size;

        /// <summary>
        /// Затычка для предодвращения незапланированного изменения данных
        /// </summary>
        private readonly object _obLock = new();

        /// <summary>
        /// Конструктор структуры
        /// </summary>
        /// <param name="size"></param>
        public Buff(int size)
        {
            BufferS = new T[size];
            _curr = 0;
            _size = size;
        }

        /// <summary>
        /// Проверка текущего индекса
        /// </summary>
        /// <param name="curr">текущий индекс для записи данных</param>
        /// <param name="size">размер массива</param>
        /// <returns></returns>
        private static bool IsFool(int curr, int size) => curr == size - 1;

        /// <summary>
        /// Добавление в массив
        /// </summary>
        /// <param name="num">данные добавляемые в массив</param>
        public void Add(T num)
        {
            lock (_obLock)
            {
                BufferS[_curr] = num;
                if (IsFool(_curr, _size))
                    _curr = 0;
                else
                    _curr++;
            }
        }

        /// <summary>
        /// Возвращение массива данных
        /// </summary>
        /// <returns></returns>
        public T[] Select() => BufferS;
    }
}

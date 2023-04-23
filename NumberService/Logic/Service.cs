namespace NumberService.Logic
{
    
    /// <summary>
    /// Класс для работы со структурой данных
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Структура отвечающая за добавление и удаление данных в массив
        /// </summary>
        private Buff<int> cl;
        
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Service() 
        {
             cl = new Buff<int>(5);
        }     

        /// <summary>
        /// Обращение к методу для добавления данных в массив
        /// </summary>
        /// <param name="num"></param>
        public void Add (int num) => cl.Add(num);

        /// <summary>
        /// Обращение к методу для вывода данных
        /// </summary>
        /// <returns></returns>
        public int[] Select() => cl.Select();
        
    }
}

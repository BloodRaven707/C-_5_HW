namespace Console_Program
{
    class C_5
    {
        /// <summary>
        /// Генератор массива указанной длинны в диапозоне значений
        /// </summary>
        /// <param name="arrayLength">Число элементов для генерации</param>
        /// <param name="minRange">Минимальное значение элемента массива</param>
        /// <param name="maxRange">Максимальное значение элемента массива</param>
        /// <returns>Cгенерированный массив из вещественных чисел</returns>
        public static int[] RandomArrayGenarate(int arrayLength, int minRange, int maxRange) {
            Random rand = new Random();
            int[] someIntArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
                someIntArray[i] = rand.Next(minRange, maxRange);

            return someIntArray;
        }

        
        private static void Main(string[] args) {
	        // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            // [3, 7, 23, 12] -> 19
	        // [-4, -6, 89, 6] -> 0
	        Console.WriteLine("\nЗадача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.\n");

            int arrayLength = 20;
            int[] someIntArray = RandomArrayGenarate(arrayLength, 100, 1000);
            int sumNumbers = 0;

            for (int i = 0; i < someIntArray.Length; i = i + 2)
                sumNumbers += someIntArray[i];

            Console.WriteLine($"В массиве [{String.Join(", ", someIntArray)}]\nСумму элементов, стоящих на нечётных позициях -> {sumNumbers}\n");
		}
    }
}
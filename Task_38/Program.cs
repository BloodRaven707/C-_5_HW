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
        public static double[] RandomDoubleArrayGenarate(int arrayLength, double minRange, double maxRange) {
            Random rand = new Random();
            double[] someIntArray = new double[arrayLength];

            for (int i = 0; i < arrayLength; i++)
                someIntArray[i] = minRange + (rand.NextDouble() * (maxRange - minRange));

            return someIntArray;
        }


        private static void Main(string[] args) {
	        // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
	        // [3 7 22 2 78] -> 76
            Console.WriteLine("\nЗадача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\n");

            int arrayLength = 20;
            double[] someIntArray = RandomDoubleArrayGenarate(arrayLength, 100, 1000);
            double minDigit = someIntArray.Min();
            double maxDigit = someIntArray.Max();

            Console.WriteLine($"В массиве [{String.Join(", ", someIntArray)}]\n\nРазница между максимальным элементом: {maxDigit} и минимальным элементом: {minDigit} -> {maxDigit - minDigit}\n");
		}
    }
}
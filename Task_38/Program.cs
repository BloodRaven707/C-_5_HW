namespace Console_Program
{
    class C_5
    {
        /// <summary>
        /// Принимает: длинну массива, минимальное и максимальное значение элемента массива
        /// Возвращает: сгенерированный массив из вещественных чисел
        /// </summary>
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
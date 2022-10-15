namespace Console_Program
{
    class C_5
    {
        /// <summary>
        /// Принимает: длинну массива, минимальное и максимальное значение элемента массива
        /// Возвращает: сгенерированный массив из целых чисел
        /// </summary>
        public static int[] RandomArrayGenarate(int arrayLength, int minRange, int maxRange) {
            Random rand = new Random();
            int[] someIntArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
                someIntArray[i] = rand.Next(minRange, maxRange);

            return someIntArray;
        }
        

        private static void Main(string[] args) {
			// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            // [345, 897, 568, 234] -> 2
	        Console.WriteLine("\nЗадача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.\n");

            int arrayLength = 20;
            int[] someIntArray = RandomArrayGenarate(arrayLength, 100, 1000);
            int countEvenNumber = 0;

            foreach (int i in someIntArray)
                if (i % 2 == 0)
                    countEvenNumber++;

            Console.WriteLine($"В массиве [{String.Join(", ", someIntArray)}]\nКоличество чётных чисел -> {countEvenNumber}\n");
		}
    }
}
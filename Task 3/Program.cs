using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задачи с массивами");
        Console.WriteLine("Количество положительных и отрицательных чисел");
        //int[] numbers = { 1, 2, 3, 4, 5 };
        //int result = 0;
        //foreach (int number in numbers)
        //{
        //    if(number > 0)
        //    {
        //        result++;
        //    }
        //}

        //Console.WriteLine($"Число элементов больше нуля: {result}");
        //Console.WriteLine("Тут будут числа в массиве, которые положительные и отрицательные");
        int[] numbers = { -1, -2, -3, -4, -5, -6, -7, 1, 2, 3, 4, 5, 6, 7 };
        int count_positive = 0;
        int count_negative = 0;
        foreach (int number in numbers)
        {
            if ( number > 0)
            {
                count_positive++;
            }
            if ( number < 0 )
            {
                count_negative++;
            }
        }
        Console.WriteLine($"Положительные: {count_positive}");
        Console.WriteLine($"Отрицательные: {count_negative}");






        Console.WriteLine("Инверсия массива");

        int[] num_reverse = { 0, 1, 2, -1, 3, 4, };
        int n = num_reverse.Length;
        int k = n / 2;
        int temp;
        for( int i = 0; i < k; i++)
        {
            temp = num_reverse[i];
            num_reverse[i] = num_reverse[n - i - 1];
            num_reverse[n - i - 1] = temp;
        }
        foreach (int i in num_reverse)
        {
            Console.WriteLine($"{i}\t");
        }




        Console.WriteLine("Программа сортировки массива");
        int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

        int sort;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    sort = nums[i];
                    nums[i] = nums[j];
                    nums[j] = sort;
                }
            }
        }

        Console.WriteLine("Вывод отсортированного массива");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
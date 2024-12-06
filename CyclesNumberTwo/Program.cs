namespace CyclesNumberTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //для зповнення масивів

            //1. Написати програму, що знаходить другий найбільший елемент масиву.

            int[] arrayForEx1 = new int[random.Next(5, 100)];
            int numberOfMaxValue = 2; //шукаємо друге найбільше число
                                      //можемо за допомогою цієї змінної шукати й третє, четверте і т.д.
            for (int i = 0; i < arrayForEx1.Length; i++) //заповнюємо масив та виводимо на екран
            {
                arrayForEx1[i] = random.Next(-1000, 1000);
                Console.Write(arrayForEx1[i] + " ");
            }
            //по суті робимо сортування до шуканого найбільшого числа, обриваючи сортування на потрібному місці
            for (int i = 1; i <= numberOfMaxValue; i++)
            {
                for (int j = 0; j < arrayForEx1.Length - i; j++)
                {
                    if (arrayForEx1[j] > arrayForEx1[j + 1])
                    {
                        (arrayForEx1[j], arrayForEx1[j + 1]) = (arrayForEx1[j + 1], arrayForEx1[j]);
                    }
                }
            }
            Console.WriteLine();
            int needMaxValue = arrayForEx1[arrayForEx1.Length - numberOfMaxValue];
            Console.WriteLine(needMaxValue);
            ////p.s. є один недолік, в даному процесі переписується сам масив
            ////от другий варіант

            int checkLargerNumber = 0;
            for (int i = 0; i < arrayForEx1.Length; i++)
            {
                for (int j = 0; j < arrayForEx1.Length; j++)
                {
                    if (arrayForEx1[i] >= arrayForEx1[j]) continue;
                    else
                    {
                        checkLargerNumber++;
                    }
                }
                if (checkLargerNumber == numberOfMaxValue - 1)
                {
                    Console.WriteLine(arrayForEx1[i]);
                    break;
                }
                checkLargerNumber = 0;
            }

            //2. Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

            int[,] arrayForEx2 = new int[5, 5]; //розмір взятий для прикладу            

            for (int i = 0; i < arrayForEx2.GetLength(0); i++) //заповнюємо масив та виводимо на екран
            {
                for (int j = 0; j < arrayForEx2.GetLength(1); j++) //заповнюємо масив та виводимо на екран
                {
                    arrayForEx2[i, j] = random.Next(-100, 100);
                    Console.Write($"{arrayForEx2[i, j]} ");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < arrayForEx2.Length - 1; i++)
            {
                for (int j = 0; j < arrayForEx2.GetLength(0); j++)
                {
                    for (int k = 0; k < arrayForEx2.GetLength(1); k++)
                    {
                        //проблема останьої ітерації
                        if (k == arrayForEx2.GetLength(1) - 1 && j == arrayForEx2.GetLength(0) - 1)
                        {
                            break;
                        }
                        //умова перевірки для останього елементу в рядку
                        else if (k == arrayForEx2.GetLength(1) - 1 && j != arrayForEx2.GetLength(0) - 1)
                        {
                            if (arrayForEx2[j, k] > arrayForEx2[j + 1, 0])
                            {
                                (arrayForEx2[j, k], arrayForEx2[j + 1, 0]) = (arrayForEx2[j + 1, 0], arrayForEx2[j, k]);
                            }                  
                        }
                        //звичайні випадки
                        else
                        {
                            if (arrayForEx2[j, k] > arrayForEx2[j, k + 1])
                            {
                                (arrayForEx2[j, k], arrayForEx2[j, k + 1]) = (arrayForEx2[j, k + 1], arrayForEx2[j, k]);
                            }                 
                        }
                    }
                }
            }

            for (int i = 0; i < arrayForEx2.GetLength(0); i++) //заповнюємо масив та виводимо на екран
            {
                for (int j = 0; j < arrayForEx2.GetLength(1); j++) //заповнюємо масив та виводимо на екран
                {                   
                    Console.Write($"{arrayForEx2[i, j]} ");
                }
                Console.WriteLine();
            }


            //3. Написати програму, що буде видаляти з масиву елемент за вказаним індексом.
            int[] beginArray = new int[random.Next(2, 100)];
            for (int i = 0; i < beginArray.Length; i++) //заповнюємо масив та виводимо на екран
            {
                beginArray[i] = random.Next(-1000, 1000);
                Console.Write(beginArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Оберіть індекс масива для видалення від 0 до {beginArray.Length - 1}");
            int indexForDelete = int.Parse(Console.ReadLine());
            //створюємо масив з меншою кількістю елементів
            int[] newArray = new int[beginArray.Length - 1];
            //заповнюємо новий масив
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i >= indexForDelete)
                {
                    newArray[i] = beginArray[i + 1];
                }
                else
                {
                    newArray[i] = beginArray[i];
                }
            }
            beginArray = newArray; //робимо нове посилання для початкового іменування
            foreach (int item in beginArray) //перевірка
            {
                Console.WriteLine(item);
            }

            //4. Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.
            int[,] begin4Array = new int[random.Next(2, 10), random.Next(2, 10)];
            int sum = 0;

            for (int i = 0; i < begin4Array.GetLength(0); i++) //заповнюємо масив та виводимо на екран
            {
                for (int j = 0; j < begin4Array.GetLength(1); j++) //заповнюємо масив та виводимо на екран
                {
                    begin4Array[i, j] = random.Next(-100, 100);
                    Console.Write($"{begin4Array[i, j]} ");
                }
                Console.WriteLine();
            }
            //рахуємо суму елементів по діагоналі
            int countOfElement = begin4Array.GetLength(0) < begin4Array.GetLength(1) ? begin4Array.GetLength(0) : begin4Array.GetLength(1);
            for (int i = 0; i < countOfElement; i++)
            {
                sum += begin4Array[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}

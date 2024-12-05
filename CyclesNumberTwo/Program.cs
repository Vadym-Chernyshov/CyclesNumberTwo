namespace CyclesNumberTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //для зповнення масивів

            //Написати програму, що знаходить другий найбільший елемент масиву.
            //Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.


            //Написати програму, що буде видаляти з масиву елемент за вказаним індексом.
            //int[] beginArray = new int[random.Next(2, 100)];
            //for (int i = 0; i < beginArray.Length; i++) //заповнюємо масив та виводимо на екран
            //{
            //    beginArray[i] = random.Next(-1000, 1000);
            //    Console.Write(beginArray[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Оберіть індекс масива для видалення від 0 до {beginArray.Length - 1}");
            //int indexForDelete = int.Parse(Console.ReadLine());
            //int[] newArray = new int[beginArray.Length - 1];
            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    if (i >= indexForDelete)
            //    {
            //        newArray[i] = beginArray[i + 1];
            //    }
            //    else
            //    {
            //        newArray[i] = beginArray[i];
            //    }
            //}
            //beginArray = newArray;
            //foreach (int item in beginArray) //перевірка
            //{
            //    Console.WriteLine(item);
            //}

            //Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.
            int[,] begin4Array = new int[random.Next(2, 10), random.Next(2, 10)];
            int sum = 0;

            for (int i = 0; i < begin4Array.GetLength(0); i++) //заповнюємо масив та виводимо на екран
            {
                for (int j = 0; j < begin4Array.GetLength(1); j++)
                {
                    begin4Array[i, j] = random.Next(-100, 100);
                    Console.Write(begin4Array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int countOfElement = begin4Array.GetLength(0) < begin4Array.GetLength(1)? begin4Array.GetLength(0): begin4Array.GetLength(1);
            for (int i = 0; i < countOfElement; i++)
            {
                sum += begin4Array[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}

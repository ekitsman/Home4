
// Д.з.1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void NatStepen(int a, int b )
// {
//     int result = 1;
//     for (int i = 1; i <=b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine($"A in the degree of B is {result}");
// }
// Console.Write("Input a number A :");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number B :");
// int numB = Convert.ToInt32(Console.ReadLine());
// NatStepen(numA, numB);

//Д.з.2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumOfDigis(int num)
// {   
//     int sum=0;
    
//     while (num!=0)
//     {   
//         sum += num%10;
//         num=num/10;
        
//     }
//     return sum;
    
    
// }
// Console.Write("Введите Число:");
// int number = Convert.ToInt32(Console.ReadLine());


// int result=SumOfDigis(number);
// if (number<0) result=-result;
// Console.WriteLine($"Сумма цифр в числе {number} is {result}");


//Д.з.3 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array=new int [size];
    for(int i=0; i<size; i++)
        Console.Write("Input a number of elements: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        array[i]=new Random(). Next(min, max+1);

    return array;
   
}
void ShowArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] myArray = CreateArray(size, num1, num2);
ShowArray(myArray);

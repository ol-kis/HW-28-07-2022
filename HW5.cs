/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Linq;
class HelloWorld {
  static void Main() {
    //Задание 1
    Console.WriteLine("Введите длину массива");
    int size=Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int[size]; //{345, 897, 568, 234};
    int count=0;
    for (int i=0;i<size;i++) { 
        numbers[i]=new Random().Next(100,999);
        if (numbers[i]%2==0){
            count=count+1;
        }
    }
    Console.WriteLine(count);
    //Задание 2
    Console.WriteLine("Введите длину массива");
    int size_2=Convert.ToInt32(Console.ReadLine());
    int [] numbers_2= new int [size_2];// {3, 7, 23, 12};
    int summa_numbers_2=0;
    for (int i=1;i<numbers_2.Length;i++) { 
        numbers_2[i]=new Random().Next(-100,100);
        summa_numbers_2=summa_numbers_2+numbers_2[i];
    }
    Console.WriteLine(summa_numbers_2);
    
    //Задание 3
    Console.WriteLine("Введите длину массива");
    int size_3=Convert.ToInt32(Console.ReadLine());
    int [] numbers_3= new int [size_3]; // {3, 7, 23, 12,46,49,78,36,96,71,100,56,99}
      for (int i=1;i<numbers_3.Length;i+=2) { 
        numbers_3[i]=new Random().Next(0,100);
    }
    int num_max=numbers_3.Max<int>();
    int num_min=numbers_3.Min<int>();
    
      
      Console.WriteLine("Максимальное число в массиве: "+num_max);
      Console.WriteLine("Минимальное число в массиве: "+num_min);
  }
}

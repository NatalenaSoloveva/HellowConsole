using System;

 namespace ConsoleApp1
  {
    class Program
    {
    static int PowTwoNumber(int number)
     {
        return number*number;
     }
     static string MultipleTwoNumber(int number)
     {
        return number % 2 == 0 ? "кратное" : "не кратное";
     }

     static int[] Shuffle(int[] array)
     {
       for (int i = 0; i < array.Length-1; i++)
       {
         int j = new Random().Next(0, i + 1);
         int tmp = array[i];
         array[i] = array[j];
         array[j] = tmp;
       } 
       return array;
     }
     static int[] CreaterArray(int number)
     {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array; 
     }
     static void WriteArray(int[] array)
     {
        Console.WriteLine("вывод массива");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
     }
    static void Main(string[] args)
     {
        //int number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(PowTwoNumber(number));
       //Console.WriteLine(MultipleTwoNumber(PowTwoNumber(number)));
      int[] array = CreaterArray(30);
       WriteArray(array);
       array = Shuffle(array);
       WriteArray(array);

        Console.ReadLine();
     }
    }
  }

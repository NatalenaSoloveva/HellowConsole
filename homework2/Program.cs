//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


//Console.Write("Введи трёхзначное число: ");
//int second = Convert.ToInt32(Console.ReadLine());
//string stringNumber = Convert.ToString(second);
//Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Console.Write("Введи число: ");
//int Numbero = Convert.ToInt32(Console.ReadLine());
//string NumberoText = Convert.ToString(Numbero);
//if (NumberoText.Length > 2){
  //Console.WriteLine("третья цифра -> " + NumberoText[2]);
//}
//else {
  //Console.WriteLine("-> третьей цифры нет");
//}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


Console.Write("Введи цифру, обозначающую день недели: ");
int dayN = Convert.ToInt32(Console.ReadLine());

void TheDayOfTheWeek (int dayN) {
  if (dayN == 6 || dayN == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayN < 1 || dayN > 7) {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

TheDayOfTheWeek(dayN);
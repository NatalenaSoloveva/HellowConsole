/*void DO()//функция не принимает и ничего не отдает
{

}
void DO2(int number)//функция  принимает и ничего не отдает
{

}
void DO3(int number)//функция не принимает и  отдает число
{
return 1;
}

void DO4(int number)//функция  принимает число и  отдает число
{
return number;
}
string DO5(int number)//функция  принимает и  отдает строку
{
return number.ToString() + "яблок";
}
string str = DO5(5);
Console.WriteLine(str);*/

void PowDoubleNumber(int number)
{
    number = number*number;
    Console.WriteLine(number);
}

int DoubleNumber(int number)
{
    number = number*2;
    return number;
}


int number = 12;
PowDoubleNumber(number);
int number2 = DoubleNumber(number);
Console.WriteLine(number);
Console.WriteLine(number2);

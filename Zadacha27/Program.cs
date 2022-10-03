//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = 191919;
int sum =0;
while (number>0)
{
	sum+=number%10;
	number /=10;
}
Console.WriteLine(sum); 

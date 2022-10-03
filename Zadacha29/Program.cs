//  Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void FillArray(int[]numbers)
{
	Random random = new Random();
		for (int i =0; i<numbers.Length; i++)
		{
			numbers[i] = random.Next(-9,10);
		}
}

void PrintArray(int[] numbers)
{
		for (int i=0; i<numbers.Length; i++)
		{
			Console.WriteLine(numbers[i]);
		}
}

int size =5;
int [] numbers = new int [size];
FillArray(numbers);
PrintArray (numbers);

for (int i = 1; i < size; i++)
{
	for (int j = 0; j < size-i; j++)
	{
		if (Math.Abs(numbers[j]) > Math.Abs(numbers[j+1]))
		{
			int temp = numbers[j];
			numbers[j] = numbers[j+1];
			numbers[j+1] = temp;
		}
	}
}
PrintArray(numbers);
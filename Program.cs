
bool isWork = true;

while (isWork)
{
	Console.Write("Введите номер задания :");

int.TryParse(Console.ReadLine(), out int w);
	{
		switch (w)
		{
			case 1:
			{

                    int a = ReadInt("First Number");
                    int b = ReadInt("Second Number");
                    int ReadInt(string argument)
                    {
                        Console.Write($"Input {argument}: ");
                        int number;

                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.WriteLine("Error! Try again.");
                        }

                        return number;
                    }
                    int numb = a;
                   for (int i = 1; i < b; i++)
                  
                    {
                        numb = numb * a;

                    }
                    System.Console.WriteLine($"{a} в степени {b} = {numb}");


 
			break;
			}
			case 2:
			{

                    int a = ReadInt("First Number");
                    int ReadInt(string argument)
                    {
                        Console.Write($"Input {argument}: ");
                        int number;
                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.WriteLine("Error! Try again.");
                        }
                        return number;
                    }
                    if (a < 99999999999) System.Console.WriteLine
                        (a % 10 +
                       +(a % 100 / 10)
                       + (a % 1000 / 100)
                       + (a % 10000 / 1000)
                       + (a % 100000 / 10000)
                       + (a % 1000000 / 100000)
                       + (a % 10000000 / 1000000)
                       + (a % 100000000 / 10000000)
                       + (a % 1000000000 / 100000000)
                       + a / 10000000000);

                    break;         
			}
				
            case 3:
			{

                    int a = ReadInt("First Number");
                    int b = ReadInt("Second Number");
                    int c = ReadInt("Third Number");
                    int d = ReadInt("Fourth Number");
                    int e = ReadInt("Fifth Number");
                    int f = ReadInt("Sixth Number");
                    int g = ReadInt("Seventh Number");
                    int h = ReadInt("Eighth Number");

                    int ReadInt(string argument)
                    {
                        Console.Write($"Input {argument}: ");
                        int number;
                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.WriteLine("Error! Try again.");
                        }
                        return number;
                    }

                    int[] array = { a, b, c, d, e, f, g, h };
                    void PrintArray(int[] array)
                    {
                        int count = array.Length;
                        int position = 0;

                        while (position < count)

                        {
                            System.Console.Write($"{array[position]}");
                            position++;
                        }
                    }
                    PrintArray(array);
                    System.Console.WriteLine();
                    break;
                    }
            
            
             case 4:
			{
                        int[] array = new int[8];
                    {
                        int lenght = array.Length;
                        int index = 0;

                        while (index < lenght)
                        {
                            array[index] = new Random().Next(1, 10);

                            index++;
                        }
                    }
                    void PrintArray(int[] array)
                    {
                        int count = array.Length;
                        int position = 0;
                        while (position < count)
                        {
                            System.Console.WriteLine(array[position]);
                            position++;
                        }
                    }
                    PrintArray(array);
                    
                    break;
            }
            
			case -1: isWork = false; break;
		}

	}
}    


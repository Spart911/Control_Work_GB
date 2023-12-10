string[] ArrFirst = new string[] { "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine", "ten"};
string[] ArrSecond = new string[ArrFirst.Length];
void SecondArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(ArrFirst, ArrSecond);
PrintArray(ArrSecond);
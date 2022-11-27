int n = 3;
int size = 5;
string[] arrayOne = new string[size];
FillArray(arrayOne);
if (SizeSecondArray(arrayOne) == 0){Console.WriteLine("Элементов не найдено");}
else
{   
    Console.Clear();
    Console.WriteLine("Рандомный строковый массив -> новый массив в котором три или меньше символов:");
    Console.WriteLine();
    string[] arrayTwo = RotateSimbol(arrayOne);
    Console.WriteLine($"[{String.Join(", ", arrayOne)}] -> [{String.Join(", ", arrayTwo)}]");
    Console.WriteLine();
}
void FillArray(string[] arr)
{
    Random rand = new Random();
    string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,8);
        for (int j = 0; j < randElemSize; j++)
        {
            arr[i] += AllSymbols[rand.Next(0,AllSymbols.Length)];
        }        
    }
}
int SizeSecondArray(string[] arr)
{   
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length < n)
        {
            secondSize++;
        }
    }
    return secondSize;
}
string[] RotateSimbol(string[] arr)
{
    string[] arrayTwo = new string[SizeSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length < n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}
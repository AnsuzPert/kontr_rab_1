string [] vvod ()
{
    Console.WriteLine("ВВедите размер массива");
    int x = Convert.ToInt32(Console.ReadLine());
    string [] mas = new string [x] ;
    for (int i = 0; i < x; i++)
    {
        Console.WriteLine("ВВедите элемент массива");
        mas[i] = Console.ReadLine();
    }
    return mas;
}


string[] sort(string[] arr)
{
    int per1 = 0;
    for (int i =0; i<arr.Length; i++)
    {
        if (arr[i].Length < 4) per1++;
    }

    string[] mas2 = new string[per1];

    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            mas2[j] = arr[i];
            j++;
        }
    }
    return mas2;
}


void vivod(string[] arr)
{
    Console.WriteLine(" ");
    for (int r = 0; r < arr.Length; r++) Console.Write ($"{arr[r]}  ");
}

string [] array = vvod();
vivod(sort(array));
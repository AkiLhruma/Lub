string[] StrArray()
{
    int size = 0;

    do
    {
        Console.Write("Input size number: ");
        size = Convert.ToInt32(Console.ReadLine());
    }
    while(size <= 0);

    string[] array = new string[size];

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Input string: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i+1 != array.Length)  Console.Write(array[i]+ ", ");
        else Console.Write(array[i]+ ".");
    }
    Console.WriteLine();
}

string[] ThreeCharArray(string[] array)
{
    int size = 0;
    
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length < 4) size++;

    string[] array3 = new string[size];
    int j = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i].Length < 4)
        { 
            array3[j] = array[i];
            j++;
        }

    return array3;
}
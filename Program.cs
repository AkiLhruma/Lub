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
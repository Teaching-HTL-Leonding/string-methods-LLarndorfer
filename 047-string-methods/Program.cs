//* String methods
//* Lukas Larndorfe
System.Console.Write("String methods\n**************************** \n");
System.Console.Write("Char for IndexOf: ");
char indexof = char.Parse(Console.ReadLine()!);

System.Console.Write("Contains char: ");
char containingchar = char.Parse(Console.ReadLine()!);
System.Console.Write("Last index of: ");
char lastindexof = char.Parse(Console.ReadLine()!);
System.Console.Write("String: ");
string input = Console.ReadLine()!;


bool Contains(string input, char containingchar)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == containingchar)
        {
            return true;
        }
    }
    return false;
}

int IndexOf(string input, char indexof)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (indexof == input[i])
        {
            return i;
        }
    }
    return -1;
}

    int LastIndexOf(string input, char lastindexof)
    {
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] == lastindexof) return i;
        }

        return -1;
    }


    Contains(input, containingchar);
    Console.Write($"Contains {containingchar}: ");
    System.Console.WriteLine(Contains(input, containingchar));
    Console.Write($"Index of {indexof}: ");
    System.Console.WriteLine(IndexOf(input, indexof));
    Console.Write($"Last index of {lastindexof}: ");
    System.Console.WriteLine(LastIndexOf(input, lastindexof));
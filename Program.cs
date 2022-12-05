void final(string[] basic)
{
    int finalSize = 0;
    string[] res = new string[basic.Length];
    for (int i = 0; i < basic.Length; i++)
    {
        if (basic[i].Length <= 3)
        {
            res[finalSize] = basic[i];
            finalSize++;
        }
    }
    Console.WriteLine($"[{String.Join(", ", res, 0, finalSize)}]");
}

string[] array1 = new string[5] { "123", "23", "hello", "world", "res" };
final(array1);
string[] array2 = new string[2] { "hello", "world" };
final(array2);
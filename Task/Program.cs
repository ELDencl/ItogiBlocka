
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] ->[]



string[] NewArray(string[] array)
{
    int index = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            result[index] = array[j];
            index++;
        }
    }
    return result;

}



string[] array = { "hello", "2", "world", ":-)" };
string[] newArray = NewArray(array);

Console.Write(String.Join(",",newArray));
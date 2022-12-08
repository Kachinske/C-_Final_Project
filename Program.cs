//Задача. Написать программу, которая из имеющегося массива строк формирует массив и строк, длина которых меньше или равна 3 символа

string[] StringArray = {"Hello", "World", "and", "some", "more", "words", ":-P"};
Console.WriteLine(string.Join(" ", StringArray));
string[] OverWritedArray = OverwriteArrayWithWordsCertainLength(StringArray,3);
Console.WriteLine(string.Join(" ", OverWritedArray));

//Methods

bool CountLetters (string word, int maxletters)
{
    int counter = 0;
    foreach (var item in word)
    {
        counter++;
    }
    if (counter <= maxletters)
    {
        return true;
    }
    return false;
}

string[] OverwriteArrayWithWordsCertainLength (string[] array, int wordlength)
{
    int NewArrayLength = 0;
    foreach (var item in array)
    {
        if(item.Length <= wordlength)
        {
            NewArrayLength++;
        }
    }

    string[] OverwritedArray = new string[NewArrayLength];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (CountLetters(array[i], wordlength) == true)
        {
            OverwritedArray[j] = array[i];
            j++;
        }
    }
    return OverwritedArray;
}
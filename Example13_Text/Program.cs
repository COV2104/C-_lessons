// Обработка текста

string text =
    "В начале мая приехал я из Москвы на Белое море."
    + "Я наблюдал за ходом весны прямо из окна домика. Перед моим окном был палисадник."
    + "Там росли молоденькие берёзки. Через их тонкие ветки мне была видна"
    + "просторная гладь Белого моря. Оно уже очистилось ото льда."
    + "Огромные стаи гусей и уток неслись над водой. Птица летела с юга ночами.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else result = result + $"{text[i]}";    
    }

    return result;
}

string newText = Replace(text,' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'с', 'С');
System.Console.WriteLine(newText);
System.Console.WriteLine();
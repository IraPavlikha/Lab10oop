using System;

abstract class TextProcessor
{
    // Абстрактний метод для обробки тексту
    public abstract string ProcessText(string input);
}

class NormalTextProcessor : TextProcessor
{
    // Звичайна обробка тексту (перетворення в верхній регістр)
    public override string ProcessText(string input)
    {
        return input.ToUpper();
    }
}

class ReplaceSpaceTextProcessor : TextProcessor
{
    // Заміна пробілів на "+"
    public override string ProcessText(string input)
    {
        return input.Replace(" ", "+");
    }
}

class ContainsWordTextProcessor : TextProcessor
{
    private string wordToSearch;

    // Конструктор для задання слова для пошуку
    public ContainsWordTextProcessor(string word)
    {
        wordToSearch = word;
    }

    // Перевірка, чи містить текст певне слово
    public override string ProcessText(string input)
    {
        return input.Contains(wordToSearch) ? $"Текст містить слово: {wordToSearch}" : "Текст не містить це слово.";
    }
}

class Program
{
    static void Main()
    {
        // Введення тексту користувачем
        Console.WriteLine("Введіть текст для обробки:");
        string text = Console.ReadLine();

        // Створення об'єктів класів для обробки тексту
        TextProcessor normalProcessor = new NormalTextProcessor();
        TextProcessor replaceSpaceProcessor = new ReplaceSpaceTextProcessor();

        // Запит на введення додаткового слова для перевірки
        Console.WriteLine("Введіть слово, щоб перевірити, чи міститься воно в тексті:");
        string word = Console.ReadLine();
        TextProcessor containsWordProcessor = new ContainsWordTextProcessor(word);

        // Виведення оригінального тексту
        Console.WriteLine("\nОригінальний текст: " + text);

        // Виведення результатів обробки тексту
        Console.WriteLine("\nЗвичайна обробка (Верхній регістр): " + normalProcessor.ProcessText(text));
        Console.WriteLine("Обробка пробілів (Заміна на +): " + replaceSpaceProcessor.ProcessText(text));
        Console.WriteLine(containsWordProcessor.ProcessText(text));
    }
}

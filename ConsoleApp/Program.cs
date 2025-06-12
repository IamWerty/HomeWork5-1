using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int firstNumber = 0;
int secondNumber = 1;
decimal result = 0;

Console.WriteLine("Вітаю в калькуляторі з одним оператором!\nВ цій програмі можна тільки ділити\n(ToT)/~~~");
try
{
        Console.Write("Введіть 1 число:\n");
        firstNumber = Convert.ToInt16(Console.ReadLine());

        Console.Write("Введіть 2 число:\n");
        secondNumber = Convert.ToInt16(Console.ReadLine());
}
catch
{
        throw new Exception("Введіть доречний формат числа!");
}
if (secondNumber == 0)
{
        throw new Exception("Неможна ділити на 0!");
}
else
{
        result = firstNumber / secondNumber;
        Console.WriteLine($"Результат ділення твого першого числа на друге: {result}\n(Результат заокруглюється)");
}
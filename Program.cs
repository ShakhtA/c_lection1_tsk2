Console.WriteLine("Введите два разных целых числа");

string Number = Console.ReadLine() ?? "";
int a = int.Parse(Number);

Number = Console.ReadLine() ?? "";
int b = int.Parse(Number);

while (a == b)
    {
       Console.WriteLine("Вы ввели одинаковые числа. Введите два разных целых числа");

Number = Console.ReadLine() ?? "";
a = int.Parse(Number);

Number = Console.ReadLine() ?? "";
b = int.Parse(Number); 
    }

if (a > b)
    Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
else 
    Console.WriteLine($"a = {a}; b = {b} -> max = {b}");

// Было бы лучше для проверки правильности ввода организовать
// цикл с постусловием, но я не знаю есть ли что-то подобное в C#
// и его синтаксис.

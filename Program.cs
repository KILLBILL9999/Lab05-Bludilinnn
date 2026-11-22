// Console.Write("Введите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine()!);

// switch (dayNumber) {
//     case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }



// Console.Write("Введите балл: ");
// int score = int.Parse(Console.ReadLine()!);

// switch (score) {
//     case >= 0 and < 40:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and < 60:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and < 80:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// } 

Console.Write("Введите температуру: ");
int temperature = int.Parse(Console.ReadLine()!);

string result = temperature switch {
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Комфортно",
    >= 25 and <= 34 => "Жарко",
    _ => "Очень жарко"
};

Console.WriteLine(result);
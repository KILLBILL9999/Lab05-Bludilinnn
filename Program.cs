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



// Console.Write("Введите температуру: ");
// int temperature = int.Parse(Console.ReadLine()!);

// string result = temperature switch {
//     < 0 => "Мороз",
//     >= 0 and <= 14 => "Прохладно",
//     >= 15 and <= 24 => "Комфортно",
//     >= 25 and <= 34 => "Жарко",
//     _ => "Очень жарко"
// };

// Console.WriteLine(result);

// Console.Write("Введите роль: ");
// string role = Console.ReadLine()!.Trim();

// string result = role switch {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     not "admin" => "Ограниченный доступ"
// };

// Console.WriteLine(result);



// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine()!);
// Console.Write("Есть билет? (да/нет): ");
// bool hasTicket = Console.ReadLine()!.Trim().ToLower() == "да";

// switch (age) {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }


// int level = 2;

// switch (level) {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }


// вариант
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// в
// Console.Write("Введите номер дня недели: ");
// int day = int.Parse(Console.ReadLine()!);

// string type = day switch {
//     >= 1 and <= 5 => "Будний",
//     6 or 7 => "Выходной",
//     _ => "Неверный день"
// };

// Console.WriteLine(type);



// г
// Console.Write("Введите роль (admin, teacher, user): ");
// string role = Console.ReadLine()!.Trim();

// string access = role switch {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     "user" => "Ограниченный доступ",
//     _ => "Неизвестная роль"
// };

// Console.WriteLine(access);


// // 7
// Console.Write("Введите количество очков: ");
// int points = int.Parse(Console.ReadLine()!);

// string level = points switch {
//     < 0 => "Ошибка",
//     >= 0 and <= 999 => "Новичок",
//     >= 1000 and <= 4999 => "Опытный",
//     >= 5000 and <= 9999 => "Продвинутый",
//     _ => "Мастер"
// };

// Console.WriteLine(level);


// 10
Console.Write("Введите возраст: ");
int age = int.Parse(Console.ReadLine()!);
Console.Write("Есть билет? (да/нет): ");
bool hasTicket = Console.ReadLine()!.Trim().ToLower() == "да";

switch (age) {
    case < 18:
        Console.WriteLine("Возраст не подходит");
        break;
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    default:
        Console.WriteLine("Нет билета");
        break;
}

// доп задание
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// string result = number switch {
//     < 0 => "Отрицательное",
//     1 or 2 or 3 => "Маленькое число",
//     >= 0 and <= 9 => "Однозначное",
//     >= 10 and <= 99 => "Двузначное",
//     _ => "Трёхзначное или больше"
// };

// Console.WriteLine(result);
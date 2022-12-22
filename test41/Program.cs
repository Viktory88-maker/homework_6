// Задача 41: Пользовательс клавиатуры вводит число M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь
// 0, 7, 8, -2, -2 -> 2
void CountPosNumbers(string[]listNum)
{
 int count = 0;
 Console.Write("Введен следующий список чисел: ");
 foreach (string elem in listNum)
 {
    if (int.Parse(elem) > 0) count ++;
 }
 Console.WriteLine($"\nКол-во чисел > 0 = {count}");
}
Console.WriteLine("Введите произвольный список целых чисел через пробел или запятую: ");
string[] list = (Console.ReadLine()!).Split(' ',',');
CountPosNumbers(list);


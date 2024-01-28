// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


try  //пытается выполнить программный код
     // Сюда засовываем всю основную программу, ну кроме функций разумеется.
{
    Console.WriteLine("Введите номер четверти");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(CheckChrtvert(num));
}
catch   // если же не получилось то уходим в этот блок
{
    Console.WriteLine("Ошибка: Надо было вводить именно целое число");
}

string CheckChrtvert(int num)  // функция возвращает строковое значение
{
    string res;
    if (num == 1) res = "x>0, y>0";
    else if (num == 2) res = "x<0, y>0";
    else if (num == 3) res = "x<0, y<0";
    else if (num == 4) res = "x>0, y<0";
    else res = "Введен некоректный номер четверти";
    return res;
}